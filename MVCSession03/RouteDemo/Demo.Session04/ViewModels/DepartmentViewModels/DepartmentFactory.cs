using Demo.BLL.DTOs;

namespace Demo.PL.ViewModels.DepartmentViewModels
{
   static class DepartmentFactory
    {
        public static DepartmentEditViewModel FromDetailsDTOsTOEditViewModel
        (this DepartmentDetailsDTO departmentDTO)
        {
            return new DepartmentEditViewModel()
            {
                Code = departmentDTO.Code,
                Name = departmentDTO.Name,
                Description = departmentDTO.Description,
                CreatedOn = departmentDTO.DateOfCreation
            };
        
        }
        public static UpdatedDepartmentDTO FromEditViewModelToUpdateDTO
       (this DepartmentEditViewModel departmentDTO)
        {
            return new UpdatedDepartmentDTO()
            {
               Code = departmentDTO.Code,
               Name = departmentDTO.Name,
               Description = departmentDTO.Description,
               CreatedOn = departmentDTO.CreatedOn
            };

        }
    }
}
