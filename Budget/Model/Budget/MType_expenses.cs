using SQLite;

namespace Model.Budget
{
    [Table("Type_expenses")]
    class MType_expenses
    {
        //Тип расхода
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
       
    }
}
