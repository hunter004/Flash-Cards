namespace Flash_Cards
{
    partial class FlashCards
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
            this.DisplayAnswer = new System.Windows.Forms.Button();
            this.cSharpQuestion = new System.Windows.Forms.Label();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayAnswer
            // 
            this.DisplayAnswer.Location = new System.Drawing.Point(370, 337);
            this.DisplayAnswer.Name = "DisplayAnswer";
            this.DisplayAnswer.Size = new System.Drawing.Size(120, 30);
            this.DisplayAnswer.TabIndex = 0;
            this.DisplayAnswer.Text = "Show Answer";
            this.DisplayAnswer.UseVisualStyleBackColor = true;
            this.DisplayAnswer.Click += new System.EventHandler(this.DisplayAnswer_Click);
            // 
            // cSharpQuestion
            // 
            this.cSharpQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSharpQuestion.Location = new System.Drawing.Point(12, 9);
            this.cSharpQuestion.Name = "cSharpQuestion";
            this.cSharpQuestion.Size = new System.Drawing.Size(625, 304);
            this.cSharpQuestion.TabIndex = 1;
            this.cSharpQuestion.Text = "Click \"Next Question\" to start flash cards";
            this.cSharpQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextQuestion
            // 
            this.nextQuestion.Location = new System.Drawing.Point(517, 337);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(120, 30);
            this.nextQuestion.TabIndex = 2;
            this.nextQuestion.Text = "Next Question";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // FlashCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 379);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.cSharpQuestion);
            this.Controls.Add(this.DisplayAnswer);
            this.Name = "FlashCards";
            this.Text = "Study Problems";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayAnswer;
        private System.Windows.Forms.Label cSharpQuestion;
        private System.Windows.Forms.Button nextQuestion;
    }
}

