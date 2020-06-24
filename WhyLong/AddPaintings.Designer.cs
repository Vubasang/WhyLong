namespace WhyLong
{
    partial class AddPaintings
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
            this.txtNameOfThePicture = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWhereIs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Называние картины";
            // 
            // txtNameOfThePicture
            // 
            this.txtNameOfThePicture.Location = new System.Drawing.Point(355, 37);
            this.txtNameOfThePicture.Name = "txtNameOfThePicture";
            this.txtNameOfThePicture.Size = new System.Drawing.Size(370, 22);
            this.txtNameOfThePicture.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Картина";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(355, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Разрешение файла";
            // 
            // txtResolution
            // 
            this.txtResolution.Location = new System.Drawing.Point(355, 373);
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(370, 22);
            this.txtResolution.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(355, 412);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(370, 22);
            this.txtAuthor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Автор";
            // 
            // txtWhereIs
            // 
            this.txtWhereIs.Location = new System.Drawing.Point(355, 457);
            this.txtWhereIs.Name = "txtWhereIs";
            this.txtWhereIs.Size = new System.Drawing.Size(370, 22);
            this.txtWhereIs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Где находится";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить картинку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddPaintings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWhereIs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameOfThePicture);
            this.Controls.Add(this.label1);
            this.Name = "AddPaintings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить картинку";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameOfThePicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWhereIs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}