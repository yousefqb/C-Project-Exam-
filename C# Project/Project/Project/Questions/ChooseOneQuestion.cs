using Project.Answerss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Questions
{
    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion() : base()
        {
            
        }
        public ChooseOneQuestion(string _Header, string _Body, int _mark,AnswerList _Answers)
                : base(_Header, _Body, _mark,_Answers)
        {

        }
    }
}
