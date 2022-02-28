using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net012New
{
    public class UniversalEventArgs : EventArgs
    {
        public int i { get; set; }
        public int j { get; set; }
        public object value { get; set; }

        public UniversalEventArgs(int i, int j, object value)
        {
            this.i = i;
            this.j = j;
            this.value = value;
        }
    }
}
