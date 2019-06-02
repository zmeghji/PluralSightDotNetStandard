using System;
using WiredBrainCoffee.Simulator;

namespace TestNugetPackageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.MakeCappuccino();
            coffeeMachine.MakeCappuccino();
            Console.WriteLine($"Cappuccino counter: {coffeeMachine.CounterCappuccino}");
            coffeeMachine.ShowStoredState();
        }
    }
}
