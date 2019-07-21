using MVCHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeWork.Service
{

    public class AccountingService
    {
        private readonly SkillTreeHomeworkEntities _db;
        public AccountingService()
        {
            _db = new SkillTreeHomeworkEntities();
        }
        public IEnumerable<AccountBook> Lookup()
        {
            return _db.AccountBook.ToList();
        }
    }
}