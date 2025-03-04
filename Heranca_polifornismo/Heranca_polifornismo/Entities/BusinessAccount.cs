﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_polifornismo.Entities
{
    class BusinessAccount:Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit): base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            Balance += amount;
        }
    }
}
