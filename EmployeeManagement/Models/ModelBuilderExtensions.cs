﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Padmasekhar",
                        Department = Dept.IT,
                        Email = "padmasekhar@gmail.com"
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "Narmada",
                        Department = Dept.HR,
                        Email = "narmada@gmail.com"
                    }
                );
        }
    }
}
