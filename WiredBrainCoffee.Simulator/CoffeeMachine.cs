using System;

namespace WiredBrainCoffee.Simulator
{
    public class CoffeeMachine
    {
        public int CounterCappuccino { get; private set; }
        public void MakeCappuccino()
        {
            CounterCappuccino++;
            Console.WriteLine($"Make Cappuccino number {CounterCappuccino}");
        }
    }
}
