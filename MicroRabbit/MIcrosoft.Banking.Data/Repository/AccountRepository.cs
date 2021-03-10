using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MIcrosoft.Banking.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIcrosoft.Banking.Data.Repository
{
   
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;
        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
          return  _ctx.Accounts;
        }
    }
}
