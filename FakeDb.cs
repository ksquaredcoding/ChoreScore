namespace ChoreScore.Data;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Wash Dishes", "Wash, dry, and put dishes away", ChoreType.Kitchen)
  };
}