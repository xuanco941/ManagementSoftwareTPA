using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSoftware.Models
{
    [Table("Group")]
    public class Group
    {

        [Key]
        public int GroupID { get; set; }
        [StringLength(100)]
        public string? GroupName { get; set; } = "";
        public bool IsManagementUser { get; set; }
        public bool IsManagementMachine { get; set; }
    }
}
