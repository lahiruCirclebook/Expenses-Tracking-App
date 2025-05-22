using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Icon is required.")]
        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        [Required(ErrorMessage = "Type is required.")]
        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }
    }
}
