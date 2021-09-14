using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiNgay7hang9.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext() : Base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}