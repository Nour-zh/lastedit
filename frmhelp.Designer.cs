namespace lastedit
{
    partial class frmhelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhelp));
            this.lblhelpyou = new System.Windows.Forms.Label();
            this.lblcalcstmr = new System.Windows.Forms.Label();
            this.lblmakereport = new System.Windows.Forms.Label();
            this.lblmyhistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhelpyou
            // 
            this.lblhelpyou.AutoSize = true;
            this.lblhelpyou.BackColor = System.Drawing.Color.Snow;
            this.lblhelpyou.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhelpyou.Location = new System.Drawing.Point(49, 35);
            this.lblhelpyou.Name = "lblhelpyou";
            this.lblhelpyou.Size = new System.Drawing.Size(335, 33);
            this.lblhelpyou.TabIndex = 0;
            this.lblhelpyou.Text = "how can we help you?";
            // 
            // lblcalcstmr
            // 
            this.lblcalcstmr.AutoSize = true;
            this.lblcalcstmr.BackColor = System.Drawing.Color.Snow;
            this.lblcalcstmr.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcalcstmr.Location = new System.Drawing.Point(49, 147);
            this.lblcalcstmr.Name = "lblcalcstmr";
            this.lblcalcstmr.Size = new System.Drawing.Size(270, 36);
            this.lblcalcstmr.TabIndex = 1;
            this.lblcalcstmr.Text = "Call coustemer center";
            // 
            // lblmakereport
            // 
            this.lblmakereport.AutoSize = true;
            this.lblmakereport.BackColor = System.Drawing.Color.Snow;
            this.lblmakereport.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmakereport.Location = new System.Drawing.Point(49, 244);
            this.lblmakereport.Name = "lblmakereport";
            this.lblmakereport.Size = new System.Drawing.Size(179, 36);
            this.lblmakereport.TabIndex = 2;
            this.lblmakereport.Text = "Make a report";
            // 
            // lblmyhistory
            // 
            this.lblmyhistory.AutoSize = true;
            this.lblmyhistory.BackColor = System.Drawing.Color.Snow;
            this.lblmyhistory.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmyhistory.Location = new System.Drawing.Point(49, 346);
            this.lblmyhistory.Name = "lblmyhistory";
            this.lblmyhistory.Size = new System.Drawing.Size(145, 36);
            this.lblmyhistory.TabIndex = 3;
            this.lblmyhistory.Text = "My history";
            // 
            // frmhelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 463);
            this.Controls.Add(this.lblmyhistory);
            this.Controls.Add(this.lblmakereport);
            this.Controls.Add(this.lblcalcstmr);
            this.Controls.Add(this.lblhelpyou);
            this.Name = "frmhelp";
            this.Text = "frmhelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblhelpyou;
        private Label lblcalcstmr;
        private Label lblmakereport;
        private Label lblmyhistory;
    }
}