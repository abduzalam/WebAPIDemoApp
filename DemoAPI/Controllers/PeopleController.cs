using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        // GET: api/People
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { Firstname = "Abdul", LastName = "Salam", Id = 0 });
            people.Add(new Person { Firstname = "Tim", LastName = "Corey", Id = 2 });
            people.Add(new Person { Firstname = "Sue", LastName = "Storm", Id = 3 });
        }
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
