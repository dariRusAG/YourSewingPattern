
namespace YourSewingPattern
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registerPanel = new System.Windows.Forms.Panel();
            this.register_close = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_log = new System.Windows.Forms.PictureBox();
            this.register_label = new System.Windows.Forms.Label();
            this.lock_pass = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userField = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passField = new System.Windows.Forms.TextBox();
            this.label_res = new System.Windows.Forms.Label();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pass)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.Transparent;
            this.registerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerPanel.BackgroundImage")));
            this.registerPanel.Controls.Add(this.label_res);
            this.registerPanel.Controls.Add(this.register_close);
            this.registerPanel.Controls.Add(this.logo);
            this.registerPanel.Controls.Add(this.RegisterButton);
            this.registerPanel.Controls.Add(this.panel2);
            this.registerPanel.Controls.Add(this.user_log);
            this.registerPanel.Controls.Add(this.register_label);
            this.registerPanel.Controls.Add(this.lock_pass);
            this.registerPanel.Controls.Add(this.panel1);
            this.registerPanel.Controls.Add(this.panel3);
            this.registerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPanel.Location = new System.Drawing.Point(0, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(458, 750);
            this.registerPanel.TabIndex = 1;
            this.registerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registerPanel_MouseDown);
            this.registerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerPanel_MouseMove);
            // 
            // register_close
            // 
            this.register_close.AutoSize = true;
            this.register_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_close.Font = new System.Drawing.Font("Segoe Print", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.register_close.Location = new System.Drawing.Point(429, 0);
            this.register_close.Name = "register_close";
            this.register_close.Size = new System.Drawing.Size(29, 40);
            this.register_close.TabIndex = 1;
            this.register_close.Text = "x";
            this.register_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.register_close.Click += new System.EventHandler(this.register_close_Click);
            this.register_close.MouseEnter += new System.EventHandler(this.register_close_MouseEnter);
            this.register_close.MouseLeave += new System.EventHandler(this.register_close_MouseLeave);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(458, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registerPanel_MouseDown);
            this.logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerPanel_MouseMove);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.Window;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.RegisterButton.Location = new System.Drawing.Point(44, 457);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(376, 62);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(52, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 62);
            this.panel2.TabIndex = 9;
            // 
            // user_log
            // 
            this.user_log.BackColor = System.Drawing.Color.Transparent;
            this.user_log.Image = ((System.Drawing.Image)(resources.GetObject("user_log.Image")));
            this.user_log.Location = new System.Drawing.Point(47, 266);
            this.user_log.Name = "user_log";
            this.user_log.Size = new System.Drawing.Size(50, 50);
            this.user_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_log.TabIndex = 2;
            this.user_log.TabStop = false;
            // 
            // register_label
            // 
            this.register_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_label.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_label.ForeColor = System.Drawing.Color.White;
            this.register_label.Location = new System.Drawing.Point(3, 614);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(455, 53);
            this.register_label.TabIndex = 6;
            this.register_label.Text = "Уже есть аккаунт?";
            this.register_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.register_label.Click += new System.EventHandler(this.register_label_Click);
            this.register_label.MouseEnter += new System.EventHandler(this.register_label_MouseEnter);
            this.register_label.MouseLeave += new System.EventHandler(this.register_label_MouseLeave);
            // 
            // lock_pass
            // 
            this.lock_pass.BackColor = System.Drawing.Color.Transparent;
            this.lock_pass.Image = ((System.Drawing.Image)(resources.GetObject("lock_pass.Image")));
            this.lock_pass.Location = new System.Drawing.Point(47, 359);
            this.lock_pass.Name = "lock_pass";
            this.lock_pass.Size = new System.Drawing.Size(50, 50);
            this.lock_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lock_pass.TabIndex = 4;
            this.lock_pass.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.userField);
            this.panel1.Location = new System.Drawing.Point(135, 266);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.passField);
            this.panel3.Location = new System.Drawing.Point(135, 359);
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
            // label_res
            // 
            this.label_res.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_res.Font = new System.Drawing.Font("Segoe Print", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_res.ForeColor = System.Drawing.Color.Black;
            this.label_res.Location = new System.Drawing.Point(47, 130);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(376, 92);
            this.label_res.TabIndex = 11;
            this.label_res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 750);
            this.Controls.Add(this.registerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lock_pass)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label register_close;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox user_log;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.PictureBox lock_pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label label_res;
    }
}