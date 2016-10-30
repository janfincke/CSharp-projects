using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class ColorPack : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            string[] colors = { "red", "blue", "green", "yellow" }; // assign colors to a string array
            for (int i = 0; i < colors.Length; i++) // iterate through all the items in the array
            {
                yield return colors[i];
            }
           // foreach (var i in colors) yield return i;
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
