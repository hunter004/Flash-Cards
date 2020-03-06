using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Cards
{
    public partial class FlashCards : Form
    {
        StudyDriver flashCardQuestions = new StudyDriver();
        public FlashCards()
        {
            InitializeComponent();

            //Initialize the cards from the input text file
            flashCardQuestions.InitializeCards();
        }

        private void UpdateQuestion()
        {
            //when displaying the question, update button text and show the question text
            cSharpQuestion.Text = flashCardQuestions.DisplayQuestions();
            cSharpQuestion.Refresh();
            DisplayAnswer.Text = "Show Answer";
            DisplayAnswer.Refresh();
            flashCardQuestions.answerShow = false;
        }

        private void UpdateAnswer()
        {
            //when displaying answer, update button text and show the answer text
            cSharpQuestion.Text = flashCardQuestions.DisplayAnswer();
            cSharpQuestion.Refresh();
            DisplayAnswer.Text = "Show Question";
            DisplayAnswer.Refresh();
            flashCardQuestions.answerShow = true;
        }

        private void DisplayAnswer_Click(object sender, EventArgs e)
        {
            //clicked button on left side ("show" + either "Question" or "Answer")
            if (!flashCardQuestions.answerShow)
            {
                UpdateAnswer();
            }
            else
            {
                UpdateQuestion();
            }
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            //clicked the next question button, call next question and update text
            flashCardQuestions.NextQuestion();
            UpdateQuestion();
        }
    }
}
