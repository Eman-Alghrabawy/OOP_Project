using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OOP_Project
{
    //public class FinalExam : Exam
    //{
    //    public FinalExam(int time, int numberOfQuestions)
    //        : base(time, numberOfQuestions)
    //    {
    //    }
    //}
    //    public class FinalExam : Exam
    //    {
    //        public Question[] Questions { get; set; }

    //    public FinalExam(
    //        int time,
    //        int numberOfQuestions,
    //        Question[] questions)
    //        : base(time, numberOfQuestions)
    //    {
    //        Questions = questions;
    //    }

    //    public override void ShowExam()
    //    {
    //        Console.WriteLine("=== Final Exam ===");
    //        Console.WriteLine($"Time: {Time} minutes");
    //        Console.WriteLine($"Number of Questions: {NumberOfQuestions}");

    //        foreach (Question question in Questions)
    //        {
    //            question.Display();
    //            Console.WriteLine();
    //        }
    //    }
    //}

    public class FinalExam : Exam
    {
        public Question[] Questions { get; set; }

        public FinalExam(
            int time,
            int numberOfQuestions,
            Question[] questions)
            : base(time, numberOfQuestions)
        {
            Questions = questions;
        }

        public override void ShowExam()
        {
            int grade = 0;
            int totalMarks = 0;

            // Display questions and receive answers
            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine($"\nQuestion {i + 1}:");
                question.Display();

                totalMarks += question.Mark;

                Console.Write("Enter your answer ID: ");
                int answerId;

                while (!int.TryParse(Console.ReadLine(), out answerId))
                {
                    Console.Write("Invalid input. Enter an answer ID: ");
                }

                // Check the student's answer
                if (question.RightAnswer != null &&
                    answerId == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }
            }

            // Show the correct answers and grade after finishing
            Console.WriteLine("\n===== Final Exam Results =====");

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine($"\nQuestion {i + 1}: {question.Body}");
                Console.WriteLine(
                    $"Correct Answer: {question.RightAnswer?.AnswerText}"
                );
            }

            Console.WriteLine($"\nYour Grade: {grade} / {totalMarks}");
        }
    }
}
