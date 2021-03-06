﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Code
{
    class Contract
    {
        public int ID { get; set; }
        public string Nomber_Contract { get; set; }
        public DateTimeOffset With { get; set; }
        public DateTimeOffset By { get; set; }
        public SqlMoney money { get; set; }

        public string[] ToRow()
        {
            string[] rez = new string[5];
            rez[0] = ID.ToString();
            rez[1] = Nomber_Contract;
            rez[2] = With.ToString("dd.MM.YYYY");
            rez[3] = By.ToString("dd.MM.YYYY");
            rez[4] = money.ToString();

            return rez;
        }
    }
}
