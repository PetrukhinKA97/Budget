using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;

namespace Budget.Views.Database
{
    [Table("Planning")]
    public class CPlanning :INotifyPropertyChanged
    {
        //Планирование
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Importance { get; set; }
        public double Amount_min { get; set; }
        public double Amount_max { get; set; }
        public DateTime Data { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
