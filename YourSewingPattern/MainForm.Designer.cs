
namespace YourSewingPattern
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.three_category = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.two_category = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_header = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.main_close = new System.Windows.Forms.Label();
            this.one_category = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_LK = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.main_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.Controls.Add(this.three_category);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.two_category);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.main_header);
            this.mainPanel.Controls.Add(this.main_close);
            this.mainPanel.Controls.Add(this.one_category);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.main_LK);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(458, 750);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // three_category
            // 
            this.three_category.BackColor = System.Drawing.SystemColors.Window;
            this.three_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three_category.FlatAppearance.BorderSize = 0;
            this.three_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.three_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.three_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three_category.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.three_category.Location = new System.Drawing.Point(21, 391);
            this.three_category.Name = "three_category";
            this.three_category.Size = new System.Drawing.Size(414, 55);
            this.three_category.TabIndex = 14;
            this.three_category.Text = "Одежда для всего тела";
            this.three_category.UseVisualStyleBackColor = false;
            this.three_category.Click += new System.EventHandler(this.three_category_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.Location = new System.Drawing.Point(29, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 55);
            this.panel3.TabIndex = 15;
            // 
            // two_category
            // 
            this.two_category.BackColor = System.Drawing.SystemColors.Window;
            this.two_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two_category.FlatAppearance.BorderSize = 0;
            this.two_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.two_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.two_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_category.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.two_category.Location = new System.Drawing.Point(21, 294);
            this.two_category.Name = "two_category";
            this.two_category.Size = new System.Drawing.Size(414, 55);
            this.two_category.TabIndex = 12;
            this.two_category.Text = "Одежда ниже пояса";
            this.two_category.UseVisualStyleBackColor = false;
            this.two_category.Click += new System.EventHandler(this.two_category_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(29, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 55);
            this.panel1.TabIndex = 13;
            // 
            // main_header
            // 
            this.main_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.main_header.Controls.Add(this.label);
            this.main_header.Location = new System.Drawing.Point(224, 57);
            this.main_header.Name = "main_header";
            this.main_header.Size = new System.Drawing.Size(276, 50);
            this.main_header.TabIndex = 11;
            // 
            // label
            // 
            this.label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(27, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(207, 50);
            this.label.TabIndex = 10;
            this.label.Text = "Каталог";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_close
            // 
            this.main_close.AutoSize = true;
            this.main_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_close.Font = new System.Drawing.Font("Segoe Print", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.main_close.Location = new System.Drawing.Point(429, 0);
            this.main_close.Name = "main_close";
            this.main_close.Size = new System.Drawing.Size(29, 40);
            this.main_close.TabIndex = 1;
            this.main_close.Text = "x";
            this.main_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_close.Click += new System.EventHandler(this.main_close_Click);
            this.main_close.MouseEnter += new System.EventHandler(this.main_close_MouseEnter);
            this.main_close.MouseLeave += new System.EventHandler(this.main_close_MouseLeave);
            // 
            // one_category
            // 
            this.one_category.BackColor = System.Drawing.SystemColors.Window;
            this.one_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one_category.FlatAppearance.BorderSize = 0;
            this.one_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.one_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.one_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_category.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.one_category.Location = new System.Drawing.Point(21, 192);
            this.one_category.Name = "one_category";
            this.one_category.Size = new System.Drawing.Size(414, 55);
            this.one_category.TabIndex = 1;
            this.one_category.Text = "Одежда выше пояса";
            this.one_category.UseVisualStyleBackColor = false;
            this.one_category.Click += new System.EventHandler(this.one_category_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(29, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 55);
            this.panel2.TabIndex = 9;
            // 
            // main_LK
            // 
            this.main_LK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_LK.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_LK.ForeColor = System.Drawing.Color.White;
            this.main_LK.Location = new System.Drawing.Point(3, 588);
            this.main_LK.Name = "main_LK";
            this.main_LK.Size = new System.Drawing.Size(452, 108);
            this.main_LK.TabIndex = 6;
            this.main_LK.Text = "Личный кабинет";
            this.main_LK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_LK.Click += new System.EventHandler(this.main_LK_Click);
            this.main_LK.MouseEnter += new System.EventHandler(this.main_LK_MouseEnter);
            this.main_LK.MouseLeave += new System.EventHandler(this.main_LK_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 750);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.main_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label main_close;
        private System.Windows.Forms.Button one_category;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label main_LK;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel main_header;
        private System.Windows.Forms.Button three_category;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button two_category;
        private System.Windows.Forms.Panel panel1;
    }
}