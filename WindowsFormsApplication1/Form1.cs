using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{

    public partial class Calculator : Form
    {
        string input = string.Empty;                 // String that holds the user input from textBox1
        List<string> inputs = new List<string>();    // List of strings that is separated into left parentheses, right parentheses, operands and operations, all in order that it's entered
        bool isLegal;                                // Checks for a legal character in the entered string, returns true if it is a legal character
        bool isParentheses;                          // Checks for parentheses in string, returns true if there are parentheses
        bool isValidOperation;                       // Checks for valid operation, false if it's not valid
        bool isValidParentheses;                     // Checks for valid number of parentheses and returns false if incorrect quantity.
        bool isDivisionByZero;                       // Checks for division by zero, if there is division by zero, it returns true, else it's false.
        bool isContaining;                           //Checks if the input contains cos, sin, or tan.
        bool isContainingParentheses;                //Checks if the inputs contains legal cos, sin, and tan.
        int LeftParenthesesIndex = 0;                // Holds the index of the left parentheses position for a prioritized set of calculations
        int RightParenthesesIndex = 0;               // Holds the index of the right parentheses position for a prioritized set of calculations

        public Calculator()
        {
            InitializeComponent();
            textBox1.Select();
            textBox1.Focus();
        }

        /* This method removes any string that are null or empty. */
        public void RemoveNullorEmptyString(ref List<string> inputs)
        {
            int size = inputs.Count();

            for (int i = 0; i < size; i++)
            {
                if (inputs[i] == "")
                {
                    inputs.RemoveAt(i);
                    size--;
                }
            }
        }

        /* This method checks if there are valid cos/sin/tan entries. */
        public bool CosTanSinCheckFullParentheses(string input)
        {
            bool isContaining = false;

            if ((input.Contains("cos(")) || (input.Contains("sin(")) || (input.Contains("tan(")))
            {
                isContaining = true;
            }

            return (isContaining);

        }

        /* This method checks there are valid cos/sin/tan entries. */
        public bool CheckCosTanSinAllHaveParentheses(string input)
        {
            bool isContainingParentheses = true;

            if (((input.Contains("cos")) && (!(input.Contains("cos(")))))
            {
                isContainingParentheses = false;
            }
            else if (((input.Contains("sin")) && (!(input.Contains("sin(")))))
            {
                isContainingParentheses = false;
            }
            else if (((input.Contains("tan")) && (!(input.Contains("tan(")))))
            {
                isContainingParentheses = false;
            }

            return (isContainingParentheses);
        }

        /* This method performs the sin/cos/tan calculations. */
        public void CosTanSinCalculation(ref List<string> inputs, int LeftParenthesesIndex)
        {
            int size = inputs.Count();
            int i = LeftParenthesesIndex - 1;
            double result = 0;
            double num1 = 0;
            double num2 = 0;

            if ((inputs[i] == "cos") || (inputs[i] == "tan") || (inputs[i] == "sin"))
            {
                if ((inputs[i + 1] == "*"))
                {
                    inputs.RemoveAt(i + 1);
                    size = inputs.Count();
                }
                if (i < size - 2)
                {
                    if (inputs[i] == "cos")
                    {
                        double.TryParse(inputs[i + 2], out num1);

                        result = Math.Cos(num1);
                        inputs.RemoveAt(i + 1);
                        inputs.RemoveAt(i + 2);
                        inputs[i] = result.ToString();
                        inputs.RemoveAt(i + 1);
                        size = (inputs.Count());
                    }
                    else if (inputs[i] == "sin")
                    {
                        double.TryParse(inputs[i + 2], out num1);

                        result = Math.Sin(num1);
                        inputs.RemoveAt(i + 1);
                        inputs.RemoveAt(i + 2);
                        inputs[i] = result.ToString();
                        inputs.RemoveAt(i + 1);
                        size = (inputs.Count());
                    }
                    else if (inputs[i] == "tan")
                    {
                        double.TryParse(inputs[i + 2], out num1);

                        result = Math.Tan(num1);
                        inputs.RemoveAt(i + 1);
                        inputs.RemoveAt(i + 2);
                        inputs[i] = result.ToString();
                        inputs.RemoveAt(i + 1);
                        size = (inputs.Count());
                    }

                    if ((size > 2) && (i > 0) && ((inputs[i - 1] != "^") && (inputs[i - 1] != "*") && (inputs[i - 1] != "/") && (inputs[i - 1] != "+") && (inputs[i - 1] != "-") && (inputs[i - 1] != ".")))
                    {
                        double.TryParse(inputs[i - 1], out num1);
                        double.TryParse(inputs[i], out num2);

                        result = num1 * num2;
                        inputs[i] = result.ToString();
                        inputs.RemoveAt(i - 1);
                        size = (inputs.Count());
                    }
                }
            }
        }


        /* This method cycles through the order of operations for a given prioritized set of calculations */
        public bool OrderOfOperations(ref List<string> inputs, int LeftParenthesesIndex)
        {
            string errorMessage = string.Empty;          // Will hold an error message if user tries to divide by zero
            int i = LeftParenthesesIndex;                // index holding postion of left Parentheses index, used for looping through the list of strings
            double resultTemp = 0;                       // Holds the resulting calculation of a given calculation
            double num1, num2;                           // num1 holds the first operand, and num2 holds the second operand
            bool isDivisionByZero = false;               // false while there is no division by zero

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
                    if (inputs[i] == "*")
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

                    else if (inputs[i] == "/")
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
                            isDivisionByZero = true;
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

            if (LeftParenthesesIndex > 0)
            {
                if ((inputs[LeftParenthesesIndex - 1] == "cos") || (inputs[LeftParenthesesIndex - 1] == "sin") || (inputs[LeftParenthesesIndex - 1] == "tan"))
                {
                    CosTanSinCalculation(ref inputs, LeftParenthesesIndex);
                }
            }

            return (isDivisionByZero);
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
            if (i < 0)
            {
                i = 0;
            }
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
            int size = inputs.Count();

            for (int i = 0; i < size; i++)
            {
                if ((i < size - 1) && ((inputs[i] == "^") || (inputs[i] == "*") || (inputs[i] == "/") || (inputs[i] == "+") || (inputs[i] == "-") || (inputs[i] == ".")))
                {
                    int k = 1;
                    while ((((inputs[i + k] == "^") || (inputs[i + k] == "*") || (inputs[i + k] == "/") || (inputs[i + k] == "+") || (inputs[i + k] == "-") || (inputs[i + k] == "."))))
                    {
                        inputs.RemoveAt(i + k);
                        size--;
                        if ((i + k) == (size - 1))
                        {
                            break;
                        }
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
        public bool CheckForIllegalCharacters(string input, bool isContaining)
        {
            bool isLegal = true;

            // loop through the string of user input and search for any illegal characters, return isLegal = false if illegal characters found.
            for (int i = 0; i < input.Length; i++)
            {
                if ((!isContaining) && (!((input[i] == '0') || (input[i] == '1') || (input[i] == '2') || (input[i] == '3') || (input[i] == '4') || (input[i] == '5') || (input[i] == '6') || (input[i] == '7') || (input[i] == '8') || (input[i] == '9')
                    || (input[i] == '^') || (input[i] == '*') || (input[i] == '/') || (input[i] == '+') || (input[i] == '-') || (input[i] == ')') || (input[i] == '(') || (input[i] == '.'))))
                {
                    isLegal = false;
                }
                else if ((((isContaining) && (!((input[i] == 'c') || (input[i] == 'o') || (input[i] == 's') || (input[i] == 't') || (input[i] == 'a') || (input[i] == 'n') || (input[i] == 'i') || (input[i] == '0') || (input[i] == '1') || (input[i] == '2') || (input[i] == '3') || (input[i] == '4') || (input[i] == '5') || (input[i] == '6') || (input[i] == '7') || (input[i] == '8') || (input[i] == '9')
                    || (input[i] == '^') || (input[i] == '*') || (input[i] == '/') || (input[i] == '+') || (input[i] == '-') || (input[i] == ')') || (input[i] == '(') || (input[i] == '.'))))))
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
                while ((i != size) && ((((int)input[i] >= 48) && ((int)input[i] <= 57)) || (input[i] == '.')))
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

                if ((input[i] == '('))
                {
                    inputs.Add("(");
                    isNumber = false;
                }
                else if ((input[i] == 'c') || (input[i] == 't') || (input[i] == 's'))
                {
                    size = input.Length;
                    if ((size - 1) >= (i + 2))
                    {
                        tempInput = string.Empty;

                        if ((input[i] == 'c') && (input[i + 1] == 'o') && (input[i + 2] == 's'))
                        {
                            tempInput = "cos";
                        }
                        else if ((input[i] == 's') && (input[i + 1] == 'i') && (input[i + 2] == 'n'))
                        {
                            tempInput = "sin";
                        }
                        else if ((input[i] == 't') && (input[i + 1] == 'a') && (input[i + 2] == 'n'))
                        {
                            tempInput = "tan";
                        }

                        inputs.Add(tempInput);
                        tempInput = string.Empty;
                        size = input.Length;
                        isNumber = false;
                    }
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
                else if (input[i] == '*')
                {
                    inputs.Add("*");
                    isNumber = false;
                }
                else if (input[i] == '/')
                {
                    inputs.Add("/");
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

        
        /* This method checks for numbers that must be treated as a negative number and manipulates the list of inputs to properly perform the set of calculations. */
        public void CheckNegativeNumberMissed(ref List<string> inputs)
        {
            int size = inputs.Count();

            for (int i = 0; i < size; i++)
            {
                if (((size > 2) && ((i + 2) < size) && ((inputs[i] == "(") || (inputs[i] == "^") || (inputs[i] == "/") || (inputs[i] == "*") || (inputs[i] == "+") || (inputs[i] == "-"))
                    && ((inputs[i + 1] == "-")) && ((inputs[i + 2] != "^") && (inputs[i + 2] != "/") && (inputs[i + 2] != "+") && (inputs[i + 2] != "*") && (inputs[i + 2] != "-"))))
                {

                    if ((inputs[i + 2] != ")") && (inputs[i + 2] != "cos") && (inputs[i + 2] != "sin") && (inputs[i + 2] != "tan"))
                    {
                        if (((i + 3) < size - 1) && (inputs[i + 3] == "^"))
                        {
                            inputs[i + 1] = "-1";
                            inputs.Insert(i + 2, "*");
                            size ++;
                        }
                        else
                        {
                            inputs[i + 1] = "(";
                            inputs.Insert(i + 2, "-1");
                            inputs.Insert(i + 3, "*");
                            inputs.Insert(i + 5, ")");
                            size += 3;
                        }
                    }
                }
                else if ((size >= 2) && (i < size - 2) && (inputs[0] == "-"))
                {
                    inputs[0] = "-1";
                    inputs.Insert(1, "*");
                    size++;
                }
            }
        }


        /* This method loops through the list of strings and checks for the correct number of parentheses and displays an error message if there is an incorrect amount. */
        public bool CheckForInvalidParentheses(List<string> inputs)
        {
            int countLeftParentheses = 0;
            int countRightParentheses = 0;
            bool isValidParentheses = true;

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
                        isValidParentheses = false;
                    }
                }

            }

            if (countLeftParentheses != countRightParentheses)
            {
                isValidParentheses = false;
            }

            return (isValidParentheses);
        }


        /* This method checks for parentheses connected, either to each other or side-by-side a numerical value, that would indicate multiplication and inputs multiplication symbol in between the two. */
        public void CheckForMatedRightToLeftParentheses(ref List<string> inputs)
        {
            int size = inputs.Count();

            for (int i = 0; i < size; i++)
            { 
                if ((i < size - 1) && (size > 1) && ((inputs[i] == ")") && (inputs[i + 1] == "(")))
                {
                    inputs.Insert(i + 1, "*");
                }
                else if ((size > 1) && (i > 1) && ((inputs[i] == "(") || (inputs[i] == ")")))
                {
                    if ((inputs[i] == "(") && ((inputs[i - 1] != "^") && (inputs[i - 1] != "/") && (inputs[i - 1] != "+") && (inputs[i - 1] != "-") && (inputs[i - 1] != "*") && (inputs[i - 1] != "cos") && (inputs[i - 1] != "sin") && (inputs[i - 1] != "tan") && (inputs[i - 1] != "(")))
                    {
                        inputs.Insert(i, "*");
                        size++;
                    }
                    else if ((inputs[i] == ")") && ((i != size - 1)) && ((inputs[i + 1] != "^") && (inputs[i + 1] != "/") && (inputs[i + 1] != "+") && (inputs[i + 1] != "-") && (inputs[i + 1] != "*") && (inputs[i + 1] != ")")))
                    {
                        inputs.Insert(i + 1, "*");
                        size++;
                    }
                }
            }
        }

        /* This method checks for several types of invalid operation symbols that would cause application crashes. */
        public bool CheckForInvalidOperation(string input)
        {
            int size = input.Length;
            bool isValidOperation = true;

            if (size > 0)
            {
                for (int i = 0; i < size; i++)
                {
                    if ((size > 1) && (i < (size - 1)))
                    {
                        if (((input[i] == '(') && ((input[i + 1] == '*') || (input[i + 1] == '^') || (input[i + 1] == '/') || (input[i + 1] == '+') || (input[i + 1] == '.'))))
                        {
                            isValidOperation = false;
                            break;
                        }
                        else if (((input[i] == '*') || (input[i] == '^') || (input[i] == '/') || (input[i] == '+') || (input[i] == '-') || (input[i] == '.')) && (input[i + 1] == ')'))
                        {
                            isValidOperation = false;
                            break;
                        }
                        else if ((input[i] == '(') && (input[i + 1] == ')'))
                        {
                            isValidOperation = false;
                            break;
                        }
                        else if (((input[0] == '*') || (input[0] == '^') || (input[0] == '/') || (input[0] == '+')))
                        {
                            isValidOperation = false;
                            break;
                        }
                    }
                }
            }

            if (size == 0)
            {
                isValidOperation = false;
            }

            else if ((input[size - 1] == '*') || (input[size - 1] == '^') || (input[size - 1] == '/') || (input[size - 1] == '+') || (input[size - 1] == '-') || (input[size - 1] == '.') || (input[size - 1] == '(') || (input[0] == ')'))
            {
                isValidOperation = false;
            }

            return (isValidOperation);
        }


        /* If operation is invalid then this is used to print an error message. */
        public void CheckForValidOperationErrorMessage()
        {
            ClearText();
            textBox1.Text = "Error: Invalid input! Hit clear and try again.";
        }


        /* This method removes a set of two parentheses, one left and one right, from the list of strings. */
        public void ClearParentheses(ref List<string> inputs, int LeftParenthesesIndex)
        {
            bool RightParenthesesFound = false;

            int i = LeftParenthesesIndex;

            int size = inputs.Count();

            if ((size > 2) && (i < size) && (inputs[i] == "("))
            {
                while (!RightParenthesesFound)
                {

                    if (inputs[i] == ")")
                    {
                        inputs.RemoveAt(i);
                        size--;
                        RightParenthesesFound = true;
                        break;
                    }
                    else if ((inputs[i] == "("))
                    {
                        inputs.RemoveAt(i);
                        size--;
                    }
                    i++;
                }
            }
        }
                                                                           

        /* This method double checks that user input =  textBox text */
        public void CompareInputToTextBox(ref string input, TextBox textBox1)
        {
            string inputTemp = string.Empty;

            if (input != textBox1.Text)
            {
                inputTemp += textBox1.Text;
                input = string.Empty;
                input = inputTemp;
            }
        }


        /* This method finishes calculation of result from user input, but first cycles through numerous input verification to prevent application crash*/
        public void GoCalculate()
        {
            isDivisionByZero = false;

            CompareInputToTextBox(ref input, textBox1);

            isContaining = CosTanSinCheckFullParentheses(input);

            if (isContaining)
            {
                isContainingParentheses = CheckCosTanSinAllHaveParentheses(input);
            }

            isLegal = CheckForIllegalCharacters(input, isContaining);

            isValidOperation = CheckForInvalidOperation(input);

            isParentheses = IsParentheses(inputs);

            isValidParentheses = CheckForInvalidParentheses(inputs);

            if ((!(isValidOperation)) || (!(isLegal)) || ((isParentheses) && (!(isValidParentheses))))
            {
                if (!isLegal)
                {
                    PrintIllegalCharacterErrorMessage();
                }
                else if ((isParentheses) && (!isValidParentheses))
                {
                    ClearText();
                    input = string.Empty;
                    textBox1.Text += "Error: Invalid parentheses! Hit clear and try again.";
                }
                else
                {
                    CheckForValidOperationErrorMessage();
                }
            }
            else
            {
                StringIntoListOfStrings(input, ref inputs);

                CheckNegativeNumberMissed(ref inputs);

                RemoveNullorEmptyString(ref inputs);

                CheckForMultipleOperations(ref inputs);

                CheckForMatedRightToLeftParentheses(ref inputs);

                FindParenthesesIndex(inputs, ref LeftParenthesesIndex, ref RightParenthesesIndex);

                isParentheses = IsParentheses(inputs);
                isValidParentheses = CheckForInvalidParentheses(inputs);

                if ((isParentheses) && (!isValidParentheses))
                {
                    ClearText();
                    input = string.Empty;
                    textBox1.Text += "Error: Invalid parentheses! Hit clear and try again.";
                }

                while (isParentheses && isValidParentheses && (inputs.Count() > 1))
                {

                    isValidParentheses = CheckForInvalidParentheses(inputs);
                    FindParenthesesIndex(inputs, ref LeftParenthesesIndex, ref RightParenthesesIndex);
                    isDivisionByZero = OrderOfOperations(ref inputs, LeftParenthesesIndex);
                    ClearParentheses(ref inputs, LeftParenthesesIndex);

                    if (isDivisionByZero)
                    {
                        ClearText();
                        input = string.Empty;
                        textBox1.Text += "Division by zero is NOT allowed! Hit clear and try again.";
                        break;
                    }
                    else if (!isValidParentheses)
                    {
                        ClearText();
                        input = string.Empty;
                        textBox1.Text += "Error: Incorrect parentheses placement! Hit clear and try again.";
                        break;
                    }
                    isParentheses = IsParentheses(inputs);
                }              
            }                                

            if (isContaining && (!(isContainingParentheses)))
            {
                ClearText();
                input = string.Empty;
                textBox1.Text += "Error: Invalid cos/sin/tan calculation! Hit clear and try again.";
            }
            
            if ((!(isParentheses)) && (!(isDivisionByZero)) && (isValidParentheses) && (isLegal) && (isValidOperation))
            {
               isDivisionByZero = OrderOfOperations(ref inputs, 0);
                if (isDivisionByZero)
                {
                    ClearText();
                    input = string.Empty;
                    textBox1.Text += "Division by zero is NOT allowed! Hit clear and try again.";
                }
            }

            if ((isValidOperation) && (isLegal) && (isValidParentheses) && (!isDivisionByZero))
            {
                input = string.Empty;
                input += inputs[0];
                inputs.Clear();
                textBox1.Text = input;
            }
        }
            

        /* Move focus to textBox1. */
        public void FocusTextBoxButton()
        {
            textBox1.Focus();
            textBox1.Select(textBox1.Text.Length, 0);         
        }

        /* Loading the form. */
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            textBox1.Focus();
        }

        /* Events for clicking "1" button. */
        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            textBox1.Text += "1";
            FocusTextBoxButton();
        }

        /* Events for clicking "2" button. */
        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            textBox1.Text += "2";
            FocusTextBoxButton();
        }

        /* Events for clicking "." button. */
        private void DECIMAL_Click(object sender, EventArgs e)
        {
            input += ".";
            textBox1.Text += ".";
            FocusTextBoxButton();
        }

        /* Events for clicking "-" button. */
        private void SUBTRACTION_Click(object sender, EventArgs e)
        {
            input += "-";
            textBox1.Text += "-";
            FocusTextBoxButton();
        }

        /* Events for clicking "0" button. */
        private void ZERO_Click(object sender, EventArgs e)
        {

            input += "0";
            textBox1.Text += "0";
            FocusTextBoxButton();
        }

        /* Events for clicking "3" button. */
        private void THREE_Click(object sender, EventArgs e)
        {

            input += "3";
            textBox1.Text += "3";
            FocusTextBoxButton();
        }

        /* Events for clicking "4" button. */
        private void FOUR_Click(object sender, EventArgs e)
        {

            input += "4";
            textBox1.Text += "4";
            FocusTextBoxButton();
        }

        /* Events for clicking "5" button. */
        private void FIVE_Click(object sender, EventArgs e)
        {

            input += "5";
            textBox1.Text += "5";
            FocusTextBoxButton();
        }

        /* Events for clicking "6" button. */
        private void SIX_Click(object sender, EventArgs e)
        {

            input += "6";
            textBox1.Text += "6";
            FocusTextBoxButton();
        }

        /* Events for clicking "7" button. */
        private void SEVEN_Click(object sender, EventArgs e)
        {
            input += "7";
            textBox1.Text += "7";
            FocusTextBoxButton();
        }

        /* Events for clicking "8" button. */
        private void EIGHT_Click(object sender, EventArgs e)
        {
            input += "8";
            textBox1.Text += "8";
            FocusTextBoxButton();
        }

        /* Events for clicking "9" button. */
        private void NINE_Click(object sender, EventArgs e)
        {
            input += "9";
            textBox1.Text += "9";
            FocusTextBoxButton();
        }

        private void COSINE_Click(object sender, EventArgs e)
        {
            input += "cos(";
            textBox1.Text += "cos(";
            FocusTextBoxButton();
        }

        private void SINE_Click(object sender, EventArgs e)
        {
            input += "sin(";
            textBox1.Text += "sin(";
            FocusTextBoxButton();
        }

        private void TANGENT_Click(object sender, EventArgs e)
        {
            input += "tan(";
            textBox1.Text += "tan(";
            FocusTextBoxButton();
        }

        /* Events for clicking "CLEAR" button on app, this clears everything user has entered and completely restores app to load-up state. */
        private void CLEAR_Click(object sender, EventArgs e)
        {
            ClearText();
            input = string.Empty;
            inputs.Clear();
            FocusTextBoxButton();
        }

        /* Events for clicking "÷" button. */
        private void DIVISION_Click(object sender, EventArgs e)
        {
            input += "/";
            textBox1.Text += "/";
            FocusTextBoxButton();
        }

        /* Events for clicking "*" button. */
        private void MULTIPLICATION_Click(object sender, EventArgs e)
        {
            input += "*";
            textBox1.Text += "*";
            FocusTextBoxButton();
        }

        /* Events for clicking "+" button. */
        private void ADDITION_Click(object sender, EventArgs e)
        {
            input += "+";
            textBox1.Text += "+";
            FocusTextBoxButton();
        }

        /* Events for clicking "^" button. */
        private void POWER_Click(object sender, EventArgs e)
        {
            input += "^";
            textBox1.Text += "^";
            FocusTextBoxButton();
        }

        /* Events for clicking "(" button. */
        private void LEFT_PARENTHESES_Click(object sender, EventArgs e)
        {
            input += "(";
            textBox1.Text += "(";
            FocusTextBoxButton();
        }

        /* Events for clicking ")" button. */

        private void RIGHT_PARENTHESES_Click(object sender, EventArgs e)
        {
            input += ")";
            textBox1.Text += ")";
            FocusTextBoxButton();
        }

        /* This method acts as a backspace command when user hits the DELETE button on the app, and also is called when "delete" or "Backspace" is pressed on keyboard */
        private void DELETE_Click(object sender, EventArgs e)
        {

            int sizeInputs = inputs.Count();
            int sizeInput = input.Length;
            string input1 = string.Empty;

            CompareInputToTextBox(ref input, textBox1);
            if (textBox1.Text.Length != 0)
            {
                if ((sizeInput == 0) && (sizeInputs == 1))
                {
                    ClearText();
                    input = string.Empty;
                    inputs.Clear();
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            CompareInputToTextBox(ref input1, textBox1);
            input = string.Empty;
            input = input1;
            FocusTextBoxButton();
        }

        /* When textBox1 has control, and the user presses "Enter" or "delete" on the keyboard, this specifies events. */
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ENTER.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DELETE.PerformClick();
            }
        }

        /* When Calculator has control and user presses certain keys on the keyboard, this specifies events. */
        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            FocusTextBoxButton();
            if (e.KeyCode == Keys.Enter)
            {
                ENTER.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DELETE.PerformClick();
            }
        }

        // Once the user hits enter, this checks for errors in input and then goes through the prioritized set of calculations then printing the answer to the textBox1, result is stored for next calculation if clear is not hit. */
        private void ENTER_Click(object sender, EventArgs e)
        {
            GoCalculate();
            FocusTextBoxButton();
        }      
    }
}

    


    
