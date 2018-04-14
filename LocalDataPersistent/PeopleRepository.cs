using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace LocalDataPersistent
{
    public class PeopleRepository
    {
        public string StatusMessage { get; set; }

        private SQLiteConnection connection;

        public PeopleRepository(string dbPath)
        {
            connection = new SQLiteConnection(dbPath);
            connection.CreateTable<Person>();
        }

        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");
                
                result = connection.Insert(new Person { Name = name });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public List<Person> GetAllPeople()
        {
            try {
                return connection.Table<Person>().ToList();
            } catch (Exception ex) {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Person>();
        }
    }
}
