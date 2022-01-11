using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Budget.Views.Database
{
    [Table("Task")]
    class СTask
    {
        //Задачи
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Importance { get; set; }
        public DateTime Date_min { get; set; }
        public DateTime Date_max { get; set; }
    }
}
