using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    //public class Question
    //{
    //    public string Header { get; set; }
    //    public string Body { get; set; }
    //    public int Mark { get; set; }

    //    public Question(string header, string body, int mark)
    //    {
    //        Header = header;
    //        Body = body;
    //        Mark = mark;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Header: {Header}\nBody: {Body}\nMark: {Mark}";
    //    }
    //}
    //public abstract class Question
    //{
    //    public string Header { get; set; }
    //    public string Body { get; set; }
    //    public int Mark { get; set; }

    //    public List<Answer> Answers { get; protected set; }

    //    public Answer CorrectAnswer { get; protected set; }

    //    protected Question(string header, string body, int mark)
    //    {
    //        Header = header;
    //        Body = body;
    //        Mark = mark;

    //        Answers = new List<Answer>();
    //    }

    //    public abstract void Display();
    //}

    //public abstract class Question
    //{
    //    public string Header { get; set; }
    //    public string Body { get; set; }
    //    public int Mark { get; set; }

    //    public Answer[] AnswerList { get; set; }

    //    public Answer RightAnswer { get; set; }

    //    protected Question(
    //        string header,
    //        string body,
    //        int mark,
    //        Answer[] answerList,
    //        Answer rightAnswer)
    //    {
    //        Header = header;
    //        Body = body;
    //        Mark = mark;
    //        AnswerList = answerList;
    //        RightAnswer = rightAnswer;
    //    }

    //    public abstract void Display();
    //}
    public abstract class Question : IComparable<Question>, ICloneable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        protected Question(
            string header,
            string body,
            int mark,
            Answer[] answerList,
            Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        public int CompareTo(Question other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }

        public abstract void Display();

        public abstract object Clone();

        public override string ToString()
        {
            return $"{Header}: {Body} (Mark: {Mark})";
        }
    }
}
