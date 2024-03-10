using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        readonly TableLayoutPanel GameField;
        readonly Button[] button;
        readonly int size = 3;
        int step;
        readonly TicTacToeModel ticTacToe;

        private void MessageShowVictory(string winner)
        {
            MessageBox.Show(
                        $"Победил игрок {winner}",
                        "Победа!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
        }
        private void MessageShowDraw()
        {
            MessageBox.Show(
                            "Ничья",
                            "Ничья",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
        }
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            ticTacToe = new TicTacToeModel(size);
            GameField = new TableLayoutPanel
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Dock = DockStyle.Fill,
                ColumnCount = size,
                RowCount = size
            };

            for (int i = 0; i < size; i++)
            {
                GameField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                GameField.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            }

            button = new Button[size * size];
            for (int i = 0; i < button.Length; i++)
            {
                button[i] = new Button
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("MV Boli", 45F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Name = "button" + i,
                    Tag = i,
                    TabStop = false
                };
                button[i].Click += new EventHandler(btn_Click);
                GameField.Controls.Add(button[i], i % size, i / size);
            }

            radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            panel1.Controls.Add(GameField);

            InitialNewGame();
        }
        void InitialNewGame()
        {
            step = 0;
            label1.Text = "Ходит игрок X";
            for(int i = 0; i < size * size; i++)
            {
                button[i].Text = "";
                button[i].Enabled = true;
            }
           
            ticTacToe.NewInitianal();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            InitialNewGame();
        }
        private async void btn_Click(object sender, EventArgs e)
        {
            string playerNextStep;
            Button btn = sender as Button;
            int position = Convert.ToInt32(btn.Tag);
            
            if (radioButton1.Checked)
            {
                //Два игрока
                if (step++ % 2 == 0)
                {
                    button[position].Text = "X";
                    ticTacToe[position] = 1;
                    playerNextStep = "игрок О";
                }
                else
                {
                    button[position].Text = "O";
                    ticTacToe[position] = 0;
                    playerNextStep = "игрок X";
                }

                button[position].Enabled = false;

                if (ticTacToe.IsCheck())
                {
                    MessageShowVictory(button[position].Text);
                    InitialNewGame();
                }

                if (ticTacToe.IsStandoff())
                {
                    MessageShowDraw();
                    InitialNewGame();
                }

                label1.Text = $"Ходит {playerNextStep}";
            }
            else
            {
                //Игра с компьютером
                button[position].Text = "X";
                ticTacToe[position] = 1;
                playerNextStep = "Компьютер";
                button[position].Enabled = false;
       
                if (ticTacToe.IsCheck())
                {
                    MessageShowVictory(button[position].Text.Equals("X") ? button[position].Text : "Компьютер");
                    InitialNewGame();
                }
                else
                if (ticTacToe.IsStandoff())
                {
                    MessageShowDraw();
                    InitialNewGame();
                }
                else
                {
                    label1.Text = $"Ходит {playerNextStep}";
                    await Task.Delay(500);
                    
                    //position = ticTacToe.RundomPositionComputer(ticTacToe.EasyStrategyAttackOrProtection);
                    //position = ticTacToe.RundomPositionComputer(ticTacToe.AverageStrategyAttackOrProtection);
                    //position = ticTacToe.RundomPositionComputer(ticTacToe.DifficultStrategyAttackOrProtection);
                    position = ticTacToe.RundomPositionComputer(ticTacToe.SuperDifficultStrategyAttackOrProtection);
                    
                    button[position].Text = "O";
                    ticTacToe[position] = 0;
                    playerNextStep = "игрок X";
                    
                    button[position].Enabled = false;

                    if (ticTacToe.IsCheck())
                    {
                        MessageShowVictory(button[position].Text.Equals("X") ? button[position].Text : "Компьютер");
                        InitialNewGame();
                    }
                    if (ticTacToe.IsStandoff())
                    {
                        MessageShowDraw();
                        InitialNewGame();
                    }
                    label1.Text = $"Ходит {playerNextStep}";
                }
            }
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
           InitialNewGame();
        }
    }
}
