using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Nursery> Nursery { get; set; }
    public DbSet<SeedlingBatch> SeedlingBatch { get; set; }
    public DbSet<TreeSpecies> TreeSpecies { get; set; }
    public DbSet<Responsible> Responsible { get; set; }
    public DbSet<Employee> Employees { get; set; }
    
    protected DatabaseContext(){}
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nursery>().HasData(new List<Nursery>()
        {
            new Nursery { NurseryId = 1, Name = "name1", EstablishedDate = DateTime.Parse("2025-05-01") },
            new Nursery { NurseryId = 2, Name = "name2", EstablishedDate = DateTime.Parse("2025-05-01") },
            new Nursery { NurseryId = 3, Name = "name3", EstablishedDate = DateTime.Parse("2025-05-01") }
        });

        modelBuilder.Entity<TreeSpecies>().HasData(new List<TreeSpecies>()
        {
            new TreeSpecies { SpeciesId = 1, LatinName = "name1", GrowthTimeInYears = 1 },
            new TreeSpecies { SpeciesId = 2, LatinName = "name2", GrowthTimeInYears = 2 },
            new TreeSpecies { SpeciesId = 3, LatinName = "name3", GrowthTimeInYears = 3 },
        });

        modelBuilder.Entity<SeedlingBatch>().HasData(new List<SeedlingBatch>()
        {
            new SeedlingBatch
            {
                BatchId = 1, NurseryId = 1, SpeciesId = 1, Quantity = 1, SownDate = DateTime.Parse("2025-05-01"),
                ReadyDate = DateTime.Parse("2027-05-01")
            },
            new SeedlingBatch
            {
                BatchId = 2, NurseryId = 2, SpeciesId = 2, Quantity = 1, SownDate = DateTime.Parse("2025-05-01"),
                ReadyDate = DateTime.Parse("2029-05-01")
            },
            new SeedlingBatch
            {
                BatchId = 3, NurseryId = 3, SpeciesId = 3, Quantity = 1, SownDate = DateTime.Parse("2025-05-01"),
                ReadyDate = DateTime.Parse("2028-05-01")
            },
        });
        modelBuilder.Entity<Employee>().HasData(new List<Employee>()
        {
            new Employee
            {
                EmployeeId = 1, FirstName = "name1", LastName = "lastname1", HireDate = DateTime.Parse("2025-05-01")
            },
            new Employee
            {
                EmployeeId = 2, FirstName = "name2", LastName = "lastname2", HireDate = DateTime.Parse("2025-05-01")
            },
            new Employee
            {
                EmployeeId = 3, FirstName = "name3", LastName = "lastname3", HireDate = DateTime.Parse("2025-05-01")
            },
        });
        modelBuilder.Entity<Responsible>().HasData(new List<Responsible>()
        {
            new Responsible { BatchId = 1, Employee = 1, Role = "role1" },
            new Responsible { BatchId = 2, Employee = 2, Role = "role2" },
            new Responsible { BatchId = 3, Employee = 3, Role = "role3" },
        });
    }
}