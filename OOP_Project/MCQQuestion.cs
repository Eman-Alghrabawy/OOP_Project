using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    //public class MCQQuestion : Question
    //{
    //    public MCQQuestion(
    //        string header,
    //        string body,
    //        int mark,
    //        List<Answer> answers,
    //        int correctAnswerId)
    //        : base(header, body, mark)
    //    {
    //        Answers = answers;

    //        CorrectAnswer = Answers.First(
    //            answer => answer.AnswerId == correctAnswerId);
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
    //public class MCQQuestion : Question
    //{
    //    public MCQQuestion(
    //        string header,
    //        string body,
    //        int mark,
    //        Answer[] answerList,
    //        Answer rightAnswer)
    //        : base(header, body, mark, answerList, rightAnswer)
    //    {
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

    public class MCQQuestion : Question
    {
        public MCQQuestion(
            string header,
            string body,
            int mark,
            Answer[] answerList,
            Answer rightAnswer)
            : base(header, body, mark, answerList, rightAnswer)
        {
        }

        public override void Display()
        {
            Console.WriteLine(this);

            foreach (Answer answer in AnswerList)
                Console.WriteLine(answer);
        }

        public override object Clone()
        {
            Answer[] clonedAnswers = new Answer[AnswerList.Length];

            for (int i = 0; i < AnswerList.Length; i++)
                clonedAnswers[i] = (Answer)AnswerList[i].Clone();

            Answer clonedRightAnswer = null;

            if (RightAnswer != null)
            {
                foreach (Answer answer in clonedAnswers)
                {
                    if (answer.AnswerId == RightAnswer.AnswerId)
                    {
                        clonedRightAnswer = answer;
                        break;
                    }
                }
            }

            return new MCQQuestion(
                Header,
                Body,
                Mark,
                clonedAnswers,
                clonedRightAnswer
            );
        }
    }
}
