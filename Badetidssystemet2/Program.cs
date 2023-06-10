namespace Badetidssystemet2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kreds Kreds1 = new Kreds("Id 001", "Gülsüm", "Maglehøjen 10", 2);
            Kreds Kreds2 = new Kreds("Id 002", "Nuriye", "Maglehøjen 10", 2);

            //Printing to console: 

            Console.WriteLine(Kreds1);
            Console.WriteLine(Kreds2);

            //Laver instanser for badetidsperiode klassen: 

            Badetidsperiode Badetidsperiode1 = new Badetidsperiode("Morgendukkert", DayOfWeek.Sunday);

            //printer det ud i konsollen: 
            Console.WriteLine(Badetidsperiode1);
            
        }
    }
}