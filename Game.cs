using DiceRollGame;

class Game
{
    private int guesses = 3;
    private int _dice = Dice.DiceRoll;

    public void StartGame()
    {
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        Console.WriteLine(_dice);
        while (guesses > 0)
        {
            var userInput = Console.ReadLine();
            var validatedInput = InputValidator.ReturnValidatedInput(userInput);

            if (checkIfNumberIsCorrect(validatedInput))
            {
                Console.WriteLine("Correct number! You win! ^_^");
                return;
            }

            Console.WriteLine("Wrong guess! :(");
            guesses--;
        }

        Console.WriteLine("You lost :(");
    }

    private bool checkIfNumberIsCorrect(int inputNumber) => inputNumber == _dice;

    public void Restart()
    {
        guesses = 3;
        _dice = Dice.RollDice();
    }
}