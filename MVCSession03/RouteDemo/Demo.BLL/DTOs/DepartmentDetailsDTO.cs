using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs
{
    public class DepartmentDetailsDTO
    {

        //public DepartmentDetailsDTO(Department department)
        //{
        //    Id = department.Id;
        //    Name = department.Name;
        //    Code = department.Code;
        //    Description = department.Description; 
        //    CreatedBy = department.CreatedBy;
        //    LastModifiedBy = department.LastModifiedBy;
        //    IsDeleted = department.IsDeleted;
        //    DateOfCreation = DateOnly.FromDateTime(department.CreatedOn);
        //    LastModifiedOn = DateOnly.FromDateTime(department.LastModifiedOn);
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Code { get; set; }

        public DateOnly DateOfCreation { get; set; }
        public DateOnly LastModifiedOn { get; set; }

        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
