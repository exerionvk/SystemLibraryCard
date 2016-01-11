using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibraryCard;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            IBibliographicDescription[] figure = new IBibliographicDescription[4];
            try
            {
                figure[0] = new Book("NTVP", "Metoda", "Garays D.V.", "TUSUR", "100");
                figure[1] = new Collection("NTVP", "сб. основных нормативно-техн. док., действующих в обл. учета электроэнергии", "Garays D.V.", "TUSUR", "100");
                figure[2] = new Dissertation("Исследование и разработка какой-то фигни", "дис. …канд. техн. наук", "Меркулов В.А.", "защищена 28.06.04", "утв. 10.09.04", "178");
                figure[3] = new Magazine("Эксергетический метод", "основа анализа систем теплофикации с целью повышения их эффективности и конкурентоспособности", "Промышленная энергетика", "3", "17");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(figure[i].Print);
                }
            }
            catch (BibliographicExeption e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            //Console.WindowWidth = 120;
            //Console.BufferWidth = 120;
            //Console.WindowHeight = 40;
            //Console.BufferHeight = 40;
            Console.ReadKey();
        }
    }
}
