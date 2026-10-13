using Project.Answerss;
using Project.Exams;
using Project.Questions;
using Project.Subjects;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Subject csharpSubject = new Subject (1, "C# Programming" );

        QuestionList questionsList = new QuestionList("CSharpQuestions.txt");


        TrueOrFalseQuestion q1 = new TrueOrFalseQuestion
        {
            Header = "OOP Concepts",
            Body = "Encapsulation is the mechanism of hiding data.",
            Mark = 10,
            Answers = new AnswerList()
            {
                new Answer { Id = 1, Text = "True" },
                new Answer { Id = 2, Text = "False" }
            }
        };

        ChooseOneQuestion q2 = new ChooseOneQuestion
        {
            Header = "C# Basics",
            Body = "Which of the following is a value type in C#?",
            Mark = 10,
            Answers = new AnswerList()
            {
                new Answer { Id = 1, Text = "string" },
                new Answer { Id = 2, Text = "int" },
                new Answer { Id = 3, Text = "class" },
                new Answer { Id = 4, Text = "interface" }
            }
        };

        ChooseOneQuestion q3 = new ChooseOneQuestion
        {
            Header = "File Extensions",
            Body = "What is the correct file extension for C# source files?",
            Mark = 10,
            Answers = new AnswerList()
            {
                new Answer { Id = 1, Text = ".cpp" },
                new Answer { Id = 2, Text = ".java" },
                new Answer { Id = 3, Text = ".cs" },
                new Answer { Id = 4, Text = ".js" }
            }
        };

        questionsList.Add(q1);
        questionsList.Add(q2);
        questionsList.Add(q3);

        Dictionary<Question, AnswerList> examMap = new Dictionary<Question, AnswerList>();

        examMap.Add(q1, new AnswerList() { new Answer { Id = 1, Text = "True" } });
        examMap.Add(q2, new AnswerList() { new Answer { Id = 2, Text = "int" } });
        examMap.Add(q3, new AnswerList() { new Answer { Id = 3, Text = ".cs" } });

        Console.WriteLine("  PRACTICE EXAM ");

        PracticeExam practiceExam = new PracticeExam
        {
            Time = 30,
            NumberOfQuestions = 3,
            AssociatedSubject = csharpSubject,
            QuestionAnswerMap = examMap
        };

        practiceExam.ShowExam();

        Console.WriteLine("\n FINAL EXAM ");

        FinalExam finalExam = new FinalExam
        {
            Time = 45,
            NumberOfQuestions = 3,
            AssociatedSubject = csharpSubject,
            QuestionAnswerMap = examMap
        };

        finalExam.ShowExam();

    }
}