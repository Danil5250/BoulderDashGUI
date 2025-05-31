namespace BoulderDash
{
    partial class Menu
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
            gBControlButtons.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblBoulderDash
            // 
            lblBoulderDash.AutoSize = true;
            lblBoulderDash.Font = new Font("Segoe UI", 20F);
            lblBoulderDash.Location = new Point(110, 29);
            lblBoulderDash.Name = "lblBoulderDash";
            lblBoulderDash.Size = new Size(168, 37);
            lblBoulderDash.TabIndex = 0;
            lblBoulderDash.Text = "BoulderDash";
            // 
            // btnRndField
            // 
            btnRndField.Location = new Point(83, 22);
            btnRndField.Name = "btnRndField";
            btnRndField.Size = new Size(198, 23);
            btnRndField.TabIndex = 1;
            btnRndField.Text = "Start playing in random field";
            btnRndField.UseVisualStyleBackColor = true;
            btnRndField.Click += btnRndField_Click;
            // 
            // btnCreateOwnField
            // 
            btnCreateOwnField.Location = new Point(83, 104);
            btnCreateOwnField.Name = "btnCreateOwnField";
            btnCreateOwnField.Size = new Size(198, 23);
            btnCreateOwnField.TabIndex = 2;
            btnCreateOwnField.Text = "Create my own map";
            btnCreateOwnField.UseVisualStyleBackColor = true;
            // 
            // gBControlButtons
            // 
            gBControlButtons.Controls.Add(btnPlayInOwnField);
            gBControlButtons.Controls.Add(btnRndField);
            gBControlButtons.Controls.Add(btnCreateOwnField);
            gBControlButtons.Location = new Point(12, 69);
            gBControlButtons.Name = "gBControlButtons";
            gBControlButtons.Size = new Size(352, 241);
            gBControlButtons.TabIndex = 3;
            gBControlButtons.TabStop = false;
            // 
            // btnPlayInOwnField
            // 
            btnPlayInOwnField.Location = new Point(83, 190);
            btnPlayInOwnField.Name = "btnPlayInOwnField";
            btnPlayInOwnField.Size = new Size(198, 23);
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 322);
            Controls.Add(gBControlButtons);
            Controls.Add(lblBoulderDash);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            gBControlButtons.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoulderDash;
        private Button btnRndField;
        private Button btnCreateOwnField;
        private GroupBox gBControlButtons;
        private Button btnPlayInOwnField;
        private MenuStrip menuStrip;
        private ToolStripMenuItem stripMenuGame;
        private ToolStripMenuItem stripMenuItemExit;
    }
}
