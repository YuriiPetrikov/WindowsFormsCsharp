using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MusicPlayer : Form
    {
        readonly List<string> paths;
        readonly Random rnd;
        int position;
        int numberPositionDelete;
       
        public MusicPlayer()
        {
            InitializeComponent();
           
            paths = new List<string>();
            player.MediaOpened += new EventHandler(player_MediaOpened);
            player.MediaEnded  += new EventHandler(player_MediaEnded);

            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_tick;
            
            rnd = new Random();
            lblLeftPercentBalance.Text = (-trackBarBalanсe.Value).ToString() + "%";
            lblRightPercentBalance.Text = (+trackBarBalanсe.Value).ToString() + "%";
            lblPercentValue.Text = trackBarVolume.Value.ToString() + "%";

            // создаем элементы контекстного меню
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Добавить файл");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить файл");
            ToolStripMenuItem clearMenuItem = new ToolStripMenuItem("Очистить плейлист");
            // добавляем элементы в меню
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, deleteMenuItem, clearMenuItem});
            // ассоциируем контекстное меню с текстовым полем
            track_list.ContextMenuStrip = contextMenuStrip1;
            // устанавливаем обработчики событий для меню
            addMenuItem.Click    += addMenuItem_Click;
            deleteMenuItem.Click += deleteMenuItem_Click;
            clearMenuItem.Click  += clearMenuItem_Click;
        }

        private void OpenFile(List<string> paths, ListBox track_list)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Выберите файлы для воспроизведения";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var vr in openFileDialog.FileNames)
                {
                    paths.Add(vr);
                    var audioFile = TagLib.File.Create(vr);
                    track_list.Items.Add($"{String.Join(", ", audioFile.Tag.Performers)} - {audioFile.Tag.Title}");
                }
            }
        }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            track_list.Items.Clear();
            paths.Clear();
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex != numberPositionDelete)
            {
                track_list.Items.RemoveAt(numberPositionDelete);
                paths.RemoveAt(numberPositionDelete);
            }
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
           OpenFile(paths, track_list);
        }

        private void player_MediaEnded(object sender, EventArgs e)
        {
            if(track_list.Items.Count != 0)
            {
                if (chk_rundom.Checked && track_list.Items.Count > 1)
                {
                    while (track_list.SelectedIndex == (position = rnd.Next(0, track_list.Items.Count - 1))) ;
                    track_list.SelectedIndex = position;
                    player.Open(new Uri(paths[track_list.SelectedIndex], UriKind.Relative));
                    player.Play();
                    timer.Start();
                }
                else
                {
                    if (track_list.SelectedIndex < track_list.Items.Count - 1)
                    {
                        track_list.SelectedIndex += 1;
                        player.Open(new Uri(paths[track_list.SelectedIndex], UriKind.Relative));
                        player.Play();
                        timer.Start();
                    }
                    else
                    {
                        if (chk_repeat.Checked)
                        {
                            track_list.SelectedIndex = 0;
                            player.Open(new Uri(paths[track_list.SelectedIndex], UriKind.Relative));
                            player.Play();
                            timer.Start();
                        }
                    }
                }
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            lbl_posision_time.Text = player.Position.ToString(@"mm\:ss");
            progressBar1.Value = (int)player.Position.TotalSeconds;
        }

        private void player_MediaOpened(object sender, EventArgs e)
        {
            lbl_full_time.Text = player.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
            progressBar1.Maximum = (int)player.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if(track_list.Items.Count != 0)
            {
                //track_list.SelectedIndex = 0;
                player.Play();
                timer.Start();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Stop();
            timer.Stop();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Pause();
            timer.Stop();
        }
    
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.Volume = trackBarVolume.Value * 0.01;
            lblPercentValue.Text = trackBarVolume.Value.ToString() + "%";
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFile(paths, track_list);
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                player.Open(new Uri(paths[track_list.SelectedIndex], UriKind.Relative));
                player.Play();
                timer.Start();
            }
            else
            {
                track_list.SelectedIndex = 0;
                player.Open(new Uri(paths[0], UriKind.Relative));
                player.Play();
                timer.Start();
            }

            try 
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch 
            {
               pic_art.Image = Properties.Resources.Music;
            }  
        }

        private void trackBarBalanсe_Scroll(object sender, EventArgs e)
        {
            player.Balance = trackBarBalanсe.Value * 0.01;
            lblLeftPercentBalance.Text = (-trackBarBalanсe.Value).ToString() + "%";
            lblRightPercentBalance.Text = (+trackBarBalanсe.Value).ToString() + "%";

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (chk_rundom.Checked && track_list.Items.Count > 1)
            {
                while (track_list.SelectedIndex == (position = rnd.Next(0, track_list.Items.Count - 1)));
                track_list.SelectedIndex = position;
            }
            else if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex += 1;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (chk_rundom.Checked && track_list.Items.Count > 1)
            {
                while (track_list.SelectedIndex == (position = rnd.Next(0, track_list.Items.Count - 1))) ;
                track_list.SelectedIndex = position;
            }
            else if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex -= 1;
            }
        }

        private void progressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            double currentvalue = (double)progressBar1.Maximum / (double)progressBar1.Width * (double)e.X;
            player.Pause();
            progressBar1.Value = (int)currentvalue;
            player.Position = TimeSpan.FromSeconds(progressBar1.Value);
            player.Play();
        }

        private void track_list_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int y = e.Y / track_list.ItemHeight;

                if (y < track_list.Items.Count)
                {
                    numberPositionDelete = track_list.TopIndex + y;
                }
            }
        }

        private void track_list_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void track_list_DragDrop(object sender, DragEventArgs e)
        {
            List<string> paths_1 = new List<string>();
            foreach (string obj in (string[])e.Data.GetData(DataFormats.FileDrop))
                if (Directory.Exists(obj))
                {
                    paths_1.AddRange(Directory.GetFiles(obj, "*.mp3", SearchOption.AllDirectories));
                }
                else
                {
                    if(obj.ToLower().EndsWith(".mp3") || obj.ToLower().EndsWith(".wma")
                        || obj.ToLower().EndsWith(".wav") || obj.ToLower().EndsWith(".flac"))
                        paths_1.Add(obj);    
                }

            foreach (var vr in paths_1)
            {
                var audioFile = TagLib.File.Create(vr);
                track_list.Items.Add($"{String.Join(", ", audioFile.Tag.Performers)} - {audioFile.Tag.Title}");
                paths.Add(vr);
            }
        }
    }
}
