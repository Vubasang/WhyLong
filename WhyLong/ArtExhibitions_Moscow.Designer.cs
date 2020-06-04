namespace WhyLong
{
    partial class ArtExhibitions_Moscow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mapExhibition = new GMap.NET.WindowsForms.GMapControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTime_Exhibition = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mapPerformances = new GMap.NET.WindowsForms.GMapControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTime_Performances = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mapConcert = new GMap.NET.WindowsForms.GMapControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime_Concert = new System.Windows.Forms.Label();
            this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mapMasterClass = new GMap.NET.WindowsForms.GMapControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTime_MasterClass = new System.Windows.Forms.Label();
            this.monthCalendar4 = new System.Windows.Forms.MonthCalendar();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.mapContest = new GMap.NET.WindowsForms.GMapControl();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTime_Contest = new System.Windows.Forms.Label();
            this.monthCalendar5 = new System.Windows.Forms.MonthCalendar();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mapExhibition);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbTime_Exhibition);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выставки ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mapExhibition
            // 
            this.mapExhibition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapExhibition.Bearing = 0F;
            this.mapExhibition.CanDragMap = true;
            this.mapExhibition.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapExhibition.GrayScaleMode = false;
            this.mapExhibition.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapExhibition.LevelsKeepInMemory = 5;
            this.mapExhibition.Location = new System.Drawing.Point(273, 84);
            this.mapExhibition.MarkersEnabled = true;
            this.mapExhibition.MaxZoom = 2;
            this.mapExhibition.MinZoom = 2;
            this.mapExhibition.MouseWheelZoomEnabled = true;
            this.mapExhibition.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapExhibition.Name = "mapExhibition";
            this.mapExhibition.NegativeMode = false;
            this.mapExhibition.PolygonsEnabled = true;
            this.mapExhibition.RetryLoadTile = 0;
            this.mapExhibition.RoutesEnabled = true;
            this.mapExhibition.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapExhibition.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapExhibition.ShowTileGridLines = false;
            this.mapExhibition.Size = new System.Drawing.Size(716, 454);
            this.mapExhibition.TabIndex = 18;
            this.mapExhibition.Zoom = 0D;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Художественные выставки в Москве";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точная дата";
            // 
            // lbTime_Exhibition
            // 
            this.lbTime_Exhibition.AutoSize = true;
            this.lbTime_Exhibition.Enabled = false;
            this.lbTime_Exhibition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime_Exhibition.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTime_Exhibition.Location = new System.Drawing.Point(65, 251);
            this.lbTime_Exhibition.Name = "lbTime_Exhibition";
            this.lbTime_Exhibition.Size = new System.Drawing.Size(141, 36);
            this.lbTime_Exhibition.TabIndex = 1;
            this.lbTime_Exhibition.Text = "00:00:00";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(38, 84);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mapPerformances);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbTime_Performances);
            this.tabPage2.Controls.Add(this.monthCalendar2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1028, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спектакли";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mapPerformances
            // 
            this.mapPerformances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPerformances.Bearing = 0F;
            this.mapPerformances.CanDragMap = true;
            this.mapPerformances.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapPerformances.GrayScaleMode = false;
            this.mapPerformances.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapPerformances.LevelsKeepInMemory = 5;
            this.mapPerformances.Location = new System.Drawing.Point(273, 84);
            this.mapPerformances.MarkersEnabled = true;
            this.mapPerformances.MaxZoom = 2;
            this.mapPerformances.MinZoom = 2;
            this.mapPerformances.MouseWheelZoomEnabled = true;
            this.mapPerformances.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapPerformances.Name = "mapPerformances";
            this.mapPerformances.NegativeMode = false;
            this.mapPerformances.PolygonsEnabled = true;
            this.mapPerformances.RetryLoadTile = 0;
            this.mapPerformances.RoutesEnabled = true;
            this.mapPerformances.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapPerformances.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapPerformances.ShowTileGridLines = false;
            this.mapPerformances.Size = new System.Drawing.Size(716, 454);
            this.mapPerformances.TabIndex = 19;
            this.mapPerformances.Zoom = 0D;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(18, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Спектакли в Москве";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(33, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Точная дата";
            // 
            // lbTime_Performances
            // 
            this.lbTime_Performances.AutoSize = true;
            this.lbTime_Performances.Enabled = false;
            this.lbTime_Performances.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime_Performances.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTime_Performances.Location = new System.Drawing.Point(65, 251);
            this.lbTime_Performances.Name = "lbTime_Performances";
            this.lbTime_Performances.Size = new System.Drawing.Size(141, 36);
            this.lbTime_Performances.TabIndex = 4;
            this.lbTime_Performances.Text = "00:00:00";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(38, 84);
            this.monthCalendar2.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mapConcert);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lbTime_Concert);
            this.tabPage3.Controls.Add(this.monthCalendar3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1028, 608);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Концерты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mapConcert
            // 
            this.mapConcert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapConcert.Bearing = 0F;
            this.mapConcert.CanDragMap = true;
            this.mapConcert.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapConcert.GrayScaleMode = false;
            this.mapConcert.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapConcert.LevelsKeepInMemory = 5;
            this.mapConcert.Location = new System.Drawing.Point(273, 84);
            this.mapConcert.MarkersEnabled = true;
            this.mapConcert.MaxZoom = 2;
            this.mapConcert.MinZoom = 2;
            this.mapConcert.MouseWheelZoomEnabled = true;
            this.mapConcert.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapConcert.Name = "mapConcert";
            this.mapConcert.NegativeMode = false;
            this.mapConcert.PolygonsEnabled = true;
            this.mapConcert.RetryLoadTile = 0;
            this.mapConcert.RoutesEnabled = true;
            this.mapConcert.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapConcert.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapConcert.ShowTileGridLines = false;
            this.mapConcert.Size = new System.Drawing.Size(716, 454);
            this.mapConcert.TabIndex = 20;
            this.mapConcert.Zoom = 0D;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(17, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Концерты в Москве";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Точная дата";
            // 
            // lbTime_Concert
            // 
            this.lbTime_Concert.AutoSize = true;
            this.lbTime_Concert.Enabled = false;
            this.lbTime_Concert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime_Concert.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTime_Concert.Location = new System.Drawing.Point(65, 251);
            this.lbTime_Concert.Name = "lbTime_Concert";
            this.lbTime_Concert.Size = new System.Drawing.Size(141, 36);
            this.lbTime_Concert.TabIndex = 7;
            this.lbTime_Concert.Text = "00:00:00";
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.Location = new System.Drawing.Point(38, 84);
            this.monthCalendar3.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.mapMasterClass);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.lbTime_MasterClass);
            this.tabPage4.Controls.Add(this.monthCalendar4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1028, 608);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Мастер-классы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // mapMasterClass
            // 
            this.mapMasterClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapMasterClass.Bearing = 0F;
            this.mapMasterClass.CanDragMap = true;
            this.mapMasterClass.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapMasterClass.GrayScaleMode = false;
            this.mapMasterClass.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapMasterClass.LevelsKeepInMemory = 5;
            this.mapMasterClass.Location = new System.Drawing.Point(273, 84);
            this.mapMasterClass.MarkersEnabled = true;
            this.mapMasterClass.MaxZoom = 2;
            this.mapMasterClass.MinZoom = 2;
            this.mapMasterClass.MouseWheelZoomEnabled = true;
            this.mapMasterClass.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapMasterClass.Name = "mapMasterClass";
            this.mapMasterClass.NegativeMode = false;
            this.mapMasterClass.PolygonsEnabled = true;
            this.mapMasterClass.RetryLoadTile = 0;
            this.mapMasterClass.RoutesEnabled = true;
            this.mapMasterClass.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapMasterClass.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapMasterClass.ShowTileGridLines = false;
            this.mapMasterClass.Size = new System.Drawing.Size(716, 454);
            this.mapMasterClass.TabIndex = 20;
            this.mapMasterClass.Zoom = 0D;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(18, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(478, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Семинары и мастер-классы в Москве";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(33, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Точная дата";
            // 
            // lbTime_MasterClass
            // 
            this.lbTime_MasterClass.AutoSize = true;
            this.lbTime_MasterClass.Enabled = false;
            this.lbTime_MasterClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime_MasterClass.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTime_MasterClass.Location = new System.Drawing.Point(65, 251);
            this.lbTime_MasterClass.Name = "lbTime_MasterClass";
            this.lbTime_MasterClass.Size = new System.Drawing.Size(141, 36);
            this.lbTime_MasterClass.TabIndex = 7;
            this.lbTime_MasterClass.Text = "00:00:00";
            // 
            // monthCalendar4
            // 
            this.monthCalendar4.Location = new System.Drawing.Point(38, 84);
            this.monthCalendar4.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar4.Name = "monthCalendar4";
            this.monthCalendar4.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.mapContest);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.lbTime_Contest);
            this.tabPage5.Controls.Add(this.monthCalendar5);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1028, 608);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конкурсы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // mapContest
            // 
            this.mapContest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapContest.Bearing = 0F;
            this.mapContest.CanDragMap = true;
            this.mapContest.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapContest.GrayScaleMode = false;
            this.mapContest.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapContest.LevelsKeepInMemory = 5;
            this.mapContest.Location = new System.Drawing.Point(273, 84);
            this.mapContest.MarkersEnabled = true;
            this.mapContest.MaxZoom = 2;
            this.mapContest.MinZoom = 2;
            this.mapContest.MouseWheelZoomEnabled = true;
            this.mapContest.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapContest.Name = "mapContest";
            this.mapContest.NegativeMode = false;
            this.mapContest.PolygonsEnabled = true;
            this.mapContest.RetryLoadTile = 0;
            this.mapContest.RoutesEnabled = true;
            this.mapContest.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapContest.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapContest.ShowTileGridLines = false;
            this.mapContest.Size = new System.Drawing.Size(716, 454);
            this.mapContest.TabIndex = 20;
            this.mapContest.Zoom = 0D;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(18, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Конкурсы в Москве";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(33, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Точная дата";
            // 
            // lbTime_Contest
            // 
            this.lbTime_Contest.AutoSize = true;
            this.lbTime_Contest.Enabled = false;
            this.lbTime_Contest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime_Contest.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTime_Contest.Location = new System.Drawing.Point(65, 251);
            this.lbTime_Contest.Name = "lbTime_Contest";
            this.lbTime_Contest.Size = new System.Drawing.Size(141, 36);
            this.lbTime_Contest.TabIndex = 7;
            this.lbTime_Contest.Text = "00:00:00";
            // 
            // monthCalendar5
            // 
            this.monthCalendar5.Location = new System.Drawing.Point(38, 84);
            this.monthCalendar5.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar5.Name = "monthCalendar5";
            this.monthCalendar5.TabIndex = 6;
            // 
            // ArtExhibitions_Moscow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 677);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ArtExhibitions_Moscow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Афиша культурных событий в Москве";
            this.Load += new System.EventHandler(this.ArtExhibitions_Moscow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime_Exhibition;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTime_Performances;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime_Concert;
        private System.Windows.Forms.MonthCalendar monthCalendar3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTime_MasterClass;
        private System.Windows.Forms.MonthCalendar monthCalendar4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar monthCalendar5;
        private System.Windows.Forms.Label lbTime_Contest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private GMap.NET.WindowsForms.GMapControl mapExhibition;
        private GMap.NET.WindowsForms.GMapControl mapPerformances;
        private GMap.NET.WindowsForms.GMapControl mapConcert;
        private GMap.NET.WindowsForms.GMapControl mapMasterClass;
        private GMap.NET.WindowsForms.GMapControl mapContest;
    }
}