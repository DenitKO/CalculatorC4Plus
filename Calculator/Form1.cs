using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static double firstDigit = 0;
        public static double secondDigit = 0;
        public static double resalt = 0;
        public static char operation = '\0';

        public Form1()
        {
            InitializeComponent();
        }

        private void checkAddBtn(int CheckedDogit)
        {
            if (SolutionLine.Text.Equals("0"))
            {
                SolutionLine.Text = CheckedDogit.ToString();
            }
            else SolutionLine.Text += CheckedDogit.ToString();
        }

        private void checkAddSign(char CheckedSign)
        {
            if (SolutionLine.Text == "0")
            {

            }
            else if (operation.Equals('\0'))
            {
                operation = CheckedSign;
                SolutionLine.Text += CheckedSign;
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            checkAddBtn(1);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            checkAddBtn(2);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            checkAddBtn(3);
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            checkAddBtn(4);
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            checkAddBtn(5);
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            checkAddBtn(6);
        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            checkAddBtn(7);
        }

        private void btnAdd8_Click(object sender, EventArgs e)
        {
            checkAddBtn(8);
        }

        private void btnAdd9_Click(object sender, EventArgs e)
        {
            checkAddBtn(9);
        }

        private void btnAdd0_Click(object sender, EventArgs e)
        {
            if (SolutionLine.Text.Equals("0"))
            {
                
            }
            else SolutionLine.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SolutionLine.Text = "0";
            SolutionList.Text = "";
            operation = '\0';
        }

        private void btnAddPlus_Click(object sender, EventArgs e)
        {
            checkAddSign('+');
        }

        private void btnAddMinus_Click(object sender, EventArgs e)
        {
            checkAddSign('-');
        }

        private void btnAddMultiplier_Click(object sender, EventArgs e)
        {
            checkAddSign('*');
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            checkAddSign('/');
        }

        private void btnAddDot_Click(object sender, EventArgs e)
        {
            if (SolutionLine.Text.Equals("0"))
            {
                SolutionLine.Text += ",";
            }
            else if (operation == '\0' && !SolutionLine.Text.Contains(","))
            {
                SolutionLine.Text += ",";
            }
            else if (!operation.Equals('\0')  &&
                     !SolutionLine.Text.Substring(SolutionLine.Text.IndexOf(operation)).Contains(","))
            {
                SolutionLine.Text += ",";
            }
        }

        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {
            if (SolutionLine.Text.Equals("0"))
            {

            }
            else if (SolutionLine.Text.StartsWith("-"))
            {
                SolutionLine.Text = SolutionLine.Text.Substring(1);
            }
            else SolutionLine.Text = "-" + SolutionLine.Text;
        }

        //I didn 't finish it
        private void btnSolution_Click(object sender, EventArgs e)
        {
            if (SolutionLine.Text.Equals("0"))
            {

            } else if (!operation.Equals('\0') &&
                       !SolutionLine.Text.Substring(SolutionLine.Text.IndexOf(operation)).Contains(""))//fix here
            {
                firstDigit = Double.Parse(SolutionLine.Text.Substring(SolutionLine.Text.LastIndexOf(operation)));
                secondDigit = Double.Parse(SolutionLine.Text.Substring(SolutionLine.Text.IndexOf(operation)));
                resalt = firstDigit + secondDigit;
                SolutionList.Text = resalt.ToString();
            }
        }
    }

}