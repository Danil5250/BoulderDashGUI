namespace BoulderDash
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBoulderDash = new Label();
            btnRndField = new Button();
            btnCreateOwnField = new Button();
            gBControlButtons = new GroupBox();
            btnPlayInOwnField = new Button();
            menuStrip = new MenuStrip();
            stripMenuGame = new ToolStripMenuItem();
            stripMenuItemExit = new ToolStripMenuItem();
            layout = new FlowLayoutPanel();
            gBControlButtons.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblBoulderDash
            // 
            lblBoulderDash.AutoSize = true;
            lblBoulderDash.Dock = DockStyle.Top;
            lblBoulderDash.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBoulderDash.ForeColor = Color.MidnightBlue;
            lblBoulderDash.Location = new Point(0, 24);
            lblBoulderDash.Name = "lblBoulderDash";
            lblBoulderDash.Padding = new Padding(0, 20, 0, 10);
            lblBoulderDash.Size = new Size(230, 77);
            lblBoulderDash.TabIndex = 0;
            lblBoulderDash.Text = "BoulderDash";
            lblBoulderDash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRndField
            // 
            btnRndField.Location = new Point(83, 22);
            btnRndField.Name = "btnRndField";
            btnRndField.Size = new Size(198, 33);
            btnRndField.TabIndex = 1;
            btnRndField.Text = "Start playing in random field";
            btnRndField.UseVisualStyleBackColor = true;
            btnRndField.Click += btnRndField_Click;
            // 
            // btnCreateOwnField
            // 
            btnCreateOwnField.Location = new Point(83, 104);
            btnCreateOwnField.Name = "btnCreateOwnField";
            btnCreateOwnField.Size = new Size(198, 33);
            btnCreateOwnField.TabIndex = 2;
            btnCreateOwnField.Text = "Create my own map";
            btnCreateOwnField.UseVisualStyleBackColor = true;
            btnCreateOwnField.Click += btnCreateOwnField_Click;
            // 
            // gBControlButtons
            // 
            gBControlButtons.BackColor = Color.WhiteSmoke;
            gBControlButtons.Controls.Add(btnPlayInOwnField);
            gBControlButtons.Controls.Add(btnRndField);
            gBControlButtons.Controls.Add(btnCreateOwnField);
            gBControlButtons.FlatStyle = FlatStyle.Flat;
            gBControlButtons.Font = new Font("Segoe UI", 10F);
            gBControlButtons.Location = new Point(12, 104);
            gBControlButtons.Name = "gBControlButtons";
            gBControlButtons.Size = new Size(352, 259);
            gBControlButtons.TabIndex = 3;
            gBControlButtons.TabStop = false;
            gBControlButtons.Text = "Select Mode";
            // 
            // btnPlayInOwnField
            // 
            btnPlayInOwnField.Location = new Point(83, 190);
            btnPlayInOwnField.Name = "btnPlayInOwnField";
            btnPlayInOwnField.Size = new Size(198, 28);
            btnPlayInOwnField.TabIndex = 3;
            btnPlayInOwnField.Text = "Play in my own map";
            btnPlayInOwnField.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { stripMenuGame });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(376, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip";
            // 
            // stripMenuGame
            // 
            stripMenuGame.DropDownItems.AddRange(new ToolStripItem[] { stripMenuItemExit });
            stripMenuGame.Name = "stripMenuGame";
            stripMenuGame.Size = new Size(50, 20);
            stripMenuGame.Text = "Game";
            // 
            // stripMenuItemExit
            // 
            stripMenuItemExit.Name = "stripMenuItemExit";
            stripMenuItemExit.ShortcutKeys = Keys.Control | Keys.Q;
            stripMenuItemExit.Size = new Size(136, 22);
            stripMenuItemExit.Text = "Exit";
            stripMenuItemExit.Click += exitToolStripMenuItem_Click;
            // 
            // layout
            // 
            layout.AutoScroll = true;
            layout.Dock = DockStyle.Fill;
            layout.FlowDirection = FlowDirection.TopDown;
            layout.Location = new Point(0, 0);
            layout.Name = "layout";
            layout.Size = new Size(200, 100);
            layout.TabIndex = 0;
            layout.WrapContents = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 375);
            Controls.Add(gBControlButtons);
            Controls.Add(lblBoulderDash);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            gBControlButtons.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Style

        void StyleButton(Button btn)
        {
            btn.BackColor = Color.SteelBlue;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
            btn.Height = 40;
            btn.Width = 220;
            btn.Margin = new Padding(10);
        }
        #endregion Style

        private Label lblBoulderDash;
        private Button btnRndField;
        private Button btnCreateOwnField;
        private GroupBox gBControlButtons;
        private Button btnPlayInOwnField;
        private MenuStrip menuStrip;
        private ToolStripMenuItem stripMenuGame;
        private ToolStripMenuItem stripMenuItemExit;
        private FlowLayoutPanel layout;
    }
}
