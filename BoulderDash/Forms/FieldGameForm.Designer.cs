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
            infoPanel = new Panel();
            lblBombUsed = new Label();
            lblJumps = new Label();
            lblStoneMoves = new Label();
            lblLives = new Label();
            lblScore = new Label();
            panelPlay = new Panel();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            infoPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(lblBombUsed);
            infoPanel.Controls.Add(lblJumps);
            infoPanel.Controls.Add(lblStoneMoves);
            infoPanel.Controls.Add(lblLives);
            infoPanel.Controls.Add(lblScore);
            infoPanel.Dock = DockStyle.Bottom;
            infoPanel.Location = new Point(0, 449);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(684, 62);
            infoPanel.TabIndex = 0;
            infoPanel.Paint += infoPanel_Paint;
            // 
            // lblBombUsed
            // 
            lblBombUsed.AutoSize = true;
            lblBombUsed.Location = new Point(447, 21);
            lblBombUsed.Name = "lblBombUsed";
            lblBombUsed.Size = new Size(67, 15);
            lblBombUsed.TabIndex = 9;
            lblBombUsed.Text = "Bomb used";
            // 
            // lblJumps
            // 
            lblJumps.AutoSize = true;
            lblJumps.Location = new Point(343, 22);
            lblJumps.Name = "lblJumps";
            lblJumps.Size = new Size(41, 15);
            lblJumps.TabIndex = 8;
            lblJumps.Text = "Jumps";
            // 
            // lblStoneMoves
            // 
            lblStoneMoves.AutoSize = true;
            lblStoneMoves.Location = new Point(202, 23);
            lblStoneMoves.Name = "lblStoneMoves";
            lblStoneMoves.Size = new Size(78, 15);
            lblStoneMoves.TabIndex = 7;
            lblStoneMoves.Text = "StoneMoves: ";
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.Location = new Point(107, 22);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(39, 15);
            lblLives.TabIndex = 6;
            lblLives.Text = "Lives: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(12, 23);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(42, 15);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: ";
            // 
            // panelPlay
            // 
            panelPlay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPlay.Location = new Point(0, 27);
            panelPlay.Name = "panelPlay";
            panelPlay.Padding = new Padding(1);
            panelPlay.Size = new Size(684, 404);
            panelPlay.TabIndex = 1;
            panelPlay.Paint += panelPlay_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // GameField
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 511);
            Controls.Add(panelPlay);
            Controls.Add(infoPanel);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            KeyPreview = true;
            MaximumSize = new Size(1000, 720);
            MinimumSize = new Size(700, 550);
            Name = "GameField";
            Text = "BoulderDash";
            FormClosing += GameField_FormClosing;
            KeyDown += GameField_KeyDown;
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel infoPanel;
        private Label lblLives;
        private Label lblScore;
        private Label lblBombUsed;
        private Label lblJumps;
        private Label lblStoneMoves;
        private Panel panelPlay;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}