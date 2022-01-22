using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding MBLD = new MultiBuilding("ул.Пушкина, д.1", 50, 20, 12, 3);
            MBLD.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress
            { get; set; }
        public double Length
            { get; set; }
        public double Width
            { get; set; }
        public double Height
            { get; set; }
        public Building()
        {
        }
        public Building (string s, double l, double w, double h)
        {
            Adress = s;
            Length = l;
            Width = w;
            Height = h;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес здания: {Adress}");
            Console.WriteLine($"Длина здания - {Length}");
            Console.WriteLine($"Ширина здания - {Width}");
            Console.WriteLine($"Высота здания - {Height}");
        }
    }
    sealed class MultiBuilding : Building
    {
        byte TopFloor
            { get; set; }
        public MultiBuilding(string s, double l, double w, double h, byte tf)
            :base(s, l, w, h)
        {
            TopFloor = tf;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Этажность здания - {TopFloor}");
        }
    }
}
