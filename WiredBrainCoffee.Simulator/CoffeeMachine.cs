namespace WiredBrainCoffee.Simulator
{
    public class CoffeeMachine
    {
        public int CounterCappuccino { get; private set; }
        public void MakeCappuccino()
        {
            CounterCappuccino++;
        }
    }
}
