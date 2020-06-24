namespace WhyLong
{
    partial class ListsOfArt
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
            this.NameOfThePicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.Resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhereIs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameOfThePicture,
            this.Picture,
            this.Resolution,
            this.Author,
            this.WhereIs});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1659, 599);
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
            // NameOfThePicture
            // 
            this.NameOfThePicture.DataPropertyName = "NameOfThePicture";
            this.NameOfThePicture.HeaderText = "Название картины";
            this.NameOfThePicture.MinimumWidth = 6;
            this.NameOfThePicture.Name = "NameOfThePicture";
            this.NameOfThePicture.Width = 180;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Картина";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Picture.MinimumWidth = 6;
            this.Picture.Name = "Picture";
            this.Picture.Width = 210;
            // 
            // Resolution
            // 
            this.Resolution.DataPropertyName = "Resolution";
            this.Resolution.HeaderText = "Разрешение файла";
            this.Resolution.MinimumWidth = 6;
            this.Resolution.Name = "Resolution";
            this.Resolution.Width = 200;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Автор";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 200;
            // 
            // WhereIs
            // 
            this.WhereIs.DataPropertyName = "WhereIs";
            this.WhereIs.HeaderText = "Где находится";
            this.WhereIs.MinimumWidth = 6;
            this.WhereIs.Name = "WhereIs";
            this.WhereIs.Width = 300;
            // 
            // ListsOfArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 623);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListsOfArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список картин";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfThePicture;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhereIs;
    }
}