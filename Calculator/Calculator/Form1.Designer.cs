
namespace Calculator
{
    partial class Form1
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
            this.one = new System.Windows.Forms.Button();
            this.Output_Screen = new System.Windows.Forms.TextBox();
            this.Three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Gray;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.Color.White;
            this.one.Location = new System.Drawing.Point(14, 51);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 49);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Button_Click_1);
            // 
            // Output_Screen
            // 
            this.Output_Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Screen.Location = new System.Drawing.Point(14, 11);
            this.Output_Screen.Multiline = true;
            this.Output_Screen.Name = "Output_Screen";
            this.Output_Screen.Size = new System.Drawing.Size(218, 33);
            this.Output_Screen.TabIndex = 1;
            this.Output_Screen.Text = "0";
            this.Output_Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.Gray;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.ForeColor = System.Drawing.Color.White;
            this.Three.Location = new System.Drawing.Point(126, 51);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(50, 49);
            this.Three.TabIndex = 2;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Button_Click_3);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Gray;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.Color.White;
            this.two.Location = new System.Drawing.Point(70, 51);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 49);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Button_Click_2);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.IndianRed;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(182, 51);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 49);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "AC";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Button_Clear);
            // 
            // Mul
            // 
            this.Mul.BackColor = System.Drawing.Color.SlateGray;
            this.Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mul.ForeColor = System.Drawing.Color.White;
            this.Mul.Location = new System.Drawing.Point(182, 219);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(50, 49);
            this.Mul.TabIndex = 16;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = false;
            this.Mul.Click += new System.EventHandler(this.Multiplication);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.Gray;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.ForeColor = System.Drawing.Color.White;
            this.Zero.Location = new System.Drawing.Point(14, 219);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(106, 49);
            this.Zero.TabIndex = 15;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.Color.Gray;
            this.Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals.ForeColor = System.Drawing.Color.White;
            this.Equals.Location = new System.Drawing.Point(70, 275);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(106, 49);
            this.Equals.TabIndex = 14;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.Button_Equal);
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.Color.Gray;
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.ForeColor = System.Drawing.Color.White;
            this.Decimal.Location = new System.Drawing.Point(126, 219);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(50, 49);
            this.Decimal.TabIndex = 13;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = false;
            this.Decimal.Click += new System.EventHandler(this.Button_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.SlateGray;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(182, 107);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 49);
            this.Add.TabIndex = 20;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Additon);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.Gray;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.ForeColor = System.Drawing.Color.White;
            this.Five.Location = new System.Drawing.Point(70, 107);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 49);
            this.Five.TabIndex = 19;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Button_Click_5);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.Gray;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.ForeColor = System.Drawing.Color.White;
            this.Six.Location = new System.Drawing.Point(126, 107);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 49);
            this.Six.TabIndex = 18;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Button_Click_6);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.Gray;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.ForeColor = System.Drawing.Color.White;
            this.Four.Location = new System.Drawing.Point(14, 107);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 49);
            this.Four.TabIndex = 17;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Button_Click_4);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.SlateGray;
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.ForeColor = System.Drawing.Color.White;
            this.Sub.Location = new System.Drawing.Point(182, 163);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(50, 49);
            this.Sub.TabIndex = 24;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Subtraction);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.Gray;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.ForeColor = System.Drawing.Color.White;
            this.Eight.Location = new System.Drawing.Point(70, 163);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(50, 49);
            this.Eight.TabIndex = 23;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Button_Click_8);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.Gray;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.ForeColor = System.Drawing.Color.White;
            this.Nine.Location = new System.Drawing.Point(126, 163);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(50, 49);
            this.Nine.TabIndex = 22;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Button_Click_9);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.Gray;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.ForeColor = System.Drawing.Color.White;
            this.Seven.Location = new System.Drawing.Point(14, 163);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 49);
            this.Seven.TabIndex = 21;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Button_Click_7);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.SlateGray;
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.ForeColor = System.Drawing.Color.White;
            this.Div.Location = new System.Drawing.Point(182, 273);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(50, 49);
            this.Div.TabIndex = 25;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Divison);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Gray;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(14, 273);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(50, 49);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "DEL";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Button_Delete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 333);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.two);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Output_Screen);
            this.Controls.Add(this.one);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.TextBox Output_Screen;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Delete;
    }
}

