namespace DiceRollGame;

public static class InputValidator
{
    private static int CheckIsValidNumber(string input)
    {
        var userInput = input;
        while (true)
        {
            var validNumber = int.TryParse(userInput, out int number);

            if (validNumber && (number > 0 && number < 7))
            {
                return number;
            }

            Console.WriteLine("Enter a valid number");
            userInput = Console.ReadLine();
        }
    }

    public static int ReturnValidatedInput(string userInput) => CheckIsValidNumber(userInput);
}