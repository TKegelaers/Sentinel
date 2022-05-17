namespace Sentinel.Core.Domain;

public class Player
{
    public string Name { get; set; }
    public string Sex { get; set; }

    public Player(string name, string sex)
    {
        Name = name;
        Sex = sex;
    }
}