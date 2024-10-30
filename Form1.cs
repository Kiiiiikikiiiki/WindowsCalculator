using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullyWorkingCalculator
{
    public partial class Form1 : Form
    {
        /* Global Obj Calc */
        Calc calc;

        /* Global bool to know if we formated before */
        bool prevFormat = false;

        /* Global Previous txtInput Box Text value */
        string prevTxtInput = "";

        /**************/
        /* Functions */
        /**************/

        /// <summary>
        /// Send info to the Calc object about what is the current inputs
        /// </summary>
        public void GetInput()
        {
            if (calc.first_input != 0)
            {
                calc.input = Convert.ToDouble(txtInput.Text);
            }
            else
            {
                calc.first_input = Convert.ToDouble(txtInput.Text);
            }
        }

        /// <summary>
        /// Return the focus after a button is clicked to the txtInputBox
        /// </summary>
        public void GetFocus()
        {
            txtInput.Focus();
            txtInput.SelectAll();
        }


        public void ReplaceCursor()
        {
            txtInput.Focus();
            txtInput.SelectionStart = txtInput.Text.Length;
            txtInput.SelectionLength = 0;
        }

        /// <summary>
        /// Function that calculate the equation
        /// </summary>
        public void EqualButton()
        {
            GetInput();
            txtInput.Text = calc.Result();

            // Check if an operator has been selected if not will only show first_input = first_input
            if (calc.operation == "")
            {
                txtPrevious.Text = calc.first_input + " =";

            }
            else
            {
                txtPrevious.Text = calc.first_input + " " + calc.NameToSymbole() + " " + calc.input + " =";
            }
            calc.Reset();
            DoAfterBtnPress();
        }

        /// <summary>
        /// Return the string to show the current history
        /// </summary>
        public void ShowHistory()
        {
            txtHistory.Text = "\r\n";
            foreach (string e in calc.history)
            {
                txtHistory.Text += e + "\r\n\r\n\r\n";
            }
        }

        /// <summary>
        /// reset the txtInput box 
        /// </summary>
        public void ResetTxtIput()
        {
            txtInput.Text = "0";
            txtInput.BorderStyle = BorderStyle.Fixed3D; // rajoute le border 
            txtInput.Focus();
            txtInput.SelectAll(); // Select the 0 so that we overwrite it when writing new number 
        }

        /// <summary>
        /// Actions to make after every button pressed 
        /// </summary>
        public void DoAfterBtnPress()
        {
            ShowHistory();
            GetFocus();
        }

        /// <summary>
        /// Change the text in the txtPrevious Box Using the correct operator.
        /// </summary>
        /// <param name="text"></param>
        public void ChangeTxtPrevious(string text)
        {
            txtPrevious.Text = txtInput.Text + " " + text;
        }


        // TODO
        public string FormatInput(string text)
        {
            prevFormat = true;

            double input = Convert.ToDouble(text);
            string v = "";

            // Check if the number has a fractionnal part
            if (input % 1 == 0)
            {
                // Without decimal
                v = string.Format("{0:0,0}", input);
            }
            else
            {
                // With decimal
                v = string.Format("{0:0,0.#######}", input);
            }

            // Fix formatage where it give 2 '0' for a results thats just suppose to be 0
            if (v == "00")
            {
                v = v.Remove(0, 1);
            }
            // Fix random 0 appearing before number because of formatage
            if (v.Length > 1 && v.StartsWith("0"))
            {
                if (!StartWithPourcentage())
                {
                    v = v.Remove(0, 1);
                }
            }
            if (v.Length > 1 && v.StartsWith("-0"))
            {
                if (!StartWithPourcentage())
                {
                    v = v.Remove(1, 1);
                }
            }

            return v;
        }

        public bool StartWithPourcentage()
        {
            if (txtInput.Text.StartsWith("0.") || txtInput.Text.StartsWith("00."))
            {
                return true;
            }
            else if (txtInput.Text.StartsWith("-0.") || txtInput.Text.StartsWith("-00."))
            {
                return true;
            }
            return false;
        }


        /*****************/
        /* END FUCNTIONS */
        /*****************/



        public Form1()
        {
            InitializeComponent();

            // Setup the listener for keypress
            txtInput.KeyUp += txtInput_KeyUp;


            // create the calculator object
            calc = new Calc();
        }

        /// <summary>
        /// The desc of the current operation that is being made 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrevious_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The Main Input for the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // Make sure the character that was input by the user is a number if not remove it. 
            try
            {
                Convert.ToDouble(txtInput.Text);
            }
            catch (Exception ex)
            {
                if (txtInput.Text.Length >= 1)
                {
                    txtInput.Text = prevTxtInput; // Since there was a miss input it revert to backup input value
                    ReplaceCursor();
                    if (txtInput.Text.Length == 1)
                    {
                        GetFocus();
                    }
                }
            }

            if (!prevFormat)
            { 
                // Assure que le text ne soit jamais vide mais plutot à une valeur de 0
                if (txtInput.Text == "")
                {
                    ResetTxtIput();
                }

                // Si on commence à ecrire dans la textBox, on remove le 0 de default
                if (txtInput.Text.StartsWith("0") && txtInput.Text.Length > 1)
                {
                    if (!StartWithPourcentage())
                    {
                        txtInput.Text = txtInput.Text.Remove(0, 1);

                        // Replace the cursor at the start of the textBox
                        txtInput.SelectionStart = txtInput.Text.Length;
                        txtInput.SelectionLength = 0;
                    }
                    
                }
                // Quand le textBox n'est plus de 0, on enleve le border. 
                if (txtInput.BorderStyle == BorderStyle.Fixed3D && txtInput.Text != "0")
                {
                    txtInput.BorderStyle = BorderStyle.None;
                }

                // Format the current input if not 0
                if (txtInput.Text.Length > 1)
                {
                    if (txtInput.Text.IndexOf('.') != txtInput.Text.Length - 1)
                    {
                        txtInput.Text = FormatInput(txtInput.Text);
                        ReplaceCursor();
                    }
                }
            }
            else
            {
                prevFormat = false;
            }

            // Store the current input 
            prevTxtInput = txtInput.Text;
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EqualButton();
            }
        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            prevTxtInput = txtInput.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            GetInput();
            if (calc.AddingOperation("Addition"))
            {
                txtInput.Text = calc.Result();
                calc.Reset();
            }
            ChangeTxtPrevious(btnPlus.Text);
            DoAfterBtnPress(); 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            EqualButton();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            ResetTxtIput();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetTxtIput();
            txtPrevious.Text = ""; // Clear the previous operation txtBox
            calc.operation = ""; // If it had a saved operation it will remove it. 
            calc.first_input = 0;
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.StartsWith("-") && txtInput.Text.Length == 2)
            {
                ResetTxtIput();
            }
            else
            {
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1, 1);
                ReplaceCursor();
            }
        }


        /// <summary>
        /// Delete history Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txtHistory.Text = "There's no history yet   ";
            calc.history = new List<string>();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            GetInput();
            if (calc.AddingOperation("Substraction"))
            {
                txtInput.Text = calc.Result(); // let the user use the previous result has a input.
                calc.Reset();
            }
            ChangeTxtPrevious(btnMinus.Text);
            DoAfterBtnPress();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            GetInput();
            if (calc.AddingOperation("Multiply"))
            {
                txtInput.Text = calc.Result();
                calc.Reset();
            }
            ChangeTxtPrevious(btnMulti.Text);
            DoAfterBtnPress();
        }

        private void btnDivider_Click(object sender, EventArgs e)
        {
            GetInput();
            if (calc.AddingOperation("Division"))
            {
                txtInput.Text = calc.Result();
                calc.Reset();
            }
            ChangeTxtPrevious(btnDivider.Text);
            DoAfterBtnPress();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn1.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn1.Text}");
            }
            ReplaceCursor();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn2.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn2.Text}");
            }
            ReplaceCursor();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn3.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn3.Text}");
            }
            ReplaceCursor();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn4.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn4.Text}");
            }
            ReplaceCursor();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn5.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn5.Text}");
            }
            ReplaceCursor();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn6.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn6.Text}");
            }
            ReplaceCursor();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn7.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn7.Text}");
            }
            ReplaceCursor();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn8.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn8.Text}");
            }
            ReplaceCursor();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn9.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn9.Text}");
            }
            ReplaceCursor();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // Check if the input is currently 0. if so we dont insert but replace input with btn value
            if (txtInput.SelectionLength >= 1)
            {
                txtInput.Text = btn0.Text;
            }
            else
            {
                txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, $"{btn0.Text}");
            }
            ReplaceCursor();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.Insert(txtInput.Text.Length, ".");
            ReplaceCursor();
        }

        /// <summary>
        /// Make the input negative or positive if already negative.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * -1);
                ReplaceCursor();
            }
        }

        /// <summary>
        /// Divide 1 by the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOneDividedBySelf_Click(object sender, EventArgs e)
        {
            // GetInput();

            // Make the calcul for the division
            txtInput.Text = FormatInput(Convert.ToString(1 / Convert.ToDouble(txtInput.Text)));

            GetFocus();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtInput.Text);
            txtInput.Text = Convert.ToString(num * num);

            GetFocus();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            // FUCK ME THIS SHIT AIN'T EASY FUCK FUCK FUCK ME AGAIN.
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            txtInput.Text = FormatInput(Convert.ToString(Convert.ToDouble(txtInput.Text) / 100));

            GetFocus();
        }
    }
}
