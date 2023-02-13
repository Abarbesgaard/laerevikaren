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
            
            
            Start: 
            Console.WriteLine("Hvilken skole har brug for vikarer: ");


            string input = Console.ReadLine();
            string answer = input.ToUpper();

            
                switch (answer)
                {
                    case "BØGELUND":
                        Console.WriteLine("Dette er en skole");

                        break;
                    case "EGELUND":
                        Console.WriteLine("informationen om denne skole: ");
                        Egelund nyEge = new Egelund();
                        Console.WriteLine(nyEge.skoleNavn);
                        Console.WriteLine("Addresse: " + nyEge.skoleAddresseNavn + " " + nyEge.skoleAddresseNR);
                    Console.WriteLine("Skolens id: " + nyEge.skoleID);
                    Console.WriteLine("skolens Email: " + nyEge.skoleEmail);
                    break;
                    default:
                        Console.WriteLine("Fejl.");
                        goto Start;
                }


            


            //afslut koden ved at trykke på 'enter'
            Console.ReadLine();
        }
        public class Skole
        {
            public string skoleNavn;
            public string skoleAddresseNavn;
            public int skoleAddresseNR;
            public int skoleTLF;
            public string skoleEmail;
            public string skoleID;

          
        }

        public class Egelund : Skole
        {
            public Egelund()
            {
                skoleNavn = "Egelund";
                skoleAddresseNavn = "Halløjstedvej";
                skoleAddresseNR = 10;
                skoleTLF = 45365783;
                skoleEmail = "Drgt75@egelund.dk";
                skoleID = "egelund1";

            }
        }
    }

}