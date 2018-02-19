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
    public partial class Form1 : Form
    {
        //global value of the result to use throughout the program
        private double result;
       
        //making the input string used for number 1 and number 2
        private string input;

        public Form1()
        {
            InitializeComponent();
        }

        private Button OneButton;
        private Button TwoButton;
        private Button ThreeButton;
        private Button FourButton;
        private Button FiveButton;
        private Button SixButton;
        private Button SevenButton;
        private Button EightButton;
        private Button NineButton;
        private Button ZeroButton;
        private Button AddButton;
        private Button SubtractButton;
        private Button ClearButton;
        private Button EqualsButton;
        private TextBox DisplayBox;

        private void InitializeComponent()
        {
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.DivideButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(12, 60);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(50, 50);
            this.OneButton.TabIndex = 0;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(68, 60);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(50, 50);
            this.TwoButton.TabIndex = 1;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(124, 60);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(50, 50);
            this.ThreeButton.TabIndex = 2;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(12, 116);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(50, 50);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(68, 116);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(50, 50);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(124, 116);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(50, 50);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(12, 172);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(50, 50);
            this.SevenButton.TabIndex = 6;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(68, 172);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(50, 50);
            this.EightButton.TabIndex = 7;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(124, 172);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(50, 50);
            this.NineButton.TabIndex = 8;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(68, 228);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(50, 50);
            this.ZeroButton.TabIndex = 9;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(231, 60);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(72, 50);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(231, 116);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(72, 50);
            this.SubtractButton.TabIndex = 11;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(231, 9);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(72, 45);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(310, 60);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(72, 218);
            this.EqualsButton.TabIndex = 13;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBox.Location = new System.Drawing.Point(13, 10);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(212, 44);
            this.DisplayBox.TabIndex = 14;
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(231, 172);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(72, 50);
            this.DivideButton.TabIndex = 15;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(124, 228);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(50, 50);
            this.DotButton.TabIndex = 16;
            this.DotButton.Text = ",";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(385, 300);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //the buttons that control the numbers, add, subtract and equals
        private void OneButton_Click(object sender, EventArgs e)
        {
            input  = input + "1";
            DisplayBox.Text = input;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            input = input + "2";
            DisplayBox.Text = input;
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            input = input + "3";
            DisplayBox.Text = input;
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            input = input + "4";
            DisplayBox.Text = input;
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            input = input + "5";
            DisplayBox.Text = input;
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            input = input + "6";
            DisplayBox.Text = input;
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            input = input + "7";
            DisplayBox.Text = input;
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            input = input + "8";
            DisplayBox.Text = input;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            input = input + "9";
            DisplayBox.Text = input;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            input = input + "0";
            DisplayBox.Text = input;
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            input = input + ",";
            DisplayBox.Text = input;
        }



        //making the array to hold the numbers for calculation
        double[] firstNumber = new double[] { 0.0 , 1.0};

        //setting the string retrieval of the input on the screen
        string output;

        //making the bools to set the method of calculation
        bool addUp    = false;
        bool subTract = false;
        bool divide   = false;

        //setting conditions for setting the first number and the switch operator
        private void AddButton_Click(object sender, EventArgs e)
        {
           if(input == null)
            {
                firstNumber[0] = 0;
            }
            else
            {
                try
                {
                    firstNumber[0] = Convert.ToDouble(input);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong entry.Try again!");
                }
            }

            output = "+";
            addUp = true;
            subTract = false;

            EqualsButton.Click += EqualsButton_Click;
            DisplayBox.Text = String.Empty;
            input = "";
        }

        //setting conditions for setting the first number and the switch operator
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if(input == null)
            {
                firstNumber[0] = 0;
            }
            else
            {
                try
                {
                    firstNumber[0] = Convert.ToDouble(input);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong entry.Try again!");
                }
            }

            output = "-";
            subTract = true;
            addUp = false;
            divide = false;

            EqualsButton.Click += EqualsButton_Click;
            DisplayBox.Text = String.Empty;

            input = "";
        }

        //setting conditions for setting the first number and the switch operator
        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                firstNumber[0] = 0;
            }
            else
            {
                try
                {
                    firstNumber[0] = Convert.ToDouble(input);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Wrong entry.Try again!");
                }
            }
            output = "/";
            subTract = false;
            addUp = false;
            divide = true;

            EqualsButton.Click += EqualsButton_Click;
            DisplayBox.Text = String.Empty;

            input = "";

        }

        //here the choice of operation is initialized
        //Setting the second number and calculations are made here
        private void EqualsButton_Click(object sender, EventArgs e)
        {

            try
            {
                string calcOption = output;
                switch (calcOption)
                {
                    //add up sequence
                    case "+":
                        addUp = true;
                            if (input == null)
                            {
                                DisplayBox.Text = String.Empty;
                            }

                            firstNumber[1] = Convert.ToDouble(input);
                            result = firstNumber[0] + firstNumber[1];
                            DisplayBox.Text = Convert.ToString(result);
                        break;

                     //subtract sequence
                    case "-":
                        subTract = true;
                            if (input == null)
                            {
                                DisplayBox.Text = String.Empty;
                            }
                            firstNumber[1] = Convert.ToDouble(input);
                            result = firstNumber[0] - firstNumber[1];
                            DisplayBox.Text = Convert.ToString(result);
                        break;

                    //divide sequence
                    case "/":
                        divide = true;
                            if(input == null)
                            {
                                DisplayBox.Text = String.Empty;
                            }
                            firstNumber[1] = Convert.ToDouble(input);
                            result = firstNumber[0] / firstNumber[1];
                            DisplayBox.Text = Convert.ToString(result);
                        break;
                       
                    // the clear section of the calculator
                    case "":
                            result = 0;
                            firstNumber[0] = 0;
                            firstNumber[1] = 0;
                            if (input == null)
                            {
                                input = "0";
                            }
                        break;

                    // when no input is given
                    default:
                        DisplayBox.Text = "Invalid Input";
                        break;
                }
            }
            catch(Exception)
            {
                output = "";
                MessageBox.Show("Wrong entry.Try again");
                EqualsButton.Click -= EqualsButton_Click;
            }

            EqualsButton.Click -= EqualsButton_Click;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
            input = String.Empty;
            //input = "0";
            //firstNumber[0] = 0;
            //firstNumber[1] = 0;
            output = "clear";
        }

        private Button DivideButton;
        private Button DotButton;

    }
}
