using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser
{
    public class MoodAnalyse
    {
        private string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.Contains("happy"))
            {  
                return "HAPPY";
            }
            else if (message.Contains("any"))
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}
