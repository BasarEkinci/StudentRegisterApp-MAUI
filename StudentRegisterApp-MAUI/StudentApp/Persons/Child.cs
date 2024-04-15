namespace StudentApp.Persons;

public class Child
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Team { get; set; }
    
    public string FullName => $"{Name} {LastName}";

    public Child(string Name,string LastName, string Gender, string Team)
    {
        this.Name = Name;
        this.LastName = LastName;
        this.Gender = Gender;
        this.Team = Team;
    }
}
