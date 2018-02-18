namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = float.MinValue;  // begin comparison pt.
            LowestGrade = float.MaxValue;   // begin comparison pt.
        }

        // Then we can all rest easier based on what we all know
        // and bargain better as well.



        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }
                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if(AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public float AverageGrade;
        public float LowestGrade;
        public float HighestGrade;
    }
}