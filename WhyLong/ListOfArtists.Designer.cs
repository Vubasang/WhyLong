namespace WhyLong
{
    partial class ListOfArtists
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biography = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExhibitionList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListOfPublications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.YearOfBirth,
            this.PlaceOfBirth,
            this.Biography,
            this.Image,
            this.ExhibitionList,
            this.ProjectList,
            this.ListOfPublications});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1889, 569);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "ФИО художника";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.DataPropertyName = "YearOfBirth";
            this.YearOfBirth.HeaderText = "Год рождения";
            this.YearOfBirth.MinimumWidth = 6;
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.Width = 150;
            // 
            // PlaceOfBirth
            // 
            this.PlaceOfBirth.DataPropertyName = "PlaceOfBirth";
            this.PlaceOfBirth.HeaderText = "Место рождения";
            this.PlaceOfBirth.MinimumWidth = 6;
            this.PlaceOfBirth.Name = "PlaceOfBirth";
            this.PlaceOfBirth.Width = 200;
            // 
            // Biography
            // 
            this.Biography.DataPropertyName = "Biography";
            this.Biography.HeaderText = "Биография";
            this.Biography.MinimumWidth = 6;
            this.Biography.Name = "Biography";
            this.Biography.Width = 180;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Фотография худождника";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 180;
            // 
            // ExhibitionList
            // 
            this.ExhibitionList.DataPropertyName = "ExhibitionList";
            this.ExhibitionList.HeaderText = "Список выставок";
            this.ExhibitionList.MinimumWidth = 6;
            this.ExhibitionList.Name = "ExhibitionList";
            this.ExhibitionList.Width = 160;
            // 
            // ProjectList
            // 
            this.ProjectList.DataPropertyName = "ProjectList";
            this.ProjectList.HeaderText = "Список проектов";
            this.ProjectList.MinimumWidth = 6;
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Width = 160;
            // 
            // ListOfPublications
            // 
            this.ListOfPublications.DataPropertyName = "ListOfPublications";
            this.ListOfPublications.HeaderText = "Список публикаций";
            this.ListOfPublications.MinimumWidth = 6;
            this.ListOfPublications.Name = "ListOfPublications";
            this.ListOfPublications.Width = 180;
            // 
            // ListOfArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 673);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListOfArtists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сотрудников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biography;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExhibitionList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListOfPublications;
    }
}