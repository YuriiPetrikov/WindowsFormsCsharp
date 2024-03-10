using System.Globalization;

namespace Simple_Calculator
{

    public partial class Form1 : Form
    {
        private decimal number_1, number_2;
        char action = ' ';
        bool isEqual = false;
        bool isOperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnNumberClick(object sender, EventArgs e)
        {
            if (ResultLable.Text.Equals("0") || isEqual)
            {
                ResultLable.Text = "";
                isEqual = false;
            }
                
            ResultLable.Text += ((Button)sender).Text;
            isOperation = false;
        }

        private void BtnOperationClick(object sender, EventArgs e)
        {
            if (!isOperation)
            {
                if (action != ' ')
                    BtnEqualsClick(sender, e);

                number_1 = Convert.ToDecimal(ResultLable.Text);
                isEqual = true;
            }

            action = Convert.ToChar(((Button)sender).Text);
            isOperation = true;
        }

        private void BtnEqualsClick(object sender, EventArgs e)
        {
            number_2 = Convert.ToDecimal(ResultLable.Text);
            switch (action)
            {
                case '+':
                    ResultLable.Text = (number_1 + number_2).ToString("G29");
                    break;
                case '-':
                    ResultLable.Text = (number_1 - number_2).ToString("G29");
                    break;
                case '*':
                    ResultLable.Text = (number_1 * number_2).ToString("G29");
                    break;
                case '/':
                    ResultLable.Text = (number_1 / number_2).ToString("G29");
                    break;
                case '%':
                    ResultLable.Text = (number_1 * number_2 / 100).ToString("G29");
                    break;
            }
            action = ' ';
            isEqual = true;
        }

        private void BtnInversionClick(object sender, EventArgs e)
        {
            decimal number = Convert.ToDecimal(ResultLable.Text);
            ResultLable.Text = (number * (-1)).ToString();
        }

        private void BtnClearClick(object sender, EventArgs e)
        {
            ResultLable.Text = "0";
            number_1 = number_2 = 0;
            isEqual = false;
            isOperation = false;
            action = ' ';
        }

        private void BtnDotClick(object sender, EventArgs e)
        {
            if(!ResultLable.Text.Contains(','))
                ResultLable.Text += ",";
            if(isEqual == true)
                ResultLable.Text = "0,";

            isEqual = false;
        }
    }
}
