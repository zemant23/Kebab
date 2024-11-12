using System.Threading.Tasks.Sources;

namespace KebabMenu
{
    internal class Dopln
    {
        public void Dopln1()
        {
            
            Console.WriteLine("Kolik chcete doplnit?");
            string B = Console.ReadLine();
            int value1 = int.Parse(B);
            Sklad.maso =+ value1;
            Console.WriteLine(Sklad.maso);
            

                
        }
    }
}
