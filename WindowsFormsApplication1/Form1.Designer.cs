using System.Windows.Forms;

namespace SimpleCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ONE = new System.Windows.Forms.Button();
            this.TWO = new System.Windows.Forms.Button();
            this.THREE = new System.Windows.Forms.Button();
            this.FOUR = new System.Windows.Forms.Button();
            this.FIVE = new System.Windows.Forms.Button();
            this.SIX = new System.Windows.Forms.Button();
            this.SEVEN = new System.Windows.Forms.Button();
            this.EIGHT = new System.Windows.Forms.Button();
            this.NINE = new System.Windows.Forms.Button();
            this.ZERO = new System.Windows.Forms.Button();
            this.DECIMAL = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.DIVISION = new System.Windows.Forms.Button();
            this.MULTIPLY = new System.Windows.Forms.Button();
            this.SUBTRACTION = new System.Windows.Forms.Button();
            this.ADDITION = new System.Windows.Forms.Button();
            this.POWER = new System.Windows.Forms.Button();
            this.ENTER = new System.Windows.Forms.Button();
            this.LEFT_PARENTHESES = new System.Windows.Forms.Button();
            this.RIGHT_PARENTHESES = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.COSINE = new System.Windows.Forms.Button();
            this.SINE = new System.Windows.Forms.Button();
            this.TANGENT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // ONE
            // 
            this.ONE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONE.Location = new System.Drawing.Point(108, 74);
            this.ONE.Name = "ONE";
            this.ONE.Size = new System.Drawing.Size(90, 52);
            this.ONE.TabIndex = 1;
            this.ONE.Text = "1";
            this.ONE.UseVisualStyleBackColor = true;
            this.ONE.Click += new System.EventHandler(this.button1_Click);
            // 
            // TWO
            // 
            this.TWO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWO.Location = new System.Drawing.Point(204, 74);
            this.TWO.Name = "TWO";
            this.TWO.Size = new System.Drawing.Size(90, 52);
            this.TWO.TabIndex = 2;
            this.TWO.Text = "2";
            this.TWO.UseVisualStyleBackColor = true;
            this.TWO.Click += new System.EventHandler(this.button2_Click);
            // 
            // THREE
            // 
            this.THREE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.THREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THREE.Location = new System.Drawing.Point(300, 74);
            this.THREE.Name = "THREE";
            this.THREE.Size = new System.Drawing.Size(90, 52);
            this.THREE.TabIndex = 3;
            this.THREE.Text = "3";
            this.THREE.UseVisualStyleBackColor = true;
            this.THREE.Click += new System.EventHandler(this.THREE_Click);
            // 
            // FOUR
            // 
            this.FOUR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FOUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOUR.Location = new System.Drawing.Point(12, 132);
            this.FOUR.Name = "FOUR";
            this.FOUR.Size = new System.Drawing.Size(90, 52);
            this.FOUR.TabIndex = 4;
            this.FOUR.Text = "4";
            this.FOUR.UseVisualStyleBackColor = true;
            this.FOUR.Click += new System.EventHandler(this.FOUR_Click);
            // 
            // FIVE
            // 
            this.FIVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FIVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIVE.Location = new System.Drawing.Point(108, 132);
            this.FIVE.Name = "FIVE";
            this.FIVE.Size = new System.Drawing.Size(90, 52);
            this.FIVE.TabIndex = 5;
            this.FIVE.Text = "5";
            this.FIVE.UseVisualStyleBackColor = true;
            this.FIVE.Click += new System.EventHandler(this.FIVE_Click);
            // 
            // SIX
            // 
            this.SIX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SIX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIX.Location = new System.Drawing.Point(204, 132);
            this.SIX.Name = "SIX";
            this.SIX.Size = new System.Drawing.Size(90, 52);
            this.SIX.TabIndex = 6;
            this.SIX.Text = "6";
            this.SIX.UseVisualStyleBackColor = true;
            this.SIX.Click += new System.EventHandler(this.SIX_Click);
            // 
            // SEVEN
            // 
            this.SEVEN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SEVEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEVEN.Location = new System.Drawing.Point(300, 132);
            this.SEVEN.Name = "SEVEN";
            this.SEVEN.Size = new System.Drawing.Size(90, 52);
            this.SEVEN.TabIndex = 7;
            this.SEVEN.Text = "7";
            this.SEVEN.UseVisualStyleBackColor = true;
            this.SEVEN.Click += new System.EventHandler(this.SEVEN_Click);
            // 
            // EIGHT
            // 
            this.EIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIGHT.Location = new System.Drawing.Point(12, 190);
            this.EIGHT.Name = "EIGHT";
            this.EIGHT.Size = new System.Drawing.Size(90, 52);
            this.EIGHT.TabIndex = 8;
            this.EIGHT.Text = "8";
            this.EIGHT.UseVisualStyleBackColor = true;
            this.EIGHT.Click += new System.EventHandler(this.EIGHT_Click);
            // 
            // NINE
            // 
            this.NINE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NINE.Location = new System.Drawing.Point(108, 190);
            this.NINE.Name = "NINE";
            this.NINE.Size = new System.Drawing.Size(90, 52);
            this.NINE.TabIndex = 9;
            this.NINE.Text = "9";
            this.NINE.UseVisualStyleBackColor = true;
            this.NINE.Click += new System.EventHandler(this.NINE_Click);
            // 
            // ZERO
            // 
            this.ZERO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZERO.Location = new System.Drawing.Point(12, 74);
            this.ZERO.Name = "ZERO";
            this.ZERO.Size = new System.Drawing.Size(90, 52);
            this.ZERO.TabIndex = 10;
            this.ZERO.Text = "0";
            this.ZERO.UseVisualStyleBackColor = true;
            this.ZERO.Click += new System.EventHandler(this.ZERO_Click);
            // 
            // DECIMAL
            // 
            this.DECIMAL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DECIMAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DECIMAL.Location = new System.Drawing.Point(204, 190);
            this.DECIMAL.Name = "DECIMAL";
            this.DECIMAL.Size = new System.Drawing.Size(90, 52);
            this.DECIMAL.TabIndex = 11;
            this.DECIMAL.Text = ".";
            this.DECIMAL.UseVisualStyleBackColor = true;
            this.DECIMAL.Click += new System.EventHandler(this.DECIMAL_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(300, 190);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(90, 52);
            this.CLEAR.TabIndex = 12;
            this.CLEAR.Text = "Clear";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // DIVISION
            // 
            this.DIVISION.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DIVISION.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIVISION.Location = new System.Drawing.Point(12, 248);
            this.DIVISION.Name = "DIVISION";
            this.DIVISION.Size = new System.Drawing.Size(90, 52);
            this.DIVISION.TabIndex = 13;
            this.DIVISION.Text = "÷";
            this.DIVISION.UseVisualStyleBackColor = true;
            this.DIVISION.Click += new System.EventHandler(this.DIVISION_Click);
            // 
            // MULTIPLY
            // 
            this.MULTIPLY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MULTIPLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MULTIPLY.Location = new System.Drawing.Point(108, 248);
            this.MULTIPLY.Name = "MULTIPLY";
            this.MULTIPLY.Size = new System.Drawing.Size(90, 52);
            this.MULTIPLY.TabIndex = 14;
            this.MULTIPLY.Text = "*";
            this.MULTIPLY.UseVisualStyleBackColor = true;
            this.MULTIPLY.Click += new System.EventHandler(this.MULTIPLICATION_Click);
            // 
            // SUBTRACTION
            // 
            this.SUBTRACTION.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SUBTRACTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBTRACTION.Location = new System.Drawing.Point(204, 248);
            this.SUBTRACTION.Name = "SUBTRACTION";
            this.SUBTRACTION.Size = new System.Drawing.Size(90, 52);
            this.SUBTRACTION.TabIndex = 15;
            this.SUBTRACTION.Text = "-";
            this.SUBTRACTION.UseVisualStyleBackColor = true;
            this.SUBTRACTION.Click += new System.EventHandler(this.SUBTRACTION_Click);
            // 
            // ADDITION
            // 
            this.ADDITION.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADDITION.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDITION.Location = new System.Drawing.Point(300, 248);
            this.ADDITION.Name = "ADDITION";
            this.ADDITION.Size = new System.Drawing.Size(90, 52);
            this.ADDITION.TabIndex = 16;
            this.ADDITION.Text = "+";
            this.ADDITION.UseVisualStyleBackColor = true;
            this.ADDITION.Click += new System.EventHandler(this.ADDITION_Click);
            // 
            // POWER
            // 
            this.POWER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.POWER.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POWER.Location = new System.Drawing.Point(12, 306);
            this.POWER.Name = "POWER";
            this.POWER.Size = new System.Drawing.Size(90, 52);
            this.POWER.TabIndex = 17;
            this.POWER.Text = "^";
            this.POWER.UseVisualStyleBackColor = true;
            this.POWER.Click += new System.EventHandler(this.POWER_Click);
            // 
            // ENTER
            // 
            this.ENTER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ENTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENTER.Location = new System.Drawing.Point(302, 364);
            this.ENTER.Name = "ENTER";
            this.ENTER.Size = new System.Drawing.Size(90, 52);
            this.ENTER.TabIndex = 20;
            this.ENTER.Text = "Enter";
            this.ENTER.UseVisualStyleBackColor = true;
            this.ENTER.Click += new System.EventHandler(this.ENTER_Click);
            // 
            // LEFT_PARENTHESES
            // 
            this.LEFT_PARENTHESES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LEFT_PARENTHESES.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEFT_PARENTHESES.Location = new System.Drawing.Point(108, 306);
            this.LEFT_PARENTHESES.Name = "LEFT_PARENTHESES";
            this.LEFT_PARENTHESES.Size = new System.Drawing.Size(90, 52);
            this.LEFT_PARENTHESES.TabIndex = 21;
            this.LEFT_PARENTHESES.Text = "(";
            this.LEFT_PARENTHESES.UseVisualStyleBackColor = true;
            this.LEFT_PARENTHESES.Click += new System.EventHandler(this.LEFT_PARENTHESES_Click);
            // 
            // RIGHT_PARENTHESES
            // 
            this.RIGHT_PARENTHESES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RIGHT_PARENTHESES.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIGHT_PARENTHESES.Location = new System.Drawing.Point(204, 306);
            this.RIGHT_PARENTHESES.Name = "RIGHT_PARENTHESES";
            this.RIGHT_PARENTHESES.Size = new System.Drawing.Size(90, 52);
            this.RIGHT_PARENTHESES.TabIndex = 22;
            this.RIGHT_PARENTHESES.Text = ")";
            this.RIGHT_PARENTHESES.UseVisualStyleBackColor = true;
            this.RIGHT_PARENTHESES.Click += new System.EventHandler(this.RIGHT_PARENTHESES_Click);
            // 
            // DELETE
            // 
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(302, 306);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(90, 52);
            this.DELETE.TabIndex = 23;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // COSINE
            // 
            this.COSINE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.COSINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COSINE.Location = new System.Drawing.Point(12, 364);
            this.COSINE.Name = "COSINE";
            this.COSINE.Size = new System.Drawing.Size(90, 52);
            this.COSINE.TabIndex = 24;
            this.COSINE.Text = "cos()";
            this.COSINE.UseVisualStyleBackColor = true;
            this.COSINE.Click += new System.EventHandler(this.COSINE_Click);
            // 
            // SINE
            // 
            this.SINE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SINE.Location = new System.Drawing.Point(108, 364);
            this.SINE.Name = "SINE";
            this.SINE.Size = new System.Drawing.Size(90, 52);
            this.SINE.TabIndex = 25;
            this.SINE.Text = "sin()";
            this.SINE.UseVisualStyleBackColor = true;
            this.SINE.Click += new System.EventHandler(this.SINE_Click);
            // 
            // TANGENT
            // 
            this.TANGENT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TANGENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TANGENT.Location = new System.Drawing.Point(204, 364);
            this.TANGENT.Name = "TANGENT";
            this.TANGENT.Size = new System.Drawing.Size(90, 52);
            this.TANGENT.TabIndex = 26;
            this.TANGENT.Text = "tan()";
            this.TANGENT.UseVisualStyleBackColor = true;
            this.TANGENT.Click += new System.EventHandler(this.TANGENT_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 507);
            this.Controls.Add(this.TANGENT);
            this.Controls.Add(this.SINE);
            this.Controls.Add(this.COSINE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.RIGHT_PARENTHESES);
            this.Controls.Add(this.LEFT_PARENTHESES);
            this.Controls.Add(this.ENTER);
            this.Controls.Add(this.POWER);
            this.Controls.Add(this.ADDITION);
            this.Controls.Add(this.SUBTRACTION);
            this.Controls.Add(this.MULTIPLY);
            this.Controls.Add(this.DIVISION);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DECIMAL);
            this.Controls.Add(this.ZERO);
            this.Controls.Add(this.NINE);
            this.Controls.Add(this.EIGHT);
            this.Controls.Add(this.SEVEN);
            this.Controls.Add(this.SIX);
            this.Controls.Add(this.FIVE);
            this.Controls.Add(this.FOUR);
            this.Controls.Add(this.THREE);
            this.Controls.Add(this.TWO);
            this.Controls.Add(this.ONE);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "SimpleCalculator4.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ONE;
        private System.Windows.Forms.Button TWO;
        private System.Windows.Forms.Button THREE;
        private System.Windows.Forms.Button FOUR;
        private System.Windows.Forms.Button FIVE;
        private System.Windows.Forms.Button SIX;
        private System.Windows.Forms.Button SEVEN;
        private System.Windows.Forms.Button EIGHT;
        private System.Windows.Forms.Button NINE;
        private System.Windows.Forms.Button ZERO;
        private System.Windows.Forms.Button DECIMAL;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button DIVISION;
        private System.Windows.Forms.Button MULTIPLY;
        private System.Windows.Forms.Button SUBTRACTION;
        private System.Windows.Forms.Button ADDITION;
        private System.Windows.Forms.Button POWER;
        private System.Windows.Forms.Button ENTER;
        private System.Windows.Forms.Button LEFT_PARENTHESES;
        private System.Windows.Forms.Button RIGHT_PARENTHESES;
        private System.Windows.Forms.Button DELETE;
        private Button COSINE;
        private Button SINE;
        private Button TANGENT;
    }
}

