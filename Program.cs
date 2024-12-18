//My personal memento project
//This pattern is useful to take a snapshot of a system, and to be able to restore its (previus state or stack of state)
//The history class mantain the history of originator (our game class)
//The history class and the originator is loosely coupled
//The memento pattern can use a huge amount of ram, for example if you want backup a state of a video, or a photo
//The are other types of patter for save the state of a system.

GameOriginator game = new GameOriginator();
GameHistory history = new GameHistory(game);
history.Backup("Backup ONE");
game.Level = 1;
game.Score = 0;
history.Backup("Backup TWO");
game.Level = 2;
game.Score = 10;
history.Backup("Backup THREE");
game.Level = 3;
game.Score = 25;
history.Backup("Backup FOUR");


Console.WriteLine($"Actual level: {game.Level}");
Console.WriteLine($"Actual score: {game.Score}");

Console.WriteLine(System.Environment.NewLine+ System.Environment.NewLine);
history.ShowHistory();
Console.WriteLine(System.Environment.NewLine + System.Environment.NewLine);

history.Undo();
Console.WriteLine($"Actual level, after uno: {game.Level}");
Console.WriteLine($"Actual score, after uno: {game.Score}" + System.Environment.NewLine);

history.Undo();
Console.WriteLine($"Actual level, after uno: {game.Level}");
Console.WriteLine($"Actual score, after uno: {game.Score}" + System.Environment.NewLine);

history.Undo();
Console.WriteLine($"Actual level, after uno: {game.Level}");
Console.WriteLine($"Actual score, after uno: {game.Score}" + System.Environment.NewLine);

history.Undo();
Console.WriteLine($"Actual level, after uno: {game.Level}");
Console.WriteLine($"Actual score, after uno: {game.Score}" + System.Environment.NewLine);