public class Validator
{
    public bool CheckString(string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;
        return true;
    }
}

git add Validator.cs
git commit -m 