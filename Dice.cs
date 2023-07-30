static class Dice
{
    private static readonly Random RandomNumber = new Random();

    public static readonly int DiceRoll = RollDice();

    public static int RollDice() => RandomNumber.Next(1, 6);
}