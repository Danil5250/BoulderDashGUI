using BoulderDash.Config;
using BoulderDashCore.GameObjects.Managers;
using BoulderDashCore.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderDash.Forms
{
    public partial class FieldGenerationForm : Form
    {
        private string[][] fieldMatrix;
        private Point? dragStartPoint = null; //init point of cells drag&drop
        public FieldGenerationForm()
        {
            InitializeComponent();
            InitializeMatrix(10, 10);
            RedrawField();
            SetupEventHandlers();
        }

        private void InitializeMatrix(int width, int height)
        {
            try
            {
                fieldMatrix = new string[height][];
                for (int y = 0; y < height; y++)
                {
                    fieldMatrix[y] = new string[width];
                    for (int x = 0; x < width; x++)
                        fieldMatrix[y][x] = GenerateFormConfig.EmptyCellView;

                }
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void RedrawField()
        {
            panelField.Controls.Clear();
            if (fieldMatrix == null) return;

            for (int y = 0; y < fieldMatrix.Length; y++)
            {
                for (int x = 0; x < fieldMatrix[y].Length; x++)
                {
                    var cell = new Label
                    {
                        Size = new Size(GenerateFormConfig.CellSize, GenerateFormConfig.CellSize),
                        Location = new Point(x * GenerateFormConfig.CellSize, y * GenerateFormConfig.CellSize),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = new Point(x, y),
                        BackColor = GenerateFormConfig.GetCellColor(fieldMatrix[y][x]),
                        Text = GenerateFormConfig.FullToShortName(fieldMatrix[y][x]),
                        ForeColor = GenerateFormConfig.ItemsDefaultColor
                    };

                    cell.MouseDown += Cell_MouseDown;
                    cell.DragEnter += Cell_DragEnter;
                    cell.DragDrop += Cell_DragDrop;
                    cell.AllowDrop = true;

                    panelField.Controls.Add(cell);
                }
            }
        }

        private void SetupEventHandlers()
        {
            lbStone.MouseDown += (s, e) => StartDrag(GenerateFormConfig.StoneFullName);
            lbSand.MouseDown += (s, e) => StartDrag(GenerateFormConfig.SandFullName);
            lbPlayer.MouseDown += (s, e) => StartDrag(GenerateFormConfig.PlayerFullName);
            lbDiamond.MouseDown += (s, e) => StartDrag(GenerateFormConfig.DiamondFullName);
            lbEnemy.MouseDown += (s, e) => StartDrag(GenerateFormConfig.EnemyFullName);
        }

        private void StartDrag(string tool)
        {
            //clear
            dragStartPoint = null;
            //start drag and drop operation
            //tool - data that is transfered
            //DragDropEffects.Copy - type of the action is copying, and not the moving
            //original text is still in the place, copy is transfered to the cell
            DoDragDrop(tool, DragDropEffects.Copy);
        }

        private void UpdateFieldSize(object sender, EventArgs e)
        {
            if (int.TryParse(tbWidth.Text, out int width) &&
                int.TryParse(tbHeight.Text, out int height) &&
                width > 0 && height > 0)
            {
                InitializeMatrix(width, height);
                RedrawField();
            }
        }

        private void Cell_MouseDown(object sender, MouseEventArgs e)
        {
            var cell = (Label)sender;
            var pos = (Point)cell.Tag;

            if (e.Button == MouseButtons.Right)
            {
                fieldMatrix[pos.Y][pos.X] = GenerateFormConfig.EmptyCellView;
                cell.BackColor = GenerateFormConfig.GetCellColor(GenerateFormConfig.EmptyCellView);
                cell.Text = GenerateFormConfig.EmptyCellView;
            }
            else if (e.Button == MouseButtons.Left && !string.IsNullOrEmpty(fieldMatrix[pos.Y][pos.X]))
            {
                dragStartPoint = pos;
                cell.DoDragDrop(fieldMatrix[pos.Y][pos.X], DragDropEffects.Move);
            }
        }

        private void Cell_DragEnter(object sender, DragEventArgs e)
        {
            //is some data in Data
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = dragStartPoint.HasValue ?
                DragDropEffects.Move :
                DragDropEffects.Copy;
            }
        }

        private void Cell_DragDrop(object sender, DragEventArgs e)
        {
            //cell where dragged element came
            var cell = (Label)sender;

            //coordinates of the cell in the field, the cell where dragged element came
            var targetPos = (Point)cell.Tag;
            string draggedItem = e.Data.GetData(DataFormats.Text).ToString();

            //check if this is transfering between cells or this is creating of a new element
            //from labels
            //if (dragStartPoint.HasValue) - transfering between cells
            if (dragStartPoint.HasValue)
            {
                var sourcePos = dragStartPoint.Value;

                //update if only transferring at another cell
                if (sourcePos != targetPos)
                {
                    //clear init cell
                    fieldMatrix[sourcePos.Y][sourcePos.X] = "";

                    //update UI
                    UpdateCell(sourcePos);

                    //set element at another cell
                    fieldMatrix[targetPos.Y][targetPos.X] = draggedItem;
                    cell.BackColor = GenerateFormConfig.GetCellColor(draggedItem);
                    cell.Text = GenerateFormConfig.FullToShortName(draggedItem); //draggedItem;
                }
            }
            else
            {
                //we are adding a new element from label
                fieldMatrix[targetPos.Y][targetPos.X] = draggedItem;
                cell.BackColor = GenerateFormConfig.GetCellColor(draggedItem);
                cell.Text = GenerateFormConfig.FullToShortName(draggedItem); //draggedItem;
            }

            dragStartPoint = null;
        }

        //update appearance of the field
        private void UpdateCell(Point position)
        {
            foreach (Control control in panelField.Controls)
            {
                if (control is Label cell && cell.Tag is Point pos && pos == position)
                {
                    cell.Text = GenerateFormConfig.FullToShortName(fieldMatrix[position.Y][position.X]); // fieldMatrix[position.Y][position.X];
                    cell.BackColor = GenerateFormConfig.GetCellColor(fieldMatrix[position.Y][position.X]);
                    break;
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbMapName.Text))
                    throw new FileFieldException("Map name cannot be empty");

                FileManager.IsMapNameUnique(tbMapName.Text);

                //string[] fieldRows = FileManager.BuildCompressedMap(fieldMatrix);
                //string[] resultField = new string[fieldMatrix.Length + 1];

                var resultField = FileManager.BuildCompressedMap(fieldMatrix);

                resultField[0] = $"Width:{fieldMatrix[0].Length}{GenerateFormConfig.ElementsSeparator}Height:{fieldMatrix.Length}\n";

                SaveField(resultField);
            }
            catch (FileFieldException ex)
            {
                MessageBox.Show(ex.Message, "Field error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void SaveField(string[] resultField)
        {
            FileManager.FieldValidation(resultField, fieldMatrix[0].Length);

            var result = FileManager.UserGeneratesMap(tbMapName.Text, resultField,
                fieldMatrix[0].Length, fieldMatrix.Length);

            MessageBox.Show(result, "Field generation", MessageBoxButtons.OKCancel);
            var mbResult = MessageBox.Show("Do you want to clear the field", "Field", MessageBoxButtons.YesNoCancel);
            if (mbResult.Equals(DialogResult.Yes))
            {
                SetDefaultValues();
                ResetMap();
            }
        }

        private void SetDefaultValues()
        {
            tbMapName.Text = "";
            tbWidth.Text = GenerateFormConfig.DefaultFieldWidth;
            tbHeight.Text = GenerateFormConfig.DefaultFieldHeight;
            RedrawField();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FieldGenerationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultD = FieldGenerationExiting();
            if (!resultD.Equals(DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private DialogResult FieldGenerationExiting()
        {
            return MessageBox.Show("Are you sure you want to leave field creating?",
                "Quit field creating", MessageBoxButtons.YesNoCancel);
        }



        private void fillEmptySpaceWithSandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //here I can modify not full map but partially
            for (int y = 0; y < fieldMatrix.Length; y++)
            {
                for (int x = 0; x < fieldMatrix[y].Length; x++)
                {
                    if (fieldMatrix[y][x] == "")
                    {
                        fieldMatrix[y][x] = GenerateFormConfig.SandFullName;
                        UpdateCell(new Point(x, y));
                    }
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMap();
        }

        private void ResetMap()
        {
            //here I modify full map
            for (int y = 0; y < fieldMatrix.Length; y++)
            {
                for (int x = 0; x < fieldMatrix[y].Length; x++)
                {
                    fieldMatrix[y][x] = GenerateFormConfig.EmptyCellView;
                }
            }
            RedrawField();
        }

        //Validations
        private void tbMapName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FileManager.IsMapNameUnique(tbMapName.Text);
            }
            catch (FileFieldException ex)
            {
                MessageBox.Show(ex.Message, "Field errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
            }
        }
    }
}
