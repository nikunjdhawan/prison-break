public class Prison
{
    public List<Prisoner> Prisoners { get; set; }
    public Prison()
    {
        var numbers = Helper.GetRandomNumbers();
        Prisoners = new List<Prisoner>();
        for (int i = 0; i < 100; i++)
        {
            Prisoner prisoner = new Prisoner();
            prisoner.Number = numbers[i];
            Prisoners.Add(prisoner);
        }
    }
}