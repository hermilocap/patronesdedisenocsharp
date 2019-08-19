using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutofact
{
    class TodayWriter:IDateWriter
    {
        private IOutput _output;
        public TodayWriter(IOutput output)
        {
            _output = output;
        }
       
        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
