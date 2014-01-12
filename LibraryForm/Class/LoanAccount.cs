using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class LoanAccount
  {
    List<Sample> sampleList;


    public LoanAccount() 
    {
        this.sampleList = new List<Sample>();
    }


    public LoanAccount(List<Sample> sampleList)
    {
        this.sampleList = sampleList;
    }


    public List<Sample> SampleList
    {
        get { return sampleList; }
        set { this.sampleList = value; }
    }


    public void addSample(Sample sample)
    {
      sampleList.Add(sample);
    }


    public void removeSample(Sample sample)
    {
        sampleList.Remove(sample);
    }    
  }
}
