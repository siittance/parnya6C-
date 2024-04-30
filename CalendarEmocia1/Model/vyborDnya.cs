using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarEmocia.Model
{
    internal class vyborDnya
    {
        public DateTime data;
        List<pervyivybor> vybor;

        public vyborDnya(DateTime data, List<pervyivybor> vybor)
        {
            this.data = data;
            this.vybor = vybor;
        }
    }
}

