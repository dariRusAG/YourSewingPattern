
namespace YourSewingPattern
{
    partial class DataChangeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataChangeForm));
            this.dataChangePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pers_paramField = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passField_repeat = new System.Windows.Forms.TextBox();
            this.dataChange_close = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancellation_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userField = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passField = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataChangePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataChangePanel
            // 
            this.dataChangePanel.BackColor = System.Drawing.Color.Transparent;
            this.dataChangePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dataChangePanel.BackgroundImage")));
            this.dataChangePanel.Controls.Add(this.panel5);
            this.dataChangePanel.Controls.Add(this.panel4);
            this.dataChangePanel.Controls.Add(this.dataChange_close);
            this.dataChangePanel.Controls.Add(this.logo);
            this.dataChangePanel.Controls.Add(this.saveButton);
            this.dataChangePanel.Controls.Add(this.panel2);
            this.dataChangePanel.Controls.Add(this.cancellation_label);
            this.dataChangePanel.Controls.Add(this.panel1);
            this.dataChangePanel.Controls.Add(this.panel3);
            this.dataChangePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataChangePanel.Location = new System.Drawing.Point(0, 0);
            this.dataChangePanel.Name = "dataChangePanel";
            this.dataChangePanel.Size = new System.Drawing.Size(458, 750);
            this.dataChangePanel.TabIndex = 1;
            this.dataChangePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataChangePanel_MouseDown);
            this.dataChangePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataChangePanel_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel5.Controls.Add(this.pers_paramField);
            this.panel5.Location = new System.Drawing.Point(23, 424);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 64);
            this.panel5.TabIndex = 12;
            // 
            // pers_paramField
            // 
            this.pers_paramField.BackColor = System.Drawing.SystemColors.Window;
            this.pers_paramField.Font = new System.Drawing.Font("Times New Roman", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pers_paramField.ForeColor = System.Drawing.Color.Black;
            this.pers_paramField.Location = new System.Drawing.Point(3, 3);
            this.pers_paramField.Multiline = true;
            this.pers_paramField.Name = "pers_paramField";
            this.pers_paramField.Size = new System.Drawing.Size(402, 58);
            this.pers_paramField.TabIndex = 5;
            this.pers_paramField.TextChanged += new System.EventHandler(this.pers_paramField_TextChanged);
            this.pers_paramField.Enter += new System.EventHandler(this.pers_paramField_Enter);
            this.pers_paramField.Leave += new System.EventHandler(this.pers_paramField_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel4.Controls.Add(this.passField_repeat);
            this.panel4.Location = new System.Drawing.Point(23, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 50);
            this.panel4.TabIndex = 11;
            // 
            // passField_repeat
            // 
            this.passField_repeat.BackColor = System.Drawing.SystemColors.Window;
            this.passField_repeat.Font = new System.Drawing.Font("Times New Roman", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField_repeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.passField_repeat.Location = new System.Drawing.Point(3, 3);
            this.passField_repeat.Multiline = true;
            this.passField_repeat.Name = "passField_repeat";
            this.passField_repeat.Size = new System.Drawing.Size(402, 44);
            this.passField_repeat.TabIndex = 5;
            this.passField_repeat.Text = "подтвердите пароль";
            this.passField_repeat.UseSystemPasswordChar = true;
            this.passField_repeat.TextChanged += new System.EventHandler(this.passField_repeat_TextChanged);
            this.passField_repeat.Enter += new System.EventHandler(this.passField_repeat_Enter);
            this.passField_repeat.Leave += new System.EventHandler(this.passField_repeat_Leave);
            // 
            // dataChange_close
            // 
            this.dataChange_close.AutoSize = true;
            this.dataChange_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataChange_close.Font = new System.Drawing.Font("Segoe Print", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataChange_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dataChange_close.Location = new System.Drawing.Point(429, 0);
            this.dataChange_close.Name = "dataChange_close";
            this.dataChange_close.Size = new System.Drawing.Size(29, 40);
            this.dataChange_close.TabIndex = 1;
            this.dataChange_close.Text = "x";
            this.dataChange_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataChange_close.Click += new System.EventHandler(this.dataChange_close_Click);
            this.dataChange_close.MouseEnter += new System.EventHandler(this.dataChange_close_MouseEnter);
            this.dataChange_close.MouseLeave += new System.EventHandler(this.dataChange_close_MouseLeave);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(458, 156);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataChangePanel_MouseDown);
            this.logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataChangePanel_MouseMove);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Window;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe Print", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.saveButton.Location = new System.Drawing.Point(23, 512);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(402, 74);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(31, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 74);
            this.panel2.TabIndex = 9;
            // 
            // cancellation_label
            // 
            this.cancellation_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancellation_label.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancellation_label.ForeColor = System.Drawing.Color.White;
            this.cancellation_label.Location = new System.Drawing.Point(3, 615);
            this.cancellation_label.Name = "cancellation_label";
            this.cancellation_label.Size = new System.Drawing.Size(452, 66);
            this.cancellation_label.TabIndex = 6;
            this.cancellation_label.Text = "Отменить изменения";
            this.cancellation_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancellation_label.Click += new System.EventHandler(this.cancellation_label_Click);
            this.cancellation_label.MouseEnter += new System.EventHandler(this.cancellation_label_MouseEnter);
            this.cancellation_label.MouseLeave += new System.EventHandler(this.cancellation_label_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.userField);
            this.panel1.Location = new System.Drawing.Point(23, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 50);
            this.panel1.TabIndex = 7;
            // 
            // userField
            // 
            this.userField.BackColor = System.Drawing.SystemColors.Window;
            this.userField.Font = new System.Drawing.Font("Times New Roman", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userField.ForeColor = System.Drawing.Color.Black;
            this.userField.Location = new System.Drawing.Point(3, 3);
            this.userField.Multiline = true;
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(405, 44);
            this.userField.TabIndex = 3;
            this.userField.Enter += new System.EventHandler(this.userField_Enter);
            this.userField.Leave += new System.EventHandler(this.userField_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.passField);
            this.panel3.Location = new System.Drawing.Point(23, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 50);
            this.panel3.TabIndex = 8;
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.Window;
            this.passField.Font = new System.Drawing.Font("Times New Roman", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.ForeColor = System.Drawing.Color.Black;
            this.passField.Location = new System.Drawing.Point(3, 3);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(405, 44);
            this.passField.TabIndex = 5;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "В каком порядке и какие параметры нужно ввести";
            // 
            // DataChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 750);
            this.Controls.Add(this.dataChangePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataChangeForm";
            this.Text = "FavoritesForm";
            this.Load += new System.EventHandler(this.DataChangeForm_Load);
            this.dataChangePanel.ResumeLayout(false);
            this.dataChangePanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataChangePanel;
        private System.Windows.Forms.Label dataChange_close;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox passField_repeat;
        private System.Windows.Forms.Label cancellation_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox pers_paramField;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}