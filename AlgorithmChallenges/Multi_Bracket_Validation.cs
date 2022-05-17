using System;
using System.Text;
using System.Collections.Generic;
using DataStructures;

public class Multi_Bracket_Validation
{
	public class Bracket
	{
		public char OGBracket { get; set; }
		public char Opposite { get; set; }
		public bool IsOpening { get; set; }

		public Bracket (char ogBracket)
		{
			OGBracket = ogBracket;
		}
		public Bracket(char ogBracket, char opposite, bool isOpening)
		{
			OGBracket = ogBracket;
			Opposite = opposite;
			IsOpening = isOpening;		
		}

	}

	public static DataStructures.Stack<Bracket> Stack = new DataStructures.Stack<Bracket>();
	public static char[] TurnStringIntoCharArray(string bracketstring)
	{
		return bracketstring.ToCharArray();
	}

	public static Bracket[] MakeBracketObjects (char[] arrayOfChars)
	{
		Bracket[] bracketObjects = new Bracket[arrayOfChars.Length];

		for (int i = 0; i < arrayOfChars.Length; i++)
		{

			if (arrayOfChars[i] == '{')
			{
				char opposite = '}';
				bracketObjects[i] = new Bracket(arrayOfChars[i], opposite, true);
			}
			else if (arrayOfChars[i] == '[')
			{
				char opposite = ']';
				bracketObjects[i] = new Bracket(arrayOfChars[i], opposite, true);
			}
			else if (arrayOfChars[i] == '(')
			{
				char opposite = ')';
				bracketObjects[i] = new Bracket(arrayOfChars[i], opposite, true);
			}
			else
			{
				bracketObjects[i] = new Bracket(arrayOfChars[i]);
			}
		}

		return bracketObjects;
	}



	public static void PutOpeningBracketsInStack(Bracket[] brackets)
	{
		for (int i = 0; i < brackets.Length; i++)
		{
			if (brackets[i].IsOpening == true)
			{
				Stack.Push(brackets[i]);	
			}
		}

  }

	public static void CheckStackForOpposites(DataStructures.Stack<Bracket> stack, Bracket[] bracketArr)
	{
		Node<Bracket> topNodeOfStack = stack.Peek();
		Bracket topBracketOftack = topNodeOfStack.Value;
		
		for (int i = 0; i < bracketArr.Length; i++)
		{
			if (bracketArr[i].OGBracket == topBracketOftack.Opposite)
			{
				Stack.Pop();
			}
			else
			{
				continue;
			}
		}
	}

	public static bool IsItEmpty(DataStructures.Stack<Bracket> stack)
	{
		if (stack.Peek() == null){
			return true;
		}
		else
		{
			return false;
		}
	}

	public static bool DoAllOpeningBracketsHaveClosingBrackets(string bracketstring)
	{
		char[] characterArray = TurnStringIntoCharArray(bracketstring);
		Bracket[] bracketObjArray = MakeBracketObjects(characterArray);
	  
		PutOpeningBracketsInStack(bracketObjArray);
		CheckStackForOpposites(Stack, bracketObjArray);

		return IsItEmpty(Stack);

	}
}

