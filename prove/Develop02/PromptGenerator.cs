using System;
public class PromptGenerator
{
    static string[] prompts = {"What was your favorite thing you did today?", "What is something you learned today?", "How do you feel about today? Why?"};
    static public List<string> _promptsList = new List<string>(prompts);
    static int promptsCount = _promptsList.Count;
    static Random rnd = new Random();
    public string Prompt()
    {
        int num = rnd.Next(promptsCount);
        string prompt = (_promptsList[num]);
        return prompt;
    }
}