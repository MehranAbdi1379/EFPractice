using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Models.Models;

public class Book
{
    [Key]
    public int Book_Id { get; set; }
    [Required]
    public int Title { get; set; }
    [Required]
    [MaxLength(15)]
    public string ISBN { get; set; }
    [Required]
    public double Price { get; set; }
    [ForeignKey("Category")]
    public int Category_Id { get; set; }
    public Category Category { get; set; }

    [NotMapped]
    public string PriceRange { get; set; }
}
