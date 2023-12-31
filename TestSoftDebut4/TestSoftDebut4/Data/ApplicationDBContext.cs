﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestSoftDebut4.Models;

namespace TestSoftDebut4.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<DepartmentModel> Department { get; set; }
        public DbSet<EmployeeBackupModel> EmployeeBackup { get; set; }
    }
}
