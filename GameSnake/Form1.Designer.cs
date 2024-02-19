namespace GameSnake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.map = new System.Windows.Forms.Panel();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.map.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.Controls.Add(this.lbGameOver);
            this.map.Location = new System.Drawing.Point(75, 88);
            this.map.Margin = new System.Windows.Forms.Padding(0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(402, 402);
            this.map.TabIndex = 1;
            // 
            // lbGameOver
            // 
            this.lbGameOver.Font = new System.Drawing.Font("Monotype Corsiva", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameOver.Location = new System.Drawing.Point(0, 132);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(400, 110);
            this.lbGameOver.TabIndex = 0;
            this.lbGameOver.Text = "Game Over";
            this.lbGameOver.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(67, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 418);
            this.panel1.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnNewGame
            // 
            this.btnNewGame.CausesValidation = false;
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewGame.Location = new System.Drawing.Point(318, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(87, 23);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            this.btnNewGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventKeyDown);
            this.btnNewGame.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EventPreviewKeyDown);
            // 
            // btnStartPause
            // 
            this.btnStartPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartPause.Location = new System.Drawing.Point(318, 44);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(87, 23);
            this.btnStartPause.TabIndex = 6;
            this.btnStartPause.TabStop = false;
            this.btnStartPause.Text = "Старт/Пауза";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            this.btnStartPause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventKeyDown);
            this.btnStartPause.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EventPreviewKeyDown);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.SystemColors.Control;
            this.btnMusic.CausesValidation = false;
            this.btnMusic.Image = global::GameSnake.Properties.Resources.Звук_Серый;
            this.btnMusic.Location = new System.Drawing.Point(422, 12);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(55, 55);
            this.btnMusic.TabIndex = 7;
            this.btnMusic.TabStop = false;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            this.btnMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventKeyDown);
            this.btnMusic.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EventPreviewKeyDown);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(544, 545);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.map);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Змейка\"";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventKeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EventPreviewKeyDown);
            this.map.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Label lbGameOver;
    }
}

