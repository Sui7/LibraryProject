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
            this.charges = value;
        }
    }

  
    //Setzt das Gebührenkonto zurück
    public void clearChargeAccount()
    {
        // set charges = 0
        this.charges = 0;
    }


    public double payIn(double amount)
    {
        if (amount <= charges)
        {
            charges -= amount;
        }

        if (charges < 0)
        {
            charges = 0;
        }

        return charges;
    }


    public void setCharges(double amount)
    {
        // add charges
        charges += amount; 
    }
  }
}
