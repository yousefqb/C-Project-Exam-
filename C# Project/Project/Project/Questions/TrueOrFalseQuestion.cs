using Project.Answerss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Questions
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion() : base()
        {
            
        }
        public TrueOrFalseQuestion(string _Header, string _Body, int _mark) 
            : base(_Header, _Body, _mark, new AnswerList { new Answer { Id=1,Text="true"}, new Answer {Id= 2,Text="False"}})
        {
            
        }
    }
}
