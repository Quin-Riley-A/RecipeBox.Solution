using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Tag
  {
    public int TagId { get; set; }
    [Required(ErrorMessage = "Field cannot be empty!")]
    public string Cuisine { get; set; }
    public List<RecipeTag> JoinEntities { get; }
  }
}