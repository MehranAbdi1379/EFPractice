using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Models.Models;

public class Fluent_Book
{
    public int Book_Id { get; set; }
    public int Title { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }
}
