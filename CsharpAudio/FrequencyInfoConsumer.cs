using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAudio
{
    class FrequencyInfoConsumer
    {

        public static void ConsumeFrequencyInfo(object sender, FrequencyEventArgs args)
        {
            Console.Clear();
            FrequencyInfo info = args.FrequencyInfo;
            Console.WriteLine(String.Concat(Enumerable.Repeat("##", (int)info.Bass)));
            Console.WriteLine(String.Concat(Enumerable.Repeat("##", (int)info.Middle)));
            Console.WriteLine(String.Concat(Enumerable.Repeat("##", (int)info.Treble)));
        }

    }
}
