namespace lastedit
{
    partial class frmcstmrlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcstmrlogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncstmrlogin = new System.Windows.Forms.Button();
            this.lblcstmrpass = new System.Windows.Forms.Label();
            this.txtcstmrpass = new System.Windows.Forms.TextBox();
            this.lblcstmrname = new System.Windows.Forms.Label();
            this.txtcstmrname = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(153, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 161);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTER YOUR USER!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btncstmrlogin);
            this.panel1.Controls.Add(this.lblcstmrpass);
            this.panel1.Controls.Add(this.txtcstmrpass);
            this.panel1.Controls.Add(this.lblcstmrname);
            this.panel1.Controls.Add(this.txtcstmrname);
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 393);
            this.panel1.TabIndex = 13;
            // 
            // btncstmrlogin
            // 
            this.btncstmrlogin.Location = new System.Drawing.Point(101, 103);
            this.btncstmrlogin.Name = "btncstmrlogin";
            this.btncstmrlogin.Size = new System.Drawing.Size(137, 44);
            this.btncstmrlogin.TabIndex = 22;
            this.btncstmrlogin.Text = "log in";
            this.btncstmrlogin.UseVisualStyleBackColor = true;
            this.btncstmrlogin.Click += new System.EventHandler(this.btncstmrlogin_Click);
            // 
            // lblcstmrpass
            // 
            this.lblcstmrpass.AutoSize = true;
            this.lblcstmrpass.Location = new System.Drawing.Point(12, 68);
            this.lblcstmrpass.Name = "lblcstmrpass";
            this.lblcstmrpass.Size = new System.Drawing.Size(167, 20);
            this.lblcstmrpass.TabIndex = 21;
            this.lblcstmrpass.Text = "CUSTEMER PASSWORD:";
            // 
            // txtcstmrpass
            // 
            this.txtcstmrpass.Location = new System.Drawing.Point(187, 61);
            this.txtcstmrpass.Name = "txtcstmrpass";
            this.txtcstmrpass.Size = new System.Drawing.Size(196, 27);
            this.txtcstmrpass.TabIndex = 20;
            // 
            // lblcstmrname
            // 
            this.lblcstmrname.AutoSize = true;
            this.lblcstmrname.Location = new System.Drawing.Point(39, 14);
            this.lblcstmrname.Name = "lblcstmrname";
            this.lblcstmrname.Size = new System.Drawing.Size(131, 20);
            this.lblcstmrname.TabIndex = 19;
            this.lblcstmrname.Text = "CUSTEMER NAME:";
            // 
            // txtcstmrname
            // 
            this.txtcstmrname.Location = new System.Drawing.Point(187, 7);
            this.txtcstmrname.Name = "txtcstmrname";
            this.txtcstmrname.Size = new System.Drawing.Size(196, 27);
            this.txtcstmrname.TabIndex = 18;
            // 
            // frmcstmrlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "frmcstmrlogin";
            this.Text = "frmcstmrlogin";
            this.Load += new System.EventHandler(this.frmcstmrlogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btncstmrlogin;
        private Label lblcstmrpass;
        private TextBox txtcstmrpass;
        private Label lblcstmrname;
        private TextBox txtcstmrname;
    }
}