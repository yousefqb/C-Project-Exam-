using Project.Answerss;
using Project.Questions;
using Project.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Exams
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, AnswerList> QuestionAnswerMap { get; set; }
        public Subject AssociatedSubject { get; set; }

        public abstract void ShowExam();
    }
}
