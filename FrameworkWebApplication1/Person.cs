using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrameworkWebApplication1
{
    public class Person
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Person(string name, string description) 
        {
            Name = name;
            Description = description;
        }

    }
}