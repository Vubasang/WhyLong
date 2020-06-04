namespace WhyLong
{
    partial class SomethingIsNotWorking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomethingIsNotWorking));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(443, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Что-то не работает, проблемы с сайтом или найдена ошибка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(617, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Технические проблемы сайта";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(83, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 37);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(29, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Создать новую тему";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(-3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 31);
            this.label3.TabIndex = 0;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(83, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1327, 35);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Темы:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.topicTitle,
            this.Topic,
            this.Answer});
            this.dataGridView1.Location = new System.Drawing.Point(71, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 227);
            this.dataGridView1.TabIndex = 4;
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
            // topicTitle
            // 
            this.topicTitle.DataPropertyName = "topicTitle";
            this.topicTitle.HeaderText = "Заголовок темы";
            this.topicTitle.MinimumWidth = 6;
            this.topicTitle.Name = "topicTitle";
            this.topicTitle.ReadOnly = true;
            this.topicTitle.Width = 250;
            // 
            // Topic
            // 
            this.Topic.DataPropertyName = "Topic";
            this.Topic.HeaderText = "Тема";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            this.Topic.Width = 350;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Ответы";
            this.Answer.MinimumWidth = 6;
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 350;
            // 
            // SomethingIsNotWorking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SomethingIsNotWorking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Что-то не работает";
            this.Load += new System.EventHandler(this.SomethingIsNotWorking_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}