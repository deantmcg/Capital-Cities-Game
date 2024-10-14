using System;
using System.Linq;

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

        public int?[] HintsIndexUsed { get; set; } = new int?[Constants.MaximumHintsPerQuestion];
        public int HintsLeft { get; set; } = 2;
        public int HintsUsed { get { return 2 - HintsLeft; } }
        public QuestionStatus Status { get; set; } = QuestionStatus.Unanswered;
        public bool Completed { get { return Status != QuestionStatus.Unanswered; } }

        public bool IsCorrect(string answer)
        {
            if (Format == QuestionFormat.Country)
            {
                return Country.IsAnswerAccepted(answer);
            }
            else if (Format == QuestionFormat.CapitalCity)
            {
                return Country.CapitalCity.IsAnswerAccepted(answer);
            }

            return false;
        }

        // Gets a random hint
        public string GetHint()
        {
            var hintText = "No hints left";

            // If user has used all available hints
            if (HintsLeft <= 0)
                return hintText;

            Random random = new Random();
            int hintIndex = -1;

            while (hintIndex == -1)
            {
                var tempIndex = random.Next(0, 3);

                // Check user already received this hint
                if (!HintsIndexUsed.Contains(tempIndex))
                {
                    hintIndex = tempIndex;
                    // Get the index which is free in HintsIndexUsed
                    int freeIndex = Constants.MaximumHintsPerQuestion - HintsIndexUsed.Count(x => x == null);
                    HintsIndexUsed[freeIndex] = tempIndex;
                }
            }

            if (Format is QuestionFormat.Country)
            {
                hintText = Country.Hints[hintIndex];
            }
            else if (Format is QuestionFormat.CapitalCity)
            {
                hintText = Country.CapitalCity.Hints[hintIndex];
            }

            HintsLeft--;
            return hintText;
        }
    }
}