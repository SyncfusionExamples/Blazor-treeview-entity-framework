using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLTreeView.Shared.Models;
using SQLTreeView.Data;
using SQLTreeView.Shared.DataAccess;
namespace SQLTreeView.Shared.DataAccess
{
    public class OrganizationDataAccessLayer
    {
        OrganizationContext db = new OrganizationContext();
        List<OrganizationDetails> EmployeeList = new List<OrganizationDetails>();
        // returns the organization data from the data base
        public DbSet<OrganizationDetails> GetAllEmployees()
        {
            try
            {
                return db.Organization;
            }
            catch
            {
                throw;
            }
        }

        // Adds the new entry to the data base
        public void AddEmployee(OrganizationDetails Employee)
        {
            try
            {
                db.Organization.Add(Employee);
                OrganizationDetails ParentDetails = db.Organization.Find(Employee.ParentId);
                if (ParentDetails != null)
                {
                    ParentDetails.HasTeam = true;
                }
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // Update the existing data in the data base
        public void UpdateEmployee(OrganizationDetails Employee)
        {
            try
            {
                db.Entry(Employee).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // To delete an entry from the data base
        public void DeleteEmployee(int id)
        {
            try
            {
                OrganizationDetails Employee = db.Organization.Find(id);
                db.Organization.Remove(Employee);
                DeleteChildEmployee(id);
                db.Organization.RemoveRange(EmployeeList);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // To delete the nested child from the data base
        public void DeleteChildEmployee(int id)
        {
            try
            {
                var data = GetAllEmployees().ToList();
                for (int i = 0; i < data.Count(); i++)
                {
                    if (data[i].ParentId == id && EmployeeList.Contains(data[i]) == false)
                    {
                        EmployeeList.Add(data[i]);
                        if (data[i].HasTeam == true)
                        {
                            DeleteChildEmployee(data[i].Id);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
