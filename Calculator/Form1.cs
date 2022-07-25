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
            string choice = sender.ToString();
            choice = choice.Substring(35 ,choice.Length-35);

            switch (choice)
            {
                case "+": {
                        if(basic_checker())return;
                        operation_type = "+";
                        //math_was_done();
                        done_operation = true;
                        break;
                    }
                case "-": {
                        basic_checker();
                        operation_type = "-";
                        math_was_done();
                        done_operation = true;
                        break;
                    }
                case "*": {
                        basic_checker();
                        operation_type = "*";
                        math_was_done();
                        done_operation = true;
                        break;
                    }
                case "/": {
                        basic_checker();
                        operation_type = "/";
                        math_was_done();
                        done_operation = true;
                        break;
                    }
                case "=":
                    {
                        if (number.Count < 2) return;
                        OutBox.Text = "";
                        OutBox.ResetText();
                        do_math();
                        OutBox.AppendText(Convert.ToString(result));
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
                        OutBox.Text = choice;
                        break;
                    }
                case "C":
                    {
                        OutBox.Text = choice;
                        break;
                    }
                case "CE":
                    {
                        OutBox.Text = choice;
                        break;
                    }
                case "DEL":
                    {
                        OutBox.Text = choice;
                        break;
                    }
                default:
                    {
                        OutBox.Text = "ERROR: " + choice;
                        break;
                    }
            }


        }


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
                OutBox.AppendText(text);
                return;
            }
            //If 
            number[index] = text;
            OutBox.AppendText(text);

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

        private void new_list_item()
        {
            number.Add("0");
        }
        
        private void after_operation()
        {
            OutBox.ResetText();
            OutBox.Text = "";
            done_operation = false;
        }

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

        private void math_was_done()
        {
            OutBox.ResetText();
            //OutBox.AppendText(Convert.ToString(result));
            number.Clear();
            number.Add(Convert.ToString(result));
            new_list_item();
        }

        private void reset_calculator()
        {
            number.Clear();
            new_list_item();
            index = 0;
            result = 0;
            done_operation = true;
        }

        private void do_math()
        {
            switch (operation_type)
            {
                case "+": {
                        //OutBox.AppendText($"{Convert.ToDouble(number[0])}+{Convert.ToDouble(number[1])}");
                        //result = Convert.ToDouble(number[0]) + Convert.ToDouble(number[1]);
                        foreach(String num in number)
                        {
                            result += Convert.ToDouble(num);
                        }
                        break;
                    }
                case "-": {
                        OutBox.AppendText("-");
                        result = Convert.ToDouble(number[0]) - Convert.ToDouble(number[1]);
                        break;
                    }
                case "*": {
                        OutBox.AppendText("*");
                        result = Convert.ToDouble(number[0]) * Convert.ToDouble(number[1]);
                        break;
                    }
                case "/":
                    {
                        OutBox.AppendText("/");
                        result = Convert.ToDouble(number[0]) / Convert.ToDouble(number[1]);
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