using apr04people.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apr04people.Models
{
    public class PersonsService
    {
        public PersonsService(ContactDBContext context)
        {
            this.context = context;
        }
        private readonly ContactDBContext context;

        //int peopleCounter = 3;
        //List<Person> people = new List<Person>()
        //{
        //    new Person {Id= 1, Name = "Henrik", Email = "henrik@academy.com" },
        //    new Person {Id= 2, Name = "Jonas", Email = "jonas@academy.com" },
        //    new Person {Id= 3, Name = "Daniel", Email ="daniel@academy.com" }
        //};

        //public void AddPerson(Contact person)
        //{
        //    //person.Id = ++peopleCounter;
        //    context.Contact.Add(person);
        //    context.SaveChanges();
        //}

        public async Task AddPerson(Contact person)
        {
            context.Contact.Add(person);
            await context.SaveChangesAsync();
        }

        public Contact[] GetAllPeople()
        {
            return context.Contact.ToArray();
        }

        public Contact GetPersonById(int id)
        {
            return context.Contact.Single(o => o.Id == id);
        }
    }
}
