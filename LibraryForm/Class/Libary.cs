using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
    class Libary
    {
        string name = "Stadt Bibliothek";
        string address = "Stadtstraße 5 12345 Berlin";
        long charge = 20;           //jährliche Gebühren
        long OverdrowCharge = 3;   //Überziehungsgebühr
        TimeSpan OpeningTime = new TimeSpan(8, 0, 0);
        TimeSpan CloseTime = new TimeSpan(20, 0, 0);
        string PeriodOfLoan;    
    }
}
