using System.Collections.Generic;
using System.Linq;

namespace CapitalCityProgram.Models
{
    public class CapitalCity
    {
        public string Name { get; set; }
        public string[] AcceptedNames { get; set; } = new string[0];
        public string[] Hints { get; set; } = new string[0];  // Multiple hints for the city

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