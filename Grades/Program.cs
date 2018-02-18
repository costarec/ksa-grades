using System;
using System.IO;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();
            //GradeBook book = new ThrowAwayGradeBook();

            GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);

        }

        private static IGradeTracker CreateGradeBook()
        {
            // static type = dynamic type
            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            // in place of console.out we will write to a file
            //book.WriteGrades(Console.Out);

            // so go ahead and write the code
            //StreamWriter outputFile = File.CreateText("grades.txt"))
            //book.WriteGrades(outputFile);
            //outputFile.Close(); // or outputFile.Dispose();


            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.Write("Enter a name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Something went wrong");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went really REALLY wrong" + ex.Message);
            }
        }

        public static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
        public static void WriteResult(string description, float result)
        {
            //Console.WriteLine("{0}: {1:F2}", description, result);
            Console.WriteLine($"{description}: {result:F2}");
        }

    }
}
