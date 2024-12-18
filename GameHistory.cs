namespace Behavioral_Memento
{
	internal class GameHistory
	{
		private Dictionary<string, GameState> _states = new Dictionary<string, GameState>();
		private GameOriginator _game;

		public GameHistory(GameOriginator game)
		{
			_game = game;
		}

		public void Backup(string nameBackup)
		{
			_states.Add(nameBackup, _game.CreateState());
		}

		public void Undo()
		{
			if (_states.Count > 0)
			{
				GameState prevState = _states.Last().Value;
				string nameBackup = _states.Last().Key;
				Console.WriteLine($"Undo to the last backup: {nameBackup}");
				_states.Remove(nameBackup);
				_game.Restore(prevState);
			}
			else
			{
				Console.WriteLine("You have reached the final of Undo stack");
				return;
			}
		}

		public void ShowHistory()
		{
			Console.WriteLine("History: the list of saved Mementos:");
			foreach (KeyValuePair<string, GameState> state in _states)
			{
				Console.WriteLine($"Name of backup:{state.Key} - {state.Value.ToString()}");
			}
		}
	}
}
