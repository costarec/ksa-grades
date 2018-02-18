using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        // this is a default ctor - a ctor that takes 0 params
        public GradeBook()
        {
            _name = "Empty Grade Book";
            grades = new List<float>();
        }

        public override void WriteGrades(TextWriter destination)
        {

            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i-1]);
            }
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics()--");

            GradeStatistics stats = new GradeStatistics();
            // then calculate the stats
            stats.HighestGrade = 0;

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count; 

            return stats;
        }

        // members that do work - behavior related methods
        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        // fields - using field initializer syntax
        protected List<float> grades;

    }
}
