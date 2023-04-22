using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        bool isEmpty = false;
        bool hasLetters;
        string temp = statement.Trim();
        bool emptyCheckTemp = false;
        if (temp.Any(x => char.IsLetter(x)))
        {
            hasLetters = true;
        }
        else
        {
            hasLetters = false;
        }
        for (int i = 0; i < temp.Length; i++)
        {
            if (char.IsWhiteSpace(temp[i]))
            {
                emptyCheckTemp = true;
            }
            else
            {
                emptyCheckTemp = false;
                break;
            }
            
        }
        if (emptyCheckTemp == true)
        {
            isEmpty = true;
        }
        if (temp.Length == 0 || temp == null)
            return "Fine. Be that way!";

        if (temp[temp.Length - 1] == '?' && temp == temp.ToUpper()&& hasLetters != false)
        {
            return "Calm down, I know what I'm doing!";
        } 
        else if (isEmpty)
        {
            return "Fine. Be that way!";
        }
        
        else if (temp[temp.Length - 1] == '?' || temp[0] == '?')
        {
            return "Sure.";
        }
        else if (temp == temp.ToUpper() && !isEmpty && hasLetters)
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }
}