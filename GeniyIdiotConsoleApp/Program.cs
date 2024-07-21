﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        

    //Commint
        static void Main(string[] args)
        {
            Console.WriteLine("Привет дружище!Напиши, как тебя зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Давай сыграем с тобой в игру!");
            bool flag = true;

            while (flag == true)
            {
                int countQuestions = 5;
                string[] questions = GetQuestions(countQuestions);
                int[] answers = GetAnswers(countQuestions);


                int countRightAnswers = 0;

                Random random = new Random();

                for (int i = countQuestions-1; i >= 1; i--)
                {
                    int index = random.Next(0,i);

                    string tempQuestion = questions[index];
                    questions[index] = questions[i];
                    questions[i] = tempQuestion;

                    int tempAnswers = answers[index];
                    answers[index] = answers[i];
                    answers[i] = tempAnswers;

                }

                for (int i = 0; i < countQuestions; i++)
                {
 
                    Console.WriteLine("Вопрос №" + i + 1);
                    
                    Console.WriteLine(questions[i]);
                    
                    int userAnswer = Convert.ToInt32(Console.ReadLine());

                    int rightAnswer = answers[i];

                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }
                }
                

                Console.WriteLine("Количество правильных ответов: " + countRightAnswers);

                string[] diagnoses = GetDiagnoses();

                Console.WriteLine($"Ваш диагноз, {name}: " + diagnoses[countRightAnswers]);
                Console.WriteLine("Хочешь сыгарть еще раз?");
                string anware =  Console.ReadLine().ToLower();
                if (anware == "нет") flag = false; 
            }
            Console.WriteLine("Спасибо за игру!Удачи!");
            Console.ReadLine();




        }

        static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
            return questions;
        }

        static int[] GetAnswers(int countQuestions)
        {
            int[] answers = new int[countQuestions];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;

            return answers;
        }

        static string[] GetDiagnoses()
        {
            string[] diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";

            return diagnoses;
        }



    }
}
