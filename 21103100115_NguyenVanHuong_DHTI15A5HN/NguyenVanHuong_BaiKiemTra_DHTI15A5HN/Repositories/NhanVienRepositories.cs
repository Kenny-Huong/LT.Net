using Microsoft.Identity.Client;
using NguyenVanHuong_BaiKiemTra_DHTI15A5HN.Context;
using NguyenVanHuong_BaiKiemTra_DHTI15A5HN.DomainClass;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHuong_BaiKiemTra_DHTI15A5HN.Repositories
{
    internal class NhanVienRepositories
    {
        private DBContext dbContext;
        private Employees employees;
        public NhanVienRepositories()
        {
            dbContext = new DBContext(); 
        }
        public List<Employees> GetEmployees()
        {
            List<Employees> data = dbContext.Employees.ToList();
            return data;
        }
        public bool AddEmployee(Employees employees)
        {
            if (employees == null)
            {
                return false;
            }
            else
            {
                dbContext.Employees.Add(employees);
                dbContext.SaveChanges();
                return true;
            }
        }
        public bool DeleteEmployee(Employees employees)
        {
            if (employees == null)
            {
                return false;
            }
            else
            {
                dbContext.Employees.Remove(employees);
                dbContext.SaveChanges();
                return true;
            }
        }

    }
}
