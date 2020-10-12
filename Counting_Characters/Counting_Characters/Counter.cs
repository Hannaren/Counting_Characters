using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Counter
{
	public static Dictionary<char, int> charCounter(string input)
	{
		input = input.ToLower();
		Dictionary<char, int> countChars = new Dictionary<char, int>();
		char[] chars = input.ToCharArray();

		foreach (char c in chars)
        {
			if (char.IsLetter(c))
            {
				if (countChars.ContainsKey(c))
                {
					countChars[c]++;
				}
				else
				{
					countChars.Add(c, 1);
				}
			}
        }

		return countChars;
	}
}
