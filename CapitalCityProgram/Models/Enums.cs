namespace CapitalCityProgram.Models
{
    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard,
        VeryHard
    }

    public enum QuestionFormat
    {
        Country = 0,
        CapitalCity = 1
    }

    public enum QuestionStatus
    {
        Correct,
        Incorrect,
        Passed,
        Unanswered
    }
}