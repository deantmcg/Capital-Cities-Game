using System.Collections.Generic;
using System.Linq;

namespace CapitalCityProgram.Models
{
    public class GameDetails
    {
        public string Username { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public int Score { get; set; } = 0;
        public int HintsUsed { get; set; } = 0;
        public List<Question> Questions { get; set; }

        public int QuestionsPassed
        {
            get
            {
                if (Questions.Count == 0)
                    return 0;

                return Questions.Count(x => x.Status == QuestionStatus.Passed);
            }
        }

        public int QuestionsAsked
        {
            get
            {
                if (Questions.Count == 0)
                    return 0;

                return Questions.Count(x => x.Status != QuestionStatus.Unanswered);
            }
        }

        // takes an int variable and updates score
        public void UpdateScore(int change)
        {
            Score += change;
        }
    }
}