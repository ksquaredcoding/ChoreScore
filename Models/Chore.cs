namespace ChoreScore.Models;

public class Chore
{
  public string Id { get; private set; }
  public string Name { get; private set; }
  public string Description { get; private set; }
  public ChoreType TheType { get; private set; }

  public Chore(string name, string description, ChoreType theType)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Description = description;
    TheType = theType;
  }
}