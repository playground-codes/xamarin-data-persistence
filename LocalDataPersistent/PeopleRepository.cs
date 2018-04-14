using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using System.Threading.Tasks;

namespace LocalDataPersistent
{
    public class PeopleRepository
    {
        public string StatusMessage { get; set; }

        private SQLiteAsyncConnection connection;

        public PeopleRepository(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<Person>().Wait();
        }

        public async Task AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");
                
                result = await connection.InsertAsync(new Person { Name = name });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public async Task<List<Person>> GetAllPeople()
        {
            try {
                return await connection.Table<Person>().ToListAsync();
            } catch (Exception ex) {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Person>();
        }
    }
}
