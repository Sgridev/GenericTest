using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public class Keyboard : ITools, IParts
    {
        public List<string> GetParts()
        {
            return new List<string>() { "buttons", "lights" };
        }

        public List<string> GetTools()
        {
            return new List<string>() { "hammer" };
        }
    }
}
