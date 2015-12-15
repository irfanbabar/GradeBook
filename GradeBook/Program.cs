using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        // ---------------- Grade system function -----------------
        public static void getGrades(string[] subjects, double[] percentageForEachSubjects, double[] gradePoint) {
            for (int i = 0; i < subjects.Length; i++)
            {
                if (subjects[i] != null)
                {
                    Console.WriteLine(subjects[i]+":-");

                    if (percentageForEachSubjects[i] >= 80 && percentageForEachSubjects[i] <= 100)
                    {
                        Console.WriteLine(" Greade A");
                        gradePoint[i] = 4;
                        Console.WriteLine(gradePoint[i]);
                    
                    }
                    else if (percentageForEachSubjects[i] <= 80 && percentageForEachSubjects[i] >= 64)
                    {
                        Console.WriteLine(" Greade B");
                        gradePoint[i] = 3;
                        Console.WriteLine(gradePoint[i]);
                    
                    }
                    else if (percentageForEachSubjects[i] <= 65 && percentageForEachSubjects[i] >= 49)
                    {
                        Console.WriteLine(" Greade C");
                        gradePoint[i] = 2;
                        Console.WriteLine(gradePoint[i]);
                    
                    }

                    else if (percentageForEachSubjects[i] <= 50 && percentageForEachSubjects[i] > 39)
                    {
                        Console.WriteLine(" Greade D");
                        gradePoint[i] = 1;
                        Console.WriteLine(gradePoint[i]);
                    
                    }
                    else if (percentageForEachSubjects[i] < 40)
                    {
                        Console.WriteLine(" Greade F");
                        gradePoint[i] = 0;                    
                    }

                }
            }
        }
        // ---------------- end here -----------------


        // ---------------- Get GPA function -----------------

        public static void getGPA(double[] gradePoint) {
            double totalGradePoint=0;
            for (int i = 0; i < gradePoint.Length; i++)
            {
                totalGradePoint += gradePoint[i];
            }
            Console.WriteLine("GPA: {0}", totalGradePoint);
        }

        // ----------------- end here --------------------


        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************Electronic Grade Book*************************************************");
            Console.WriteLine("Subjects:");

            string[] subjects = new string[10];
            double[] assignment = new double[10];
            double[] quiz = new double[10];
            double[] mid = new double[10];
            double[] final = new double[10];
            double[] totalMarks = new double[10];
            double[] percentageForEachSubjects = new double[10];
            double[] gradePoint = new double[10];
            //  this loop is for adding subjects in array

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("continue 1, exit 2");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    Console.WriteLine("Enter subject Code:");
                    subjects[i] = Console.ReadLine();

                    Console.WriteLine("Assignment Marks out of 30:");
                    assignment[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quiz Marks out of 30:");
                    quiz[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Mid Marks out of 30:");
                    mid[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Final Marks out of 30:");
                    final[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Total Marks:");
                    totalMarks[i] = assignment[i] + quiz[i] + mid[i] + final[i];
                    Console.WriteLine(totalMarks[i]);
                    percentageForEachSubjects[i] = (totalMarks[i] / 120) * 100;
                    Console.WriteLine("Subject: {0}, Percentage: {1}", subjects[i], percentageForEachSubjects[i]);

                }
                else {
                    break;
                }

            }

            getGrades(subjects, percentageForEachSubjects, gradePoint);

            getGPA(gradePoint);
            Console.Read();

        }
    }
}
