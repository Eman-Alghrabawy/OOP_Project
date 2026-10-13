namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question q1 = new Question(
            //    "C# Question",
            //    "What is a class in C#?",
            //    5
            //);

            // Console.WriteLine(q1);
            // True / False Question
            //Question q1 = new TrueFalseQuestion(
            //    "Q1 - True or False",
            //    "C# is an object-oriented language.",
            //    2,
            //    true
            //);

            //// MCQ Question
            //List<Answer> answers = new List<Answer>
            //{
            //    new Answer(1, "Cairo"),
            //    new Answer(2, "Alexandria"),
            //    new Answer(3, "Luxor")
            //};

            //Question q2 = new MCQQuestion(
            //    "Q2 - Choose One Answer",
            //    "What is the capital of Egypt?",
            //    3,
            //    answers,
            //    1
            //);

            //q1.Display();
            //Console.WriteLine();

            //q2.Display();

            //Answer answer1 = new Answer(1, "True");
            //Answer answer2 = new Answer(2, "False");

            //Console.WriteLine(answer1.AnswerId);  
            //Console.WriteLine(answer1.AnswerText); 


            //  Question[] questions =
            //{
            //      new TrueFalseQuestion(
            //          "Q1",
            //          "C# supports inheritance.",
            //          2,
            //          true
            //      )
            //  };

            //  Exam exam = new FinalExam(120, 1, questions);

            //  exam.ShowExam();

            // Create a question
            //Question q1 = new TrueFalseQuestion(
            //    "Q1",
            //    "C# is an object-oriented language.",
            //    5,
            //    true
            //);

            //Question[] questions = { q1 };

            //// Create the exam
            //Exam finalExam = new FinalExam(
            //    120,
            //    questions.Length,
            //    questions
            //);

            //// Create the subject
            //Subject subject = new Subject(
            //    1,
            //    "C# Programming"
            //);

            //// Associate the exam with the subject
            //subject.CreateExam(finalExam);

            //// Display subject and its exam
            //subject.ShowSubject();

            // Create the subject
            Subject subject = new Subject(1, "C# Programming");

            // Create answers
            Answer[] answers1 =
            {
                new Answer(1, "HTML"),
                new Answer(2, "C#"),
                new Answer(3, "CSS")
            };

            Answer[] answers2 =
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

            // Create questions
            Question q1 = new MCQQuestion(
                "MCQ",
                "Which language is used in this project?",
                5,
                answers1,
                answers1[1]
            );

            Question q2 = new TrueFalseQuestion(
                "True/False",
                "C# supports object-oriented programming.",
                5,
                true
            );

            Question[] questions = { q1, q2 };

            // Optional: sort questions by Mark
            Array.Sort(questions);

            // Create the exam
            Exam finalExam = new FinalExam(
                60,
                questions.Length,
                questions
            );

            // Associate the exam with the subject
            subject.CreateExam(finalExam);

            // Display subject and exam
            subject.ShowSubject();

            // Demonstrate cloning
            Question clonedQuestion = (Question)q1.Clone();
            Console.WriteLine("\nCloned Question:");
            Console.WriteLine(clonedQuestion);

            Console.ReadKey();
        }
    }
}
