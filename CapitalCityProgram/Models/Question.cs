using System;

namespace CapitalCityProgram.Models
{
    public class Question
    {
        public Question(Country country)
        {
            Country = country;

            // Assign a random question format
            var random = new Random();
            Format = (QuestionFormat)random.Next(0, 2);
        }

        public Country Country { get; set; }
        public QuestionFormat Format { get; set; }
        public string Text
        {
            get
            {
                if (Format == QuestionFormat.CapitalCity)
                    return $"What is the capital city of {Country.Name}?";
                else if (Format == QuestionFormat.Country)
                    return $"{Country.CapitalCity.Name} is the capital city of which country?";
                return string.Empty;
            }
        }

        public int HintsLeft { get; set; } = 2;
        public int HintsUsed { get { return 2 - HintsLeft; } }
        public QuestionStatus Status { get; set; } = QuestionStatus.Unanswered;
        public bool Completed { get { return Status != QuestionStatus.Unanswered; } }
    }
}