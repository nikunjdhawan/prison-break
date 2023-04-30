public class Box
{
    public int Number { get; set; }
    public int ChitNumber { get; set; }

    public override string ToString()
    {
        return "Box Number: " + Number + " | Chit Number: " + ChitNumber;
    }
}
