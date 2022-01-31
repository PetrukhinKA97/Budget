using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Budget.Views.Database
{
    [Table("Importance")]
    class BImportance
    {
        //Важность
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
