using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week4_Classwork
{
    public class Student
    {
        public Student(string name, int age)
        {
            _name = name;
            _age = age;
            _scores = new List<int>();
        }

        public Student(string name, int age, List<int> scores)
        {
            _name = name;
            _age = age;
            _scores = scores;
        }

        public string _name;
        public int _age;
        public List<int> _scores;

        public double GetAverageScore()
        {
            int sum = 0;

            if (_scores.Count == 0)
            {
                return sum;
            }

            foreach (int score in _scores)
            {
                sum += score;
            }

            return sum/_scores.Count;
        }

        public int GetMaxScore()
        {
            int maxim = 0;

            foreach (int score in _scores)
            {
                if (score > maxim)
                {
                    maxim = score;
                }
            }

            return maxim;
        }

        public void AddScore(int score)
        {
            _scores.Add(score);
        }

        public string GetInfo()
        {
            return $"Name: {_name}, Age: {_age}, Average Score: {this.GetAverageScore()}";
        }
    }
}


/*
 * 
 * Create a class Student with the following fields:
- name
- age
- scores (a list of integers representing the scores obtained by the student)

Add the following methods:
- GetAverageScore() - returns the average score of the student.
- GetMaxScore() - returns the maximum score obtained by the student.
- AddScore(score) - adds a new score to the student's list of scores.
- GetInfo() - returns a string with the student's name, age, and average score in the following format: "Name: [name], Age: [age], Average Score: [average score]".
 */