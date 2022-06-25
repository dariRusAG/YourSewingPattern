
namespace YourSewingPattern
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.passField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userField = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.user_log = new System.Windows.Forms.PictureBox();
            this.lock_pass = new System.Windows.Forms.PictureBox();
            this.auth_label = new System.Windows.Forms.Label();
            this.auth_close = new System.Windows.Forms.Label();
            this.authPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pass)).BeginInit();
            this.authPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.passField);
            this.panel3.Location = new System.Drawing.Point(135, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 50);
            this.panel3.TabIndex = 8;
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.Window;
            this.passField.Font = new System.Drawing.Font("Times New Roman", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.passField.Location = new System.Drawing.Point(3, 3);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(282, 44);
            this.passField.TabIndex = 5;
            this.passField.Text = "пароль";
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.userField);
            this.panel1.Location = new System.Drawing.Point(135, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 50);
            this.panel1.TabIndex = 7;
            // 
            // userField
            // 
            this.userField.BackColor = System.Drawing.SystemColors.Window;
            this.userField.Font = new System.Drawing.Font("Times New Roman", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.userField.Location = new System.Drawing.Point(3, 3);
            this.userField.Multiline = true;
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(282, 44);
            this.userField.TabIndex = 3;
            this.userField.Text = "логин";
            this.userField.Enter += new System.EventHandler(this.userField_Enter);
            this.userField.Leave += new System.EventHandler(this.userField_Leave);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.Window;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.signInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe Print", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.signInButton.Location = new System.Drawing.Point(93, 424);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(284, 74);
            this.signInButton.TabIndex = 1;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // user_log
            // 
            this.user_log.BackColor = System.Drawing.Color.Transparent;
            this.user_log.Image = ((System.Drawing.Image)(resources.GetObject("user_log.Image")));
            this.user_log.Location = new System.Drawing.Point(47, 197);
            this.user_log.Name = "user_log";
            this.user_log.Size = new System.Drawing.Size(50, 50);
            this.user_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_log.TabIndex = 2;
            this.user_log.TabStop = false;
            // 
            // lock_pass
            // 
            this.lock_pass.BackColor = System.Drawing.Color.Transparent;
            this.lock_pass.Image = ((System.Drawing.Image)(resources.GetObject("lock_pass.Image")));
            this.lock_pass.Location = new System.Drawing.Point(47, 290);
            this.lock_pass.Name = "lock_pass";
            this.lock_pass.Size = new System.Drawing.Size(50, 50);
            this.lock_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lock_pass.TabIndex = 4;
            this.lock_pass.TabStop = false;
            // 
            // auth_label
            // 
            this.auth_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auth_label.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_label.ForeColor = System.Drawing.Color.White;
            this.auth_label.Location = new System.Drawing.Point(0, 618);
            this.auth_label.Name = "auth_label";
            this.auth_label.Size = new System.Drawing.Size(458, 53);
            this.auth_label.TabIndex = 6;
            this.auth_label.Text = "Еще нет аккаунта?";
            this.auth_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.auth_label.Click += new System.EventHandler(this.auth_label_Click);
            this.auth_label.MouseEnter += new System.EventHandler(this.auth_label_MouseEnter);
            this.auth_label.MouseLeave += new System.EventHandler(this.auth_label_MouseLeave);
            // 
            // auth_close
            // 
            this.auth_close.AutoSize = true;
            this.auth_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auth_close.Font = new System.Drawing.Font("Segoe Print", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.auth_close.Location = new System.Drawing.Point(429, 0);
            this.auth_close.Name = "auth_close";
            this.auth_close.Size = new System.Drawing.Size(29, 40);
            this.auth_close.TabIndex = 1;
            this.auth_close.Text = "x";
            this.auth_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.auth_close.Click += new System.EventHandler(this.auth_close_Click);
            this.auth_close.MouseEnter += new System.EventHandler(this.auth_close_MouseEnter);
            this.auth_close.MouseLeave += new System.EventHandler(this.auth_close_MouseLeave);
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.Transparent;
            this.authPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("authPanel.BackgroundImage")));
            this.authPanel.Controls.Add(this.auth_close);
            this.authPanel.Controls.Add(this.logo);
            this.authPanel.Controls.Add(this.signInButton);
            this.authPanel.Controls.Add(this.panel2);
            this.authPanel.Controls.Add(this.user_log);
            this.authPanel.Controls.Add(this.auth_label);
            this.authPanel.Controls.Add(this.lock_pass);
            this.authPanel.Controls.Add(this.panel1);
            this.authPanel.Controls.Add(this.panel3);
            this.authPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authPanel.Location = new System.Drawing.Point(0, 0);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(458, 750);
            this.authPanel.TabIndex = 0;
            this.authPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authPanel_MouseDown);
            this.authPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authPanel_MouseMove);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(458, 191);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authPanel_MouseDown);
            this.logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authPanel_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(101, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 74);
            this.panel2.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 750);
            this.Controls.Add(this.authPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pass)).EndInit();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.PictureBox user_log;
        private System.Windows.Forms.PictureBox lock_pass;
        private System.Windows.Forms.Label auth_label;
        private System.Windows.Forms.Label auth_close;
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
    }
}