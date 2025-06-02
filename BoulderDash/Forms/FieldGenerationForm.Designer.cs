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
            gbFieldItems = new GroupBox();
            lbEnemy = new Label();
            lbDiamond = new Label();
            lbSand = new Label();
            lbPlayer = new Label();
            lbStone = new Label();
            panelField = new Panel();
            gbFieldConfig.SuspendLayout();
            menuStrip1.SuspendLayout();
            gbFieldItems.SuspendLayout();
            SuspendLayout();
            // 
            // gbFieldConfig
            // 
            gbFieldConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbFieldConfig.Controls.Add(tbMapName);
            gbFieldConfig.Controls.Add(lbMapName);
            gbFieldConfig.Controls.Add(lbHeight);
            gbFieldConfig.Controls.Add(tbHeight);
            gbFieldConfig.Controls.Add(lbWidth);
            gbFieldConfig.Controls.Add(tbWidth);
            gbFieldConfig.Location = new Point(12, 27);
            gbFieldConfig.Name = "gbFieldConfig";
            gbFieldConfig.Size = new Size(776, 62);
            gbFieldConfig.TabIndex = 0;
            gbFieldConfig.TabStop = false;
            gbFieldConfig.Text = "FieldConfig";
            // 
            // tbMapName
            // 
            tbMapName.Location = new Point(89, 27);
            tbMapName.Name = "tbMapName";
            tbMapName.Size = new Size(225, 23);
            tbMapName.TabIndex = 6;
            tbMapName.Leave += tbMapName_TextChanged;
            // 
            // lbMapName
            // 
            lbMapName.AutoSize = true;
            lbMapName.Location = new Point(7, 30);
            lbMapName.Name = "lbMapName";
            lbMapName.Size = new Size(64, 15);
            lbMapName.TabIndex = 5;
            lbMapName.Text = "Map name";
            // 
            // lbHeight
            // 
            lbHeight.AutoSize = true;
            lbHeight.Location = new Point(565, 30);
            lbHeight.Name = "lbHeight";
            lbHeight.Size = new Size(43, 15);
            lbHeight.TabIndex = 4;
            lbHeight.Text = "Height";
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(628, 27);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(100, 23);
            tbHeight.TabIndex = 3;
            tbHeight.Text = "10";
            tbHeight.TextChanged += UpdateFieldSize;
            // 
            // lbWidth
            // 
            lbWidth.AutoSize = true;
            lbWidth.Location = new Point(355, 30);
            lbWidth.Name = "lbWidth";
            lbWidth.Size = new Size(39, 15);
            lbWidth.TabIndex = 2;
            lbWidth.Text = "Width";
            // 
            // tbWidth
            // 
            tbWidth.Location = new Point(418, 27);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(100, 23);
            tbWidth.TabIndex = 0;
            tbWidth.Text = "10";
            tbWidth.TextChanged += UpdateFieldSize;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, mapUtilitiesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(140, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(140, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // mapUtilitiesToolStripMenuItem
            // 
            mapUtilitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fillEmptySpaceWithSandToolStripMenuItem, clearToolStripMenuItem });
            mapUtilitiesToolStripMenuItem.Name = "mapUtilitiesToolStripMenuItem";
            mapUtilitiesToolStripMenuItem.Size = new Size(85, 20);
            mapUtilitiesToolStripMenuItem.Text = "Map Utilities";
            // 
            // fillEmptySpaceWithSandToolStripMenuItem
            // 
            fillEmptySpaceWithSandToolStripMenuItem.Name = "fillEmptySpaceWithSandToolStripMenuItem";
            fillEmptySpaceWithSandToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            fillEmptySpaceWithSandToolStripMenuItem.Size = new Size(249, 22);
            fillEmptySpaceWithSandToolStripMenuItem.Text = "Fill empty space with sand";
            fillEmptySpaceWithSandToolStripMenuItem.Click += fillEmptySpaceWithSandToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            clearToolStripMenuItem.Size = new Size(249, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // gbFieldItems
            // 
            gbFieldItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbFieldItems.Controls.Add(lbEnemy);
            gbFieldItems.Controls.Add(lbDiamond);
            gbFieldItems.Controls.Add(lbSand);
            gbFieldItems.Controls.Add(lbPlayer);
            gbFieldItems.Controls.Add(lbStone);
            gbFieldItems.Location = new Point(12, 95);
            gbFieldItems.Name = "gbFieldItems";
            gbFieldItems.Size = new Size(776, 63);
            gbFieldItems.TabIndex = 2;
            gbFieldItems.TabStop = false;
            gbFieldItems.Text = "FieldItems";
            // 
            // lbEnemy
            // 
            lbEnemy.AutoSize = true;
            lbEnemy.Location = new Point(317, 33);
            lbEnemy.Name = "lbEnemy";
            lbEnemy.Size = new Size(43, 15);
            lbEnemy.TabIndex = 4;
            lbEnemy.Text = "Enemy";
            // 
            // lbDiamond
            // 
            lbDiamond.AutoSize = true;
            lbDiamond.Location = new Point(224, 33);
            lbDiamond.Name = "lbDiamond";
            lbDiamond.Size = new Size(56, 15);
            lbDiamond.TabIndex = 3;
            lbDiamond.Text = "Diamond";
            // 
            // lbSand
            // 
            lbSand.AutoSize = true;
            lbSand.Location = new Point(156, 33);
            lbSand.Name = "lbSand";
            lbSand.Size = new Size(33, 15);
            lbSand.TabIndex = 2;
            lbSand.Text = "Sand";
            // 
            // lbPlayer
            // 
            lbPlayer.AutoSize = true;
            lbPlayer.Location = new Point(88, 32);
            lbPlayer.Name = "lbPlayer";
            lbPlayer.Size = new Size(39, 15);
            lbPlayer.TabIndex = 1;
            lbPlayer.Text = "Player";
            // 
            // lbStone
            // 
            lbStone.AutoSize = true;
            lbStone.ForeColor = SystemColors.ControlText;
            lbStone.Location = new Point(18, 32);
            lbStone.Name = "lbStone";
            lbStone.Size = new Size(37, 15);
            lbStone.TabIndex = 0;
            lbStone.Text = "Stone";
            // 
            // panelField
            // 
            panelField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelField.AutoScroll = true;
            panelField.Location = new Point(12, 164);
            panelField.Name = "panelField";
            panelField.Size = new Size(776, 274);
            panelField.TabIndex = 3;
            // 
            // FieldGenerationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelField);
            Controls.Add(gbFieldItems);
            Controls.Add(gbFieldConfig);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FieldGenerationForm";
            Text = " Form Creation";
            FormClosing += FieldGenerationForm_FormClosing;
            gbFieldConfig.ResumeLayout(false);
            gbFieldConfig.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbFieldItems.ResumeLayout(false);
            gbFieldItems.PerformLayout();
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
        private GroupBox gbFieldItems;
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
    }
}