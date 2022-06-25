
namespace YourSewingPattern
{
    partial class PatternListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternListForm));
            this.patternPanel = new System.Windows.Forms.Panel();
            this.PatternButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_patterns = new System.Windows.Forms.PictureBox();
            this.pattern_header = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.patterns_close = new System.Windows.Forms.Label();
            this.patterns_LK = new System.Windows.Forms.Label();
            this.patternPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_patterns)).BeginInit();
            this.pattern_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // patternPanel
            // 
            this.patternPanel.BackColor = System.Drawing.Color.Transparent;
            this.patternPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patternPanel.BackgroundImage")));
            this.patternPanel.Controls.Add(this.PatternButton);
            this.patternPanel.Controls.Add(this.panel2);
            this.patternPanel.Controls.Add(this.dataGridView1);
            this.patternPanel.Controls.Add(this.back_patterns);
            this.patternPanel.Controls.Add(this.pattern_header);
            this.patternPanel.Controls.Add(this.patterns_close);
            this.patternPanel.Controls.Add(this.patterns_LK);
            this.patternPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patternPanel.Location = new System.Drawing.Point(0, 0);
            this.patternPanel.Name = "patternPanel";
            this.patternPanel.Size = new System.Drawing.Size(458, 750);
            this.patternPanel.TabIndex = 3;
            this.patternPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patternPanel_MouseDown);
            this.patternPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.patternPanel_MouseMove);
            // 
            // PatternButton
            // 
            this.PatternButton.BackColor = System.Drawing.SystemColors.Window;
            this.PatternButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatternButton.FlatAppearance.BorderSize = 0;
            this.PatternButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PatternButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PatternButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatternButton.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatternButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.PatternButton.Location = new System.Drawing.Point(92, 471);
            this.PatternButton.Name = "PatternButton";
            this.PatternButton.Size = new System.Drawing.Size(346, 53);
            this.PatternButton.TabIndex = 14;
            this.PatternButton.Text = "Добавить в избранное";
            this.PatternButton.UseVisualStyleBackColor = false;
            this.PatternButton.Click += new System.EventHandler(this.PatternButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(100, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 53);
            this.panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(434, 322);
            this.dataGridView1.TabIndex = 13;
            // 
            // back_patterns
            // 
            this.back_patterns.Image = ((System.Drawing.Image)(resources.GetObject("back_patterns.Image")));
            this.back_patterns.Location = new System.Drawing.Point(92, 57);
            this.back_patterns.Name = "back_patterns";
            this.back_patterns.Size = new System.Drawing.Size(50, 50);
            this.back_patterns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_patterns.TabIndex = 12;
            this.back_patterns.TabStop = false;
            this.back_patterns.Click += new System.EventHandler(this.back_patterns_Click);
            this.back_patterns.MouseEnter += new System.EventHandler(this.back_patterns_MouseEnter);
            this.back_patterns.MouseLeave += new System.EventHandler(this.back_patterns_MouseLeave);
            // 
            // pattern_header
            // 
            this.pattern_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.pattern_header.Controls.Add(this.label);
            this.pattern_header.Location = new System.Drawing.Point(148, 57);
            this.pattern_header.Name = "pattern_header";
            this.pattern_header.Size = new System.Drawing.Size(352, 50);
            this.pattern_header.TabIndex = 11;
            // 
            // label
            // 
            this.label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(27, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(283, 50);
            this.label.TabIndex = 10;
            this.label.Text = "Список шаблонов";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patterns_close
            // 
            this.patterns_close.AutoSize = true;
            this.patterns_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patterns_close.Font = new System.Drawing.Font("Segoe Print", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patterns_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.patterns_close.Location = new System.Drawing.Point(429, 0);
            this.patterns_close.Name = "patterns_close";
            this.patterns_close.Size = new System.Drawing.Size(29, 40);
            this.patterns_close.TabIndex = 1;
            this.patterns_close.Text = "x";
            this.patterns_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patterns_close.Click += new System.EventHandler(this.patterns_close_Click);
            this.patterns_close.MouseEnter += new System.EventHandler(this.patterns_close_MouseEnter);
            this.patterns_close.MouseLeave += new System.EventHandler(this.patterns_close_MouseLeave);
            // 
            // patterns_LK
            // 
            this.patterns_LK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patterns_LK.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patterns_LK.ForeColor = System.Drawing.Color.White;
            this.patterns_LK.Location = new System.Drawing.Point(0, 588);
            this.patterns_LK.Name = "patterns_LK";
            this.patterns_LK.Size = new System.Drawing.Size(458, 108);
            this.patterns_LK.TabIndex = 6;
            this.patterns_LK.Text = "Личный кабинет";
            this.patterns_LK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patterns_LK.Click += new System.EventHandler(this.patterns_LK_Click);
            this.patterns_LK.MouseEnter += new System.EventHandler(this.patterns_LK_MouseEnter);
            this.patterns_LK.MouseLeave += new System.EventHandler(this.patterns_LK_MouseLeave);
            // 
            // PatternListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 750);
            this.Controls.Add(this.patternPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatternListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatternListForm";
            this.patternPanel.ResumeLayout(false);
            this.patternPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_patterns)).EndInit();
            this.pattern_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel patternPanel;
        private System.Windows.Forms.PictureBox back_patterns;
        private System.Windows.Forms.Panel pattern_header;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label patterns_close;
        private System.Windows.Forms.Label patterns_LK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PatternButton;
        private System.Windows.Forms.Panel panel2;
    }
}