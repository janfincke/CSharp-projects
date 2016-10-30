using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            B.SM();
            C.SM();
     
            C obj = new C();

            var b = obj as B;
            var c = obj as C;

            b.NIM();
            b.VIM();
            c.VIM();
            c.NIM();

            
            

        }
    }
}
