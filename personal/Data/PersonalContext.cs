using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personal.Models;

    public class PersonalContext : DbContext
    {
        public PersonalContext (DbContextOptions<PersonalContext> options)
            : base(options)
        {
        }

        public DbSet<Personal.Models.PersonalInformation> PersonalInformation { get; set; }
    }
