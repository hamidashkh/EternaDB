using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EternaDB.Models
{
    public class Teams
    {
        public int Id { get; set; }
        [StringLength(100),Required]
        public string FullName { get; set; }
        [StringLength(100),Required]
        public string Description { get; set; }
        [StringLength(100), Required]
        public string Job { get; set; }
        public string Imgae { get; set; }
    }
}
