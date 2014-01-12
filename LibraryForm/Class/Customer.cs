using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
   public class Customer : Person
  {
      LoanAccount loanAccount;
      ChargeAccount chargeAccount;
      MessageAccount messageAccount;
      PreorderAccount preorderAccount;
      DateTime registerDate;

      public Customer() 
      {
      }

      public LoanAccount LoanAccount 
      {
          get { return loanAccount; }
          set { this.loanAccount = LoanAccount; } 
      }


      public ChargeAccount ChargeAccount 
      {
          get { return chargeAccount; }
          set { this.chargeAccount = ChargeAccount; }
      }


      public MessageAccount MessageAccount 
      {
          get { return messageAccount; }
          set { this.messageAccount = MessageAccount; }
      }


      public PreorderAccount PreorderAccount 
      {
          get { return preorderAccount; }
          set { this.preorderAccount = PreorderAccount; }
      }


      public DateTime RegisterDate 
      {
          get { return registerDate; }
          set { this.registerDate = RegisterDate; }
      }
  }
}
