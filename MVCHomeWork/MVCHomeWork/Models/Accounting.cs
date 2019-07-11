using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeWork.Models
{
    public class Accounting
    {
        public int TypeOfMoney { get; set; }
        public DateTime Date { get; set; }
        public decimal Money { get; set; }
    }
}