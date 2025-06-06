namespace BoulderDash.Forms
{
    partial class FieldGenerationForm
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
            gbFieldConfig = new GroupBox();
            tbMapName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbStone = new Label();
            lbEnemy = new Label();
            lbDiamond = new Label();
            lbSand = new Label();
            lbPlayer = new Label();
            lbMapName = new Label();
            lbHeight = new Label();
            tbHeight = new TextBox();
            lbWidth = new Label();
            tbWidth = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            mapUtilitiesToolStripMenuItem = new ToolStripMenuItem();
            fillEmptySpaceWithSandToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            panelField = new Panel();
            gbFieldConfig.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbFieldConfig
            // 
            gbFieldConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbFieldConfig.BackColor = Color.WhiteSmoke;
            gbFieldConfig.Controls.Add(tbMapName);
            gbFieldConfig.Controls.Add(tableLayoutPanel1);
            gbFieldConfig.Controls.Add(lbMapName);
            gbFieldConfig.Controls.Add(lbHeight);
            gbFieldConfig.Controls.Add(tbHeight);
            gbFieldConfig.Controls.Add(lbWidth);
            gbFieldConfig.Controls.Add(tbWidth);
            gbFieldConfig.Font = new Font("Segoe UI", 11F);
            gbFieldConfig.ForeColor = Color.Black;
            gbFieldConfig.Location = new Point(12, 27);
            gbFieldConfig.Name = "gbFieldConfig";
            gbFieldConfig.Padding = new Padding(30, 10, 10, 10);
            gbFieldConfig.Size = new Size(776, 113);
            gbFieldConfig.TabIndex = 0;
            gbFieldConfig.TabStop = false;
            gbFieldConfig.Text = "FieldConfig";
            // 
            // tbMapName
            // 
            tbMapName.BorderStyle = BorderStyle.FixedSingle;
            tbMapName.Location = new Point(104, 27);
            tbMapName.Name = "tbMapName";
            tbMapName.Size = new Size(272, 27);
            tbMapName.TabIndex = 6;
            tbMapName.Leave += tbMapName_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lbStone, 0, 0);
            tableLayoutPanel1.Controls.Add(lbEnemy, 4, 0);
            tableLayoutPanel1.Controls.Add(lbDiamond, 3, 0);
            tableLayoutPanel1.Controls.Add(lbSand, 2, 0);
            tableLayoutPanel1.Controls.Add(lbPlayer, 1, 0);
            tableLayoutPanel1.Location = new Point(7, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(756, 38);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lbStone
            // 
            lbStone.AutoSize = true;
            lbStone.ForeColor = SystemColors.ControlText;
            lbStone.Location = new Point(4, 1);
            lbStone.Name = "lbStone";
            lbStone.Size = new Size(47, 20);
            lbStone.TabIndex = 0;
            lbStone.Text = "Stone";
            // 
            // lbEnemy
            // 
            lbEnemy.AutoSize = true;
            lbEnemy.Location = new Point(608, 1);
            lbEnemy.Name = "lbEnemy";
            lbEnemy.Size = new Size(53, 20);
            lbEnemy.TabIndex = 4;
            lbEnemy.Text = "Enemy";
            // 
            // lbDiamond
            // 
            lbDiamond.AutoSize = true;
            lbDiamond.Location = new Point(457, 1);
            lbDiamond.Name = "lbDiamond";
            lbDiamond.Size = new Size(71, 20);
            lbDiamond.TabIndex = 3;
            lbDiamond.Text = "Diamond";
            // 
            // lbSand
            // 
            lbSand.AutoSize = true;
            lbSand.Location = new Point(306, 1);
            lbSand.Name = "lbSand";
            lbSand.Size = new Size(42, 20);
            lbSand.TabIndex = 2;
            lbSand.Text = "Sand";
            // 
            // lbPlayer
            // 
            lbPlayer.AutoSize = true;
            lbPlayer.Location = new Point(155, 1);
            lbPlayer.Name = "lbPlayer";
            lbPlayer.Size = new Size(49, 20);
            lbPlayer.TabIndex = 1;
            lbPlayer.Text = "Player";
            // 
            // lbMapName
            // 
            lbMapName.AutoSize = true;
            lbMapName.Location = new Point(7, 30);
            lbMapName.Name = "lbMapName";
            lbMapName.Size = new Size(80, 20);
            lbMapName.TabIndex = 5;
            lbMapName.Text = "Map name";
            // 
            // lbHeight
            // 
            lbHeight.AutoSize = true;
            lbHeight.Location = new Point(586, 30);
            lbHeight.Name = "lbHeight";
            lbHeight.Size = new Size(54, 20);
            lbHeight.TabIndex = 4;
            lbHeight.Text = "Height";
            // 
            // tbHeight
            // 
            tbHeight.BorderStyle = BorderStyle.FixedSingle;
            tbHeight.Location = new Point(654, 27);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(100, 27);
            tbHeight.TabIndex = 3;
            tbHeight.Text = "10";
            tbHeight.TextChanged += UpdateFieldSize;
            // 
            // lbWidth
            // 
            lbWidth.AutoSize = true;
            lbWidth.Location = new Point(405, 32);
            lbWidth.Name = "lbWidth";
            lbWidth.Size = new Size(49, 20);
            lbWidth.TabIndex = 2;
            lbWidth.Text = "Width";
            // 
            // tbWidth
            // 
            tbWidth.BorderStyle = BorderStyle.FixedSingle;
            tbWidth.Location = new Point(468, 27);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(100, 27);
            tbWidth.TabIndex = 0;
            tbWidth.Text = "10";
            tbWidth.TextChanged += UpdateFieldSize;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, mapUtilitiesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(157, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(157, 24);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // mapUtilitiesToolStripMenuItem
            // 
            mapUtilitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fillEmptySpaceWithSandToolStripMenuItem, clearToolStripMenuItem });
            mapUtilitiesToolStripMenuItem.Name = "mapUtilitiesToolStripMenuItem";
            mapUtilitiesToolStripMenuItem.Size = new Size(98, 23);
            mapUtilitiesToolStripMenuItem.Text = "Map Utilities";
            // 
            // fillEmptySpaceWithSandToolStripMenuItem
            // 
            fillEmptySpaceWithSandToolStripMenuItem.Name = "fillEmptySpaceWithSandToolStripMenuItem";
            fillEmptySpaceWithSandToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            fillEmptySpaceWithSandToolStripMenuItem.Size = new Size(281, 24);
            fillEmptySpaceWithSandToolStripMenuItem.Text = "Fill empty space with sand";
            fillEmptySpaceWithSandToolStripMenuItem.Click += fillEmptySpaceWithSandToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            clearToolStripMenuItem.Size = new Size(281, 24);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // panelField
            // 
            panelField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelField.AutoScroll = true;
            panelField.Location = new Point(12, 146);
            panelField.Name = "panelField";
            panelField.Size = new Size(776, 292);
            panelField.TabIndex = 3;
            // 
            // FieldGenerationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(panelField);
            Controls.Add(gbFieldConfig);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FieldGenerationForm";
            Text = " Form Creation";
            FormClosing += FieldGenerationForm_FormClosing;
            gbFieldConfig.ResumeLayout(false);
            gbFieldConfig.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbFieldConfig;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TextBox tbWidth;
        private Label lbWidth;
        private Label lbHeight;
        private TextBox tbHeight;
        private Label lbEnemy;
        private Label lbDiamond;
        private Label lbSand;
        private Label lbPlayer;
        private Label lbStone;
        private Panel panelField;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem mapUtilitiesToolStripMenuItem;
        private ToolStripMenuItem fillEmptySpaceWithSandToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private TextBox tbMapName;
        private Label lbMapName;
        private TableLayoutPanel tableLayoutPanel1;
    }
}