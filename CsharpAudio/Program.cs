using MathNet.Numerics.IntegralTransforms;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAudio
{
    class Program
    {


        static void Main(string[] args)
        {

            IWaveIn capture = new NAudio.CoreAudioApi.WasapiLoopbackCapture();
            AudioProcessor AudioProcessor = new CsharpAudio.AudioProcessor();
            capture.RecordingStopped += AudioProcessor.handleEndOfAudio;
            capture.DataAvailable += AudioProcessor.handleAudioData;
            capture.StartRecording();
            AudioProcessor.FrequencyDataAvailable += FrequencyInfoConsumer.ConsumeFrequencyInfo;

        }
    }


}
