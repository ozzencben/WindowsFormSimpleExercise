namespace WindowsForms2
{
    partial class anaForm
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
            this.lblSelamla = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textLastname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelamla
            // 
            this.lblSelamla.AutoSize = true;
            this.lblSelamla.Location = new System.Drawing.Point(67, 9);
            this.lblSelamla.Name = "lblSelamla";
            this.lblSelamla.Size = new System.Drawing.Size(49, 13);
            this.lblSelamla.TabIndex = 0;
            this.lblSelamla.Text = "Merhaba";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textName.Location = new System.Drawing.Point(23, 36);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(45, 17);
            this.textName.TabIndex = 1;
            this.textName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textLastname
            // 
            this.textLastname.AutoSize = true;
            this.textLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textLastname.Location = new System.Drawing.Point(23, 60);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(70, 17);
            this.textLastname.TabIndex = 1;
            this.textLastname.Text = "Lastname";
            this.textLastname.Click += new System.EventHandler(this.textLastname_Click);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(108, 59);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(180, 20);
            this.textBoxLastname.TabIndex = 2;
            // 
            // textUsername
            // 
            this.textUsername.AutoSize = true;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUsername.Location = new System.Drawing.Point(325, 36);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(73, 17);
            this.textUsername.TabIndex = 1;
            this.textUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(410, 33);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(180, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPassword.Location = new System.Drawing.Point(325, 60);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(69, 17);
            this.textPassword.TabIndex = 1;
            this.textPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(410, 59);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxLong
            // 
            this.textBoxLong.Location = new System.Drawing.Point(26, 125);
            this.textBoxLong.Multiline = true;
            this.textBoxLong.Name = "textBoxLong";
            this.textBoxLong.Size = new System.Drawing.Size(564, 64);
            this.textBoxLong.TabIndex = 2;
            this.textBoxLong.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Açıklama";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(26, 196);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(564, 26);
            this.guncellebtn.TabIndex = 3;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 234);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.textBoxLong);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblSelamla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "anaForm";
            this.Text = "Akitf Kullanıcı Bilgisi";
            this.Load += new System.EventHandler(this.anaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelamla;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label textLastname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label textUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label textPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button guncellebtn;
    }
}