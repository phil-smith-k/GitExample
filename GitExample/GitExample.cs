using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample
{
    public class GitExample
    {
        public GitExample()
        {
            Console.WriteLine("Cookies are good!");
        }

        public GitExample(string exampleProp)
        {
            this.ExampleProp = exampleProp;
        }

        public string ExampleProp { get; set; }
    }
}
