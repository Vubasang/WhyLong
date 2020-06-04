namespace WhyLong
{
    partial class PosterExhibition
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
            System.Windows.Forms.Timer timer1;
            this.label4 = new System.Windows.Forms.Label();
            this.btnExhibitionYakutsk = new System.Windows.Forms.Button();
            this.btnExhibitionMoscow = new System.Windows.Forms.Button();
            this.btnExhibitionPeterburg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTime_PosterExhibition = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.mapPosterExhibition = new GMap.NET.WindowsForms.GMapControl();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(37, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Афиша художественных выставок";
            // 
            // btnExhibitionYakutsk
            // 
            this.btnExhibitionYakutsk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExhibitionYakutsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExhibitionYakutsk.Location = new System.Drawing.Point(42, 71);
            this.btnExhibitionYakutsk.Name = "btnExhibitionYakutsk";
            this.btnExhibitionYakutsk.Size = new System.Drawing.Size(98, 47);
            this.btnExhibitionYakutsk.TabIndex = 5;
            this.btnExhibitionYakutsk.Text = "Якутск";
            this.btnExhibitionYakutsk.UseVisualStyleBackColor = false;
            this.btnExhibitionYakutsk.Click += new System.EventHandler(this.BtnExhibitionYakutsk_Click);
            // 
            // btnExhibitionMoscow
            // 
            this.btnExhibitionMoscow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExhibitionMoscow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExhibitionMoscow.Location = new System.Drawing.Point(156, 71);
            this.btnExhibitionMoscow.Name = "btnExhibitionMoscow";
            this.btnExhibitionMoscow.Size = new System.Drawing.Size(98, 47);
            this.btnExhibitionMoscow.TabIndex = 6;
            this.btnExhibitionMoscow.Text = "Москва";
            this.btnExhibitionMoscow.UseVisualStyleBackColor = false;
            this.btnExhibitionMoscow.Click += new System.EventHandler(this.BtnExhibitionMoscow_Click);
            // 
            // btnExhibitionPeterburg
            // 
            this.btnExhibitionPeterburg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExhibitionPeterburg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExhibitionPeterburg.Location = new System.Drawing.Point(270, 71);
            this.btnExhibitionPeterburg.Name = "btnExhibitionPeterburg";
            this.btnExhibitionPeterburg.Size = new System.Drawing.Size(174, 47);
            this.btnExhibitionPeterburg.TabIndex = 7;
            this.btnExhibitionPeterburg.Text = "Санкт-Петербург";
            this.btnExhibitionPeterburg.UseVisualStyleBackColor = false;
            this.btnExhibitionPeterburg.Click += new System.EventHandler(this.BtnExhibitionPeterburg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(37, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Точная дата";
            // 
            // lbTime_PosterExhibition
            // 
            this.lbTime_PosterExhibition.AutoSize = true;
            this.lbTime_PosterExhibition.Enabled = false;
            this.lbTime_PosterExhibition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime_PosterExhibition.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTime_PosterExhibition.Location = new System.Drawing.Point(79, 385);
            this.lbTime_PosterExhibition.Name = "lbTime_PosterExhibition";
            this.lbTime_PosterExhibition.Size = new System.Drawing.Size(141, 36);
            this.lbTime_PosterExhibition.TabIndex = 9;
            this.lbTime_PosterExhibition.Text = "00:00:00";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(42, 182);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // mapPosterExhibition
            // 
            this.mapPosterExhibition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPosterExhibition.Bearing = 0F;
            this.mapPosterExhibition.CanDragMap = true;
            this.mapPosterExhibition.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapPosterExhibition.GrayScaleMode = false;
            this.mapPosterExhibition.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapPosterExhibition.LevelsKeepInMemory = 5;
            this.mapPosterExhibition.Location = new System.Drawing.Point(296, 182);
            this.mapPosterExhibition.MarkersEnabled = true;
            this.mapPosterExhibition.MaxZoom = 2;
            this.mapPosterExhibition.MinZoom = 2;
            this.mapPosterExhibition.MouseWheelZoomEnabled = true;
            this.mapPosterExhibition.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapPosterExhibition.Name = "mapPosterExhibition";
            this.mapPosterExhibition.NegativeMode = false;
            this.mapPosterExhibition.PolygonsEnabled = true;
            this.mapPosterExhibition.RetryLoadTile = 0;
            this.mapPosterExhibition.RoutesEnabled = true;
            this.mapPosterExhibition.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapPosterExhibition.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapPosterExhibition.ShowTileGridLines = false;
            this.mapPosterExhibition.Size = new System.Drawing.Size(815, 541);
            this.mapPosterExhibition.TabIndex = 19;
            this.mapPosterExhibition.Zoom = 0D;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PosterExhibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 822);
            this.Controls.Add(this.mapPosterExhibition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTime_PosterExhibition);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnExhibitionPeterburg);
            this.Controls.Add(this.btnExhibitionMoscow);
            this.Controls.Add(this.btnExhibitionYakutsk);
            this.Controls.Add(this.label4);
            this.Name = "PosterExhibition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Афиша художественных выставок";
            this.Load += new System.EventHandler(this.PosterExhibition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExhibitionYakutsk;
        private System.Windows.Forms.Button btnExhibitionMoscow;
        private System.Windows.Forms.Button btnExhibitionPeterburg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime_PosterExhibition;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private GMap.NET.WindowsForms.GMapControl mapPosterExhibition;
    }
}