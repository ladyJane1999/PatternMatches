using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatches
{
    public record Engine(int power);
    public class Car
    {
        public Engine Engine { get; }
        
        public Car(Engine engine)
        {
            Engine = engine?? throw new ArgumentNullException(nameof(engine));
        }
    }
}
