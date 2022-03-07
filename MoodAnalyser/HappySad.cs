using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class HappySad
    {

        string Message;
        public HappySad()
        {
        }
        public HappySad(string message)
        {
            this.Message = message;
        }

        public string AnalysingMood()
        {
            if (this.Message.ToUpper().Contains("HAPPY"))
            {
                return "HAPPY";
            }
            if (this.Message.ToUpper().Contains("SAD"))
            {
                return "SAD".ToUpper();
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}


