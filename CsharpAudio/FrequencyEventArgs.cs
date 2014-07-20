using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAudio
{
    class FrequencyEventArgs : EventArgs
    {

        public FrequencyEventArgs(FrequencyInfo info)
        {
            FrequencyInfo = info;
        }

        public FrequencyInfo FrequencyInfo { get; private set; }

    }
}
