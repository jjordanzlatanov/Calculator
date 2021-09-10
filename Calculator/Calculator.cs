using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        decimal Answer, Completer;
        char Operation = '.';
        bool NewOperation = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Digit_Click(object sender, EventArgs e)
        {
            Button Current_Button = (Button)sender;
            if (NewOperation)
            {
                Answer = Convert.ToDecimal(Text_Box.Text);
                Text_Box.Text = "";
                NewOperation = false;
            }
            Text_Box.AppendText(Current_Button.Text);
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            NewOperation = true;
            Button Current_Button = (Button)sender;
            if (Operation != '.')
            {
                Completer = Convert.ToDecimal(Text_Box.Text);
                switch (Operation)
                {
                    case '+':
                        Answer += Completer;
                        break;
                    case '-':
                        Answer -= Completer;
                        break;
                    case '*':
                        Answer *= Completer;
                        break;
                    case '/':
                        Answer /= Completer;
                        break;
                }
                Text_Box.Text = Convert.ToString(Answer);
            }
            Operation = Current_Button.Text[0];
        }

        private void Clear_Text(object sender, EventArgs e)
        {
            Text_Box.Text = "";
            NewOperation = false;
            Operation = '.';
        }

        private void Pressed_Digit(object sender, KeyPressEventArgs e)
        {
            if (NewOperation)
            {
                Answer = Convert.ToDecimal(Text_Box.Text);
                Text_Box.Text = "";
                NewOperation = false;
            }
            Text_Box.AppendText(Convert.ToString(e.KeyChar));
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if(Operation != '.')
            {
                Completer = Convert.ToDecimal(Text_Box.Text);
                switch (Operation)
                {
                    case '+':
                        Answer += Completer;
                        break;
                    case '-':
                        Answer -= Completer;
                        break;
                    case '*':
                        Answer *= Completer;
                        break;
                    case '/':
                        Answer /= Completer;
                        break;
                }
                Text_Box.Text = Convert.ToString(Answer);
            }
            Operation = '.';
            NewOperation = true;
        }
    }
}
