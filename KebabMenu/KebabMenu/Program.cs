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
            if (skl == "S")
            {
                sklad1.Surov();
            }

        }
    }
}
