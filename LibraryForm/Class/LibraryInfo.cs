using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryForm.Class
{
    class LibraryInfo
    {
        string name;
        string address;
        int charge;
        int overdrowCharge;        
        int periodOfLoan;
        int openingTime;
        int closingTime;


        public LibraryInfo(string name, string address, int charge, int overdrowCharge, int periodOfLoan, int openingTime, int closingTime) {
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


        public int Charge
        {
            get
            {
                return charge;
            }
        }


        public int OverdrowCharge
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


        public int OpeningTime
        {
            get
            {
                return openingTime;
            }
        }


        public int ClosingTime
        {
            get
            {
                return closingTime;
            }
        }
    }
}
