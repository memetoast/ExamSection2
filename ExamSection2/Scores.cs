using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSection2
{
    internal class Scores
    {
        public static void testScores()
        {
            int sum = 0;
            double avg = 0;

            int[] classScores;
            classScores = new int[] {100, 99, 88, 77, 66, 50};
            for (int i = 0; i < classScores.Length; i++)
            {
                sum += classScores[i];
            }
            avg = sum / classScores.Length;
            MessageBox.Show();
        }
    }
}
