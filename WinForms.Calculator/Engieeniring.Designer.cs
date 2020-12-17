namespace SimpleCalculator
{
    partial class Engieeniring
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
            this.Square = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Cubic = new System.Windows.Forms.Button();
            this.SquareEquation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyExit
            // 
            this.KeyExit.Location = new System.Drawing.Point(283, 373);
            // 
            // KeyDate
            // 
            this.KeyDate.Location = new System.Drawing.Point(283, 310);
            this.KeyDate.Size = new System.Drawing.Size(90, 56);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.Size = new System.Drawing.Size(367, 35);
            // 
            // KeyClear
            // 
            this.KeyClear.Location = new System.Drawing.Point(283, 246);
            // 
            // KeyMinus
            // 
            this.KeyMinus.Location = new System.Drawing.Point(213, 374);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Location = new System.Drawing.Point(213, 436);
            this.KeyPlus.Size = new System.Drawing.Size(64, 58);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Location = new System.Drawing.Point(283, 438);
            this.KeyEqual.Size = new System.Drawing.Size(90, 56);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Location = new System.Drawing.Point(213, 310);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Location = new System.Drawing.Point(213, 246);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Location = new System.Drawing.Point(73, 437);
            // 
            // KeySign
            // 
            this.KeySign.Location = new System.Drawing.Point(143, 435);
            this.KeySign.Size = new System.Drawing.Size(64, 58);
            // 
            // KeyZero
            // 
            this.KeyZero.Location = new System.Drawing.Point(6, 437);
            // 
            // KeyNine
            // 
            this.KeyNine.Location = new System.Drawing.Point(143, 246);
            // 
            // KeyEight
            // 
            this.KeyEight.Location = new System.Drawing.Point(73, 249);
            // 
            // KeySeven
            // 
            this.KeySeven.Location = new System.Drawing.Point(3, 249);
            // 
            // KeySix
            // 
            this.KeySix.Location = new System.Drawing.Point(143, 310);
            // 
            // KeyFive
            // 
            this.KeyFive.Location = new System.Drawing.Point(73, 310);
            // 
            // KeyFour
            // 
            this.KeyFour.Location = new System.Drawing.Point(6, 310);
            // 
            // KeyThree
            // 
            this.KeyThree.Location = new System.Drawing.Point(143, 373);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Location = new System.Drawing.Point(73, 374);
            // 
            // KeyOne
            // 
            this.KeyOne.Location = new System.Drawing.Point(6, 374);
            // 
            // Square
            // 
            this.Square.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Square.ForeColor = System.Drawing.Color.Blue;
            this.Square.Location = new System.Drawing.Point(213, 185);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(64, 58);
            this.Square.TabIndex = 30;
            this.Square.TabStop = false;
            this.Square.Text = "х²";
            this.Square.Click += new System.EventHandler(this.cmdSquareOfX_Click);
            // 
            // Reverse
            // 
            this.Reverse.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Reverse.ForeColor = System.Drawing.Color.Blue;
            this.Reverse.Location = new System.Drawing.Point(143, 185);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(64, 58);
            this.Reverse.TabIndex = 29;
            this.Reverse.TabStop = false;
            this.Reverse.Text = "1/x";
            this.Reverse.Click += new System.EventHandler(this.cmdGetReverseValue_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Sqrt.ForeColor = System.Drawing.Color.Blue;
            this.Sqrt.Location = new System.Drawing.Point(3, 185);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(64, 58);
            this.Sqrt.TabIndex = 28;
            this.Sqrt.TabStop = false;
            this.Sqrt.Text = "√x";
            this.Sqrt.Click += new System.EventHandler(this.cmdSqrtX_Click);
            // 
            // Degree
            // 
            this.Degree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Degree.ForeColor = System.Drawing.Color.Blue;
            this.Degree.Location = new System.Drawing.Point(73, 185);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(64, 58);
            this.Degree.TabIndex = 27;
            this.Degree.TabStop = false;
            this.Degree.Text = "xʸ";
            this.Degree.Click += new System.EventHandler(this.cmdXToThePowerOfY_Click);
            // 
            // Factorial
            // 
            this.Factorial.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Factorial.ForeColor = System.Drawing.Color.Blue;
            this.Factorial.Location = new System.Drawing.Point(3, 121);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(64, 58);
            this.Factorial.TabIndex = 31;
            this.Factorial.TabStop = false;
            this.Factorial.Text = "F*";
            this.Factorial.Click += new System.EventHandler(this.cmdFactorialX_Click);
            // 
            // Cubic
            // 
            this.Cubic.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Cubic.ForeColor = System.Drawing.Color.Blue;
            this.Cubic.Location = new System.Drawing.Point(73, 121);
            this.Cubic.Name = "Cubic";
            this.Cubic.Size = new System.Drawing.Size(64, 58);
            this.Cubic.TabIndex = 32;
            this.Cubic.TabStop = false;
            this.Cubic.Text = "∛x";
            this.Cubic.Click += new System.EventHandler(this.cmdSquareRootX_Click);
            // 
            // SquareEquation
            // 
            this.SquareEquation.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.SquareEquation.ForeColor = System.Drawing.Color.Blue;
            this.SquareEquation.Location = new System.Drawing.Point(143, 120);
            this.SquareEquation.Name = "SquareEquation";
            this.SquareEquation.Size = new System.Drawing.Size(230, 58);
            this.SquareEquation.TabIndex = 33;
            this.SquareEquation.TabStop = false;
            this.SquareEquation.Text = "Square root";
            this.SquareEquation.Click += new System.EventHandler(this.cmdSquareEquation_Click);
            // 
            // Engieeniring
            // 
            this.ClientSize = new System.Drawing.Size(383, 504);
            this.Controls.Add(this.SquareEquation);
            this.Controls.Add(this.Cubic);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Degree);
            this.Name = "Engieeniring";
            this.Text = "Engieeniring Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngeneersCalc_FormClosed);
            this.Load += new System.EventHandler(this.IngeneersCalc_Load);
            this.Controls.SetChildIndex(this.OutputDisplay, 0);
            this.Controls.SetChildIndex(this.KeyExit, 0);
            this.Controls.SetChildIndex(this.KeyClear, 0);
            this.Controls.SetChildIndex(this.KeyDate, 0);
            this.Controls.SetChildIndex(this.KeyEqual, 0);
            this.Controls.SetChildIndex(this.KeyPoint, 0);
            this.Controls.SetChildIndex(this.KeySign, 0);
            this.Controls.SetChildIndex(this.KeyDivide, 0);
            this.Controls.SetChildIndex(this.KeyMultiply, 0);
            this.Controls.SetChildIndex(this.KeyMinus, 0);
            this.Controls.SetChildIndex(this.KeyPlus, 0);
            this.Controls.SetChildIndex(this.KeyZero, 0);
            this.Controls.SetChildIndex(this.KeyNine, 0);
            this.Controls.SetChildIndex(this.KeyEight, 0);
            this.Controls.SetChildIndex(this.KeySeven, 0);
            this.Controls.SetChildIndex(this.KeySix, 0);
            this.Controls.SetChildIndex(this.KeyFive, 0);
            this.Controls.SetChildIndex(this.KeyFour, 0);
            this.Controls.SetChildIndex(this.KeyThree, 0);
            this.Controls.SetChildIndex(this.KeyTwo, 0);
            this.Controls.SetChildIndex(this.KeyOne, 0);
            this.Controls.SetChildIndex(this.Degree, 0);
            this.Controls.SetChildIndex(this.Sqrt, 0);
            this.Controls.SetChildIndex(this.Reverse, 0);
            this.Controls.SetChildIndex(this.Square, 0);
            this.Controls.SetChildIndex(this.Factorial, 0);
            this.Controls.SetChildIndex(this.Cubic, 0);
            this.Controls.SetChildIndex(this.SquareEquation, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Cubic;
        private System.Windows.Forms.Button SquareEquation;
    }
}
