using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise18
{
    public class C : B
    {
        public static void SM() { Console.WriteLine("Hello from C.SM()"); }
        public virtual void VIM() { Console.WriteLine("Hello from C.VIM()"); }
        public void NIM() { Console.WriteLine("Hello from C.NIM()"); }
    }
}
