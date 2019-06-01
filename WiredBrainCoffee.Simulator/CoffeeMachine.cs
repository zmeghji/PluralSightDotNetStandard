using System;
using WiredBrainCoffee.Storage;

namespace WiredBrainCoffee.Simulator
{
    public class CoffeeMachine
    {
        private readonly CoffeeMachineStateSaver _coffeeMachineStateSaver;
        public CoffeeMachine()
        {
            _coffeeMachineStateSaver = new CoffeeMachineStateSaver();
            var state = _coffeeMachineStateSaver.Load();
            CounterCappuccino = state.CounterCappuccino;
        }
        public int CounterCappuccino { get; private set; }
        public void MakeCappuccino()
        {
            CounterCappuccino++;
            Console.WriteLine($"Make Cappuccino number {CounterCappuccino}");
            _coffeeMachineStateSaver.Save(new CoffeeMachineState { CounterCappuccino = CounterCappuccino });
        }
        public void ShowStoredState()
        {
            _coffeeMachineStateSaver.ShowStoredJson();
        }
    }
}
