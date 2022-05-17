using System;

namespace AlgorithmChallenges
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (var i = 0; i < 6; i++)
			{
				Console.WriteLine(Multi_Bracket_Validation.TurnStringIntoCharArray("{[()]}")[i]);
			}
			
		}
	}
}
