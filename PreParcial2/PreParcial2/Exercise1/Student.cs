using System.Collections.Generic;
using System.Linq;

namespace PreParcial2.Exercise1
{
    internal class Student
    {
        public List<float> Practices;
        public List<float> Quiz;
        public string Name;

        public Student(string name)
        {
            Practices = new List<float>();
            Quiz = new List<float>();
            Name = name;
        }

        public void AddPracticeScore(float score)
        {
            Practices.Add(score);
        }

        public void AddQuizScore(float score)
        {
            Quiz.Add(score);
        }

        public float GetQuizAverageScore()
        {
            return (Quiz.Sum() / Quiz.Count);
        }

        public float GetPracticesAverageScore()
        {
            return (Practices.Sum() / Quiz.Count);
        }
    }
}
