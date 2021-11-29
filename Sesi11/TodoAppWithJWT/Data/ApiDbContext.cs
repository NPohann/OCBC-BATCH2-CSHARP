using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TodoAppWithJWT.Data{
    public class ApiDbContext : IdentityDbContext{
        public virtual DbSet<ItemData> Items {get;set;}
        public virtual DbSet<RefreshToken> RefreshToken {get;set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
            {

            }
    }
}