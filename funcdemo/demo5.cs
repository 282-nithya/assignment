using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcdemo
{
    internal class demo5
    {
        static void Main(String[] args)
        {
            var names = new List<string> { "nithya", "sahana", "zuha", "sindhu", "shilpa" };
            names.Add("tabraz");
            names.Add("monika");
            names.Remove("shilpa");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names[3]);
        }
    }
}
