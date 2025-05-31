using BoulderDash.Forms;
using BoulderDash.Utils;
using BoulderDashCore.GameObjects.Managers;
using BoulderDashCore.Managers.InputManagers;
using System.Windows.Forms;

namespace BoulderDash
{
    public partial class Menu : Form
    {
        private GameManager _game;
        private InputManager _inputManager;

        public Menu()
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
            _inputManager = new InputManager();
            _game = new GameManager(_inputManager);
            GameField gameField = new GameField(_game, _inputManager);
            gameField.FormClosed += (s, args) => this.Show();
            gameField.StartPosition = FormStartPosition.Manual;

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int centerX = screen.Left + (screen.Width - gameField.Width) / 2;
            int centerY = screen.Top + (screen.Height - gameField.Height) / 2;

            int offsetY = 100;

            gameField.Location = new Point(centerX, centerY - offsetY);

            gameField.Show();
            gameField.StartPosition = FormStartPosition.CenterScreen;
            gameField.Show();
            this.Hide();
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
    }
}
