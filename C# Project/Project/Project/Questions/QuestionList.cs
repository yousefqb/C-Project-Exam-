using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Questions
{
    public class QuestionList : List<Question>
    {
        public String FilePath { get; set; }

        public QuestionList(string _FilePath)
        {
            FilePath = _FilePath;
        }
        public new void Add(Question question)
        {
            
            base.Add(question);

            using (TextWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"Header: {question.Header} - Body: {question.Body}");
            }
        }
    }
}
