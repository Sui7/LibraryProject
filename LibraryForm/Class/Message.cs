﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class Message
  {
    int id;
    int personId;
    DateTime creationDate;
    string messageText;


    public Message()
    {
    }


    public int Id 
    {
        get { return id; }
        set { this.id = value; } 
    }


    public int PersonId
    {
        get { return personId; }
        set { this.personId = value; }
    }


    public DateTime CreationDate 
    {
        get { return creationDate; }
        set { this.creationDate = value; } 
    }


    public string MessageText 
    {
        get { return messageText; }
        set { this.messageText = value; }
    }
  }

}
