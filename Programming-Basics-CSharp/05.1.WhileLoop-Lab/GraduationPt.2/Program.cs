using System;

namespace GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double sumYearEvaluation = 0.0;

            int classCounter = 1;
            
            int outClass = 0;




            while (classCounter <= 12)
            {
                double yearEvaluation = double.Parse(Console.ReadLine());
                sumYearEvaluation += yearEvaluation;



                if (yearEvaluation < 4.00)
                {
                    outClass++;
                    if (outClass > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {classCounter} grade");
                        break;

                    }
                    continue;                   


                }               
                
                classCounter++;            
                                              

            }
                      

            if(classCounter > 11)
            {
                double averageGrade = sumYearEvaluation / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
            





        }
    }
}
