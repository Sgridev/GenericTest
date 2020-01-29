using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public abstract class RazerObject<T> where T : ITools, IParts, new()
    {
        public abstract string Title { get; }

        public virtual string Color { get; } = "black";

        public void GetInventory()
        {
            var newModel = new T();
            Console.WriteLine(Title);
            Console.WriteLine(Color);
            foreach(string part in newModel.GetParts())
                Console.WriteLine(part);
            foreach(string tool in newModel.GetTools())
                Console.WriteLine(tool);
        }
    }
}
