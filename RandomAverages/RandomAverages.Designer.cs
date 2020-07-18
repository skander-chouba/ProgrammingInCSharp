namespace RandomAverages
{
    partial class RandomAverages
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NumberOfValuesLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.NumberOfValuesTextBox = new System.Windows.Forms.TextBox();
            this.ResultValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(226, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(348, 52);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Random Averages";
            // 
            // NumberOfValuesLabel
            // 
            this.NumberOfValuesLabel.AutoSize = true;
            this.NumberOfValuesLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfValuesLabel.Location = new System.Drawing.Point(83, 153);
            this.NumberOfValuesLabel.Name = "NumberOfValuesLabel";
            this.NumberOfValuesLabel.Size = new System.Drawing.Size(285, 42);
            this.NumberOfValuesLabel.TabIndex = 1;
            this.NumberOfValuesLabel.Text = "Number Of Values:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(226, 364);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(100, 29);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Result: ";
            // 
            // StartButton
            // 
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(300, 255);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(201, 58);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NumberOfValuesTextBox
            // 
            this.NumberOfValuesTextBox.Location = new System.Drawing.Point(374, 167);
            this.NumberOfValuesTextBox.Name = "NumberOfValuesTextBox";
            this.NumberOfValuesTextBox.Size = new System.Drawing.Size(344, 27);
            this.NumberOfValuesTextBox.TabIndex = 4;
            this.NumberOfValuesTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberOfValuesTextBox_MouseClick);
            // 
            // ResultValueLabel
            // 
            this.ResultValueLabel.AutoSize = true;
            this.ResultValueLabel.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultValueLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ResultValueLabel.Location = new System.Drawing.Point(319, 364);
            this.ResultValueLabel.Name = "ResultValueLabel";
            this.ResultValueLabel.Size = new System.Drawing.Size(0, 29);
            this.ResultValueLabel.TabIndex = 2;
            // 
            // RandomAverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultValueLabel);
            this.Controls.Add(this.NumberOfValuesTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.NumberOfValuesLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "RandomAverages";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NumberOfValuesLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox NumberOfValuesTextBox;
        private System.Windows.Forms.Label ResultValueLabel;
    }
}

