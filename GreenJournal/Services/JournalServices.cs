using GreenJournal.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace GreenJournal.Services
{
    class JournalServices
    {
        static SQLiteAsyncConnection db;
        public static async Task Init()
        {
            //Create Database and Tables

            //If database has not been created, don't run it again
            if (db != null)
                return;

            //Create Database
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "JournalU.db");

            db = new SQLiteAsyncConnection(databasePath);

            //Create Tables
            await db.CreateTableAsync<Entry>();
        }

        public static async Task AddEntry(string content, DateTime date)
        {
            await Init();
            var entry = new Entry
            {
                EntryDateTime = date,
                Content = content

            };

            await db.InsertAsync(entry);

        }

        public static async Task DeleteEntry(int? id)
        {
            await Init();

            if (id == null) return;

            await db.DeleteAsync<Entry>(id);
        }

        public static async Task<IEnumerable<Entry>> GetAllEntry()
        {
            await Init();

            var entries = await db.Table<Entry>().ToListAsync();
            return entries;
        }

        public static async Task GetEntry(int id)
        {
            await Init();

            var entry = await db.Table<Entry>().FirstOrDefaultAsync(e=> e.ID == id);
        }


        public static async Task SaveEntryAsync(Entry entry)
        {
            await Init();

            await db.UpdateAsync(entry);
            
        }
    }
}
