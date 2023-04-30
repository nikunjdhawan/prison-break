// See https://aka.ms/new-console-template for more information
Prison prison = new Prison();
BoxRoom boxroom = new BoxRoom();
int count = 0;
foreach (var p in prison.Prisoners)
{
    bool found = boxroom.EnterRoom(p);
    if (found)
    {
        System.Console.WriteLine("Found the Chit for Prisoner {0}", p.Number);
        count++;
    }
    else
    {
        System.Console.WriteLine("Jail Break failed for Prisoner {0}", p.Number);
    }

}
if (count < 100)
{
    System.Console.WriteLine("Kill them all !");
}
else
{
    System.Console.WriteLine("Free them all !");
}