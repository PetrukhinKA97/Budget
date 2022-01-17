﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Budget.Views.Database
{
    [Table("Spending")]
    class CSpending
    {
        //Расход
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type_of_Spending { get; set; }
        public int Importance { get; set; }
        public DateTime Data { get; set; }
        public double Amount { get; set; }
    }
}
