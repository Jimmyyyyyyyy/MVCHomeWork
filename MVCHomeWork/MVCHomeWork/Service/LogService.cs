using MVCHomeWork.Models;
using MVCHomeWork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeWork.Service
{
    public class LogService
    {
        private readonly IRepository<Log> _logRepository;

        public LogService(IUnitOfWork unitOfWork)
        {
            _logRepository = new Repository<Log>(unitOfWork);
        }

        public void Add(DateTime date, string remark)
        {
            _logRepository.Create(new Log
            {
                LogDate = date,
                Remark = remark
            });
        }
    }
}