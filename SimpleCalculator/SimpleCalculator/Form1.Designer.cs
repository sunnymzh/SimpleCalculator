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
            this.firstnumberLabel = new System.Windows.Forms.Label();
            this.secondnumberLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.secondnumberTextBox = new System.Windows.Forms.TextBox();
            this.firstnumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstnumberLabel
            // 
            this.firstnumberLabel.AutoSize = true;
            this.firstnumberLabel.Location = new System.Drawing.Point(77, 47);
            this.firstnumberLabel.Name = "firstnumberLabel";
            this.firstnumberLabel.Size = new System.Drawing.Size(66, 13);
            this.firstnumberLabel.TabIndex = 0;
            this.firstnumberLabel.Text = "First Number";
            // 
            // secondnumberLabel
            // 
            this.secondnumberLabel.AutoSize = true;
            this.secondnumberLabel.Location = new System.Drawing.Point(59, 95);
            this.secondnumberLabel.Name = "secondnumberLabel";
            this.secondnumberLabel.Size = new System.Drawing.Size(84, 13);
            this.secondnumberLabel.TabIndex = 1;
            this.secondnumberLabel.Text = "Second Number";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(106, 138);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(42, 213);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(141, 213);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(241, 213);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(340, 213);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 9;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(170, 138);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(206, 20);
            this.resultTextBox.TabIndex = 10;
            // 
            // secondnumberTextBox
            // 
            this.secondnumberTextBox.Location = new System.Drawing.Point(170, 92);
            this.secondnumberTextBox.Name = "secondnumberTextBox";
            this.secondnumberTextBox.Size = new System.Drawing.Size(206, 20);
            this.secondnumberTextBox.TabIndex = 11;
            // 
            // firstnumberTextBox
            // 
            this.firstnumberTextBox.Location = new System.Drawing.Point(170, 47);
            this.firstnumberTextBox.Name = "firstnumberTextBox";
            this.firstnumberTextBox.Size = new System.Drawing.Size(206, 20);
            this.firstnumberTextBox.TabIndex = 12;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 270);
            this.Controls.Add(this.firstnumberTextBox);
            this.Controls.Add(this.secondnumberTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondnumberLabel);
            this.Controls.Add(this.firstnumberLabel);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnumberLabel;
        private System.Windows.Forms.Label secondnumberLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox secondnumberTextBox;
        private System.Windows.Forms.TextBox firstnumberTextBox;
    }
}

