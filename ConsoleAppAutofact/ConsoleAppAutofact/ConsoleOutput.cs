﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutofact
{
  public  class ConsoleOutput:IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
