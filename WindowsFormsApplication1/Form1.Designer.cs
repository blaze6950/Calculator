namespace WindowsFormsApplication1
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.clear = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.resultsView = new System.Windows.Forms.TextBox();
            this.not = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.memoryClean = new System.Windows.Forms.Button();
            this.memoryRead = new System.Windows.Forms.Button();
            this.memorySave = new System.Windows.Forms.Button();
            this.memoryPlus = new System.Windows.Forms.Button();
            this.memoryMinus = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.denominator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(13, 117);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(187, 40);
            this.clear.TabIndex = 0;
            this.clear.TabStop = false;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.clear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(208, 165);
            this.division.Margin = new System.Windows.Forms.Padding(4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(57, 40);
            this.division.TabIndex = 12;
            this.division.TabStop = false;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            this.division.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.division.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(208, 213);
            this.multiply.Margin = new System.Windows.Forms.Padding(4);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(57, 40);
            this.multiply.TabIndex = 13;
            this.multiply.TabStop = false;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            this.multiply.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.multiply.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(208, 261);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(57, 40);
            this.minus.TabIndex = 14;
            this.minus.TabStop = false;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            this.minus.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.minus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(208, 309);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(57, 40);
            this.plus.TabIndex = 15;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            this.plus.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.plus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(143, 165);
            this.nine.Margin = new System.Windows.Forms.Padding(4);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(57, 40);
            this.nine.TabIndex = 3;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            this.nine.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.nine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(78, 165);
            this.eight.Margin = new System.Windows.Forms.Padding(4);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(57, 40);
            this.eight.TabIndex = 2;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            this.eight.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.eight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(13, 165);
            this.seven.Margin = new System.Windows.Forms.Padding(4);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(57, 40);
            this.seven.TabIndex = 1;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            this.seven.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.seven.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(143, 213);
            this.six.Margin = new System.Windows.Forms.Padding(4);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(57, 40);
            this.six.TabIndex = 6;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            this.six.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.six.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(78, 213);
            this.five.Margin = new System.Windows.Forms.Padding(4);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(57, 40);
            this.five.TabIndex = 5;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            this.five.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.five.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(13, 213);
            this.four.Margin = new System.Windows.Forms.Padding(4);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(57, 40);
            this.four.TabIndex = 4;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            this.four.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.four.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(143, 261);
            this.three.Margin = new System.Windows.Forms.Padding(4);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(57, 40);
            this.three.TabIndex = 9;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            this.three.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.three.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(78, 261);
            this.two.Margin = new System.Windows.Forms.Padding(4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(57, 40);
            this.two.TabIndex = 8;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            this.two.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.two.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(13, 261);
            this.one.Margin = new System.Windows.Forms.Padding(4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(57, 40);
            this.one.TabIndex = 7;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            this.one.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.one.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(273, 261);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(57, 88);
            this.result.TabIndex = 18;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            this.result.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(143, 309);
            this.dot.Margin = new System.Windows.Forms.Padding(4);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(57, 40);
            this.dot.TabIndex = 11;
            this.dot.TabStop = false;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            this.dot.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.dot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(13, 309);
            this.zero.Margin = new System.Windows.Forms.Padding(4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(122, 40);
            this.zero.TabIndex = 10;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            this.zero.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.zero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // resultsView
            // 
            this.resultsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsView.Location = new System.Drawing.Point(13, 14);
            this.resultsView.Margin = new System.Windows.Forms.Padding(4);
            this.resultsView.Name = "resultsView";
            this.resultsView.ReadOnly = true;
            this.resultsView.Size = new System.Drawing.Size(317, 47);
            this.resultsView.TabIndex = 19;
            this.resultsView.TabStop = false;
            this.resultsView.Text = "0";
            this.resultsView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // not
            // 
            this.not.Location = new System.Drawing.Point(208, 117);
            this.not.Margin = new System.Windows.Forms.Padding(4);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(57, 40);
            this.not.TabIndex = 16;
            this.not.TabStop = false;
            this.not.Text = "±";
            this.not.UseVisualStyleBackColor = true;
            this.not.Click += new System.EventHandler(this.not_Click);
            this.not.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.not.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(273, 117);
            this.sqrt.Margin = new System.Windows.Forms.Padding(4);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(57, 40);
            this.sqrt.TabIndex = 17;
            this.sqrt.TabStop = false;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            this.sqrt.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.sqrt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // memoryClean
            // 
            this.memoryClean.Location = new System.Drawing.Point(13, 69);
            this.memoryClean.Margin = new System.Windows.Forms.Padding(4);
            this.memoryClean.Name = "memoryClean";
            this.memoryClean.Size = new System.Drawing.Size(57, 40);
            this.memoryClean.TabIndex = 20;
            this.memoryClean.TabStop = false;
            this.memoryClean.Text = "MC";
            this.memoryClean.UseVisualStyleBackColor = true;
            this.memoryClean.Click += new System.EventHandler(this.memoryClean_Click);
            this.memoryClean.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.memoryClean.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // memoryRead
            // 
            this.memoryRead.Location = new System.Drawing.Point(78, 69);
            this.memoryRead.Margin = new System.Windows.Forms.Padding(4);
            this.memoryRead.Name = "memoryRead";
            this.memoryRead.Size = new System.Drawing.Size(57, 40);
            this.memoryRead.TabIndex = 21;
            this.memoryRead.TabStop = false;
            this.memoryRead.Text = "MR";
            this.memoryRead.UseVisualStyleBackColor = true;
            this.memoryRead.Click += new System.EventHandler(this.memoryRead_Click);
            this.memoryRead.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.memoryRead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // memorySave
            // 
            this.memorySave.Location = new System.Drawing.Point(143, 69);
            this.memorySave.Margin = new System.Windows.Forms.Padding(4);
            this.memorySave.Name = "memorySave";
            this.memorySave.Size = new System.Drawing.Size(57, 40);
            this.memorySave.TabIndex = 22;
            this.memorySave.TabStop = false;
            this.memorySave.Text = "MS";
            this.memorySave.UseVisualStyleBackColor = true;
            this.memorySave.Click += new System.EventHandler(this.memorySave_Click);
            this.memorySave.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.memorySave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // memoryPlus
            // 
            this.memoryPlus.Location = new System.Drawing.Point(208, 69);
            this.memoryPlus.Margin = new System.Windows.Forms.Padding(4);
            this.memoryPlus.Name = "memoryPlus";
            this.memoryPlus.Size = new System.Drawing.Size(57, 40);
            this.memoryPlus.TabIndex = 23;
            this.memoryPlus.TabStop = false;
            this.memoryPlus.Text = "M+";
            this.memoryPlus.UseVisualStyleBackColor = true;
            this.memoryPlus.Click += new System.EventHandler(this.memoryPlus_Click);
            this.memoryPlus.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.memoryPlus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // memoryMinus
            // 
            this.memoryMinus.Location = new System.Drawing.Point(273, 69);
            this.memoryMinus.Margin = new System.Windows.Forms.Padding(4);
            this.memoryMinus.Name = "memoryMinus";
            this.memoryMinus.Size = new System.Drawing.Size(57, 40);
            this.memoryMinus.TabIndex = 24;
            this.memoryMinus.TabStop = false;
            this.memoryMinus.Text = "M-";
            this.memoryMinus.UseVisualStyleBackColor = true;
            this.memoryMinus.Click += new System.EventHandler(this.memoryMinus_Click);
            this.memoryMinus.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.memoryMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(273, 165);
            this.percent.Margin = new System.Windows.Forms.Padding(4);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(57, 40);
            this.percent.TabIndex = 25;
            this.percent.TabStop = false;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            this.percent.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.percent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // denominator
            // 
            this.denominator.Location = new System.Drawing.Point(273, 213);
            this.denominator.Margin = new System.Windows.Forms.Padding(4);
            this.denominator.Name = "denominator";
            this.denominator.Size = new System.Drawing.Size(57, 40);
            this.denominator.TabIndex = 26;
            this.denominator.TabStop = false;
            this.denominator.Text = "1/x";
            this.denominator.UseVisualStyleBackColor = true;
            this.denominator.Click += new System.EventHandler(this.denominator_Click);
            this.denominator.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.denominator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 362);
            this.Controls.Add(this.denominator);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.memoryMinus);
            this.Controls.Add(this.memoryPlus);
            this.Controls.Add(this.memorySave);
            this.Controls.Add(this.memoryRead);
            this.Controls.Add(this.memoryClean);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.not);
            this.Controls.Add(this.resultsView);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.division);
            this.Controls.Add(this.clear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.TextBox resultsView;
        private System.Windows.Forms.Button not;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button memoryClean;
        private System.Windows.Forms.Button memoryRead;
        private System.Windows.Forms.Button memorySave;
        private System.Windows.Forms.Button memoryPlus;
        private System.Windows.Forms.Button memoryMinus;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button denominator;
    }
}

