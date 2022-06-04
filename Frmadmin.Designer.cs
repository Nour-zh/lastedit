namespace lastedit
{
    partial class Frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmadmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnwebsitemanege = new System.Windows.Forms.Button();
            this.btncoustemerreport = new System.Windows.Forms.Button();
            this.btnupdateminue = new System.Windows.Forms.Button();
            this.btnaddemployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnwebsitemanege
            // 
            this.btnwebsitemanege.Location = new System.Drawing.Point(221, 206);
            this.btnwebsitemanege.Name = "btnwebsitemanege";
            this.btnwebsitemanege.Size = new System.Drawing.Size(183, 56);
            this.btnwebsitemanege.TabIndex = 8;
            this.btnwebsitemanege.Text = "WEBSITE MANEGE";
            this.btnwebsitemanege.UseVisualStyleBackColor = true;
            // 
            // btncoustemerreport
            // 
            this.btncoustemerreport.Location = new System.Drawing.Point(361, 114);
            this.btncoustemerreport.Name = "btncoustemerreport";
            this.btncoustemerreport.Size = new System.Drawing.Size(183, 56);
            this.btncoustemerreport.TabIndex = 9;
            this.btncoustemerreport.Text = "COUSTEMER REPORT";
            this.btncoustemerreport.UseVisualStyleBackColor = true;
            this.btncoustemerreport.Click += new System.EventHandler(this.btncoustemerreport_Click);
            // 
            // btnupdateminue
            // 
            this.btnupdateminue.Location = new System.Drawing.Point(221, 24);
            this.btnupdateminue.Name = "btnupdateminue";
            this.btnupdateminue.Size = new System.Drawing.Size(183, 56);
            this.btnupdateminue.TabIndex = 10;
            this.btnupdateminue.Text = "UPDATE MINUE";
            this.btnupdateminue.UseVisualStyleBackColor = true;
            // 
            // btnaddemployee
            // 
            this.btnaddemployee.Location = new System.Drawing.Point(361, 305);
            this.btnaddemployee.Name = "btnaddemployee";
            this.btnaddemployee.Size = new System.Drawing.Size(183, 56);
            this.btnaddemployee.TabIndex = 11;
            this.btnaddemployee.Text = "ADD EMPLOYEE";
            this.btnaddemployee.UseVisualStyleBackColor = true;
            // 
            // Frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnaddemployee);
            this.Controls.Add(this.btnupdateminue);
            this.Controls.Add(this.btncoustemerreport);
            this.Controls.Add(this.btnwebsitemanege);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frmadmin";
            this.Text = "Frmadmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnwebsitemanege;
        private Button btncoustemerreport;
        private Button btnupdateminue;
        private Button btnaddemployee;
    }
}