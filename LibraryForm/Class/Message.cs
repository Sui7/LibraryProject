using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class Message
  {
    int id;
    DateTime creationDate;
    string messageText;

    public int Id 
    {
        get { return id; }
        set { this.id = Id; } 
    }


    public DateTime CreationDate 
    {
        get { return creationDate; }
        set { this.creationDate = CreationDate; } 
    }


    public string MessageText 
    {
        get { return messageText; }
        set { this.messageText = MessageText; }
    }
  }

}
