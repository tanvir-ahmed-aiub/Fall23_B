using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PersonRepo : Repo, IRepo<Person, int, bool>
    {
        public bool Create(Person obj)
        {
            db.Persons.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Persons.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Person> Get()
        {
            return db.Persons.ToList();
        }

        public Person Get(int id)
        {
            return db.Persons.Find(id);
        }

        public bool Update(Person obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;

        }
    }
}
