using CapitalCityProgram.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CapitalCityTests.Helpers
{
    public class HighScoresHelper
    {
        private const string fileName = "high_scores.json";
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameFiles", fileName);

        public static List<HighScore> GetHighScores()
        {
            try
            {
                // Read the content of the JSON file
                string jsonString = File.ReadAllText(filePath);

                // Reuse the new method to deserialize from a string
                return DeserializeHighScores(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading high scores from file: {ex.Message}");
                return new List<HighScore>();
            }
        }

        public static List<HighScore> DeserializeHighScores(string jsonString)
        {
            try
            {
                // Deserialize the JSON content into a list of HighScore objects
                return JsonConvert.DeserializeObject<List<HighScore>>(jsonString)
                    .OrderByDescending(x => x.Score)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing high scores from JSON string: {ex.Message}");
                return new List<HighScore>(); // Return an empty list in case of an error
            }
        }

        // Method to add a new high score and save it
        public static void AddNewHighScore(string username, int score)
        {
            var highScores = GetHighScores();

            // Add new high score
            highScores.Add(new HighScore
            {
                Username = username,
                Score = score,
                Timestamp = DateTime.UtcNow
            });

            // Save updated list to the file
            SaveHighScores(highScores);
        }

        // Method to save high scores to the file
        public static void SaveHighScores(List<HighScore> highScores)
        {
            string json = JsonConvert.SerializeObject(highScores, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}