﻿namespace _123
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.zadanaMoc = new System.Windows.Forms.NumericUpDown();
            this.ProcentMocyZn = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zadanaMoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcentMocyZn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tworzenie obiektu klasy samochód";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "wlasciwosci";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "tech przec operatora +";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(128, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(349, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Stworz samochod z podana moca";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // zadanaMoc
            // 
            this.zadanaMoc.Location = new System.Drawing.Point(484, 301);
            this.zadanaMoc.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.zadanaMoc.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.zadanaMoc.Name = "zadanaMoc";
            this.zadanaMoc.Size = new System.Drawing.Size(120, 20);
            this.zadanaMoc.TabIndex = 4;
            this.zadanaMoc.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // ProcentMocyZn
            // 
            this.ProcentMocyZn.Location = new System.Drawing.Point(483, 327);
            this.ProcentMocyZn.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ProcentMocyZn.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.ProcentMocyZn.Name = "ProcentMocyZn";
            this.ProcentMocyZn.Size = new System.Drawing.Size(120, 20);
            this.ProcentMocyZn.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(128, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(349, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "O ile procent cmienićmoc znamionową pojazdu?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Moc Znamionowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zmiana mocy o procent znamionowej";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(113, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(275, 39);
            this.button7.TabIndex = 8;
            this.button7.Text = "Dodawanie trzech przebiegow";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(395, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(267, 38);
            this.button8.TabIndex = 9;
            this.button8.Text = "Dodawanie czterech przebiegow";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(395, 357);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(267, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "dziedziczenie";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ProcentMocyZn);
            this.Controls.Add(this.zadanaMoc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zadanaMoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcentMocyZn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown zadanaMoc;
        private System.Windows.Forms.NumericUpDown ProcentMocyZn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button9;
    }
}

