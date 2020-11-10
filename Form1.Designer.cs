namespace Forms_ControlWork
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtAdmin = new System.Windows.Forms.Button();
            this.BtUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Coral;
            this.pictureBox1.BackgroundImage = global::Forms_ControlWork.Properties.Resources.uz;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 176);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtAdmin
            // 
            this.BtAdmin.BackColor = System.Drawing.Color.DeepPink;
            this.BtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtAdmin.Location = new System.Drawing.Point(68, 209);
            this.BtAdmin.Name = "BtAdmin";
            this.BtAdmin.Size = new System.Drawing.Size(271, 76);
            this.BtAdmin.TabIndex = 1;
            this.BtAdmin.Text = "Admin";
            this.BtAdmin.UseVisualStyleBackColor = false;
            this.BtAdmin.Click += new System.EventHandler(this.BtAdmin_Click);
            // 
            // BtUser
            // 
            this.BtUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtUser.Location = new System.Drawing.Point(68, 307);
            this.BtUser.Name = "BtUser";
            this.BtUser.Size = new System.Drawing.Size(271, 80);
            this.BtUser.TabIndex = 2;
            this.BtUser.Text = "User";
            this.BtUser.UseVisualStyleBackColor = false;
            this.BtUser.Click += new System.EventHandler(this.BtUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(431, 442);
            this.Controls.Add(this.BtUser);
            this.Controls.Add(this.BtAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtAdmin;
        private System.Windows.Forms.Button BtUser;
    }
}

