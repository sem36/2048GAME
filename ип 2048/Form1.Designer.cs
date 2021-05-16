
using System;

namespace ип_2048
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mmGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mmNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mmLine = new System.Windows.Forms.ToolStripSeparator();
            this.mmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pPole = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ISchet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IRecord = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmGame,
            this.mmAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(529, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // mmGame
            // 
            this.mmGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmSettings,
            this.mmNewGame,
            this.mmLine,
            this.mmExit});
            this.mmGame.Name = "mmGame";
            this.mmGame.Size = new System.Drawing.Size(46, 20);
            this.mmGame.Text = "Игра";
            this.mmGame.Click += new System.EventHandler(this.mmGame_Click);
            // 
            // mmSettings
            // 
            this.mmSettings.Name = "mmSettings";
            this.mmSettings.Size = new System.Drawing.Size(138, 22);
            this.mmSettings.Text = "Настройки";
            this.mmSettings.Click += new System.EventHandler(this.mmSettings_Click);
            // 
            // mmNewGame
            // 
            this.mmNewGame.Name = "mmNewGame";
            this.mmNewGame.Size = new System.Drawing.Size(138, 22);
            this.mmNewGame.Text = "Новая Игра";
            this.mmNewGame.Click += new System.EventHandler(this.mmNewGame_Click);
            // 
            // mmLine
            // 
            this.mmLine.Name = "mmLine";
            this.mmLine.Size = new System.Drawing.Size(135, 6);
            // 
            // mmExit
            // 
            this.mmExit.Name = "mmExit";
            this.mmExit.Size = new System.Drawing.Size(138, 22);
            this.mmExit.Text = "Выход";
            this.mmExit.Click += new System.EventHandler(this.mmExit_Click);
            // 
            // mmAbout
            // 
            this.mmAbout.Name = "mmAbout";
            this.mmAbout.Size = new System.Drawing.Size(94, 20);
            this.mmAbout.Text = "О программе";
            this.mmAbout.Click += new System.EventHandler(this.mmAbout_Click);
            // 
            // pPole
            // 
            this.pPole.Location = new System.Drawing.Point(12, 27);
            this.pPole.Name = "pPole";
            this.pPole.Size = new System.Drawing.Size(505, 338);
            this.pPole.TabIndex = 1;
            this.pPole.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Счёт";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ISchet
            // 
            this.ISchet.AutoSize = true;
            this.ISchet.Location = new System.Drawing.Point(13, 417);
            this.ISchet.Name = "ISchet";
            this.ISchet.Size = new System.Drawing.Size(13, 13);
            this.ISchet.TabIndex = 3;
            this.ISchet.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Рекорд";
            // 
            // IRecord
            // 
            this.IRecord.AutoSize = true;
            this.IRecord.Location = new System.Drawing.Point(96, 417);
            this.IRecord.Name = "IRecord";
            this.IRecord.Size = new System.Drawing.Size(13, 13);
            this.IRecord.TabIndex = 5;
            this.IRecord.Text = "0";
            this.IRecord.Click += new System.EventHandler(this.label4_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 564);
            this.Controls.Add(this.IRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISchet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pPole);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmGame;
        private System.Windows.Forms.ToolStripMenuItem mmSettings;
        private System.Windows.Forms.ToolStripMenuItem mmNewGame;
        private System.Windows.Forms.ToolStripSeparator mmLine;
        private System.Windows.Forms.ToolStripMenuItem mmExit;
        private System.Windows.Forms.ToolStripMenuItem mmAbout;
        private System.Windows.Forms.Panel pPole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ISchet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IRecord;
    }
}

