namespace Behavioral_Memento
{
	internal class GameOriginator
	{
		public int Score { get; set; }
		public int Level { get; set; }
		
		public GameState CreateState()
		{
			return new GameState(Score, Level);
		}

		public void Restore(GameState state)
		{
			Score = state.GetScore();
			Level = state.GetLevel();
		}
	}
}
