using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Budget.Views.Database
{
    [Table("Profit")]
    class BProfit
    {
        //Прибыль
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type_profit { get; set; }
        public DateTime Data { get; set; }
        public double Amount { get; set; }
    }
}
