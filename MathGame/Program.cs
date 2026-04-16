using MathGame.Logic;
using MathGame.UI;

List<GameData> gameList = new();
TextGenerator textGenerator = new();
InputParser parser = new();
GameEngine gameEngine = new(textGenerator);
DataHandler dataHandler = new();

textGenerator.StartingPrompt();
int problemCount = parser.GetNumberFromUser();

gameEngine.Run(gameList, problemCount);

bool gameOver = false;

while (!gameOver)
{

    textGenerator.MenuPrompt();

    int userChoice = parser.GetUserMenuOption();

    switch (userChoice)
    {
        case 1:
            textGenerator.StartingPrompt();
            problemCount = parser.GetNumberFromUser();
            gameEngine.Run(gameList, problemCount);
            break;
        case 2:
            dataHandler.DisplayData(gameList);
            break;
        case 3:
            gameOver = true;
            break;
    }
}
