using System.ComponentModel;

namespace Lære_Vikaren_A7S
{
    internal class Program
    {
        /* Comment: Andreas
         * Jeg tænker at dette vil være hovedfilen for Lærervikaren A/S.
         * Ud over dette kan vi vælge om klasserne skal være i seperate  filer eller neden under Main() 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("hvilken skole har brug for vikarer: ");


            string input = Console.ReadLine();
            string answer = input.ToUpper();

            switch(answer)
            {
                case "BØGELUND":
                    Console.WriteLine("dette er en skole");
                    break;
                default:
                    Console.WriteLine("Error 365");
                    break;
            }

            




            //afslut koden ved at trykke på 'enter'
            Console.ReadLine();
        }
    }

    public class Student
    {
        public string studentName;
        
    }
    public class Emre : Student 
    { 
        
        StudentID newStudentID = new StudentID();
        public int studentID() 
        {
            return  newStudentID.RandomNR();
        }


    }
    public class Alma : Student { }
    public class Justin : Student { }
    public class laurits : Student { }
    public class Frederik : Student { }
    public class Andreas : Student { }

    public class StudentID 
    { 
     Random rd = new();
            public int RandomNR()
            {
            int newRD = rd.Next(1, 1000000);
            return newRD;
            }
    }
}