namespace lastedit
{
    partial class frmbasket
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
            this.btnfinish = new System.Windows.Forms.Button();
            this.lblbskt1 = new System.Windows.Forms.Label();
            this.lblbskt2 = new System.Windows.Forms.Label();
            this.lblbskt3 = new System.Windows.Forms.Label();
            this.lblbskt4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfinish
            // 
            this.btnfinish.BackColor = System.Drawing.Color.Snow;
            this.btnfinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfinish.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnfinish.Location = new System.Drawing.Point(199, 361);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(184, 77);
            this.btnfinish.TabIndex = 0;
            this.btnfinish.Text = "FINISH";
            this.btnfinish.UseVisualStyleBackColor = false;
            // 
            // lblbskt1
            // 
            this.lblbskt1.AutoSize = true;
            this.lblbskt1.ForeColor = System.Drawing.Color.Snow;
            this.lblbskt1.Location = new System.Drawing.Point(95, 64);
            this.lblbskt1.Name = "lblbskt1";
            this.lblbskt1.Size = new System.Drawing.Size(50, 20);
            this.lblbskt1.TabIndex = 1;
            this.lblbskt1.Text = "label1";
            // 
            // lblbskt2
            // 
            this.lblbskt2.AutoSize = true;
            this.lblbskt2.ForeColor = System.Drawing.Color.Snow;
            this.lblbskt2.Location = new System.Drawing.Point(95, 118);
            this.lblbskt2.Name = "lblbskt2";
            this.lblbskt2.Size = new System.Drawing.Size(50, 20);
            this.lblbskt2.TabIndex = 2;
            this.lblbskt2.Text = "label2";
            // 
            // lblbskt3
            // 
            this.lblbskt3.AutoSize = true;
            this.lblbskt3.ForeColor = System.Drawing.Color.Snow;
            this.lblbskt3.Location = new System.Drawing.Point(95, 173);
            this.lblbskt3.Name = "lblbskt3";
            this.lblbskt3.Size = new System.Drawing.Size(50, 20);
            this.lblbskt3.TabIndex = 3;
            this.lblbskt3.Text = "label3";
            // 
            // lblbskt4
            // 
            this.lblbskt4.AutoSize = true;
            this.lblbskt4.ForeColor = System.Drawing.Color.Snow;
            this.lblbskt4.Location = new System.Drawing.Point(95, 221);
            this.lblbskt4.Name = "lblbskt4";
            this.lblbskt4.Size = new System.Drawing.Size(50, 20);
            this.lblbskt4.TabIndex = 4;
            this.lblbskt4.Text = "label4";
            // 
            // frmbasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblbskt4);
            this.Controls.Add(this.lblbskt3);
            this.Controls.Add(this.lblbskt2);
            this.Controls.Add(this.lblbskt1);
            this.Controls.Add(this.btnfinish);
            this.Name = "frmbasket";
            this.Text = "frmbasket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnfinish;
        private Label lblbskt1;
        private Label lblbskt2;
        private Label lblbskt3;
        private Label lblbskt4;
    }
}