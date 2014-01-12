using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
   class Customer : Person
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
          set { this.loanAccount = value; } 
      }


      public ChargeAccount ChargeAccount 
      {
          get { return chargeAccount; }
          set { this.chargeAccount = value; }
      }


      public MessageAccount MessageAccount 
      {
          get { return messageAccount; }
          set { this.messageAccount = value; }
      }


      public PreorderAccount PreorderAccount 
      {
          get { return preorderAccount; }
          set { this.preorderAccount = value; }
      }


      public DateTime RegisterDate 
      {
          get { return registerDate; }
          set { this.registerDate = value; }
      }
  }
}
