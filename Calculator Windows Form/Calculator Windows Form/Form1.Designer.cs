namespace Calculator_Windows_Form
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
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.squareRootButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(99, 12);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.ReadOnly = true;
            this.InputTextbox.Size = new System.Drawing.Size(116, 20);
            this.InputTextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(99, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(182, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 161);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            this.button7.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(99, 161);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            this.button8.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(182, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 45);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            this.button9.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(14, 212);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(55, 45);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.ClearButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(99, 212);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(55, 45);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button1_Click);
            this.button0.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button0.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(182, 212);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(55, 45);
            this.DecimalButton.TabIndex = 12;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.button1_Click);
            this.DecimalButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.DecimalButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(249, 210);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(68, 47);
            this.EqualButton.TabIndex = 16;
            this.EqualButton.Text = "==";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            this.EqualButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.EqualButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(289, 99);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(28, 31);
            this.SubtractButton.TabIndex = 17;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.AddButton_Click);
            this.SubtractButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.SubtractButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(249, 136);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(28, 31);
            this.MultiplyButton.TabIndex = 18;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.AddButton_Click);
            this.MultiplyButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.MultiplyButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(289, 136);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(28, 31);
            this.DivideButton.TabIndex = 19;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.AddButton_Click);
            this.DivideButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.DivideButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(249, 99);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(28, 31);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Location = new System.Drawing.Point(249, 59);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(68, 34);
            this.BackspaceButton.TabIndex = 21;
            this.BackspaceButton.Text = "<------";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            this.BackspaceButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.BackspaceButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(249, 173);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(28, 31);
            this.SquareButton.TabIndex = 22;
            this.SquareButton.Text = "x²";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.AddButton_Click);
            this.SquareButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.SquareButton.MouseHover += new System.EventHandler(this.button1_MouseLeave);
            // 
            // squareRootButton
            // 
            this.squareRootButton.Location = new System.Drawing.Point(289, 173);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.Size = new System.Drawing.Size(28, 31);
            this.squareRootButton.TabIndex = 23;
            this.squareRootButton.Text = "√";
            this.squareRootButton.UseVisualStyleBackColor = true;
            this.squareRootButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.squareRootButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button squareRootButton;
    }
}

