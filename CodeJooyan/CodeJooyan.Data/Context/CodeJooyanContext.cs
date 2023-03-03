using CodeJooyan.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeJooyan.Data.Context
{
    public class CodeJooyanContext:DbContext
    {
        #region Ctor
        public CodeJooyanContext(DbContextOptions<CodeJooyanContext> options):base(options)
        {

        }
        #endregion

        #region DbSet

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion

        #endregion
    }
}
