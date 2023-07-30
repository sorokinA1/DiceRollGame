var game = new Game();

while (true)
{
    game.StartGame();
    Console.WriteLine("Want to start a new game? [y/n]");
    var answer = Console.ReadLine();

    if (answer != "y".ToLower()) break;

    game.Restart();
}