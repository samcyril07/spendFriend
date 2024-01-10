﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace spendFriend.Models
{

    public class Category
    { 
    [Key]
    public int CategoryId { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Required(ErrorMessage ="Title is a mandatory field")]
    public string Title { get; set; }
    [Column(TypeName = "nvarchar(5)")]
    public string Icon { get; set; } = "";

    [Column(TypeName = "nvarchar(10)")]
    public string Type { get; set; } = "expense";

    public string?  TitleWithIcon
        {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }

}
}
