namespace Calculator
{
    public partial class Form1 : Form
    {
        List<string> number = new List<string>();
        double result=0;
        int index = 0;
        bool done_operation = false;
        string operation_type = "";

        public Form1()
        {
            InitializeComponent();
            new_list_item();
            
            
        }

        private void b_Click(object sender, EventArgs e)
        {
            //whenever button is clicked it's value will be set into the string
            string choice = sender.ToString();
            //line below will crop string to get wanted information
            choice = choice.Substring(35 ,choice.Length-35);

            //
            switch (choice)
            {
                case "+": {
                        if(basic_checker())return;
                        if ((number.Count == 2 && number[1] != "0"))
                        {
                            change_operation();
                        }
                        if ((number[0] != "0" || number[0] != "0.") && operation_type != "")
                        {
                            change_operation();
                        }

                        operation_type = "+";
                        done_operation = true;
                        show_equasion();
                        break;
                    }
                case "-": {
                        if (basic_checker()) return;
                        if (operation_type == "+" || (number.Count == 2 && number[1] != "0"))
                        {
                            change_operation();
                        }
                        if ((number[0] != "0" || number[0] != "0.") && operation_type != "")
                        {
                            change_operation();
                        }
                        operation_type = "-";
                       
                        done_operation = true;
                        show_equasion();
                        break;
                    }
                case "*": {
                        if (basic_checker()) return;
                        if (operation_type == "+" || (number.Count == 2 && number[1] != "0"))
                        {
                            change_operation();
                        }
                        if ((number[0] != "0" || number[0] != "0.") && operation_type != "")
                        {
                            change_operation();
                        }
                        operation_type = "*";
                        
                        done_operation = true;
                        show_equasion();
                        break;
                    }
                case "/": {
                        if (basic_checker()) return;
                        if (operation_type == "+" || (number.Count == 2 && number[1] != "0"))
                        {
                            change_operation();
                        }
                        if ((number[0] != "0" || number[0] != "0.") && operation_type != "")
                        {
                            change_operation();
                        }
                        operation_type = "/";
                        
                        done_operation = true;
                        show_equasion();
                        break;
                    }
                case "=":
                    {
                        if (number.Count < 2) return;
                        OutBox.Text = "";
                        OutBox.ResetText();
                        do_math();
                        OutBox.AppendText(Convert.ToString(result));
                        show_equasion(choice);
                        reset_calculator();
                        break;
                    }
                case "0":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "1":
                    {
                        if (done_operation) after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "2":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "3":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "4":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "5":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "6":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "7":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "8":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case "9":
                    {
                        if(done_operation)after_operation();
                        add_number_to_string(choice);
                        break;
                    }
                case ".":
                    {
                        if (number[index].Contains(",")) return;
                        if (number[index] == "") number[index] = "0,";
                        else number[index] += ",";
                        OutBox.Text = number[index];
                        break;
                    }
                case "C":
                    {
                        OutBox.Text = "0";
                        reset_calculator();
                        show_equasion();
                        break;
                    }
                case "CE":
                    {
                        //OutBox.Text = choice;
                        number[index] = "0";
                        OutBox.Text = number[index];
                        show_equasion();
                        break;
                    }
                case "DEL":
                    {
                        //OutBox.Text = choice;
                        if (number[index].Length != 0)
                        {
                            number[index] = number[index].Substring(0, number[index].Length - 1);
                        }
                        if (number[index] == "") number[index] = "0";
                        OutBox.Text = number[index];
                        show_equasion();
                        break;
                    }
                default:
                    {
                        OutBox.Text = "ERROR: " + choice;
                        break;
                    }
            }


        }

        //Whenever buttons with numbers are clicked, this method appends string with clicked number
        private void add_number_to_string(String text)
        {
            //if index > number of elements in list, add new element to the list
            if(index == number.Count())
            {
                number.Add(text);
                return;
            }


            //Append string with chosen number and print result on screen
            if (!string_is_only_0(text))
            {
                number[index] += text;
                OutBox.Text = number[index];
                return;
            }
            //If 
            number[index] = text;
            OutBox.Text = number[index];

        }

        //checks if strings is a "0"
        private bool string_is_only_0(string text)
        {
            if (number[index] == "0")
            {
                return true;
            }
            return false;
        }

        //Adds new item to the list
        private void new_list_item()
        {
            number.Add("0");
        }
        
        //This makes this calculator work like windows calculator, whevener you click on different operation
        //this method will count current equasion and set 1st item in the list to result of equasion
        //then reset everything else that is, other items in list, index and current_operation
        private void change_operation()
        {
            do_math();
            double temp = result;
            reset_calculator();
            number[index] = Convert.ToString(temp);
            number.Add("0");
            index++;
        }

        //if math operation was done this method will reset output box and set it's value to "" which clears a box
        private void after_operation()
        {
            OutBox.ResetText();
            OutBox.Text = "";
            done_operation = false;
        }

        //this prevents most of erros, for example: when you try to do operations with no items in list
        private bool basic_checker()
        {
            if (number[0] == "") return true;
            if (number.Count != 0)
            {
                new_list_item();
                OutBox.Text = "";
                OutBox.ResetText();
                index++;
                return false;
            }
            return false;
        }

        //method resets calculator that is: clears the list, set index and result to 0 
        private void reset_calculator()
        {
            number.Clear();
            new_list_item();
            index = 0;
            result = 0;
            done_operation = true;
        }

        //Shows current equasion
        private void show_equasion(string optional = "")
        {
            string text = "";
            foreach(string n in number)
            {
                text += n+" ";
                text += operation_type + " ";
            }
            text = text.Substring(0, text.Length - 2);
            text += optional;
            equasion.Text = text;
        }

        //if you click equal sign or any other math operation sign, this method will simply solve equation
        private void do_math()
        {
            switch (operation_type)
            {
                case "+": {
                        foreach(String num in number)
                        {
                            result += Convert.ToDouble(num);
                        }
                        break;
                    }
                case "-": {
                        result = Convert.ToDouble(number[0]) - Convert.ToDouble(number[1]);

                        break;
                    }
                case "*": {
                        result = Convert.ToDouble(number[0]) * Convert.ToDouble(number[1]);
                        break;
                    }
                case "/":
                    {
                        try
                        {
                            result = Convert.ToDouble(number[0]) / Convert.ToDouble(number[1]);
                        }
                        catch (DivideByZeroException)
                        {
                            OutBox.Text = "You can't divide by zero";
                            reset_calculator();
                        }
                        break;
                    }
                default:
                    {
                        OutBox.AppendText("YEP");
                        break;
                    }
            }

            

        }

        
    }
}