using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet9
{
    class Snippet9
    {
        string studName = "Alexander";
        int studId = 30;

        public void Details()
        {
            Console.WriteLine("StudentName: " + studName);
            Console.WriteLine("StudentID: " + studId);
        }
    }

    class ScoreReport
    {
        public string Subject = "Science";
        public int Marks = 60;

        static void Main(string[] args)
        {
            Snippet9 objStudents = new Snippet9();
            ScoreReport objReport = new ScoreReport();
            objStudents.Details();
            Console.WriteLine("Subject: " + objReport.Subject);
            Console.WriteLine("Marks: " + objReport.Marks);
        }
    }
}