namespace BoulderDash.Forms.helpForms
{
    partial class GetFileFieldForm
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
            btnBack = new Button();
            btnPlay = new Button();
            flowLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Bottom;
            btnBack.Location = new Point(0, 427);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(277, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPlay
            // 
            btnPlay.Dock = DockStyle.Bottom;
            btnPlay.Location = new Point(0, 404);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(277, 23);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // flowLP
            // 
            flowLP.AutoScroll = true;
            flowLP.FlowDirection = FlowDirection.TopDown;
            flowLP.Location = new Point(12, 12);
            flowLP.Name = "flowLP";
            flowLP.Size = new Size(253, 386);
            flowLP.TabIndex = 3;
            flowLP.WrapContents = false;
            // 
            // GetFileFieldForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 450);
            Controls.Add(flowLP);
            Controls.Add(btnPlay);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GetFileFieldForm";
            Text = "GetFileFieldForm";
            Load += GetFileFieldForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack;
        private Button btnPlay;
        private FlowLayoutPanel flowLP;
    }
}