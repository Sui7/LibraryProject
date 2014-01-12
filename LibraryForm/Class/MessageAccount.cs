using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  class MessageAccount
  {
    Dictionary<int ,Message> messageDict = null;


    public MessageAccount() 
    {
        messageDict = new Dictionary<int, Message>();
    }


    public MessageAccount(Dictionary<int, Message> messageDict) 
    {
        this.messageDict = messageDict;
    }


    public Dictionary<int, Message> MessageDict 
    {
        get { return messageDict; }
        set { this.messageDict = value; }
    }


    public void addMessage(int messageId, Message message)
    {
        messageDict.Add(messageId, message);
    }


    public void deleteMessage(int messageId)
    {
      messageDict.Remove(messageId);   
    }
  }
}
