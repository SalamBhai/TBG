using System;

class Prompt
{
    public static bool ValidateGender(string s)
    {
        s = s.Trim().ToUpperInvariant();
        return s == "MALE" || s == "FEMALE";
    }

    public static bool ValidateYear(string s)
    {
        int year;
        if (!int.TryParse(s, out year))
        {
            return false;
        }

        return DateTime.Now.Year - year >= 18;
    }

    public static bool NullValidation(string _) => true;

    public static string PromptString(string prompt, Func<string, bool> validate = null)
    {
        if (validate == null)
        {
            validate = NullValidation;
        }

        string result;
        var isValid = false;
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
            isValid = validate(result);
        }
        while (!isValid);

        return result;
    }


    // static void Main1(string[] args)
    // {
    //     PromptString("Enter gender (MALE/FEMALE): ", ValidateGender);
    //     PromptString("Enter gender (M/F): ", Validate2);
    //     PromptString("Enter year: ", ValidateYear);
    // }
}