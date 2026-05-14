using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Kilunina.Classes
{
    public class Notification : INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler PropertyChanging;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanging != null)
                PropertyChanging(this, new PropertyChangingEventArgs(prop));
        }
    }
}
