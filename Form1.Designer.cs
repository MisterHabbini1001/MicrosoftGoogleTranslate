namespace HabboGaastraTranslateMicrosoftGoogle
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
            this.texttoTranslate = new System.Windows.Forms.TextBox();
            this.EnterTextlabel = new System.Windows.Forms.Label();
            this.btnDetect = new System.Windows.Forms.Button();
            this.DetectedLanguagelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LanguageSelectLabel = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.TranslatedTextLabel = new System.Windows.Forms.Label();
            this.TranslatedTextBox = new System.Windows.Forms.TextBox();
            this.DetectedLanguageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // texttoTranslate
            // 
            this.texttoTranslate.Location = new System.Drawing.Point(12, 38);
            this.texttoTranslate.Multiline = true;
            this.texttoTranslate.Name = "texttoTranslate";
            this.texttoTranslate.Size = new System.Drawing.Size(828, 135);
            this.texttoTranslate.TabIndex = 0;
            // 
            // EnterTextlabel
            // 
            this.EnterTextlabel.AutoSize = true;
            this.EnterTextlabel.Location = new System.Drawing.Point(13, 13);
            this.EnterTextlabel.Name = "EnterTextlabel";
            this.EnterTextlabel.Size = new System.Drawing.Size(56, 13);
            this.EnterTextlabel.TabIndex = 1;
            this.EnterTextlabel.Text = "Enter Text";
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(12, 179);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(75, 23);
            this.btnDetect.TabIndex = 2;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            // 
            // DetectedLanguagelabel
            // 
            this.DetectedLanguagelabel.AutoSize = true;
            this.DetectedLanguagelabel.Location = new System.Drawing.Point(13, 220);
            this.DetectedLanguagelabel.Name = "DetectedLanguagelabel";
            this.DetectedLanguagelabel.Size = new System.Drawing.Size(105, 13);
            this.DetectedLanguagelabel.TabIndex = 3;
            this.DetectedLanguagelabel.Text = "Detected Language:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // LanguageSelectLabel
            // 
            this.LanguageSelectLabel.AutoSize = true;
            this.LanguageSelectLabel.Location = new System.Drawing.Point(13, 262);
            this.LanguageSelectLabel.Name = "LanguageSelectLabel";
            this.LanguageSelectLabel.Size = new System.Drawing.Size(91, 13);
            this.LanguageSelectLabel.TabIndex = 6;
            this.LanguageSelectLabel.Text = "Select Language:";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(12, 301);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 7;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // TranslatedTextLabel
            // 
            this.TranslatedTextLabel.AutoSize = true;
            this.TranslatedTextLabel.Location = new System.Drawing.Point(13, 366);
            this.TranslatedTextLabel.Name = "TranslatedTextLabel";
            this.TranslatedTextLabel.Size = new System.Drawing.Size(81, 13);
            this.TranslatedTextLabel.TabIndex = 8;
            this.TranslatedTextLabel.Text = "Translated Text";
            // 
            // TranslatedTextBox
            // 
            this.TranslatedTextBox.Location = new System.Drawing.Point(12, 382);
            this.TranslatedTextBox.Multiline = true;
            this.TranslatedTextBox.Name = "TranslatedTextBox";
            this.TranslatedTextBox.Size = new System.Drawing.Size(828, 174);
            this.TranslatedTextBox.TabIndex = 9;
            // 
            // DetectedLanguageTextBox
            // 
            this.DetectedLanguageTextBox.Location = new System.Drawing.Point(129, 220);
            this.DetectedLanguageTextBox.Name = "DetectedLanguageTextBox";
            this.DetectedLanguageTextBox.Size = new System.Drawing.Size(160, 20);
            this.DetectedLanguageTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 866);
            this.Controls.Add(this.DetectedLanguageTextBox);
            this.Controls.Add(this.TranslatedTextBox);
            this.Controls.Add(this.TranslatedTextLabel);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.LanguageSelectLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DetectedLanguagelabel);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.EnterTextlabel);
            this.Controls.Add(this.texttoTranslate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texttoTranslate;
        private System.Windows.Forms.Label EnterTextlabel;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Label DetectedLanguagelabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LanguageSelectLabel;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label TranslatedTextLabel;
        private System.Windows.Forms.TextBox TranslatedTextBox;
        private System.Windows.Forms.TextBox DetectedLanguageTextBox;

    }
}

