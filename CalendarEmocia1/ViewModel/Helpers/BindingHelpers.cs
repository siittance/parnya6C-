using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalendarEmocia1.ViewModel.Helpers
{
    internal class BindingHelpers
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPrioertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
