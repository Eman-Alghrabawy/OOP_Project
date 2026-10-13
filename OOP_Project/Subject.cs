using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    //public class Subject
    //{
    //    public int SubjectId { get; set; }
    //    public string SubjectName { get; set; }
    //    public Exam SubjectExam { get; private set; }

    //    public Subject(int subjectId, string subjectName)
    //    {
    //        SubjectId = subjectId;
    //        SubjectName = subjectName;
    //    }

    //    public void CreateExam(Exam exam)
    //    {
    //        SubjectExam = exam;
    //    }

    //    public void ShowSubject()
    //    {
    //        System.Console.WriteLine($"Subject ID: {SubjectId}");
    //        System.Console.WriteLine($"Subject Name: {SubjectName}");

    //        if (SubjectExam != null)
    //        {
    //            SubjectExam.ShowExam();
    //        }
    //        else
    //        {
    //            System.Console.WriteLine("No exam created yet.");
    //        }
    //    }
    //}

    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; private set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Name: {SubjectName}";
        }

        public void ShowSubject()
        {
            Console.WriteLine(this);

            if (SubjectExam != null)
                SubjectExam.ShowExam();
            else
                Console.WriteLine("No exam created yet.");
        }
    }
}
