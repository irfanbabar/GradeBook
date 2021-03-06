﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        #region  DisplayTable Function
        public static void displayTable(double gradePoint, string subjects, double percentageForEachSubjects, string grade)
        {
            Console.WriteLine("{0} \t\t {1}% \t\t {2} \t {3}", subjects, Math.Round(percentageForEachSubjects), grade, gradePoint);
        }
        #endregion


        #region  Grade System Function

        // ---------------- Grade system function -----------------
        public static void getGrades(string[] subjects, double[] percentageForEachSubjects, double[] gradePoint)
        {
            string grade;
            Console.WriteLine("Subject \t Percentage \t Grade \t GradePoint");

            for (int i = 0; i < subjects.Length; i++)
            {
                if (subjects[i] != null)
                {

                    if (percentageForEachSubjects[i] >= 80 && percentageForEachSubjects[i] <= 100)
                    {
                        gradePoint[i] = 4;
                        grade = "A";
                        displayTable(gradePoint[i], subjects[i], percentageForEachSubjects[i], grade);

                        //Console.WriteLine(" Greade A \n");

                        //Console.WriteLine("Grade Point: {0}", gradePoint[i]);
                        //Console.WriteLine("Remarks: Excellent \n");
                    }
                    else if (percentageForEachSubjects[i] <= 80 && percentageForEachSubjects[i] >= 64)
                    {
                        gradePoint[i] = 3;
                        grade = "B";
                        displayTable(gradePoint[i], subjects[i], percentageForEachSubjects[i], grade);

                        //Console.WriteLine(" Greade B \n");

                        //Console.WriteLine("Grade Point: {0}", gradePoint[i]);
                        //Console.WriteLine("Remarks: Good \n");
                    }
                    else if (percentageForEachSubjects[i] <= 65 && percentageForEachSubjects[i] >= 49)
                    {
                        gradePoint[i] = 2;
                        grade = "C";
                        displayTable(gradePoint[i], subjects[i], percentageForEachSubjects[i], grade);


                        //Console.WriteLine(" Greade C \n");

                        //Console.WriteLine("Grade Point: {0}", gradePoint[i]);
                        //Console.WriteLine("Remarks: Satisfactory \n");
                    }

                    else if (percentageForEachSubjects[i] <= 50 && percentageForEachSubjects[i] > 39)
                    {
                        gradePoint[i] = 1;
                        grade = "D";
                        displayTable(gradePoint[i], subjects[i], percentageForEachSubjects[i], grade);

                        //Console.WriteLine(" Greade D \n");

                        //Console.WriteLine("Grade Point: {0}", gradePoint[i]);
                        //Console.WriteLine("Remarks: Pass \n");

                    }
                    else if (percentageForEachSubjects[i] < 40)
                    {
                        gradePoint[i] = 0;
                        grade = "F";
                        displayTable(gradePoint[i], subjects[i], percentageForEachSubjects[i], grade);

                        //Console.WriteLine(" Greade F \n");
                        // Console.WriteLine("Grade Point: {0}", gradePoint[i]);

                        //Console.WriteLine("Remarks: Fail \n");
                    }

                }
            }
        }
        // ---------------- end here -----------------


        #endregion


        #region   Get GPA function

        // ---------------- Get GPA function -----------------

        public static void getGPA(double[] gradePoint, string[] subjects)
        {
            double totalGradePoint = 0;   // GPA
            int number = 0;

            for (int i = 0; i < gradePoint.Length; i++)
            {
                if (subjects[i] != null)
                {
                    totalGradePoint += gradePoint[i];
                    number += 1;
                }

            }


            totalGradePoint = totalGradePoint / number;

            Console.WriteLine("OverAll GPA: {0}", totalGradePoint);

            if (totalGradePoint <= 4 && totalGradePoint >= 3)
            {
                Console.WriteLine("Remarks: \t Excellent");

            }
            if (totalGradePoint < 3 && totalGradePoint >= 2.5)
            {
                Console.WriteLine("Remarks: \t Good");
            }
            if (totalGradePoint < 2.5 && totalGradePoint >= 2)
            {
                Console.WriteLine("Remarks: \t Satisfactory");
            }
            if (totalGradePoint < 2 && totalGradePoint >= 1)
            {
                Console.WriteLine("Remarks: \t Pass");
            }

            if (totalGradePoint < 1)
            {
                Console.WriteLine("Remarks: \t Fail");
            }

        }

        // ----------------- end here -------------------

        #endregion


        #region  Main function

        static void Main(string[] args)
        {
            Console.WriteLine("********Electronic Grade Book********");

            string choose = "";
            string[] subjects = new string[10];
            double[] assignment = new double[10];
            double[] quiz = new double[10];
            double[] mid = new double[10];
            double[] final = new double[10];
            double[] totalMarks = new double[10];
            double[] percentageForEachSubjects = new double[10];
            double[] gradePoint = new double[10];
            string[] arr = new string[5];

            //  this loop is for adding subjects in array

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("To Continue Press 1: \nTo Exit Press 2:");

                choose = Console.ReadLine();

                if (choose == "1")
                {

                    Console.WriteLine("Enter subject Code:");
                    subjects[i] = Console.ReadLine();

                    Console.WriteLine("Assignment Marks out of 30: \n");


                    assignment[i] = Convert.ToDouble(Console.ReadLine());


                    if (assignment[i] <= 30)
                    {
                        Console.WriteLine(" ");

                    }
                    else
                    {

                        Console.WriteLine("Invalid..");


                    }


                    Console.WriteLine("Quiz Marks out of 30: \n");
                    quiz[i] = Convert.ToDouble(Console.ReadLine());

                    if (quiz[i] <= 30)
                    {
                        Console.WriteLine(" ");

                    }
                    else
                    {

                        Console.WriteLine("Invalid..");


                    }





                    Console.WriteLine("Mid Marks out of 30: \n");
                    mid[i] = Convert.ToDouble(Console.ReadLine());
                    if (mid[i] <= 30)
                    {
                        Console.WriteLine(" ");

                    }
                    else
                    {

                        Console.WriteLine("Invalid..");


                    }



                    Console.WriteLine("Final Marks out of 30: \n");
                    final[i] = Convert.ToDouble(Console.ReadLine());

                    if (final[i] <= 30)
                    {
                        Console.WriteLine(" ");

                    }
                    else
                    {

                        Console.WriteLine("Invalid..");


                    }




                    totalMarks[i] = assignment[i] + quiz[i] + mid[i] + final[i];
                    Console.WriteLine("Total Marks: {0}", totalMarks[i]);
                    percentageForEachSubjects[i] = (totalMarks[i] / 120) * 100;
                    Console.WriteLine("Subject: {0}\nPercentage: {1}\n", subjects[i], percentageForEachSubjects[i]);

                }
                else
                {
                    Console.WriteLine("\nExiting...\n");
                    break;
                }

            }

            if (subjects[0] != null)
            {
                getGrades(subjects, percentageForEachSubjects, gradePoint);

                getGPA(gradePoint, subjects);
            }
            Console.Read();

        }
        #endregion
    }
}