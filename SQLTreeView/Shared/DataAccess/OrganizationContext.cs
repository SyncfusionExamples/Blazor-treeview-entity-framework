using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLTreeView.Shared.Models;
using SQLTreeView.Data;

namespace SQLTreeView.Shared.DataAccess
{
    public class OrganizationContext : DbContext
    {
        public virtual DbSet<OrganizationDetails> Organization { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Set the "TreeViewConnectionString" environment variable to override the default
                // LocalDB connection (e.g. when using SQL Server in Docker or a remote instance):
                //   TreeViewConnectionString="Server=localhost,1433;Database=NORTHWND;User Id=sa;Password=...;TrustServerCertificate=True"
                var connectionString = Environment.GetEnvironmentVariable("TreeViewConnectionString");
                if (!string.IsNullOrEmpty(connectionString))
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
                else
                {
                    // Default: SQL Server LocalDB, with the NORTHWND.MDF file resolved relative to
                    // the repository (SQLTreeView/Shared/App_Data), so the sample runs from any clone location.
                    var mdfPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(
                        AppContext.BaseDirectory, "..", "..", "..", "..", "Shared", "App_Data", "NORTHWND.MDF"));
                    optionsBuilder.UseSqlServer($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='{mdfPath}';Integrated Security=True;Connect Timeout=30");
                }
            }
        }
    }
}