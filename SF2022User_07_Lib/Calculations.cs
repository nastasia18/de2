using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User_07_Lib
{
    public class Calculations
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWordingTime, int consultationTime)
        {
            bool _skipFlag;

            TimeSpan curentTime = beginWorkingTime;
            List<string> outputlist = new List<string>();

            while (curentTime.Add(TimeSpan.FromMinutes(consultationTime)) <= endWordingTime)
            {
                TimeSpan startConsultationTime = curentTime;

                curentTime = curentTime.Add(TimeSpan.FromMinutes(consultationTime));
                TimeSpan endConsultationTime = curentTime;

                _skipFlag = false;
                for (int i = 0; i < startTimes.Length; i++)
                {
                    TimeSpan startDurationTime = startTimes[i];
                    TimeSpan endDurationTime = startTimes[i].Add(TimeSpan.FromMinutes(durations[i]));

                    if (startDurationTime <= startConsultationTime && startConsultationTime < endDurationTime)
                    {
                        _skipFlag = true;
                        curentTime = endDurationTime;
                    }
                    if (startDurationTime < endConsultationTime && endConsultationTime <= endDurationTime)
                    {
                        _skipFlag = true;
                        curentTime = endDurationTime;
                    }
                }

                if (!_skipFlag)
                {
                    outputlist.Add(String.Concat(startConsultationTime.ToString().Substring(0, 5), "-", endConsultationTime.ToString().Substring(0, 5)));
                }
            }

            string[] output = outputlist.ToArray();
            return output;
        }
    }
}
