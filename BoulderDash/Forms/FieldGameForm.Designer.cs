using System.Windows.Forms;

namespace BoulderDash.Forms
{
    partial class FieldGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBombUsed = new Label();
            lblJumps = new Label();
            lblStoneMoves = new Label();
            lblLives = new Label();
            lblScore = new Label();
            panelPlay = new Panel();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pauseMenuItem = new ToolStripMenuItem();
            resumeMenuItem = new ToolStripMenuItem();
            infoPanel = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            infoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblBombUsed
            // 
            lblBombUsed.AutoSize = true;
            lblBombUsed.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblBombUsed.ForeColor = Color.MidnightBlue;
            lblBombUsed.Location = new Point(554, 0);
            lblBombUsed.Margin = new Padding(10, 0, 10, 0);
            lblBombUsed.Name = "lblBombUsed";
            lblBombUsed.Size = new Size(55, 20);
            lblBombUsed.TabIndex = 9;
            lblBombUsed.Text = "Bomb:";
            // 
            // lblJumps
            // 
            lblJumps.AutoSize = true;
            lblJumps.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblJumps.ForeColor = Color.MidnightBlue;
            lblJumps.Location = new Point(418, 0);
            lblJumps.Margin = new Padding(10, 0, 10, 0);
            lblJumps.Name = "lblJumps";
            lblJumps.Size = new Size(59, 20);
            lblJumps.TabIndex = 8;
            lblJumps.Text = "Jumps:";
            // 
            // lblStoneMoves
            // 
            lblStoneMoves.AutoSize = true;
            lblStoneMoves.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblStoneMoves.ForeColor = Color.MidnightBlue;
            lblStoneMoves.Location = new Point(282, 0);
            lblStoneMoves.Margin = new Padding(10, 0, 10, 0);
            lblStoneMoves.Name = "lblStoneMoves";
            lblStoneMoves.Size = new Size(103, 20);
            lblStoneMoves.TabIndex = 7;
            lblStoneMoves.Text = "StoneMoves: ";
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblLives.ForeColor = Color.MidnightBlue;
            lblLives.Location = new Point(146, 0);
            lblLives.Margin = new Padding(10, 0, 10, 0);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(52, 20);
            lblLives.TabIndex = 6;
            lblLives.Text = "Lives: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblScore.ForeColor = Color.MidnightBlue;
            lblScore.Location = new Point(10, 0);
            lblScore.Margin = new Padding(10, 0, 10, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(55, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: ";
            // 
            // panelPlay
            // 
            panelPlay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPlay.BackColor = Color.WhiteSmoke;
            panelPlay.BorderStyle = BorderStyle.FixedSingle;
            panelPlay.Location = new Point(0, 27);
            panelPlay.Name = "panelPlay";
            panelPlay.Padding = new Padding(5);
            panelPlay.Size = new Size(684, 422);
            panelPlay.TabIndex = 1;
            panelPlay.Paint += panelPlay_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem, pauseMenuItem, resumeMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 27);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(42, 23);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // pauseMenuItem
            // 
            pauseMenuItem.Name = "pauseMenuItem";
            pauseMenuItem.Size = new Size(57, 23);
            pauseMenuItem.Text = "Pause";
            pauseMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // resumeMenuItem
            // 
            resumeMenuItem.Enabled = false;
            resumeMenuItem.Name = "resumeMenuItem";
            resumeMenuItem.Size = new Size(69, 23);
            resumeMenuItem.Text = "Resume";
            resumeMenuItem.Click += resumeToolStripMenuItem_Click;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.WhiteSmoke;
            infoPanel.ColumnCount = 5;
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            infoPanel.Controls.Add(lblBombUsed, 4, 0);
            infoPanel.Controls.Add(lblJumps, 3, 0);
            infoPanel.Controls.Add(lblStoneMoves, 2, 0);
            infoPanel.Controls.Add(lblLives, 1, 0);
            infoPanel.Controls.Add(lblScore, 0, 0);
            infoPanel.Dock = DockStyle.Bottom;
            infoPanel.Location = new Point(0, 455);
            infoPanel.Name = "infoPanel";
            infoPanel.RowCount = 1;
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPanel.Size = new Size(684, 56);
            infoPanel.TabIndex = 0;
            // 
            // FieldGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 511);
            Controls.Add(infoPanel);
            Controls.Add(panelPlay);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            KeyPreview = true;
            MaximumSize = new Size(1000, 720);
            MinimizeBox = false;
            MinimumSize = new Size(700, 550);
            Name = "FieldGameForm";
            Text = "BoulderDash";
            FormClosing += GameField_FormClosing;
            KeyDown += GameField_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLives;
        private Label lblScore;
        private Label lblBombUsed;
        private Label lblJumps;
        private Label lblStoneMoves;
        private Panel panelPlay;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem pauseMenuItem;
        private ToolStripMenuItem resumeMenuItem;
        private TableLayoutPanel infoPanel;
    }
}