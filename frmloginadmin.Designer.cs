namespace lastedit
{
    partial class frmloginadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloginadmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadminlogin = new System.Windows.Forms.Button();
            this.lbladminpass = new System.Windows.Forms.Label();
            this.txtadminpass = new System.Windows.Forms.TextBox();
            this.lbladminame = new System.Windows.Forms.Label();
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 146);
            this.panel2.TabIndex = 13;
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
            // btnadminlogin
            // 
            this.btnadminlogin.Location = new System.Drawing.Point(194, 249);
            this.btnadminlogin.Name = "btnadminlogin";
            this.btnadminlogin.Size = new System.Drawing.Size(137, 44);
            this.btnadminlogin.TabIndex = 27;
            this.btnadminlogin.Text = "log in";
            this.btnadminlogin.UseVisualStyleBackColor = true;
            this.btnadminlogin.Click += new System.EventHandler(this.btnadminlogin_Click);
            // 
            // lbladminpass
            // 
            this.lbladminpass.AutoSize = true;
            this.lbladminpass.Location = new System.Drawing.Point(116, 201);
            this.lbladminpass.Name = "lbladminpass";
            this.lbladminpass.Size = new System.Drawing.Size(143, 20);
            this.lbladminpass.TabIndex = 26;
            this.lbladminpass.Text = "ADMIN PASSWORD:";
            // 
            // txtadminpass
            // 
            this.txtadminpass.Location = new System.Drawing.Point(284, 198);
            this.txtadminpass.Name = "txtadminpass";
            this.txtadminpass.Size = new System.Drawing.Size(196, 27);
            this.txtadminpass.TabIndex = 25;
            // 
            // lbladminame
            // 
            this.lbladminame.AutoSize = true;
            this.lbladminame.Location = new System.Drawing.Point(152, 161);
            this.lbladminame.Name = "lbladminame";
            this.lbladminame.Size = new System.Drawing.Size(107, 20);
            this.lbladminame.TabIndex = 24;
            this.lbladminame.Text = "ADMIN NAME:";
            // 
            // txtadminname
            // 
            this.txtadminname.Location = new System.Drawing.Point(284, 158);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(196, 27);
            this.txtadminname.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(811, 263);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmloginadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 565);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadminlogin);
            this.Controls.Add(this.lbladminpass);
            this.Controls.Add(this.txtadminpass);
            this.Controls.Add(this.lbladminame);
            this.Controls.Add(this.txtadminname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmloginadmin";
            this.Text = "frmloginadmin";
            this.Load += new System.EventHandler(this.frmloginadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Button btnadminlogin;
        private Label lbladminpass;
        private TextBox txtadminpass;
        private Label lbladminame;
        private TextBox txtadminname;
        private DataGridView dataGridView1;
    }
}