using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarEmocia.Model
{
    internal class pervyivybor
    {
        public string name;
        public string wayKartinka;
        public bool select;

        public pervyivybor(string name, string wayKartinka, bool select)
        {
            this.name = name;
            this.wayKartinka = wayKartinka;
            this.select = select;
        }
    }
}
