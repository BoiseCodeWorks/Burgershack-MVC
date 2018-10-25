﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Burgershack.Entities;
using Burgershack.Web.Models;

namespace Burgershack.Web.Models
{
    public class BurgershackWebContext : DbContext
    {
        public BurgershackWebContext (DbContextOptions<BurgershackWebContext> options)
            : base(options)
        {
        }

        public DbSet<Burgershack.Entities.Burger> Burger { get; set; }

        public DbSet<Burgershack.Web.Models.Menu> Menu { get; set; }
    }
}
