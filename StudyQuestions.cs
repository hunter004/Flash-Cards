using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Cards
{
    //This class will import study questions from input text file and organize them in a dictionary
    class StudyQuestions
    {
        protected OrderedDictionary studyCards = new OrderedDictionary();
        protected Logger log = new Logger(@"PathToLog.log");
        private string filename = @"PathToTextFile.txt";
        public bool answerShow = false;

        //empty constructor 
        public StudyQuestions() { }

        private string[] ImportQuestions()
        {
            //default return in case file is not able to be accessed
            string[] defaultReturn = { "Question", "Answer" };

            try
            {
                string[] inputFile = File.ReadAllLines(filename);
                return inputFile;
            }
            catch(Exception ex)
            {
                log.Log(string.Format("{0} - Error when importing text file: {1}",DateTime.Now.ToString() ,ex.Message));
                MessageBox.Show("Error Handling the input text file {0}",filename);
            }
            return defaultReturn;
        }

        protected void BuildDictionary()
        {
            //add balues to dictionary from file
            try
            {
                string[] textInput = ImportQuestions();
                for (var i = 0; i < textInput.Length; i += 2)
                {
                    studyCards.Add(textInput[i], textInput[i + 1]);
                }
            }
            catch(Exception ex)
            {
                log.Log(string.Format("{0} - Error building Dictionary in BuildDictionary function, StudyQuestions Class:" +
                                      " {1}", DateTime.Now.ToString(), ex.Message));
                MessageBox.Show("Error Handling the input text file {0}", filename);
            }
        }
    }
}
