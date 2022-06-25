
namespace YourSewingPattern
{
    partial class FavoritesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritesListForm));
            this.favoritesPanel = new System.Windows.Forms.Panel();
            this.update_notes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.favorites_main = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.favorites_header = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.favorites_close = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back_favorites = new System.Windows.Forms.PictureBox();
            this.favoritesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.favorites_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_favorites)).BeginInit();
            this.SuspendLayout();
            // 
            // favoritesPanel
            // 
            this.favoritesPanel.BackColor = System.Drawing.Color.Transparent;
            this.favoritesPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favoritesPanel.BackgroundImage")));
            this.favoritesPanel.Controls.Add(this.back_favorites);
            this.favoritesPanel.Controls.Add(this.update_notes);
            this.favoritesPanel.Controls.Add(this.panel1);
            this.favoritesPanel.Controls.Add(this.favorites_main);
            this.favoritesPanel.Controls.Add(this.dataGridView1);
            this.favoritesPanel.Controls.Add(this.favorites_header);
            this.favoritesPanel.Controls.Add(this.favorites_close);
            this.favoritesPanel.Controls.Add(this.DeleteButton);
            this.favoritesPanel.Controls.Add(this.panel2);
            this.favoritesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoritesPanel.Location = new System.Drawing.Point(0, 0);
            this.favoritesPanel.Name = "favoritesPanel";
            this.favoritesPanel.Size = new System.Drawing.Size(458, 750);
            this.favoritesPanel.TabIndex = 2;
            this.favoritesPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.favoritesPanel_MouseDown);
            this.favoritesPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.favoritesPanel_MouseMove);
            // 
            // update_notes
            // 
            this.update_notes.BackColor = System.Drawing.SystemColors.Window;
            this.update_notes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_notes.FlatAppearance.BorderSize = 0;
            this.update_notes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.update_notes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.update_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_notes.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_notes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.update_notes.Location = new System.Drawing.Point(12, 459);
            this.update_notes.Name = "update_notes";
            this.update_notes.Size = new System.Drawing.Size(426, 53);
            this.update_notes.TabIndex = 17;
            this.update_notes.Text = "Изменить заметку";
            this.update_notes.UseVisualStyleBackColor = false;
            this.update_notes.Click += new System.EventHandler(this.update_notes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(20, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 53);
            this.panel1.TabIndex = 18;
            // 
            // favorites_main
            // 
            this.favorites_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favorites_main.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favorites_main.ForeColor = System.Drawing.Color.White;
            this.favorites_main.Location = new System.Drawing.Point(0, 603);
            this.favorites_main.Name = "favorites_main";
            this.favorites_main.Size = new System.Drawing.Size(458, 89);
            this.favorites_main.TabIndex = 16;
            this.favorites_main.Text = "Вернуться на главный экран";
            this.favorites_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.favorites_main.Click += new System.EventHandler(this.favorites_main_Click);
            this.favorites_main.MouseEnter += new System.EventHandler(this.favorites_main_MouseEnter);
            this.favorites_main.MouseLeave += new System.EventHandler(this.favorites_main_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(434, 322);
            this.dataGridView1.TabIndex = 15;
            // 
            // favorites_header
            // 
            this.favorites_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.favorites_header.Controls.Add(this.label);
            this.favorites_header.Location = new System.Drawing.Point(124, 56);
            this.favorites_header.Name = "favorites_header";
            this.favorites_header.Size = new System.Drawing.Size(369, 50);
            this.favorites_header.TabIndex = 14;
            // 
            // label
            // 
            this.label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(24, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(310, 50);
            this.label.TabIndex = 10;
            this.label.Text = "Список избранного";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favorites_close
            // 
            this.favorites_close.AutoSize = true;
            this.favorites_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favorites_close.Font = new System.Drawing.Font("Segoe Print", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favorites_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.favorites_close.Location = new System.Drawing.Point(429, 0);
            this.favorites_close.Name = "favorites_close";
            this.favorites_close.Size = new System.Drawing.Size(29, 40);
            this.favorites_close.TabIndex = 1;
            this.favorites_close.Text = "x";
            this.favorites_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.favorites_close.Click += new System.EventHandler(this.favorites_close_Click);
            this.favorites_close.MouseEnter += new System.EventHandler(this.favorites_close_MouseEnter);
            this.favorites_close.MouseLeave += new System.EventHandler(this.favorites_close_MouseLeave);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Window;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe Print", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.DeleteButton.Location = new System.Drawing.Point(12, 529);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(426, 53);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить выкройку";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(20, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 53);
            this.panel2.TabIndex = 9;
            // 
            // back_favorites
            // 
            this.back_favorites.Image = ((System.Drawing.Image)(resources.GetObject("back_favorites.Image")));
            this.back_favorites.Location = new System.Drawing.Point(68, 56);
            this.back_favorites.Name = "back_favorites";
            this.back_favorites.Size = new System.Drawing.Size(50, 50);
            this.back_favorites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_favorites.TabIndex = 19;
            this.back_favorites.TabStop = false;
            this.back_favorites.Click += new System.EventHandler(this.back_favorites_Click);
            this.back_favorites.MouseEnter += new System.EventHandler(this.back_favorites_MouseEnter);
            this.back_favorites.MouseLeave += new System.EventHandler(this.back_favorites_MouseLeave);
            // 
            // FavoritesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 750);
            this.Controls.Add(this.favoritesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FavoritesListForm";
            this.Text = "FavoritesListForm";
            this.favoritesPanel.ResumeLayout(false);
            this.favoritesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.favorites_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_favorites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel favoritesPanel;
        private System.Windows.Forms.Label favorites_close;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel favorites_header;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label favorites_main;
        private System.Windows.Forms.Button update_notes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox back_favorites;
    }
}