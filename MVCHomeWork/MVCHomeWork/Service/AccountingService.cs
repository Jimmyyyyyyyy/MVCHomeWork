using MVCHomeWork.Models;
using MVCHomeWork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeWork.Service
{

    public class AccountingService
    {
        private readonly IRepository<AccountBook> _accointingRepository;

        public AccountingService(IUnitOfWork unitOfWork)
        {
            _accointingRepository = new Repository<AccountBook>(unitOfWork);
        }
        public IEnumerable<Accounting> Lookup()
        {
            var source = _accointingRepository.LookupAll();
            var result = source.Select(x => new Accounting()
            {
                Money = x.Amounttt,
                Date = x.Dateee,
                TypeOfMoney = x.Categoryyy
            });

            return result.ToList();
        }
    }
}