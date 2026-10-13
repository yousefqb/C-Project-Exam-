using Project.Answerss;
using Project.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Exams
{
    internal class FinalExam : Exam
    {
        public override void ShowExam()
        {
            int numberofcorrectquestions=0;
            int numberofWorngquestions = 0;

            foreach (var test in QuestionAnswerMap)
            {
                Question question = test.Key;
                AnswerList correctans = test.Value;

                Console.WriteLine(question.Body);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.Id} , {answer.Text}");
                }
                int ansID;
                do
                {
                    Console.Write("Enter the answer Id : ");
                } while (!int.TryParse(Console.ReadLine(), out ansID));
                bool isCorrect = false;

                foreach (var answer in correctans)
                {
                    if (ansID == answer.Id)
                    {
                        isCorrect = true;
                        break;
                    }
                }

                if (isCorrect)
                {
                    numberofcorrectquestions++;
                }
                else
                {
                    numberofWorngquestions++;
                }
            }
            Console.WriteLine($"Excelent , Your Grade is {numberofcorrectquestions}/{numberofcorrectquestions+numberofWorngquestions} ");
            if (numberofWorngquestions > 0)
            {
                Console.WriteLine($"numbe of incorrect answer is : {numberofWorngquestions}");
            }
            else { Console.WriteLine("there is no incoreect answer"); }
                
        }
    }
}
