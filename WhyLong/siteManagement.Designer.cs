﻿namespace WhyLong
{
    partial class siteManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьХудожниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКартинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСотрудниковToolStripMenuItem,
            this.списокПользователейToolStripMenuItem,
            this.добавитьХудожниковToolStripMenuItem,
            this.добавитьКартинToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            this.списокСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.СписокСотрудниковToolStripMenuItem_Click);
            // 
            // списокПользователейToolStripMenuItem
            // 
            this.списокПользователейToolStripMenuItem.Name = "списокПользователейToolStripMenuItem";
            this.списокПользователейToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.списокПользователейToolStripMenuItem.Text = "Список пользователей";
            this.списокПользователейToolStripMenuItem.Click += new System.EventHandler(this.СписокПользователейToolStripMenuItem_Click);
            // 
            // добавитьХудожниковToolStripMenuItem
            // 
            this.добавитьХудожниковToolStripMenuItem.Name = "добавитьХудожниковToolStripMenuItem";
            this.добавитьХудожниковToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.добавитьХудожниковToolStripMenuItem.Text = "Добавить художников";
            this.добавитьХудожниковToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьХудожниковToolStripMenuItem_Click);
            // 
            // добавитьКартинToolStripMenuItem
            // 
            this.добавитьКартинToolStripMenuItem.Name = "добавитьКартинToolStripMenuItem";
            this.добавитьКартинToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.добавитьКартинToolStripMenuItem.Text = "Добавить картинку";
            this.добавитьКартинToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьКартинToolStripMenuItem_Click);
            // 
            // siteManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 527);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "siteManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление сайтом";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьХудожниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКартинToolStripMenuItem;
    }
}