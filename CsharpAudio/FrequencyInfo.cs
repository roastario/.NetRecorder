using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAudio
{
    class FrequencyInfo
    {

        public FrequencyInfo(double bass, double middle, double treble)
        {
            Bass = bass;
            Middle = middle;
            Treble = treble;
        }

        public double Bass { get;  private set; }
        public double Middle {  get;  private set;  }
        public double Treble {  get;  private set;  }


    }
}
