using Project.Answerss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Questions
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public AnswerList Answers { get; set; }

        protected Question()
        {
            Header = "unknown Header";
            Body = "unknown Body";
            Mark = -1;
            Answers = new AnswerList();
        }
        protected Question(string _Header,string _Body,int _mark,AnswerList _answers)
        {
            Header = _Header;
            Body = _Body;
            Mark =_mark;
            Answers = _answers;
        }

    }
}
