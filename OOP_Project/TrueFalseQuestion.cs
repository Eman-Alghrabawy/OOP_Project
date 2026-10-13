using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    //public class TrueFalseQuestion : Question
    //{
    //    public TrueFalseQuestion(
    //        string header,
    //        string body,
    //        int mark,
    //        bool correctAnswer)
    //        : base(header, body, mark)
    //    {
    //        Answers.Add(new Answer(1, "True"));
    //        Answers.Add(new Answer(2, "False"));

    //        CorrectAnswer = correctAnswer
    //            ? Answers[0]
    //            : Answers[1];
    //    }

    //    public override void Display()
    //    {
    //        System.Console.WriteLine(Header);
    //        System.Console.WriteLine(Body);

    //        foreach (Answer answer in Answers)
    //        {
    //            System.Console.WriteLine(answer);
    //        }
    //    }
    //}
    //public class TrueFalseQuestion : Question
    //{
    //    public TrueFalseQuestion(
    //        string header,
    //        string body,
    //        int mark,
    //        bool correctAnswer)
    //        : base(
    //            header,
    //            body,
    //            mark,
    //            new Answer[]
    //            {
    //                new Answer(1, "True"),
    //                new Answer(2, "False")
    //            },
    //            null)
    //    {
    //        RightAnswer = correctAnswer
    //            ? AnswerList[0]
    //            : AnswerList[1];
    //    }

    //    public override void Display()
    //    {
    //        Console.WriteLine(Header);
    //        Console.WriteLine(Body);
    //        Console.WriteLine($"Mark: {Mark}");

    //        foreach (Answer answer in AnswerList)
    //        {
    //            Console.WriteLine(answer);
    //        }
    //    }
    //}

    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(
            string header,
            string body,
            int mark,
            bool correctAnswer)
            : base(
                header,
                body,
                mark,
                new Answer[]
                {
                    new Answer(1, "True"),
                    new Answer(2, "False")
                },
                null)
        {
            RightAnswer = correctAnswer ? AnswerList[0] : AnswerList[1];
        }

        public override void Display()
        {
            Console.WriteLine(this);

            foreach (Answer answer in AnswerList)
                Console.WriteLine(answer);
        }

        public override object Clone()
        {
            return new TrueFalseQuestion(
                Header,
                Body,
                Mark,
                RightAnswer.AnswerId == 1
            );
        }
    }
}
