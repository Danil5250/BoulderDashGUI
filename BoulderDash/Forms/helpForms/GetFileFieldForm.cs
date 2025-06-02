using BoulderDashCore.GameObjects.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderDash.Forms.helpForms
{
    public partial class GetFileFieldForm : Form
    {
        private string[] maps;
        public string ChoosedMap { get; private set; }

        public GetFileFieldForm()
        {
            InitializeComponent();
            maps = FileManager.GetAllMaps();
        }

        private void GetFileFieldForm_Load(object sender, EventArgs e)
        {
            foreach (string mapName in maps)
            {
                RadioButton rb = new RadioButton
                {
                    Text = mapName,
                    AutoSize = true
                };
                rb.CheckedChanged += Rb_CheckedChanged;

                flowLP.Controls.Add(rb);
            }
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                ChoosedMap = rb.Text;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            CloseForm(DialogResult.OK);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseForm(DialogResult.Cancel);
        }

        private void CloseForm(DialogResult dialogResult)
        {
            this.DialogResult = dialogResult;
            this.Close();
        }
    }
}
