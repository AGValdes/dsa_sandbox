using System;
using System.Text;
using System.Collections.Generic;
using DataStructures;

public class Multi_Bracket_Validation
{
	public class Bracket
	{
		public static char OGBracket { get; set; }
		public static char Opposite { get; set; }

		public Bracket(char ogbracket, char opposite)
		{
			OGBracket = ogbracket;
			Opposite = opposite;
		}

	}

	public static DataStructures.Stack<Bracket> Stack = new DataStructures.Stack<Bracket>();
	public static char[] TurnStringIntoCharArray(string bracketstring)
	{
		return bracketstring.ToCharArray();
	}
	
	public static char DetermineOpposite(char character)
	{	
		if (character == '{')
		{
			char opposite = '}';
			return opposite;
		}
		else if (character == '[')
		{
			char opposite = ']';
			return opposite;
		}
		else if (character == '(')
		{
			char opposite = ')';
			return opposite;	
		}
    else
		{
			return '-';
		}
	}
	public static List<Bracket> GiveCharsTheirOpposites(char[] arrayOfChars)
	{
		List<Bracket> brackets = new List<Bracket>();
		for (int i = 0; i < arrayOfChars.Length; i++)
		{
			Bracket newBracketObj = new Bracket(arrayOfChars[i], DetermineOpposite(arrayOfChars[i]));
			brackets.Add(newBracketObj);
		}	
		return brackets;
		
	}

	public static void PutOpeningBracketsInStack(List<Bracket> list)
	{

	}

	public static void CheckStackForOpposites(Stack<Bracket> stack)
	{

	}

	public static bool IsItEmpty(Stack<Bracket> stack)
	{

	}
}

