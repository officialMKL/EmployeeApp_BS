using System;

namespace EmployeeApp_BS
{
    class Programm
    {
        public static void Main(string[] args)
        {
            CArbeiter arbeiter = new CArbeiter("Mueller", "Peter", 110, 12.85);
            CAngestellter angestellter = new CAngestellter("Schmidt", "Karl-Heinz", 2900.32);

            Console.WriteLine("Name: {0}", arbeiter.getVorname() + arbeiter.getNachname());
            Console.WriteLine("Bruttolohn: {0}", arbeiter.getBrutto().ToString("C"));

            Console.WriteLine();

            Console.WriteLine("Name: {0}", angestellter.getVorname() + angestellter.getNachname());
            Console.WriteLine("Bruttogehalt: {0}", angestellter.getBrutto().ToString("C"));
        }
    }
}
