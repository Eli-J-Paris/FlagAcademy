﻿using FlagAcademy.Models;
using Microsoft.EntityFrameworkCore;

namespace FlagAcademy.DataAccess
{
    public class FlagAcademyContext : DbContext
    {
        public DbSet<Flag> Flags { get; set; }
        public DbSet<Country> Countries { get; set; }
        public FlagAcademyContext(DbContextOptions<FlagAcademyContext> options) : base(options)
        {

        }
    }
}