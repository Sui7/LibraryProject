using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class Person
  {
    private int id;
    private int rank;
    private string pw;
    private string firstname;
    private string lastname;
    private DateTime birthday;
      
    public int Id 
    {
        get { return id; }
        set { this.id = value; }
    }


    public int Rank 
    {
        get { return rank; }
        set { this.rank = value; }
    }


    public string Pw 
    {
        get { return pw; }
        set { this.pw = value; }
    }


    public string Firstname 
    {
        get { return firstname; }
        set { this.firstname = value; }
    }


    public string Lastname 
    {
        get { return lastname; }
        set { this.lastname = value; }
    }


    public DateTime Birthday 
    {
        get { return birthday; }
        set { this.birthday = value; }
    }


    // constructor
    public Person(int Id,int Rank,string Pw, string Firstname, string Lastname, DateTime Birthday)
    {
        id = Id;
        rank = Rank;
        pw = Pw;
        firstname = Firstname;
        lastname = Lastname;
        birthday = Birthday;
    }

    public Person()
    {
    }
  }
}
