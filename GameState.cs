using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Memento
{
	internal class GameState
	{
		private readonly int _score;
		private readonly int _level;
		private readonly DateTime _stateCreatedAt;
		public GameState(int score, int level)
		{
			_score = score;
			_level = level;
			_stateCreatedAt = DateTime.Now;
		}

		public int GetScore() => _score;
		public int GetLevel() => _level;
		public DateTime GetCreatedDate() => _stateCreatedAt;

		public override string ToString()
		{
			return $"My level: {_level} - My score: {_score}";
		}
	}
}
