using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Cards
{
    class StudyDriver : StudyQuestions
    {
        //dictionary index initialized at -1
        private int dictIndex = -1;

        //empty constructor
        public StudyDriver() { }

        public void InitializeCards()
        {
            //builds dictionary based on text input in StudyQuestions parent class
            BuildDictionary();
        }

        public void NextQuestion()
        {
            //access the next index in the dictionary, reset index if end is reached
            try
            {
                if(dictIndex < studyCards.Count-1)
                {
                    dictIndex++;
                }
                else
                {
                    dictIndex = 0;
                }
            }
            catch(Exception ex)
            {
                log.Log(string.Format("{0} - Idexing error, NextQuestion methon in StudyDriver Class:" +
                                      " {1}", DateTime.Now.ToString(), ex.Message));
                MessageBox.Show("Exception Handled while handling text file.");
            }
        }

        public string DisplayQuestions()
        {
            //Access the Key in dictionary which is the Question text to display
            try
            {
                if (dictIndex >= 0 && dictIndex <= studyCards.Count)
                {
                    return studyCards.Cast<DictionaryEntry>().ElementAt(dictIndex).Key.ToString();
                }
            }
            catch (Exception ex)
            {
                log.Log(string.Format("{0} - Error DisplayQuestions Method in StudyDriver:" +
                                      " {1}", DateTime.Now.ToString(), ex.Message));
                MessageBox.Show("Cannot Display Question. Error: {0}", ex.Message);
            }
            return "Unable to access Question.";
        }

        public string DisplayAnswer()
        {
            //access the value in the key value pair which is the answer text to display
            try
            {
                if (dictIndex >= 0 && dictIndex <= studyCards.Count)
                {
                    return studyCards[dictIndex].ToString();
                }
            }
            catch (Exception ex)
            {
                log.Log(string.Format("{0} - Error DisplayAnswer Method in StudyDriver:" +
                                      " {1}", DateTime.Now.ToString(), ex.Message));
                MessageBox.Show("Cannot Display Answer. Error: {0}", ex.Message);
            }
            return "Hit 'Next Question'";
        }
    }
}
