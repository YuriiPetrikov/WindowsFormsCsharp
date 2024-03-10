namespace Игра_в_15__пятнашки_
{
    partial class FormGame15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame15));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкийУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложныйУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкийУровеньToolStripMenuItem,
            this.среднийУровеньToolStripMenuItem,
            this.сложныйУровеньToolStripMenuItem});
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.начатьИгруToolStripMenuItem.Text = "Начать игру";
            // 
            // легкийУровеньToolStripMenuItem
            // 
            this.легкийУровеньToolStripMenuItem.Name = "легкийУровеньToolStripMenuItem";
            this.легкийУровеньToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.легкийУровеньToolStripMenuItem.Text = "Легкий уровень";
            this.легкийУровеньToolStripMenuItem.Click += new System.EventHandler(this.EasyLevelToolStripMenuItem_Click);
            // 
            // среднийУровеньToolStripMenuItem
            // 
            this.среднийУровеньToolStripMenuItem.Name = "среднийУровеньToolStripMenuItem";
            this.среднийУровеньToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.среднийУровеньToolStripMenuItem.Text = "Средний уровень";
            this.среднийУровеньToolStripMenuItem.Click += new System.EventHandler(this.AverageLevelToolStripMenuItem_Click);
            // 
            // сложныйУровеньToolStripMenuItem
            // 
            this.сложныйУровеньToolStripMenuItem.Name = "сложныйУровеньToolStripMenuItem";
            this.сложныйУровеньToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.сложныйУровеньToolStripMenuItem.Text = "Сложный уровень";
            this.сложныйУровеньToolStripMenuItem.Click += new System.EventHandler(this.DifficultLevelToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 740);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(935, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "0 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество ходов = ";
            // 
            // FormGame15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.FormGame15_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкийУровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийУровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложныйУровеньToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

