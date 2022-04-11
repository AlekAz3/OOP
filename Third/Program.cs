using System;

namespace Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Предполагаю что в задании идёт речь о кинетической энергии тела
            Body body = new Body(1, 100);
            Console.WriteLine(body.FindKineticEnergy());
        }
    }
}
