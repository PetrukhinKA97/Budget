﻿using Model.Budget;
using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ViewModel.Budget
{
    public class VMExpenses_new
    {
        private SQLiteAsyncConnection database;
        #region Реализация с хранением списка из бд
        /*
        private ObservableCollection<MExpenses> list_expenses;
        public ObservableCollection<MExpenses> ListMS
        {
            get { return list_expenses; }
            set { list_expenses = value; }
        }
        public VMExpenses(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
            //VMcommand = new Command(IncreasePrice);
        }
        public async Task GetItems()
        {
            var id = await database.Table<MExpenses>().ToListAsync();
            list_expenses = new ObservableCollection<MExpenses>(id);
        }
        public async Task<List<MExpenses>> GetItemsAsync()
        {
            return await database.Table<MExpenses>().ToListAsync().ConfigureAwait(false);
        }
        public async Task<int> DeleteItemAsync(MExpenses item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(MExpenses item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                var f = ListMS.IndexOf(item);
                ListMS[f] = item;
                return item.Id;
            }
            else
            {
                ListMS.Add(item);
                return await database.InsertAsync(item);
            }
        }
        */
        #endregion
        public VMExpenses_new()
        {

        }

        public VMExpenses_new(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }
        public async Task<List<MExpenses>> GetItemsAsync()
        {
            return await database.Table<MExpenses>().ToListAsync().ConfigureAwait(false);
        }
        public async Task<int> DeleteItemAsync(MExpenses item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(MExpenses item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }


    }
}
