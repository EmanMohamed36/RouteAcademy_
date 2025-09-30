

namespace Demo.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; } // UserId who Insert the Record
        public DateTime CreatedOn { get; set; } // Date of create record

        public int LastModifiedBy { get; set; } // UserId Who last modified it

        public DateTime LastModifiedOn { get; set; } //  Date When it was last modified [Automatically Calculated ] 

        public bool IsDeleted { get; set; }
    }
}
