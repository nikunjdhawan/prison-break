public class BoxRoom
{
    public BoxRoom()
    {
        var numbers = Helper.GetRandomNumbers();
        Boxes = new List<Box>();
        for (int i = 0; i < 100; i++)
        {
            Box box = new Box();
            box.Number = i + 1;
            box.ChitNumber = numbers[i];
            Boxes.Add(box);
        }
    }
    public List<Box> Boxes { get; set; }

    public bool EnterRoom(Prisoner prisoner)
    {
        int trial = 0;
        bool found = false;
        int nextBoxNumber = prisoner.Number;
        while (trial < 51 && !found)
        {
            Box box = GetBox(nextBoxNumber);
            if(box.ChitNumber == prisoner.Number)
            {
                found = true;
            }
            trial = trial + 1;
            nextBoxNumber = box.ChitNumber;
        }
        return found;
    }

    public Box GetBox(int number)
    {
        return Boxes.Where(b => b.Number == number).First();
    }
}