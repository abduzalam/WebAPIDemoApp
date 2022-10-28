using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give all information about my peeps
    /// </summary>
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
        /// <summary>
        /// Returns all the first names without any input parameters
        /// </summary>
        /// <returns>The list of all the first names</returns>
        [Route("api/People/GetFirstName") ]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach(Person p in people)
            {
                output.Add(p.Firstname);
            }
            return output;

        }
        /// <summary>
        /// returns first name based on userId and age of the person
        /// </summary>
        /// <param name="userId"></param> a unique identifier for this person
        /// <param name="age"></param> the age of the person
        /// <returns>A list of first names</returns>
        [Route("api/People/GetFirstNameWithPrm/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNamesWithPrm(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (Person p in people)
            {
                output.Add(p.Firstname);
            }
            return output;

        }

    }
}
