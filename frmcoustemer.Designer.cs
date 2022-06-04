namespace lastedit
{
    partial class frmcoustemer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcoustemer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnbasket = new System.Windows.Forms.Button();
            this.btnmenue = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnhelp);
            this.panel1.Controls.Add(this.btnbasket);
            this.panel1.Controls.Add(this.btnmenue);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 385);
            this.panel1.TabIndex = 1;
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhelp.Location = new System.Drawing.Point(34, 247);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(101, 55);
            this.btnhelp.TabIndex = 6;
            this.btnhelp.Text = "HELP";
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnbasket
            // 
            this.btnbasket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbasket.Location = new System.Drawing.Point(34, 149);
            this.btnbasket.Name = "btnbasket";
            this.btnbasket.Size = new System.Drawing.Size(101, 55);
            this.btnbasket.TabIndex = 5;
            this.btnbasket.Text = "BASKET";
            this.btnbasket.UseVisualStyleBackColor = false;
            this.btnbasket.Click += new System.EventHandler(this.btnbasket_Click);
            // 
            // btnmenue
            // 
            this.btnmenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmenue.Location = new System.Drawing.Point(34, 55);
            this.btnmenue.Name = "btnmenue";
            this.btnmenue.Size = new System.Drawing.Size(101, 55);
            this.btnmenue.TabIndex = 4;
            this.btnmenue.Text = "MENUE";
            this.btnmenue.UseVisualStyleBackColor = false;
            this.btnmenue.Click += new System.EventHandler(this.btnmenue_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(183, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 386);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 146);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome to ower website!";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(184, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 348);
            this.panel4.TabIndex = 3;
            // 
            // frmcoustemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 494);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmcoustemer";
            this.Text = "frmcoustemer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnhelp;
        private Button btnbasket;
        private Button btnmenue;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
    }
}