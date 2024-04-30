using System;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;

namespace WindowsFormsApp2
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.lblValue = new System.Windows.Forms.Label();
            this.trackBarBalanсe = new System.Windows.Forms.TrackBar();
            this.lblBalanсe = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_posision_time = new System.Windows.Forms.Label();
            this.lbl_full_time = new System.Windows.Forms.Label();
            this.track_list = new System.Windows.Forms.ListBox();
            this.chk_repeat = new System.Windows.Forms.CheckBox();
            this.chk_rundom = new System.Windows.Forms.CheckBox();
            this.lblLeftPercentBalance = new System.Windows.Forms.Label();
            this.lblRightPercentBalance = new System.Windows.Forms.Label();
            this.lblPercentValue = new System.Windows.Forms.Label();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBalanсe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBarVolume.LargeChange = 1;
            this.trackBarVolume.Location = new System.Drawing.Point(613, 37);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 189);
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(610, 229);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(48, 13);
            this.lblValue.TabIndex = 7;
            this.lblValue.Text = "Volume";
            // 
            // trackBarBalanсe
            // 
            this.trackBarBalanсe.LargeChange = 1;
            this.trackBarBalanсe.Location = new System.Drawing.Point(142, 28);
            this.trackBarBalanсe.Maximum = 100;
            this.trackBarBalanсe.Minimum = -100;
            this.trackBarBalanсe.Name = "trackBarBalanсe";
            this.trackBarBalanсe.Size = new System.Drawing.Size(375, 45);
            this.trackBarBalanсe.TabIndex = 8;
            this.trackBarBalanсe.TickFrequency = 10;
            this.trackBarBalanсe.Scroll += new System.EventHandler(this.trackBarBalanсe_Scroll);
            // 
            // lblBalanсe
            // 
            this.lblBalanсe.AutoSize = true;
            this.lblBalanсe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanсe.ForeColor = System.Drawing.Color.White;
            this.lblBalanсe.Location = new System.Drawing.Point(306, 12);
            this.lblBalanсe.Name = "lblBalanсe";
            this.lblBalanсe.Size = new System.Drawing.Size(53, 13);
            this.lblBalanсe.TabIndex = 9;
            this.lblBalanсe.Text = "Balanсe";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 349);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(635, 14);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // lbl_posision_time
            // 
            this.lbl_posision_time.AutoSize = true;
            this.lbl_posision_time.Font = new System.Drawing.Font("DigifaceWide", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_posision_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_posision_time.Location = new System.Drawing.Point(4, 12);
            this.lbl_posision_time.Name = "lbl_posision_time";
            this.lbl_posision_time.Size = new System.Drawing.Size(125, 39);
            this.lbl_posision_time.TabIndex = 11;
            this.lbl_posision_time.Text = "00:00";
            // 
            // lbl_full_time
            // 
            this.lbl_full_time.AutoSize = true;
            this.lbl_full_time.Font = new System.Drawing.Font("DigifaceWide", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_full_time.Location = new System.Drawing.Point(523, 12);
            this.lbl_full_time.Name = "lbl_full_time";
            this.lbl_full_time.Size = new System.Drawing.Size(125, 39);
            this.lbl_full_time.TabIndex = 12;
            this.lbl_full_time.Text = "00:00";
            // 
            // track_list
            // 
            this.track_list.AllowDrop = true;
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(232, 18);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(375, 208);
            this.track_list.TabIndex = 14;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            this.track_list.DragDrop += new System.Windows.Forms.DragEventHandler(this.track_list_DragDrop);
            this.track_list.DragEnter += new System.Windows.Forms.DragEventHandler(this.track_list_DragEnter);
            this.track_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.track_list_MouseDown);
            // 
            // chk_repeat
            // 
            this.chk_repeat.AutoSize = true;
            this.chk_repeat.Checked = true;
            this.chk_repeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_repeat.ForeColor = System.Drawing.Color.White;
            this.chk_repeat.Location = new System.Drawing.Point(153, 66);
            this.chk_repeat.Name = "chk_repeat";
            this.chk_repeat.Size = new System.Drawing.Size(63, 17);
            this.chk_repeat.TabIndex = 17;
            this.chk_repeat.Text = "Повтор";
            this.chk_repeat.UseVisualStyleBackColor = true;
            // 
            // chk_rundom
            // 
            this.chk_rundom.AutoSize = true;
            this.chk_rundom.ForeColor = System.Drawing.Color.White;
            this.chk_rundom.Location = new System.Drawing.Point(391, 66);
            this.chk_rundom.Name = "chk_rundom";
            this.chk_rundom.Size = new System.Drawing.Size(126, 17);
            this.chk_rundom.TabIndex = 18;
            this.chk_rundom.Text = "Случайный порядок";
            this.chk_rundom.UseVisualStyleBackColor = true;
            // 
            // lblLeftPercentBalance
            // 
            this.lblLeftPercentBalance.AutoSize = true;
            this.lblLeftPercentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLeftPercentBalance.ForeColor = System.Drawing.Color.White;
            this.lblLeftPercentBalance.Location = new System.Drawing.Point(147, 12);
            this.lblLeftPercentBalance.Name = "lblLeftPercentBalance";
            this.lblLeftPercentBalance.Size = new System.Drawing.Size(16, 13);
            this.lblLeftPercentBalance.TabIndex = 19;
            this.lblLeftPercentBalance.Text = "%";
            // 
            // lblRightPercentBalance
            // 
            this.lblRightPercentBalance.AutoSize = true;
            this.lblRightPercentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRightPercentBalance.ForeColor = System.Drawing.Color.White;
            this.lblRightPercentBalance.Location = new System.Drawing.Point(490, 12);
            this.lblRightPercentBalance.Name = "lblRightPercentBalance";
            this.lblRightPercentBalance.Size = new System.Drawing.Size(16, 13);
            this.lblRightPercentBalance.TabIndex = 20;
            this.lblRightPercentBalance.Text = "%";
            // 
            // lblPercentValue
            // 
            this.lblPercentValue.AutoSize = true;
            this.lblPercentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPercentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentValue.ForeColor = System.Drawing.Color.White;
            this.lblPercentValue.Location = new System.Drawing.Point(619, 18);
            this.lblPercentValue.Name = "lblPercentValue";
            this.lblPercentValue.Size = new System.Drawing.Size(16, 13);
            this.lblPercentValue.TabIndex = 21;
            this.lblPercentValue.Text = "%";
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Black;
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_preview.Location = new System.Drawing.Point(11, 381);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(87, 27);
            this.btn_preview.TabIndex = 16;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_next.Location = new System.Drawing.Point(104, 381);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(87, 27);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_open.Location = new System.Drawing.Point(476, 381);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(170, 27);
            this.btn_open.TabIndex = 13;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Black;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_pause.Location = new System.Drawing.Point(290, 381);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(87, 27);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Black;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_stop.Location = new System.Drawing.Point(383, 381);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(87, 27);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Black;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_play.Location = new System.Drawing.Point(197, 381);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(87, 27);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // pic_art
            // 
            this.pic_art.Image = global::WindowsFormsApp2.Properties.Resources.Music;
            this.pic_art.Location = new System.Drawing.Point(14, 18);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(208, 208);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 22;
            this.pic_art.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblPercentValue);
            this.panel1.Controls.Add(this.pic_art);
            this.panel1.Controls.Add(this.track_list);
            this.panel1.Controls.Add(this.trackBarVolume);
            this.panel1.Controls.Add(this.lblValue);
            this.panel1.Location = new System.Drawing.Point(-1, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 244);
            this.panel1.TabIndex = 23;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(658, 427);
            this.Controls.Add(this.lblRightPercentBalance);
            this.Controls.Add(this.lblLeftPercentBalance);
            this.Controls.Add(this.chk_rundom);
            this.Controls.Add(this.chk_repeat);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lbl_full_time);
            this.Controls.Add(this.lbl_posision_time);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblBalanсe);
            this.Controls.Add(this.trackBarBalanсe);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer_v1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBalanсe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private MediaPlayer player = new MediaPlayer();
        private DispatcherTimer timer = new DispatcherTimer();
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TrackBar trackBarBalanсe;
        private System.Windows.Forms.Label lblBalanсe;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_posision_time;
        private System.Windows.Forms.Label lbl_full_time;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.CheckBox chk_repeat;
        private System.Windows.Forms.CheckBox chk_rundom;
        private Button btn_play;
        private Button btn_stop;
        private Button btn_pause;
        private Button btn_open;
        private Button btn_next;
        private Button btn_preview;
        private Label lblLeftPercentBalance;
        private Label lblRightPercentBalance;
        private Label lblPercentValue;
        private PictureBox pic_art;
        private Panel panel1;
    }
}

