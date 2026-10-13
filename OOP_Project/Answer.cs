using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    //public class Answer
    //{
    //    public int AnswerId { get; set; }
    //    public string AnswerText { get; set; }

    //    public Answer(int answerId, string answerText)
    //    {
    //        AnswerId = answerId;
    //        AnswerText = answerText;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{AnswerId}. {AnswerText}";
    //    }
    //}
    public class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
    }
}
