using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    //public class PracticalExam : Exam
    //{
    //    public PracticalExam(int time, int numberOfQuestions)
    //        : base(time, numberOfQuestions)
    //    {
    //    }
    //}
    //public class PracticalExam : Exam
    //{
    //    public Question[] Questions { get; set; }

    //    public PracticalExam(
    //        int time,
    //        int numberOfQuestions,
    //        Question[] questions)
    //        : base(time, numberOfQuestions)
    //    {
    //        Questions = questions;
    //    }

    //    public override void ShowExam()
    //    {
    //        Console.WriteLine("=== Practical Exam ===");
    //        Console.WriteLine($"Time: {Time} minutes");
    //        Console.WriteLine($"Number of Questions: {NumberOfQuestions}");

    //        foreach (Question question in Questions)
    //        {
    //            question.Display();
    //            Console.WriteLine();
    //        }
    //    }
    //}

    public class PracticalExam : Exam
    {
        public MCQQuestion[] Questions { get; set; }

        public PracticalExam(
            int time,
            int numberOfQuestions,
            MCQQuestion[] questions)
            : base(time, numberOfQuestions)
        {
            Questions = questions;
        }

        public override void ShowExam()
        {
            Console.WriteLine("=== Practical Exam ===");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");

            // First: Display all questions
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
                Questions[i].Display();
            }

            // Wait until the student finishes the exam
            Console.WriteLine("\nPress Enter after finishing the exam...");
            Console.ReadLine();

            // Then: Show the correct answers
            Console.WriteLine("\n=== Correct Answers ===");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(
                    $"Question {i + 1}: " +
                    Questions[i].RightAnswer.AnswerText
                );
            }
        }
    }
}
