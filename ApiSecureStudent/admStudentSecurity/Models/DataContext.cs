﻿namespace admStudentSecurity.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext 
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admStudentSecurity.Models.Student> Students { get; set; }
    }
}