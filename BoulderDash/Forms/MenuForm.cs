using BoulderDash.Forms;
using BoulderDash.Forms.helpForms;
using BoulderDash.Utils;
using BoulderDashCore.GameObjects.Base;
using BoulderDashCore.GameObjects.Characters;
using BoulderDashCore.GameObjects.Managers;
using BoulderDashCore.Managers.InputManagers;
using BoulderDashCore.Utils.FunctionResults.GetField;
using System.Windows.Forms;

namespace BoulderDash
{
    public partial class MenuForm : Form
    {
        private GameManager _game;
        private InputManager _inputManager;

        public MenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            //Best fits because works when first form appearing, and next form appearings
            this.VisibleChanged += (s, e) =>
            {
                if (this.Visible)
                {
                    this.Location = FormUtils.GetFormCenterCoordinates(this.Width, this.Height);
                }
            };
        }

        private void btnRndField_Click(object sender, EventArgs e)
        {
            ShowControls();
            StartNewGame();
        }

        private static void ShowControls()
        {
            string control = "Commands: " +
                            "\nup arrow: move to the top element" + "\ndown arrow: move to the bottom element"
                            + "\nright arrow: move to the right element" + "\nleft arrow: move to the left element"
                            + "\nW: jump to the top element" + "\nS: jump to the bottom element"
                            + "\nD: jump to the right element" + "\nA: jump to the left element"
                            + "\nShift + W: put a bomb to the top element" + "\nShift + S: put a bomb to the bottom element"
                            + "\nShift + D: put a bomb to the right element" + "\nShift + A: put a bomb to the left element";
            MessageBox.Show(control, "Game controls", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateOwnField_Click(object sender, EventArgs e)
        {
            FieldGenerationForm generateFieldForm = new FieldGenerationForm();
            generateFieldForm.FormClosed += (s, args) => this.Show();

            generateFieldForm.Show();
            generateFieldForm.StartPosition = FormStartPosition.Manual;
            generateFieldForm.Location = FormUtils.GetFormCenterCoordinates(generateFieldForm.Width, generateFieldForm.Height);
            this.Hide();
        }

        private void btnPlayInOwnField_Click(object sender, EventArgs e)
        {
            using (var form = new GetFileFieldForm())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = FormUtils.GetFormCenterCoordinates(form.Width, form.Height);

                if(form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        IGetFieldResult fieldResult = new GetFieldFailure();
                        fieldResult = FileManager.GetField(form.ChoosedMap);
                        if (fieldResult != null)
                        {
                            if (fieldResult is GetFieldSuccess fieldResultSuccess)
                            {
                                ShowControls();
                                StartNewGame(fieldResultSuccess);
                            }
                            else if (fieldResult is GetFieldFailure fieldResultFailure)
                            {
                                MessageBox.Show(fieldResultFailure.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;
                            }
                        }
                        else
                        {
                            MessageBox.Show("something went wrong", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("something went wrong", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void StartNewGame(GetFieldSuccess fieldResultSuccess)
        {
            InitGameManagers(fieldResultSuccess.GameConfigure.Field,
                fieldResultSuccess.GameConfigure.Width,
                fieldResultSuccess.GameConfigure.Height,
                fieldResultSuccess.DiamondCount,
                fieldResultSuccess.Player,
                fieldResultSuccess.Enemy);

            StartGameForm();
        }

        private void StartNewGame()
        {
            InitGameManagers();

            StartGameForm();
        }

        private void StartGameForm()
        {
            FieldGameForm gameField = new FieldGameForm(_game, _inputManager);
            gameField.FormClosed += (s, args) => this.Show();

            gameField.Show();
            gameField.StartPosition = FormStartPosition.Manual;
            gameField.Location = FormUtils.GetFormCenterCoordinates(gameField.Width, gameField.Height);
            this.Hide();
        }

        private void InitGameManagers(GameEntity[][] field, int width, int height, int diamondsCount, Player player, Enemy enemy)
        {
            _inputManager = new InputManager();
            _game = new GameManager(width, height, _inputManager, field, diamondsCount, player, enemy);
        }
        
        private void InitGameManagers()
        {
            _inputManager = new InputManager();
            _game = new GameManager(_inputManager);
        }
    }
}
