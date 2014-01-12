using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class Person
  {
    int id;
    int rank;
    string pw;
    string firstname;
    string lastname;
    DateTime birthday;
      
    public int Id 
    {
        get { return id; }
        set { this.id = Id; }
    }


    public int Rank 
    {
        get { return rank; }
        set { this.rank = Rank; }
    }


    public string Pw 
    {
        get { return pw; }
        set { this.pw = Pw; }
    }


    public string Firstname 
    {
        get { return firstname; }
        set { this.firstname = Firstname; }
    }


    public string Lastname 
    {
        get { return lastname; }
        set { this.lastname = Lastname; }
    }


    public DateTime Birthday 
    {
        get { return birthday; }
        set { this.birthday = Birthday; }
    }


    // constructor
    public Person()
    {
    }
  }
}
