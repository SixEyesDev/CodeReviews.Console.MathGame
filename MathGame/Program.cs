using MathGame.Logic;
using MathGame.UI;

List<GameData> gameList = new();
TextGenerator _textGenerator = new();
InputParser _inputParser = new(_textGenerator);
EquationHandler _equationHandler = new(_textGenerator);
RandomNumberGenerator _randomNumberGenerator = new();

GameEngine _gameEngine = new(_textGenerator, _inputParser, _equationHandler, _randomNumberGenerator);
DataHandler _dataHandler = new();

_textGenerator.StartingPrompt();
int problemCount = _inputParser.GetNumberFromUser();

_gameEngine.Run(gameList, problemCount);

bool gameOver = false;

while (!gameOver)
{

    _textGenerator.MenuPrompt();

    int userChoice = _inputParser.GetUserMenuOption();

    switch (userChoice)
    {
        case 1:
            _textGenerator.StartingPrompt();
            problemCount = _inputParser.GetNumberFromUser();
            _gameEngine.Run(gameList, problemCount);
            break;
        case 2:
            _dataHandler.DisplayData(gameList);
            break;
        case 3:
            gameOver = true;
            break;
    }
}
