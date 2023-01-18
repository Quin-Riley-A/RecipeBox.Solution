using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Instruction { get; set; }
    public List<RecipeTag> JoinEntities { get; }
  }
}