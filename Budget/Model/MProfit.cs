using System;
using SQLite;

namespace Model
{
    [Table("Profit")]
    class MProfit
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
