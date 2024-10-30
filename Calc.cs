using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullyWorkingCalculator
{
    internal class Calc
    {
        public double input;
        public double first_input;
        public string operation;
        public string output;
        public string memoire;

        public List<string> history;

        // Default Constructor
        public Calc()
        {
            this.input = 0;
            this.first_input = 0;
            this.operation = "";
            this.memoire = "";
            this.history = new List<string>();
        }

        public void Reset()
        {
            if (this.memoire != "")
            {
                this.first_input = (Convert.ToDouble(FormatOutput(this.output)));
            }
            else
            {
                this.first_input = 0;
            }
            this.input = 0;
            this.operation = this.memoire;
            this.memoire = "";
        }

        public string Result()
        {
            ApplyOperation();
            this.history.Insert(0, RecentHistory() + FormatOutput(this.output) + "  ");
            return FormatOutput(this.output);
        }

        public bool AddingOperation(string o)
        {
            bool madeCalcul = false;
            if (this.operation == "")
            {
                this.operation = o;
                
            }
            else if (this.operation != o && this.input == this.first_input) // If the 2 inputs are the same but different operation it will not make a calcul
            {
                this.operation = o;
            }
            else // If we here we need to do a calculate operation before adding the new operation
            {
                madeCalcul = true; // tell the form that we made a calcul and so we need to print it the the txtInput box
                this.memoire = o;
                ApplyOperation();
            }

            return madeCalcul;
        }

        public void ApplyOperation()
        {
            switch (operation)
            {
                case "Addition":
                    Add();
                    break;
                case "Substraction":
                    Substract();
                    break;
                case "Multiply":
                    Multiply();
                    break;
                case "Division":
                    Division();
                    break;
                case "":
                    this.output = Convert.ToString(this.first_input);
                    break;
            }
        }

        public string NameToSymbole()
        {
            switch (this.operation)
            {
                case "Addition":
                    return "+";
                case "Substraction":
                    return "-";
                case "Multiply":
                    return "×";
                case "Division":
                    return "÷";
                default:
                    return "";
            }
        }

        public string RecentHistory()
        {
            // Check if an operator has been selected if not will only show first_input = first_input
            if (NameToSymbole() == "")
            {
                return this.first_input + " =  \r\n";
            }
            else
            {
                return this.first_input + " " + NameToSymbole() + " " + this.input + " =  \r\n";
            }
        }

        private string FormatOutput(string text)
        {

            double output = Convert.ToDouble(text);
            string v = "";

            // Check if the number has a fractionnal part
            if (output % 1 == 0)
            {
                // Without decimal
                v = string.Format("{0:0,0}", output);
            }
            else
            {
                // With decimal
                v = string.Format("{0:0,0.#######}", output);

                // Sometimes with the format it add a 0 at the start.. this will remove it in that case
                if (v.StartsWith("0"))
                {
                    v = v.Remove(0, 1);
                }

                // Same fix but if number is negative
                if (v.StartsWith("-0"))
                {
                    v = v.Remove(1, 1);
                }
            }
            
            // Fix formatage where it give 2 '0' for a results thats just suppose to be 0
            if (v == "00")
            {
                v = v.Remove(0, 1);
            }
            // Fix random 0 appearing at before number because of formatage
            if (v.Length > 1 && v.StartsWith("0"))
            {
                v = v.Remove(0, 1);
            }
            if (v.Length > 1 && v.StartsWith("-0"))
            {
                v = v.Remove(1, 1);
            }

            // if start with . add a 0 before 
            if (v.StartsWith("."))
            {
                v.Insert(0, "0");
            }

            return v;
        }

        /* Operations */
        public void Add()
        {
            this.output = Convert.ToString(this.first_input + this.input);
        }

        public void Substract()
        {
            this.output = Convert.ToString(this.first_input - this.input);
        }

        public void Multiply()
        {
            this.output = Convert.ToString(this.first_input * this.input);
        }

        public void Division()
        {
            this.output = Convert.ToString(this.first_input / this.input);
        }

        public void DividedBySelf()
        {
            if (this.input !=  0)
            {
                this.output = Convert.ToString(1 / this.input);
            }
            else
            {
                this.output = Convert.ToString(1 / this.first_input);
            }
        }
    }
}
