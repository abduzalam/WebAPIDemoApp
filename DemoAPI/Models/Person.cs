using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// users first name
        /// </summary>
        public string Firstname { get; set; } = "";
        /// <summary>
        /// users Last Name
        /// </summary>
        public string LastName { get; set; } = "";
    }
}