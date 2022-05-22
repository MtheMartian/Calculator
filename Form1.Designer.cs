namespace Calculator
{
    partial class cCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCalculator));
            this.calcDisplay = new System.Windows.Forms.TextBox();
            this.calcTitle = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.numAddition = new System.Windows.Forms.Button();
            this.numSubstract = new System.Windows.Forms.Button();
            this.numDecimal = new System.Windows.Forms.Button();
            this.numClear = new System.Windows.Forms.Button();
            this.numDivide = new System.Windows.Forms.Button();
            this.numMultiply = new System.Windows.Forms.Button();
            this.numEqual = new System.Windows.Forms.Button();
            this.calcExit = new System.Windows.Forms.Button();
            this.calcMinimize = new System.Windows.Forms.Button();
            this.calcProjector = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcDisplay
            // 
            this.calcDisplay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calcDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcDisplay.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDisplay.Location = new System.Drawing.Point(175, 200);
            this.calcDisplay.Multiline = true;
            this.calcDisplay.Name = "calcDisplay";
            this.calcDisplay.ReadOnly = true;
            this.calcDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calcDisplay.Size = new System.Drawing.Size(381, 27);
            this.calcDisplay.TabIndex = 0;
            this.calcDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calcDisplay.TextChanged += new System.EventHandler(this.calcDisplay_TextChanged);
            // 
            // calcTitle
            // 
            this.calcTitle.AutoSize = true;
            this.calcTitle.BackColor = System.Drawing.Color.Teal;
            this.calcTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calcTitle.Font = new System.Drawing.Font("Montserrat ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.calcTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calcTitle.Location = new System.Drawing.Point(243, 45);
            this.calcTitle.Name = "calcTitle";
            this.calcTitle.Size = new System.Drawing.Size(246, 57);
            this.calcTitle.TabIndex = 1;
            this.calcTitle.Text = "CALC 4ME";
            // 
            // num1
            // 
            this.num1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.Color.White;
            this.num1.Location = new System.Drawing.Point(12, 254);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(106, 73);
            this.num1.TabIndex = 2;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.btn_Click);
            // 
            // num2
            // 
            this.num2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.Color.White;
            this.num2.Location = new System.Drawing.Point(154, 254);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(106, 73);
            this.num2.TabIndex = 3;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.btn_Click);
            // 
            // num3
            // 
            this.num3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.Color.White;
            this.num3.Location = new System.Drawing.Point(12, 370);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(106, 73);
            this.num3.TabIndex = 4;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.btn_Click);
            // 
            // num4
            // 
            this.num4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.Color.White;
            this.num4.Location = new System.Drawing.Point(154, 370);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(106, 73);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.btn_Click);
            // 
            // num5
            // 
            this.num5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.Color.White;
            this.num5.Location = new System.Drawing.Point(12, 488);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(106, 73);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.btn_Click);
            // 
            // num6
            // 
            this.num6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.Color.White;
            this.num6.Location = new System.Drawing.Point(154, 488);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(106, 73);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.btn_Click);
            // 
            // num7
            // 
            this.num7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.Color.White;
            this.num7.Location = new System.Drawing.Point(12, 599);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(106, 73);
            this.num7.TabIndex = 8;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.btn_Click);
            // 
            // num8
            // 
            this.num8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.Color.White;
            this.num8.Location = new System.Drawing.Point(154, 599);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(106, 73);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.btn_Click);
            // 
            // num9
            // 
            this.num9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.Color.White;
            this.num9.Location = new System.Drawing.Point(302, 254);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(106, 73);
            this.num9.TabIndex = 10;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.btn_Click);
            // 
            // num0
            // 
            this.num0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.Color.White;
            this.num0.Location = new System.Drawing.Point(302, 370);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(106, 73);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.btn_Click);
            // 
            // numAddition
            // 
            this.numAddition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numAddition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numAddition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.numAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numAddition.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddition.ForeColor = System.Drawing.Color.White;
            this.numAddition.Location = new System.Drawing.Point(450, 254);
            this.numAddition.Name = "numAddition";
            this.numAddition.Size = new System.Drawing.Size(106, 73);
            this.numAddition.TabIndex = 12;
            this.numAddition.Text = "+";
            this.numAddition.UseVisualStyleBackColor = true;
            this.numAddition.Click += new System.EventHandler(this.operator_Click);
            // 
            // numSubstract
            // 
            this.numSubstract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numSubstract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numSubstract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.numSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numSubstract.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSubstract.ForeColor = System.Drawing.Color.White;
            this.numSubstract.Location = new System.Drawing.Point(450, 370);
            this.numSubstract.Name = "numSubstract";
            this.numSubstract.Size = new System.Drawing.Size(106, 73);
            this.numSubstract.TabIndex = 13;
            this.numSubstract.Text = "-";
            this.numSubstract.UseVisualStyleBackColor = true;
            this.numSubstract.Click += new System.EventHandler(this.operator_Click);
            // 
            // numDecimal
            // 
            this.numDecimal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numDecimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.numDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numDecimal.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDecimal.ForeColor = System.Drawing.Color.White;
            this.numDecimal.Location = new System.Drawing.Point(302, 488);
            this.numDecimal.Name = "numDecimal";
            this.numDecimal.Size = new System.Drawing.Size(106, 73);
            this.numDecimal.TabIndex = 14;
            this.numDecimal.Text = ".";
            this.numDecimal.UseVisualStyleBackColor = true;
            this.numDecimal.Click += new System.EventHandler(this.btn_Click);
            // 
            // numClear
            // 
            this.numClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.numClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numClear.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClear.ForeColor = System.Drawing.Color.White;
            this.numClear.Location = new System.Drawing.Point(603, 254);
            this.numClear.Name = "numClear";
            this.numClear.Size = new System.Drawing.Size(106, 318);
            this.numClear.TabIndex = 15;
            this.numClear.Text = "CE";
            this.numClear.UseVisualStyleBackColor = true;
            this.numClear.Click += new System.EventHandler(this.numClear_Click);
            // 
            // numDivide
            // 
            this.numDivide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.numDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numDivide.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDivide.ForeColor = System.Drawing.Color.White;
            this.numDivide.Location = new System.Drawing.Point(302, 599);
            this.numDivide.Name = "numDivide";
            this.numDivide.Size = new System.Drawing.Size(106, 73);
            this.numDivide.TabIndex = 18;
            this.numDivide.Text = "/";
            this.numDivide.UseVisualStyleBackColor = true;
            this.numDivide.Click += new System.EventHandler(this.operator_Click);
            // 
            // numMultiply
            // 
            this.numMultiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.numMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numMultiply.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMultiply.ForeColor = System.Drawing.Color.White;
            this.numMultiply.Location = new System.Drawing.Point(450, 488);
            this.numMultiply.Name = "numMultiply";
            this.numMultiply.Size = new System.Drawing.Size(106, 73);
            this.numMultiply.TabIndex = 20;
            this.numMultiply.Text = "X";
            this.numMultiply.UseVisualStyleBackColor = true;
            this.numMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // numEqual
            // 
            this.numEqual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numEqual.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEqual.ForeColor = System.Drawing.Color.White;
            this.numEqual.Location = new System.Drawing.Point(450, 599);
            this.numEqual.Name = "numEqual";
            this.numEqual.Size = new System.Drawing.Size(259, 73);
            this.numEqual.TabIndex = 21;
            this.numEqual.Text = "=";
            this.numEqual.UseVisualStyleBackColor = true;
            this.numEqual.Click += new System.EventHandler(this.numEqual_Click);
            // 
            // calcExit
            // 
            this.calcExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calcExit.BackgroundImage")));
            this.calcExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calcExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calcExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.calcExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.calcExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcExit.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcExit.ForeColor = System.Drawing.Color.Transparent;
            this.calcExit.Location = new System.Drawing.Point(603, 12);
            this.calcExit.Name = "calcExit";
            this.calcExit.Size = new System.Drawing.Size(106, 73);
            this.calcExit.TabIndex = 22;
            this.calcExit.UseVisualStyleBackColor = true;
            this.calcExit.Click += new System.EventHandler(this.calcExit_Click);
            // 
            // calcMinimize
            // 
            this.calcMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calcMinimize.BackgroundImage")));
            this.calcMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calcMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calcMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.calcMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.calcMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcMinimize.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.calcMinimize.Location = new System.Drawing.Point(12, 12);
            this.calcMinimize.Name = "calcMinimize";
            this.calcMinimize.Size = new System.Drawing.Size(106, 73);
            this.calcMinimize.TabIndex = 23;
            this.calcMinimize.UseVisualStyleBackColor = true;
            this.calcMinimize.Click += new System.EventHandler(this.calcMinimize_Click);
            // 
            // calcProjector
            // 
            this.calcProjector.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calcProjector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcProjector.Font = new System.Drawing.Font("Montserrat ExtraBold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcProjector.ForeColor = System.Drawing.Color.RoyalBlue;
            this.calcProjector.Location = new System.Drawing.Point(175, 127);
            this.calcProjector.Multiline = true;
            this.calcProjector.Name = "calcProjector";
            this.calcProjector.ReadOnly = true;
            this.calcProjector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calcProjector.Size = new System.Drawing.Size(381, 73);
            this.calcProjector.TabIndex = 24;
            this.calcProjector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calcProjector.TextChanged += new System.EventHandler(this.calcProjector_TextChanged);
            // 
            // cCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(721, 698);
            this.Controls.Add(this.calcProjector);
            this.Controls.Add(this.calcMinimize);
            this.Controls.Add(this.calcExit);
            this.Controls.Add(this.numEqual);
            this.Controls.Add(this.numMultiply);
            this.Controls.Add(this.numDivide);
            this.Controls.Add(this.numClear);
            this.Controls.Add(this.numDecimal);
            this.Controls.Add(this.numSubstract);
            this.Controls.Add(this.numAddition);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.calcTitle);
            this.Controls.Add(this.calcDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cCalculator";
            this.Text = "Calc4Me";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.cCalculator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousePressed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcDisplay;
        private System.Windows.Forms.Label calcTitle;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button numAddition;
        private System.Windows.Forms.Button numSubstract;
        private System.Windows.Forms.Button numDecimal;
        private System.Windows.Forms.Button numClear;
        private System.Windows.Forms.Button numDivide;
        private System.Windows.Forms.Button numMultiply;
        private System.Windows.Forms.Button numEqual;
        private System.Windows.Forms.Button calcExit;
        private System.Windows.Forms.Button calcMinimize;
        private System.Windows.Forms.TextBox calcProjector;
    }
}

