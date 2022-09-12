
namespace Stopwatch
{
    partial class Stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.Mintes = new System.Windows.Forms.Label();
            this.Colon = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Milliseconds = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Mintes
            // 
            this.Mintes.AutoSize = true;
            this.Mintes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mintes.Location = new System.Drawing.Point(208, 54);
            this.Mintes.Name = "Mintes";
            this.Mintes.Size = new System.Drawing.Size(66, 46);
            this.Mintes.TabIndex = 0;
            this.Mintes.Text = "00";
            // 
            // Colon
            // 
            this.Colon.AutoSize = true;
            this.Colon.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colon.Location = new System.Drawing.Point(270, 54);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(32, 46);
            this.Colon.TabIndex = 1;
            this.Colon.Text = ":";
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.Location = new System.Drawing.Point(298, 54);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(66, 46);
            this.Seconds.TabIndex = 2;
            this.Seconds.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = ".";
            // 
            // Milliseconds
            // 
            this.Milliseconds.AutoSize = true;
            this.Milliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Milliseconds.Location = new System.Drawing.Point(370, 63);
            this.Milliseconds.Name = "Milliseconds";
            this.Milliseconds.Size = new System.Drawing.Size(55, 37);
            this.Milliseconds.TabIndex = 4;
            this.Milliseconds.Text = "00";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(162, 133);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 38);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(278, 133);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 38);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(394, 133);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 38);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(159, 198);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(321, 15);
            this.progressBar1.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(670, 250);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Milliseconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Colon);
            this.Controls.Add(this.Mintes);
            this.MaximizeBox = false;
            this.Name = "Stopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mintes;
        private System.Windows.Forms.Label Colon;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Milliseconds;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
    }
}

