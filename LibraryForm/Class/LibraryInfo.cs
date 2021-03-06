﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryForm.Class
{
    class LibraryInfo
    {
        string name;
        string address;
        double charge;
        double overdrowCharge;        
        int periodOfLoan;
        DateTime openingTime;
        DateTime closingTime;


        public LibraryInfo(string name, string address, double charge, double overdrowCharge, int periodOfLoan, DateTime openingTime, DateTime closingTime)
        {
            this.name = name;
            this.address = address;
            this.charge = charge;
            this.overdrowCharge = overdrowCharge;
            this.periodOfLoan = periodOfLoan;
            this.openingTime = openingTime;
            this.closingTime = closingTime;
        }


        public string Name
        {
            get
            {
                return name;
            }
        }


        public string Address
        {
            get
            {
                return address;
            }
        }


        public double Charge
        {
            get
            {
                return charge;
            }
        }


        public double OverdrowCharge
        {
            get
            {
                return overdrowCharge;
            }
        }


        public int PeriodOfLoan
        {
            get
            {
                return periodOfLoan;
            }
        }


        public DateTime OpeningTime
        {
            get
            {
                return openingTime;
            }
        }


        public DateTime ClosingTime
        {
            get
            {
                return closingTime;
            }
        }
    }
}
