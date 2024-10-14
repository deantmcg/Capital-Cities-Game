using System.Collections.Generic;
using System.Linq;

namespace CapitalCityProgram.Models
{
    public class GameDetails
    {
        public string Username { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public int Score { get; set; } = 0;
        public List<Question> Questions { get; set; }
        public int CurrentQuestionIndex { get; set; } = 0;
        public Question CurrentQuestion { get {  return Questions[CurrentQuestionIndex]; } }

        public int HintsUsed
        {
            get
            {
                return Questions.Sum(x => x.HintsUsed);
            }
        }

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

        public void NextQuestion()
        {
            CurrentQuestionIndex++;
        }

        public void PreviousQuestion()
        {
            CurrentQuestionIndex--;
        }

        public void PassQuestion()
        {
            CurrentQuestion.Status = QuestionStatus.Passed;
            CurrentQuestionIndex++;
        }
    }
}