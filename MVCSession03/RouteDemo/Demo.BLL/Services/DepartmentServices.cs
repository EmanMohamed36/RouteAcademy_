using Demo.BLL.DTOs;
using Demo.BLL.Factories;
using Demo.DAL.Models;
using Demo.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services
{
    public class DepartmentServices(IDepartmentRepository _DepartmentRepository) : IDepartmentServices
    // interface injection with primary constructor
    {
        // Get All Departments
        //Data transfere object DTO

        public IEnumerable<DepartmentDTO> GetAllDepartment()
        {
            //var departments = _DepartmentRepository.GetAll().Select(d => new DepartmentDTO()
            //{
            //    DepId = d.Id,
            //    Name = d.Name,
            //    Description = d.Description,
            //    Code = d.Code,
            //    DateOfCreation = DateOnly.FromDateTime(d.CreatedOn)
            //});
            var departments = _DepartmentRepository.GetAll().Select(d => d.ToDepartmentDTO()); //Extension Method
            return departments;
        }

        //Get department by id 
        // Manual Mapping
        //Constructor Mapping
        //Extension Method

        public DepartmentDetailsDTO? GetDepartmentById(int id)
        {
            var department = _DepartmentRepository.GetById(id);

            //return department is null ? null : new DepartmentDetailsDTO()
            //    {
            //        Id = department.Id,
            //        Name = department.Name,
            //        Code = department.Code,
            //        Description = department.Description,
            //        CreatedBy = department.CreatedBy,
            //        LastModifiedBy = department.LastModifiedBy,
            //        IsDeleted = department.IsDeleted,
            //        DateOfCreation = DateOnly.FromDateTime(department.CreatedOn),
            //        LastModifiedOn = DateOnly.FromDateTime(department.LastModifiedOn)

            //};
            //  return department is null ? null : new DepartmentDetailsDTO(department); // Constructor Mapping
            return department is null ? null : department.ToDepartmentDetailsDTO(); // Constructor Mapping


        }

        //Add Department

        public int AddDepartment(CreatedDepartmentDTO departmentDTO)
        {

            return _DepartmentRepository.Add(departmentDTO.ToEntity());
        }

        //Update Department

        public int UpdateDepartment(UpdatedDepartmentDTO departmentDTO)
        {
            return _DepartmentRepository.Update(departmentDTO.ToEntity());
        }


        public bool DeleteDepartment(int id)
        {
            var department = _DepartmentRepository.GetById(id);
            if (department is not null)
            {
                return _DepartmentRepository.Remove(department) > 0 ? true : false;
            }
            else return false;
        }


    }
}
