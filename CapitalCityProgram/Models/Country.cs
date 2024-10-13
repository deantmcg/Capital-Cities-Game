using System.Collections.Generic;
using System.Linq;

namespace CapitalCityProgram.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string[] AcceptedNames { get; set; } = new string[0];  // Optional, defaults to empty array
        public CapitalCity CapitalCity { get; set; }
        public DifficultyLevel Difficulty { get; set; }

        public string Continent { get; set; }
        public long Population { get; set; }
        public string[] Hints { get; set; } = new string[0];  // Multiple hints for the country

        public string[] Languages { get; set; } = new string[0];  // Spoken languages
        public string[] NeighbouringCountries { get; set; } = new string[0];  // List of neighbouring countries

        private string[] AllAcceptedNames
        {
            get
            {
                var names = new List<string>() { Name };
                names.AddRange(AcceptedNames);
                return names.ToArray();
            }
        }

        public bool IsAnswerAccepted(string answer, bool normalizeAccents = true)
        {
            var possibleAnswers = AllAcceptedNames;

            answer = StringHelper.Normalize(answer, normalizeAccents);
            for (int i = 0; i < possibleAnswers.Length; i++)
            {
                possibleAnswers[i] = StringHelper.Normalize(possibleAnswers[i]);
            }

            return possibleAnswers.Contains(answer);
        }
    }
}