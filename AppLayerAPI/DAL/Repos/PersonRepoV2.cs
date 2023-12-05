using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PersonRepoV2 : Repo,IRepo<Person,int,bool>
    {
        public static List<Person> GetAll() {
            return null;
        }
        public static List<Person> GeInd()
        {
            return null;
        }
        public static bool Insert() {
            return true;
        }


    }
}
