using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PersonRepo 
    {
        public static List<Person> Get() {
            //all person
            var db = new PContext();
            return db.Persons.ToList();
        }
        public static Person Get(int id) {
            //id person get
            var db = new PContext();
            return db.Persons.Find(id);
        }
        public static void Create(Person person) {
            //insert
            var db = new PContext();
            db.Persons.Add(person);
            db.SaveChanges();
        }
        public static void Update(Person person) {
            //update
            var db = new PContext();
            var ex = db.Persons.Find(person.Id);
            db.Entry(ex).CurrentValues.SetValues(person);
            db.SaveChanges();
        }
        public static bool Delete(int id) {
            //delete
            var db = new PContext();
            var ex = db.Persons.Find(id);
            db.Persons.Remove(ex);
            return db.SaveChanges() > 0;
        }

    }
}
