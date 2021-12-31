using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;

namespace CalculatorCalculation
{
    public class CalculatorCalculation : Calculator
    {
        /* This method cycles through the order of operations for a given prioritized set of calculations */
        public void OrderOfOperations(ref List<string> inputs, int LeftParenthesesIndex)
        {
            string errorMessage = string.Empty;          // Will hold an error message if user tries to divide by zero
            int i = LeftParenthesesIndex;                // index holding postion of left Parentheses index, used for looping through the list of strings
            double resultTemp = 0;                       // Holds the resulting calculation of a given calculation
            double num1, num2;                           // num1 holds the first operand, and num2 holds the second operand

            // Loops through the list of inputs and search for "^" operation, if found, the calculation is carried out.
            if (inputs.Count() > 1)
            {
                while ((i < inputs.Count()) && ((inputs[i] != ")")))
                {
                    if (inputs[i] == "^")
                    {
                        double.TryParse(inputs[i - 1], out num1);
                        double.TryParse(inputs[i + 1], out num2);

                        resultTemp = (Math.Pow(num1, num2));
                        inputs.RemoveAt(i + 1);
                        inputs[i] = resultTemp.ToString();
                        inputs.RemoveAt(i - 1);

                        if (i != 0)
                        {
                            i -= 1;
                        }
                    }
                    i++;
                }

                // Reset the loop variable i = LeftParenthesesIndex and begin looping back through the list of strings, searching for "x" or "÷", if found the calculation is done and made sure there is no division by 0.
                i = LeftParenthesesIndex;
                while ((i < inputs.Count()) && ((inputs[i] != ")") && (textBox1.Text != "Div By Zero NOT allowed!")))
                {
                    if (inputs[i] == "x")
                    {
                        double.TryParse(inputs[i - 1], out num1);
                        double.TryParse(inputs[i + 1], out num2);

                        resultTemp = num1 * num2;

                        inputs.RemoveAt(i + 1);
                        inputs[i] = resultTemp.ToString();
                        inputs.RemoveAt(i - 1);

                        if (i != 0)
                        {
                            i -= 1;
                        }
                    }

                    else if (inputs[i] == "÷")
                    {
                        double.TryParse(inputs[i - 1], out num1);
                        double.TryParse(inputs[i + 1], out num2);

                        if (num2 != 0)
                        {
                            resultTemp = num1 / num2;
                            inputs.RemoveAt(i + 1);
                            inputs[i] = resultTemp.ToString();
                            inputs.RemoveAt(i - 1);

                            if (i != 0)
                            {
                                i -= 1;
                            }
                        }

                        else
                        {
                            errorMessage = "Div By Zero NOT allowed!";
                            textBox1.Text = errorMessage;
                            break;
                        }
                    }
                    i++;
                }

                // If there was no error message for division by zero, then we re-cycle through the list of strings and search for "+" or "-", then calculate if found
                if (errorMessage != "Div By Zero NOT allowed!")
                {
                    i = LeftParenthesesIndex;
                    while ((i < inputs.Count()) && ((inputs[i] != ")")))
                    {
                        if (inputs[i] == "+")
                        {
                            double.TryParse(inputs[i - 1], out num1);
                            double.TryParse(inputs[i + 1], out num2);

                            resultTemp = num1 + num2;

                            inputs.RemoveAt(i + 1);
                            inputs[i] = resultTemp.ToString();
                            inputs.RemoveAt(i - 1);

                            if (i != 0)
                            {
                                i -= 1;
                            }
                        }

                        else if (inputs[i] == "-")
                        {
                            double.TryParse(inputs[i - 1], out num1);
                            double.TryParse(inputs[i + 1], out num2);

                            resultTemp = num1 - num2;
                            inputs.RemoveAt(i + 1);
                            inputs[i] = resultTemp.ToString();
                            inputs.RemoveAt(i - 1);

                            if (i != 0)
                            {
                                i -= 1;
                            }
                        }
                        i++;
                    }
                }
            }
        }


        /* This method searches for the innermost left parentheses index and will return that left parentheses through the parameter */
        public void FindParenthesesIndex(List<string> inputs, ref int LeftParenthesesIndex, ref int RightParenthesesIndex)
        {
            int i = 0;       // Loop variable for left parentheses index
            int k = 0;       // Loop variable for right parentheses index

            // loop through list of inputs and find "(" then store the left parentheses index
            for (i = inputs.Count() - 1; i >= 0; i--)
            {
                if (inputs[i] == "(")
                {
                    LeftParenthesesIndex = i;
                    break;
                }
            }

            // loop through the list of inputs and find ")" then store the right parentheses index
            for (k = i; k < inputs.Count(); k++)
            {
                if (inputs[k] == ")")
                {
                    RightParenthesesIndex = k;
                    break;
                }
            }
        }


        /* This method checks for repeating, back-to-back, sets of operations in the list of strings and removes all but the first one after the first operand */
        public void CheckForMultipleOperations(ref List<string> inputs)
        {
            for (int i = 0; i < inputs.Count(); i++)
            {
                if (((inputs[i] == "^") || (inputs[i] == "x") || (inputs[i] == "÷") || (inputs[i] == "+") || (inputs[i] == "-") || (inputs[i] == ".")) && (i < inputs.Count() - 1))
                {
                    int k = 1;
                    while ((((inputs[i + k] == "^") || (inputs[i + k] == "x") || (inputs[i + k] == "÷") || (inputs[i + k] == "+") || (inputs[i + k] == "-") || (inputs[i + k] == ".")) && ((i + k) < inputs.Count())))
                    {
                        inputs.RemoveAt(i + k);
                        k++;
                    }
                }
            }
        }


        /* This method searches for parentheses in the list of strings and returns true if there are parentheses */
        public bool IsParentheses(List<string> inputs)
        {
            bool isParentheses = false;

            // loop through list of strings and search for parentheses, return true if there are parentheses
            for (int i = 0; i < inputs.Count(); i++)
            {
                if ((inputs[i] == "(") || (inputs[i] == ")"))
                {
                    isParentheses = true;
                }
            }

            return (isParentheses);
        }


        /* This method checks for any illegal characters that do not allow calculation and returns false if there are illegal characters */
        public bool CheckForIllegalCharacters(string input)
        {
            bool isLegal = true;

            // loop through the string of user input and search for any illegal characters, return isLegal = false if illegal characters found.
            for (int i = 0; i < input.Length; i++)
            {
                if (!((input[i] == '0') || (input[i] == '1') || (input[i] == '2') || (input[i] == '3') || (input[i] == '4') || (input[i] == '5') || (input[i] == '6') || (input[i] == '7') || (input[i] == '8') || (input[i] == '9')
                    || (input[i] == '^') || (input[i] == 'x') || (input[i] == '÷') || (input[i] == '+') || (input[i] == '-') || (input[i] == ')') || (input[i] == '(') || (input[i] == '.')))
                {
                    isLegal = false;
                }

            }
            return (isLegal);
        }

        /* This method clears the textBox1 text, allowing for new set of calculations. */
        private void ClearText()
        {
            textBox1.Text = "";
        }


        /* This method clears the original text in textBox1 and then prints an error message about illegal characters, This is called if CheckForIllegalCharacters(isLegal == false). */
        public void PrintIllegalCharacterErrorMessage()
        {
            ClearText();
            textBox1.Text = "Error: Illegal character found. Hit clear and try again!";
        }


        /* This method loops through the user input string and turns it into a list of strings called inputs. */
        public void StringIntoListOfStrings(string input, ref List<string> inputs)
        {
            string tempInput = string.Empty;
            string tempString = string.Empty;
            bool isNumber = false;
            int size = input.Length;

            int i = 0;
            for (i = 0; i < size; i++)
            {
                while ((i != size) && (((int)input[i] >= 48) && ((int)input[i] <= 57)))
                {
                    tempString += input[i];

                    tempInput += tempString;
                    isNumber = true;
                    if (i <= (size - 1))
                    {
                        i++;
                    }
                    tempString = string.Empty;
                }

                if (isNumber == true)
                {
                    inputs.Add(tempInput);
                    tempInput = string.Empty;
                }

                if (i == size)
                {
                    break;
                }

                if (input[i] == '(')
                {
                    inputs.Add("(");
                    isNumber = false;
                }
                else if (input[i] == ')')
                {
                    inputs.Add(")");
                    isNumber = false;
                }
                else if (input[i] == '^')
                {
                    inputs.Add("^");
                    isNumber = false;
                }
                else if (input[i] == 'x')
                {
                    inputs.Add("x");
                    isNumber = false;
                }
                else if (input[i] == '÷')
                {
                    inputs.Add("÷");
                    isNumber = false;
                }
                else if (input[i] == '+')
                {
                    inputs.Add("+");
                    isNumber = false;
                }
                else if (input[i] == '-')
                {
                    inputs.Add("-");
                    isNumber = false;
                }
            }
        }


        /* This method loops through the list of strings and checks for the correct number of parentheses and displays an error message if there is an incorrect amount. */
        public void CheckForInvalidParentheses(List<string> inputs)
        {
            int countLeftParentheses = 0;
            int countRightParentheses = 0;

            for (int i = 0; i < inputs.Count(); i++)
            {

                if ((inputs[i] == "(") || (inputs[i] == ")"))
                {
                    if (inputs[i] == "(")
                    {
                        countLeftParentheses++;
                    }
                    else if (inputs[i] == ")")
                    {
                        countRightParentheses++;
                    }
                    if ((inputs[i] == "(") && (inputs[i + 1] == ")"))
                    {
                        textBox1.Text = "Error: Incorrect parentheses placement, hit clear and try again!";
                    }
                }

            }

            if (countLeftParentheses != countRightParentheses)
            {
                textBox1.Text = "Error: Incorrect number of parentheses. Hit clear and try again!";
            }
        }


        /* This method removes a set of two parentheses, one left and one right, from the list of strings. */
        public void ClearParentheses(ref List<string> inputs, int LeftParenthesesIndex)
        {
            bool RightParenthesesFound = false;

            int i = LeftParenthesesIndex;

            while (!RightParenthesesFound)
            {
                if (inputs[i] == ")")
                {
                    inputs.RemoveAt(i);
                    RightParenthesesFound = true;
                }
                else if ((inputs[i] == "("))
                {
                    inputs.RemoveAt(i);
                }
                i++;
            }
        }
    }
}
