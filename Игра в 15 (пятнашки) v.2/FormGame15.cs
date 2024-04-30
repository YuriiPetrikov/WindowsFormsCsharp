using System;
using System.Windows.Forms;

namespace Игра_в_15__пятнашки_
{
    public partial class FormGame15 : Form
    {
        TableLayoutPanel GameField;
        RoundedButton[] button;
        GameModel gameModel;
        int size;
        int countStep;
      
        public FormGame15()
        {
            InitializeComponent();
            StartInitializeGame(size = 4);
        }

        private void EasyLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartLevel(size = 3);
        }

        private void AverageLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartLevel(size = 4);
        }
        private void DifficultLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartLevel(size = 5);
        }

        private void FormGame15_Load(object sender, EventArgs e)
        {

        }
        void StartGame(int size)
        {
            gameModel = new GameModel(size);

            GameField = new TableLayoutPanel
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Dock = DockStyle.Fill,
                ColumnCount = size,
                RowCount = size
            };

            for (int i = 0; i < size; i++)
            {
                GameField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                GameField.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            }

            button = new RoundedButton[size * size];

            for (int i = 0; i < button.Length; i++)
            {
                button[i] = new RoundedButton()
                {
                    Dock = DockStyle.Fill,
                    Font = new System.Drawing.Font("MV Boli", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Name = "button" + i,
                    Tag = i,
                    TabStop = false,
                    BackgroundImage = Properties.Resources.Кнопка_пятнашки,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    FlatStyle = FlatStyle.Popup,
                    Margin = new Padding(0),
                };

                button[i].Click += new EventHandler(ButtonClick);
                GameField.Controls.Add(button[i], i % size, i / size);
            }

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(GameField);
        }

        private void refresh()
        {
            for(int position = 0; position < size * size; position++)
            {
                button[position].Text = gameModel.GetNumber(position).ToString();
                button[position].Visible = (gameModel.GetNumber(position) == 0) ? false : true;
            }
        }

        private void StartLevel(int size)
        {
            label1.Text = (countStep = 0).ToString();
            StartGame(size);
            StartGameModel();
        }

        private void StartInitializeGame(int size)
        {
            StartGame(size);
            label1.Text = (countStep = 0).ToString();
            gameModel.Start();
            refresh();
            for (int i = 0; i < button.Length; i++)
                button[i].Enabled = false;
        }
        private void StartGameModel()
        {
            gameModel.Start();

            for (int i = 0; i < 100; i++)
                gameModel.ShiftRandom();
            refresh();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((Button)sender).Tag);
            gameModel.Shift(position);
            label1.Text = (++countStep).ToString();
            refresh();

            if(gameModel.CheckGame())
            {
                var res = MessageBox.Show("Вы прошли игру за " + countStep + " шагов", "Победа!!!");
                
                if (res == DialogResult.OK)
                {
                    StartInitializeGame(size = 4);
                }
            }
        }
    }
}
