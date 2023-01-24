namespace Unit_Tests.Character_counter;

public class CharacterCounter
{
    //Consecutive means (in this project) is the same as 10,11,12 or a,b,c , but it can not be like 12,11,10 or c,b,a
    private string _argument;

    public CharacterCounter(string argument = "") => _argument = argument;

    public void ChangeArgument(string str = "") => _argument = str;

    public int ConsecutiveNonIdenticalLetter()
    {
        if (string.IsNullOrEmpty(_argument))
        {
            return -1;
        }

        int result = 0;
        string argument = Trimmer(_argument.ToLower(), ' ');
        int length = argument.Length;
        for (int i = 0; i < length; i++)
        {
            if (i + 1 < length && (argument[i] - argument[i + 1] == -1))
            {
                result++;
            }
        }

        return result;
    }

    public int ConsecutiveIdenticalLetter()
    {
        if (string.IsNullOrEmpty(_argument))
        {
            return -1;
        }

        int result = 0;
        string str = _argument.ToLower();
        string argument = Trimmer(str, ' ');
        int length = argument.Length;
        for (int i = 0; i < length; i++)
        {
            if (i + 1 < length && (argument[i] - argument[i + 1] == -1 || argument[i].Equals(argument[i + 1])))
            {
                result++;
            }
        }

        return result;
    }


    //Trimmer method returns a string without any whitespace
    private string Trimmer(string str, char ele)
    {
        string result = "";
        foreach (var s in str)
        {
            if (!s.Equals(ele)) result += s;
        }


        return result;
    }
}