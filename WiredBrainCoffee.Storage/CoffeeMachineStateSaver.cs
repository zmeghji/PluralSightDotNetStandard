using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Storage
{
    public class CoffeeMachineStateSaver
    {
        private string _filename = "machine.json";
        public void Save(CoffeeMachineState state)
        {
            var json = JsonConvert.SerializeObject(state);
            File.WriteAllText(_filename, json);
        }
        public CoffeeMachineState Load()
        {
            if (File.Exists(_filename))
            {
                var json = File.ReadAllText(_filename);
                return JsonConvert.DeserializeObject<CoffeeMachineState>(json);
            }
            else
            {
                return new CoffeeMachineState { CounterCappuccino = 0 };
            }
        }
        public void ShowStoredJson()
        {
            string jsonString = "<empty>";
            if (File.Exists(_filename))
            {
                jsonString = File.ReadAllText(_filename);
            }
#if NETSTANDARD1_3
            Console.WriteLine($"Store JSON: {jsonString}");
#else
            var window = new System.Windows.Window
            {
                Title = "Store JSON",
                Content = jsonString,
                WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen,
                Width = 300,
                Height = 300
            };
            window.Show();
#endif
        }
    }
}
