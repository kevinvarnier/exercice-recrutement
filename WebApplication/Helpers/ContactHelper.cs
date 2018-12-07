using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Helpers
{
    public static class ContactHelper
    {
        public static List<Contact> SeedContacts()
        {
            var list = new List<Contact>
            {
                new Contact
                {
                    Id = Guid.NewGuid(),
                    BirthDate = new DateTime(1983, 01, 03),
                    Email = "dupont.jean@exemple.ca",
                    LastName = "Dupont",
                    FirstName = "Pierre"
                },
                 new Contact
                {
                    Id = Guid.NewGuid(),
                    BirthDate = new DateTime(1923, 04, 10),
                    Email = "tremblay.jeanne@exemple.ca",
                    LastName = "Tremblay",
                    FirstName = "Jeanne"
                },
                  new Contact
                {
                    Id = Guid.NewGuid(),
                    BirthDate = new DateTime(1945, 07, 23),
                    Email = "fontaine.henri@exemple.ca",
                    LastName = "Fontaine",
                    FirstName = "Henri"
                },
                 new Contact
                {
                    Id = Guid.NewGuid(),
                    BirthDate = new DateTime(1965, 03, 15),
                    Email = "dupuis.flora@exemple.ca",
                    LastName = "Dupuis",
                    FirstName = "Flora"
                },
                new Contact
                {
                    Id = Guid.NewGuid(),
                    BirthDate = new DateTime(1990, 08, 17),
                    Email = "sylvania.jean@exemple.ca",
                    LastName = "Sylvania",
                    FirstName = "Jean"
                }
            };
            return list;
        }
    }
}