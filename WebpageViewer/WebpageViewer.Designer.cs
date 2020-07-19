namespace WebpageViewer
{
    partial class WebpageViewer
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
            this.UrlLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(290, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(323, 52);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Webpage Viewer";
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UrlLabel.Location = new System.Drawing.Point(118, 102);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(65, 31);
            this.UrlLabel.TabIndex = 1;
            this.UrlLabel.Text = "URL:";
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoadButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Location = new System.Drawing.Point(345, 155);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(212, 58);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(206, 107);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(453, 27);
            this.UrlTextBox.TabIndex = 3;
            this.UrlTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UrlTextBox_MouseDown);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(86, 260);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(730, 320);
            this.ResultTextBox.TabIndex = 4;
            this.ResultTextBox.Text = "";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(86, 611);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(0, 20);
            this.CommentLabel.TabIndex = 5;
            // 
            // WebpageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 664);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "WebpageViewer";
            this.Text = "Webpage Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Label CommentLabel;
    }
}

