namespace SEO_Analyzer
{
    partial class SEOAnalyzerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEOAnalyzerForm));
            this.rawTextData = new System.Windows.Forms.RichTextBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.resultsBoxOneWord = new System.Windows.Forms.RichTextBox();
            this.totalImpressionsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsBoxTwoWord = new System.Windows.Forms.RichTextBox();
            this.resultsBoxThreeWord = new System.Windows.Forms.RichTextBox();
            this.resultsBoxFourWord = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalClicksText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultsBoxOverall = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rawTextData
            // 
            this.rawTextData.Location = new System.Drawing.Point(12, 36);
            this.rawTextData.Name = "rawTextData";
            this.rawTextData.Size = new System.Drawing.Size(425, 544);
            this.rawTextData.TabIndex = 0;
            this.rawTextData.Text = resources.GetString("rawTextData.Text");
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(12, 642);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 1;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // resultsBoxOneWord
            // 
            this.resultsBoxOneWord.Location = new System.Drawing.Point(463, 36);
            this.resultsBoxOneWord.Name = "resultsBoxOneWord";
            this.resultsBoxOneWord.Size = new System.Drawing.Size(205, 544);
            this.resultsBoxOneWord.TabIndex = 2;
            this.resultsBoxOneWord.Text = "";
            // 
            // totalImpressionsText
            // 
            this.totalImpressionsText.Location = new System.Drawing.Point(12, 605);
            this.totalImpressionsText.Name = "totalImpressionsText";
            this.totalImpressionsText.Size = new System.Drawing.Size(100, 20);
            this.totalImpressionsText.TabIndex = 3;
            this.totalImpressionsText.Text = "94800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Impressions";
            // 
            // resultsBoxTwoWord
            // 
            this.resultsBoxTwoWord.Location = new System.Drawing.Point(700, 36);
            this.resultsBoxTwoWord.Name = "resultsBoxTwoWord";
            this.resultsBoxTwoWord.Size = new System.Drawing.Size(205, 544);
            this.resultsBoxTwoWord.TabIndex = 5;
            this.resultsBoxTwoWord.Text = "";
            // 
            // resultsBoxThreeWord
            // 
            this.resultsBoxThreeWord.Location = new System.Drawing.Point(927, 36);
            this.resultsBoxThreeWord.Name = "resultsBoxThreeWord";
            this.resultsBoxThreeWord.Size = new System.Drawing.Size(205, 544);
            this.resultsBoxThreeWord.TabIndex = 6;
            this.resultsBoxThreeWord.Text = "";
            // 
            // resultsBoxFourWord
            // 
            this.resultsBoxFourWord.Location = new System.Drawing.Point(1154, 36);
            this.resultsBoxFourWord.Name = "resultsBoxFourWord";
            this.resultsBoxFourWord.Size = new System.Drawing.Size(249, 544);
            this.resultsBoxFourWord.TabIndex = 7;
            this.resultsBoxFourWord.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Clicks";
            // 
            // totalClicksText
            // 
            this.totalClicksText.Location = new System.Drawing.Point(127, 605);
            this.totalClicksText.Name = "totalClicksText";
            this.totalClicksText.Size = new System.Drawing.Size(100, 20);
            this.totalClicksText.TabIndex = 8;
            this.totalClicksText.Text = "837";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "BaseKeyword List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Weighted OneWord Matches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weighted Two Word Matches";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(924, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Weighted Three Word Matches";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1151, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Weighted Four Word Matches";
            // 
            // resultsBoxOverall
            // 
            this.resultsBoxOverall.Location = new System.Drawing.Point(1409, 36);
            this.resultsBoxOverall.Name = "resultsBoxOverall";
            this.resultsBoxOverall.Size = new System.Drawing.Size(249, 544);
            this.resultsBoxOverall.TabIndex = 15;
            this.resultsBoxOverall.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1406, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Weighted Overall, Excluding One Word";
            // 
            // SEOAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 793);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultsBoxOverall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalClicksText);
            this.Controls.Add(this.resultsBoxFourWord);
            this.Controls.Add(this.resultsBoxThreeWord);
            this.Controls.Add(this.resultsBoxTwoWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalImpressionsText);
            this.Controls.Add(this.resultsBoxOneWord);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.rawTextData);
            this.Name = "SEOAnalyzerForm";
            this.Text = "SEO Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rawTextData;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.RichTextBox resultsBoxOneWord;
        private System.Windows.Forms.TextBox totalImpressionsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultsBoxTwoWord;
        private System.Windows.Forms.RichTextBox resultsBoxThreeWord;
        private System.Windows.Forms.RichTextBox resultsBoxFourWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalClicksText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox resultsBoxOverall;
        private System.Windows.Forms.Label label8;
    }
}

