using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Models.Models;

[Table("Categoria")]
public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(255)]
    [Column("NameOfTheColumn")]
    public string Name { get; set; }
}
