using CapitalCityProgram.Models;
using CapitalCityTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapitalCityProgram.Helpers
{
    public class QuestionsGenerator
    {
        private List<Country> _countries = CountriesAndCapitalsReader.GetCountries();
        private List<Question> _questions = new List<Question>();

        public List<Question> GetQuestions(DifficultyLevel difficulty)
        {
            Random _random = new Random();
            _countries = _countries.OrderBy(x => _random.Next()).ToList();
            var questionCounts = GetQuestionCountPerDifficulty(difficulty);
            questionCounts = FixQuestionCounts(questionCounts);

            // Loop question counts backwards
            for (var i = 3; i >= 0; i--)
            {
                for (var j = questionCounts[i]; j > 0; j--)
                {
                    var questionDifficulty = (DifficultyLevel)i;
                    var question = GenerateQuestion(questionDifficulty);
                    _questions.Add(question);
                }
            }

            return _questions.OrderBy(x => _random.Next()).ToList();
        }

        // Get a question for a chosen difficulty
        private Question GenerateQuestion(DifficultyLevel difficulty)
        {
            var country = _countries
                .Where(x => x.Difficulty == difficulty &&
                            !_questions.Select(y => y.Country).Contains(x)) // Ensure country already isn't selected for questions
                .FirstOrDefault();

            return new Question(country);
        }

        public int[] GetQuestionCountPerDifficulty(DifficultyLevel difficultyLevel)
        {
            // Get the total number of countries available
            int countryCount = _countries.Count;

            // Initialize the array to store the count for each difficulty: Easy, Medium, Hard, Very Hard
            int[] questionCounts = new int[4];

            // Set the maximum number of questions for each difficulty level
            int maxEasy = Math.Min(15, countryCount);  // Max 15, but can't exceed available countries
            int maxMedium = Math.Min(20, countryCount);  // Max 20, but can't exceed available countries
            int maxHard = Math.Min(30, countryCount);  // Max 30, but can't exceed available countries
            int maxVeryHard = Math.Min(30, countryCount);  // Max 30, but can't exceed available countries

            switch (difficultyLevel)
            {
                case DifficultyLevel.Easy:
                    // All questions should be easy, up to the max of 15
                    questionCounts[0] = maxEasy;  // Easy questions
                    break;

                case DifficultyLevel.Medium:
                    // Distribute 20 questions with most being easy and medium, and some hard
                    questionCounts[0] = Math.Min(8, maxMedium);  // Easy
                    questionCounts[1] = Math.Min(10, maxMedium - questionCounts[0]);  // Medium
                    questionCounts[2] = Math.Min(2, maxHard - questionCounts[1]);  // Hard
                    break;

                case DifficultyLevel.Hard:
                    // Distribute 30 questions with most being hard, and some medium and very hard
                    questionCounts[1] = Math.Min(8, maxHard);  // Medium
                    questionCounts[2] = Math.Min(16, maxHard - questionCounts[1]);  // Hard
                    questionCounts[3] = Math.Min(6, maxVeryHard - questionCounts[2]);  // Very Hard
                    break;

                case DifficultyLevel.VeryHard:
                    // Distribute 30 questions between hard and very hard
                    questionCounts[2] = Math.Min(15, maxHard);  // Hard
                    questionCounts[3] = Math.Min(15, maxVeryHard - questionCounts[2]);  // Very Hard
                    break;
            }

            // Ensure the total number of questions doesn't exceed the available countries
            int totalQuestions = questionCounts.Sum();
            if (totalQuestions > countryCount)
            {
                // Scale down proportionally if necessary
                double scale = (double)countryCount / totalQuestions;
                questionCounts[0] = (int)(questionCounts[0] * scale);
                questionCounts[1] = (int)(questionCounts[1] * scale);
                questionCounts[2] = (int)(questionCounts[2] * scale);
                questionCounts[3] = (int)(questionCounts[3] * scale);
            }

            return questionCounts;
        }

        // Ensures there is enough questions for question count
        private int[] FixQuestionCounts(int[] questionCounts)
        {
            for (int i = 3; i >= 0; i--)
            {
                if (questionCounts[i] == 0)
                    continue;

                var difficulty = (DifficultyLevel)i;
                var questionsAvailableForDifficulty = _countries.Count(x => x.Difficulty == difficulty);

                var difference = questionsAvailableForDifficulty - questionCounts[i];

                // If there is not enough questions for this difficulty
                if (difference < 0)
                {
                    // Decrease the question count for this difficulty
                    questionCounts[i] = questionCounts[i] + difference;

                    // If difficulty is not Easy
                    if (i != 0)
                    {
                        // Increase count for the difficulty lower than current difficulty
                        questionCounts[i - 1] = questionCounts[i - 1] - difference;
                    }
                }
            }

            return questionCounts;
        }
    }
}
