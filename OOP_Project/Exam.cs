using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    //public class Exam
    //{
    //    public int Time { get; set; }
    //    public int NumberOfQuestions { get; set; }

    //    public Exam(int time, int numberOfQuestions)
    //    {
    //        Time = time;
    //        NumberOfQuestions = numberOfQuestions;
    //    }
    //}
    //public abstract class Exam
    //{
    //    public int Time { get; set; }
    //    public int NumberOfQuestions { get; set; }

    //    protected Exam(int time, int numberOfQuestions)
    //    {
    //        Time = time;
    //        NumberOfQuestions = numberOfQuestions;
    //    }

    //    public abstract void ShowExam();
    //}
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        protected Exam(int time)
            : this(time, 0)
        {
        }

        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Time: {Time} minutes, Questions: {NumberOfQuestions}";
        }
    }
}
