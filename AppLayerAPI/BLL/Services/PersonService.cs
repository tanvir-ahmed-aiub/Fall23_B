using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PersonService
    {
        public static List<PersonDTO> GetAllPerson() {
            var data = DataAccessFactory.PersonData().Get();
            var config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<Person,PersonDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<List<PersonDTO>>(data);
            return ret;
        }
        public static PersonDTO Get(int id) {
            var data = DataAccessFactory.PersonData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Person, PersonDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<PersonDTO>(data);
            return ret;
        }
        
        public static void Create(PersonDTO p) {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PersonDTO, Person>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Person>(p);


            DataAccessFactory.PersonData().Create(data);
        }
    }
}
