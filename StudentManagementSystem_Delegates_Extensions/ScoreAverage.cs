using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_Delegates_Extensions
{
    public static class ScoreAverage
    {
        public static double AverageScore(this List<int> scores)
        {
            
               return (scores == null || scores.Count == 0) ? 0 : scores.Average();
            
        }
    }
}
