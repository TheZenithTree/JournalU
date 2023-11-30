using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GreenJournal.Models
{
    public class Entry
    {
        [PrimaryKey, AutoIncrement]
        public int? ID { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string Content { get; set; }

    }
}
