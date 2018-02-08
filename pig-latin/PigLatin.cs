using System;

public static class PigLatin
{
    public static string Translate(string word)
    {
        if (word.Substring(0, 1) == "a")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "e")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "i")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "o")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "u")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "u")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 2) == "ch")
        {
            string firstLetters = word.Substring(0, 2);
            string afterCh = word.Substring(2);
            return afterCh + firstLetters + "ay";
        }
        else if (word.Substring(0, 2) == "qu")
        {
            string firstLetters = word.Substring(0, 2);
            string afterCh = word.Substring(2);
            return afterCh + firstLetters + "ay";
        }
        else if (word.Substring(1, 1) == "y")
        {
            string mLetters = word.Substring(0, 1);
            string afterM = word.Substring(1);
            return afterM + mLetters + "ay";
        }
        else if (word.Substring(0, 3) == "squ")
        {
            string squLetters = word.Substring(0, 3);
            string afterSqu = word.Substring(3);
            return afterSqu + squLetters + "ay";
        }
        else if (word.Substring(0, 3) == "thr")
        {
            string squLetters = word.Substring(0, 3);
            string afterSqu = word.Substring(3);
            return afterSqu + squLetters + "ay";
        }
        else if (word.Substring(0, 2) == "th")
        {
            string squLetters = word.Substring(0, 2);
            string afterSqu = word.Substring(2);
            return afterSqu + squLetters + "ay";
        }
        else if (word.Substring(0, 3) == "sch")
        {
            string schLetters = word.Substring(0, 3);
            string afterSch = word.Substring(3);
            return afterSch + schLetters + "ay";
        }
        else if (word.Substring(0, 2) == "yt")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 2) == "xr")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 2) == "rh")
        {
            string rhLetters = word.Substring(0, 2);
            string afterRh = word.Substring(2);
            return afterRh + rhLetters + "ay";
        }
        else if (word.Substring(0, 2) == "y")
        {
            string rhLetters = word.Substring(0, 2);
            string afterRh = word.Substring(2);
            return afterRh + rhLetters + "ay";
        }
        //else if (word.Substring(0, 1) == "m")
        //{
        //    string mLetter = word.Substring(0, 1);
        //    char[] array = word.ToCharArray();
        //    char afterM = array[2];
        //    string toString = afterM.ToString();
        //    return toString + mLetter + "ay";
        //}
        else
        {
            string firstLetter = word.Substring(0, 1);
            string restWord = word.Substring(1);
            return restWord + firstLetter + "ay";

        }

    }
}
