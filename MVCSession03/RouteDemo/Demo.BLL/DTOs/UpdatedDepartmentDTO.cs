using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs
{
    public class UpdatedDepartmentDTO :CreatedDepartmentDTO
    {
        public int Id { get; set; }
      
    }
}
