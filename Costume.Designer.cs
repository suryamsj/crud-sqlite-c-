
namespace SQLite
{
    partial class Costume
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
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.PictureBox();
            this.Instagram = new System.Windows.Forms.PictureBox();
            this.Facebook = new System.Windows.Forms.PictureBox();
            this.Whatsapp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whatsapp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Untuk kamu yang ingin membuat costume aplikasi C#. \r\nbisa hubungi saya :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Email
            // 
            this.Email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Email.Image = global::SQLite.Properties.Resources.icons8_gmail_100px;
            this.Email.Location = new System.Drawing.Point(388, 92);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(91, 73);
            this.Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Email.TabIndex = 4;
            this.Email.TabStop = false;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Instagram
            // 
            this.Instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Instagram.Image = global::SQLite.Properties.Resources.icons8_instagram_100px;
            this.Instagram.Location = new System.Drawing.Point(291, 92);
            this.Instagram.Name = "Instagram";
            this.Instagram.Size = new System.Drawing.Size(91, 73);
            this.Instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Instagram.TabIndex = 3;
            this.Instagram.TabStop = false;
            this.Instagram.Click += new System.EventHandler(this.Instagram_Click);
            // 
            // Facebook
            // 
            this.Facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Facebook.Image = global::SQLite.Properties.Resources.icons8_facebook_100px;
            this.Facebook.Location = new System.Drawing.Point(194, 92);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(91, 73);
            this.Facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Facebook.TabIndex = 2;
            this.Facebook.TabStop = false;
            this.Facebook.Click += new System.EventHandler(this.Facebook_Click);
            // 
            // Whatsapp
            // 
            this.Whatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Whatsapp.Image = global::SQLite.Properties.Resources.icons8_whatsapp_100px;
            this.Whatsapp.Location = new System.Drawing.Point(97, 92);
            this.Whatsapp.Name = "Whatsapp";
            this.Whatsapp.Size = new System.Drawing.Size(91, 73);
            this.Whatsapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Whatsapp.TabIndex = 1;
            this.Whatsapp.TabStop = false;
            this.Whatsapp.Click += new System.EventHandler(this.Whatsapp_Click);
            // 
            // Costume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 184);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Instagram);
            this.Controls.Add(this.Facebook);
            this.Controls.Add(this.Whatsapp);
            this.Controls.Add(this.label1);
            this.Name = "Costume";
            this.Text = "Costume Aplikasi C# Desktop";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whatsapp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Whatsapp;
        private System.Windows.Forms.PictureBox Facebook;
        private System.Windows.Forms.PictureBox Instagram;
        private System.Windows.Forms.PictureBox Email;
    }
}