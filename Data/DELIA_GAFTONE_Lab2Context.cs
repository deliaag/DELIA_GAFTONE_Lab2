using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DELIA_GAFTONE_Lab2.Models;

namespace DELIA_GAFTONE_Lab2.Data
{
    public class DELIA_GAFTONE_Lab2Context : DbContext
    {
        public DELIA_GAFTONE_Lab2Context (DbContextOptions<DELIA_GAFTONE_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<DELIA_GAFTONE_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<DELIA_GAFTONE_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<DELIA_GAFTONE_Lab2.Models.Author>? Author { get; set; }
    }
}
