using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    [Required(ErrorMessage = "Field cannot be empty!")]
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Instruction { get; set; }
    public List<RecipeTag> JoinEntities { get; }
  }
}