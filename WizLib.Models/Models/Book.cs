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
    [ForeignKey("BookDetail")]
    public int BookDetail_Id { get; set; }
    public BookDetail BookDetail{ get; set; }
    public Publisher Publisher { get; set; }
    public List<Author> Authors { get; set; }

    [NotMapped]
    public string PriceRange { get; set; }
}
