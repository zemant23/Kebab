using System.Xml.Serialization;

namespace KebabMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrý den pro sklad surovin stiskněte S pro Menu kebabu M");
            string skl = Console.ReadLine();
            Sklad sklad1 = new Sklad();
            Dopln dopln1 = new Dopln();
            if (skl == "S")
            {
                Console.WriteLine("Pro doplnění stiskněte D");
                sklad1.Surov();
                string dpl = Console.ReadLine();
                if (dpl == "D")
                {
                    dopln1.Dopln1();
                }
            }
            if (skl == "M")
            {
                Console.WriteLine("S");
            }
            

        }
    }
}
