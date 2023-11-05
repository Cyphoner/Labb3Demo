using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Demo.Models
{
    internal class AllQuestion
    {
        public List<Question> _AllQuestion = new List<Question>();

        internal class AllQuizQuestions
        {
            public List<Question> _allQuizQuestions = new List<Question>()
            {
                // ANIME 
                new Question("What is the name of the character on the picture?", new string[] {"Sasuke", "Kakashi", "Jiraya", "Naruto"}, 4, "Anime", "\\images\\Naruto.jpg"),
                new Question("What is Gon Freecss' Nen ability category (Nen type) in 'Hunter x Hunter'?", new string[] {"Enhancer", "Emitter", "Manipulator", "Transmuter"}, 1, "Anime", "\\images\\Gon.jpg"),
                new Question("What is L's real name in 'Death Note''?", new string[] {"L Lawless", "L Lawliet", "L Lawman", "L Livermore"}, 2, "Anime", "\\images\\L.jpg"),
                new Question("What is Lelouch's code name when he leads the rebellion against Britannia in 'Code Geass'?", new string[] {"Zero", "One", "Knight", "Ace"}, 1, "Anime", "\\images\\Lelouch.jpg"),

                // FOOTBALL 
                new Question("How many league titles have Zlatan won in his career?", new string[] {"3", "6", "14", "17"}, 3, "Football", "\\images\\Zlatan.jpg"),
                new Question("Which club did Eden Hazard join in 2019 after leaving Chelsea?", new string[] {"Barcelona", "PSG", "Real Madrid", "Juventus"}, 3, "Football", "\\images\\Hazard.jpg"),
                new Question("What is Lionel Messi's nationality?", new string[] {"Brazil", "Argentina", "Germany", "Portugal"}, 2, "Football", "\\images\\Messi.jpg"),
                new Question("In which country did Cristiano Ronaldo begin his professional football career?", new string[] {"Spain", "Portugal", "England", "Italy"}, 2, "Football", "\\images\\Ronaldo.jpg"),

                // TRIVIA
                new Question("What is the capital of Japan?", new string[] {"Tokyo", "Beijing", "Seoul", "Bangkok"}, 1, "Trivia", "\\images\\Japan.jpg"),
                new Question("What is the largest mammal on Earth?", new string[] {"African Elephant", "Blue Whale", "Giraffe", "Polar bear"}, 2, "Trivia", "\\images\\------.jpg"),
                new Question("What is the largest organ in the human body?", new string[] {"Brain", "Heart", "Liver", "Skin"}, 4, "Trivia", "\\images\\-------.jpg"),
                new Question("What is the smallest prime number?", new string[] {"1", "2", "3", "4"}, 2, "Trivia", "\\images\\----.jpg")

            };


        }

    } 

    
}
