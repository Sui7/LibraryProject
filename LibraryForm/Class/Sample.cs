using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class Sample
  {
    private int id;
    private Book book;
    private int customerId;
    private DateTime endOfLoan;
    private string status;

    public int Id
    {
        get { return id; }
        set { this.id = value; }
    }

    public Book Book 
    {
        get { return book; }
        set { this.book = value; }
    }

    public int CustomerId 
    { 
        get { return customerId; }
        set { this.customerId = value; }
    }

    public DateTime EndOfLoan 
    {
        get { return endOfLoan; }
        set { this.endOfLoan = value; } 
    }

    public string Status
    {
        get { return status; }
        set { this.status = value; }
    }


    public Sample()
    {
    }


    public Sample(int id, Book book, string status)
    {
        this.id = id;
        this.book = book;
        this.status = status;
    }


    public List<string> GetSampleAccessList()
    {
        List<string> sampleAccessList = new List<string>();
        sampleAccessList.Add("Eingang");
        sampleAccessList.Add("Regal A");
        sampleAccessList.Add("Regal B");
        sampleAccessList.Add("Regal C");
        sampleAccessList.Add("Regal D");
        sampleAccessList.Add("Regal E");
        sampleAccessList.Add("Regal F");
        sampleAccessList.Add("Regal G");
        sampleAccessList.Add("Regal H");

        return sampleAccessList;
    }


    public List<string> GetSampleStatusList()
    {
        List<string> sampleStatusList = new List<string>();
        sampleStatusList.Add("frei verfügbar");
        sampleStatusList.Add("nur einsehbar");
        sampleStatusList.Add("beschädigt");
        sampleStatusList.Add("vermisst");
        sampleStatusList.Add("ausgeliehen");

        return sampleStatusList;
    }
  }
}
