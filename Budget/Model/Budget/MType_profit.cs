using SQLite;

namespace Model.Budget
{
    [Table("Type_profit")]
    class MType_profit
    {
        //Тип дохода
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
