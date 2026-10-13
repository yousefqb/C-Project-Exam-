using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Answerss
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Answer()
        {
            Id = 0;
            Text = "unknown answer";
        }
        public Answer(int _id,string _Text)
        {
            Id= _id;
            Text= _Text;
        }
    }
}
