namespace Calculator
{
    public partial class Form1 : Form
    {
        List<string> number = new List<string>();
        double result=0;
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            number.Add("");
            
        }

        private void b_Click(object sender, EventArgs e)
        {
            string choice = sender.ToString();
            choice = choice.Substring(35 ,1);

            switch (choice)
            {
                case "+": {
                        //when your first number is null or nan, it will skip this input
                        if (number[0] == "") return;
                        //when number on specific index is not null or nan, it will reset output box and increase working index;
                        //when both numbers are not null or nan it will proceed to execute Add operation
                        foreach(string s in number)
                        {
                            result += Convert.ToDouble(s);
                        }
                        OutBox.ResetText();
                        OutBox.AppendText(Convert.ToString(result));
                        //index++;

                        break;
                    }
                case "-": {
                        if (number[0] == "") return;
                        break;
                    }
                case "*": {
                        if (number[0] == "") return;
                        break;
                    }
                case "/": {
                        if (number[0] == "") return;
                        break;
                    }
                case "0":
                    {
                        if (number[index] == "0") return;
                        number[index] += "0";
                        break;
                    }
                case "1":
                    {
                        if (number[index] == "0")
                        {
                            number[index] = "1";
                            return;
                        }
                        number[index] += "1";
                        break;
                    }
                case "2":
                    {
                        break;
                    }
                case "3":
                    {
                        break;
                    }
                case "4":
                    {
                        break;
                    }
                case "5":
                    {
                        break;
                    }
                case "6":
                    {
                        break;
                    }
                case "7":
                    {
                        break;
                    }
                case "8":
                    {
                        break;
                    }
                case "9":
                    {
                        break;
                    }
                case ".":
                    {
                        break;
                    }
            }


        }

        private void show(String text)
        {
            OutBox.ResetText();
            OutBox.AppendText(Convert.ToString(text));
        }

    }
}