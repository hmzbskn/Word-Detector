using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Detector
{
    public class Words
    {
        public string wordEnglish { get; set; }
        public string wordTurkish { get; set; }
        public int wordDisplayCount { get; set; }
        public int wordCorrectCount { get; set; }
        public double wordRatio { get; set; }
        public void oranBulma()
        {
            this.wordRatio = this.wordCorrectCount / this.wordDisplayCount;
        }

    }
}
