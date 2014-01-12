using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class ChargeAccount
  {
       
    double charges; //Gebühren


    // constructor
    public ChargeAccount()
    {
        this.charges = 0;
    }


    // ChargeAccount Methoden
    public double Charges
    {
        get
        {
            return this.charges;
        }

        set
        {
            this.charges = Charges;
        }
    }

  
    //Setzt das Gebührenkonto zurück
    public void clearChargeAccount()
    {
        // set charges = 0
        this.charges = 0;
    }


    public void payIn(double amount)
    {
        if (amount <= charges)
        {
            amount -= charges;
        }

        if (charges < 0)
        {
            charges = 0;
        }
    }


    public void setCharges(double amount)
    {
        // add charges
        charges += amount; 
    }
  }
}
