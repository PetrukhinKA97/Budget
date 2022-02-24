using System;
using SQLite;
using System.Collections;

namespace Model.Budget
{
    [Table("MExpenses")]
    public class MExpenses 
    {
        //Расход
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type_expenses { get; set; }
        public int Importance { get; set; }
        public DateTime Data { get; set; }
        public double Amount { get; set; }
        public int Number { get; set; }
        public double Volume { get; set; }
    }

}
