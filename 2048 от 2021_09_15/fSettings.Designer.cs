
namespace ип_2048
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lRows = new System.Windows.Forms.Label();
            this.lColumns = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bRowsUp = new System.Windows.Forms.Button();
            this.bRowsDown = new System.Windows.Forms.Button();
            this.bColUp = new System.Windows.Forms.Button();
            this.bColDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Колличество строк от 1 до 8 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Колличество столбцов от 3 до 8 :";
            // 
            // lRows
            // 
            this.lRows.AutoSize = true;
            this.lRows.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRows.Location = new System.Drawing.Point(257, 50);
            this.lRows.Name = "lRows";
            this.lRows.Size = new System.Drawing.Size(17, 19);
            this.lRows.TabIndex = 2;
            this.lRows.Text = "4";
            this.lRows.Click += new System.EventHandler(this.label3_Click);
            // 
            // lColumns
            // 
            this.lColumns.AutoSize = true;
            this.lColumns.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lColumns.Location = new System.Drawing.Point(257, 126);
            this.lColumns.Name = "lColumns";
            this.lColumns.Size = new System.Drawing.Size(17, 19);
            this.lColumns.TabIndex = 3;
            this.lColumns.Text = "4";
            // 
            // bOK
            // 
            this.bOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOK.Location = new System.Drawing.Point(12, 174);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(93, 33);
            this.bOK.TabIndex = 4;
            this.bOK.Text = "Принять";
            this.bOK.UseVisualStyleBackColor = false;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(111, 174);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(95, 33);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // bRowsUp
            // 
            this.bRowsUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bRowsUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRowsUp.Image = ((System.Drawing.Image)(resources.GetObject("bRowsUp.Image")));
            this.bRowsUp.Location = new System.Drawing.Point(280, 27);
            this.bRowsUp.Name = "bRowsUp";
            this.bRowsUp.Size = new System.Drawing.Size(39, 26);
            this.bRowsUp.TabIndex = 6;
            this.bRowsUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bRowsUp.UseVisualStyleBackColor = false;
            this.bRowsUp.Click += new System.EventHandler(this.bRowsUp_Click);
            // 
            // bRowsDown
            // 
            this.bRowsDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bRowsDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRowsDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bRowsDown.Image = ((System.Drawing.Image)(resources.GetObject("bRowsDown.Image")));
            this.bRowsDown.Location = new System.Drawing.Point(280, 60);
            this.bRowsDown.Name = "bRowsDown";
            this.bRowsDown.Size = new System.Drawing.Size(39, 26);
            this.bRowsDown.TabIndex = 7;
            this.bRowsDown.UseVisualStyleBackColor = false;
            this.bRowsDown.Click += new System.EventHandler(this.bRowsDown_Click);
            // 
            // bColUp
            // 
            this.bColUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bColUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bColUp.Image = ((System.Drawing.Image)(resources.GetObject("bColUp.Image")));
            this.bColUp.Location = new System.Drawing.Point(280, 108);
            this.bColUp.Name = "bColUp";
            this.bColUp.Size = new System.Drawing.Size(39, 26);
            this.bColUp.TabIndex = 8;
            this.bColUp.UseVisualStyleBackColor = false;
            this.bColUp.Click += new System.EventHandler(this.bColUp_Click);
            // 
            // bColDown
            // 
            this.bColDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bColDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bColDown.Image = ((System.Drawing.Image)(resources.GetObject("bColDown.Image")));
            this.bColDown.Location = new System.Drawing.Point(280, 137);
            this.bColDown.Name = "bColDown";
            this.bColDown.Size = new System.Drawing.Size(39, 26);
            this.bColDown.TabIndex = 9;
            this.bColDown.UseVisualStyleBackColor = false;
            this.bColDown.Click += new System.EventHandler(this.bColDown_Click);
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 219);
            this.Controls.Add(this.bColDown);
            this.Controls.Add(this.bColUp);
            this.Controls.Add(this.bRowsDown);
            this.Controls.Add(this.bRowsUp);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lColumns);
            this.Controls.Add(this.lRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label lRows;
        public System.Windows.Forms.Label lColumns;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bRowsUp;
        private System.Windows.Forms.Button bRowsDown;
        private System.Windows.Forms.Button bColUp;
        private System.Windows.Forms.Button bColDown;
    }
}