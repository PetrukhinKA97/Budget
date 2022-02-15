using SQLite;

namespace Model
{
    [Table("Importance")]
    class MImportance
    {
        //Важность
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
