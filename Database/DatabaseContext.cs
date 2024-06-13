using System.Text.Json;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ActivityCategory> ActivityCategories { get; set; } = null!;

        public DbSet<ActivityKind> ActivityKinds { get; set; } = null!;

        public DbSet<Department> Departments { get; set; } = null!;

        public DbSet<Employee> Employees { get; set; } = null!;

        public DbSet<Student> Students { get; set; } = null!;

        public DbSet<Event> Events { get; set; } = null!;

        public DbSet<Group> Groups { get; set; } = null!;

        public DbSet<Pulpit> Pulpits { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Speciality> Specialities { get; set; } = null!;

        public DbSet<AcademicLeaveRequest> AcademicLeaveRequests { get; set; } = null!;

        public DbSet<RejectAcademicLeaveRequestDemand> RejectAcademicLeaveRequestDemands { get; set; } = null!;

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Configs", "connectionString.json");

            var connectionStrings = ReadFromFile<ConnectionStrings>(path);

            optionsBuilder.UseSqlServer(connectionStrings.Default);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillEntities<ActivityCategory>(modelBuilder, "activityCategories");
            FillEntities<ActivityKind>(modelBuilder, "activityKinds");
            FillEntities<Department>(modelBuilder, "departments");
            FillEntities<Employee>(modelBuilder, "employees");
            FillEntities<Student>(modelBuilder, "students");
            FillEntities<Event>(modelBuilder, "events");
            FillEntities<Group>(modelBuilder, "groups");
            FillEntities<Pulpit>(modelBuilder, "pulpits");
            FillEntities<Role>(modelBuilder, "roles");
            FillEntities<Speciality>(modelBuilder, "specialities");
        }

        private void FillEntities<T>(ModelBuilder modelBuilder, string jsonName) where T : class
        {
            var entities = ReadEntities<T[]>(jsonName);

            modelBuilder
                .Entity<T>()
                .HasData(entities);
        }

        private T ReadEntities<T>(string jsonName)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Configs", "Entities", $"{jsonName}.json");

            return ReadFromFile<T>(path);
        }

        private T ReadFromFile<T>(string path)
        {
            var fileContent = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(fileContent);
        }
    }
}
