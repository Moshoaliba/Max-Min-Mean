namespace My_own
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
            this.pbMath = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.lblOutput4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMath)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMath
            // 
            this.pbMath.Image = global::My_own.Properties.Resources.is__1_;
            this.pbMath.Location = new System.Drawing.Point(430, 163);
            this.pbMath.Name = "pbMath";
            this.pbMath.Size = new System.Drawing.Size(336, 246);
            this.pbMath.TabIndex = 0;
            this.pbMath.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(15, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(16, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 36);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.AutoSize = true;
            this.lblDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay2.Location = new System.Drawing.Point(13, 41);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(134, 17);
            this.lblDisplay2.TabIndex = 3;
            this.lblDisplay2.Text = "Enter second value:";
            // 
            // lblDisplay3
            // 
            this.lblDisplay3.AutoSize = true;
            this.lblDisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay3.Location = new System.Drawing.Point(13, 76);
            this.lblDisplay3.Name = "lblDisplay3";
            this.lblDisplay3.Size = new System.Drawing.Size(116, 17);
            this.lblDisplay3.TabIndex = 4;
            this.lblDisplay3.Text = "Enter third value:";
            this.lblDisplay3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(111, 17);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "Enter first value:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(152, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 23);
            this.txtInput.TabIndex = 6;
            // 
            // txtInput3
            // 
            this.txtInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput3.Location = new System.Drawing.Point(153, 76);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(100, 23);
            this.txtInput3.TabIndex = 7;
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.Location = new System.Drawing.Point(153, 41);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 23);
            this.txtInput2.TabIndex = 8;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(426, 18);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 9;
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput2.Location = new System.Drawing.Point(427, 52);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(0, 20);
            this.lblOutput2.TabIndex = 10;
            // 
            // lblOutput3
            // 
            this.lblOutput3.AutoSize = true;
            this.lblOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput3.Location = new System.Drawing.Point(427, 88);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(0, 20);
            this.lblOutput3.TabIndex = 11;
            // 
            // lblOutput4
            // 
            this.lblOutput4.AutoSize = true;
            this.lblOutput4.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput4.Location = new System.Drawing.Point(543, 442);
            this.lblOutput4.Name = "lblOutput4";
            this.lblOutput4.Size = new System.Drawing.Size(0, 25);
            this.lblOutput4.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(16, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 36);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 494);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutput4);
            this.Controls.Add(this.lblOutput3);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbMath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label lblOutput3;
        private System.Windows.Forms.Label lblOutput4;
        private System.Windows.Forms.Button btnClear;
    }
}

