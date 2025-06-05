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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPlayInOwnField = new Button();
            menuStrip = new MenuStrip();
            stripMenuGame = new ToolStripMenuItem();
            stripMenuItemExit = new ToolStripMenuItem();
            layout = new FlowLayoutPanel();
            gBControlButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblBoulderDash
            // 
            lblBoulderDash.AutoSize = true;
            lblBoulderDash.Dock = DockStyle.Top;
            lblBoulderDash.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblBoulderDash.ForeColor = Color.MidnightBlue;
            lblBoulderDash.Location = new Point(0, 24);
            lblBoulderDash.Name = "lblBoulderDash";
            lblBoulderDash.Padding = new Padding(0, 20, 0, 10);
            lblBoulderDash.Size = new Size(251, 81);
            lblBoulderDash.TabIndex = 0;
            lblBoulderDash.Text = "BoulderDash";
            lblBoulderDash.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRndField
            // 
            btnRndField.BackColor = Color.SteelBlue;
            btnRndField.FlatAppearance.BorderSize = 0;
            btnRndField.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnRndField.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnRndField.FlatStyle = FlatStyle.Flat;
            btnRndField.ForeColor = Color.White;
            btnRndField.Location = new Point(20, 20);
            btnRndField.Margin = new Padding(10);
            btnRndField.Name = "btnRndField";
            btnRndField.Size = new Size(220, 40);
            btnRndField.TabIndex = 1;
            btnRndField.Text = "Start playing in random field";
            btnRndField.UseVisualStyleBackColor = false;
            btnRndField.Click += btnRndField_Click;
            // 
            // btnCreateOwnField
            // 
            btnCreateOwnField.BackColor = Color.SteelBlue;
            btnCreateOwnField.FlatAppearance.BorderSize = 0;
            btnCreateOwnField.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnCreateOwnField.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnCreateOwnField.FlatStyle = FlatStyle.Flat;
            btnCreateOwnField.ForeColor = Color.White;
            btnCreateOwnField.Location = new Point(20, 90);
            btnCreateOwnField.Margin = new Padding(10);
            btnCreateOwnField.Name = "btnCreateOwnField";
            btnCreateOwnField.Size = new Size(220, 40);
            btnCreateOwnField.TabIndex = 2;
            btnCreateOwnField.Text = "Create my own map";
            btnCreateOwnField.UseVisualStyleBackColor = false;
            btnCreateOwnField.Click += btnCreateOwnField_Click;
            // 
            // gBControlButtons
            // 
            gBControlButtons.BackColor = Color.WhiteSmoke;
            gBControlButtons.Controls.Add(tableLayoutPanel1);
            gBControlButtons.FlatStyle = FlatStyle.Flat;
            gBControlButtons.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gBControlButtons.Location = new Point(12, 104);
            gBControlButtons.Name = "gBControlButtons";
            gBControlButtons.Size = new Size(352, 259);
            gBControlButtons.TabIndex = 3;
            gBControlButtons.TabStop = false;
            gBControlButtons.Text = "Select Mode";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnPlayInOwnField, 0, 2);
            tableLayoutPanel1.Controls.Add(btnRndField, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCreateOwnField, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.Size = new Size(346, 235);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPlayInOwnField
            // 
            btnPlayInOwnField.BackColor = Color.SteelBlue;
            btnPlayInOwnField.FlatAppearance.BorderSize = 0;
            btnPlayInOwnField.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnPlayInOwnField.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnPlayInOwnField.FlatStyle = FlatStyle.Flat;
            btnPlayInOwnField.ForeColor = Color.White;
            btnPlayInOwnField.Location = new Point(20, 160);
            btnPlayInOwnField.Margin = new Padding(10);
            btnPlayInOwnField.Name = "btnPlayInOwnField";
            btnPlayInOwnField.Size = new Size(220, 40);
            btnPlayInOwnField.TabIndex = 3;
            btnPlayInOwnField.Text = "Play in my own map";
            btnPlayInOwnField.UseVisualStyleBackColor = false;
            btnPlayInOwnField.Click += btnPlayInOwnField_Click;
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
            BackColor = Color.WhiteSmoke;
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
            gBControlButtons.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private FlowLayoutPanel layout;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
