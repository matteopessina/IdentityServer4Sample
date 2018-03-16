using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer4Sample
{
    //Currently we need to create ourselves a custom implementation of IdentityDbContext in order to override the constructor to take a 
    //non-generic version of DbContextOptions.This is because IdentityDbContext only has a constructor accepting the generic DbContextOptions which, 
    //when we are registering multiple DbContexts, results in an Invalid Operation Exception. I’ve opened an issue on this, so hopefully we can skip this step soon.
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
