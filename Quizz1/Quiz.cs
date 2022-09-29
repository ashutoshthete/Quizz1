using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz1
{
    public class Test
    {

        public static void Main(string[] args)
        {

            
            Quiz quiz = new Quiz();
            quiz.begin();

        }
    }
    public class Quiz
    {
        public void begin()
        {
            Question[] questions = new Question[5];

            questions[0] = new Question("Which of the following keyword is used to change data and behavior of a base class by replacing a member of the base class with a new derived member", "Overloads", "Overrides ", "new ", "base", new Answer("new"));
            questions[1] = new Question("C# is a programming language, developed by", "Oracle", "Microsoft ", "GNU project ", "Google", new Answer("Microsoft"));
            questions[2] = new Question("C# programming language is used to develop", "Web apps", "Desktop apps ", "Mobiles apps ", "All of the above", new Answer("All of the above"));
            questions[3] = new Question("What is the extension of a C# language file", ".c", ".cpp ", ".cs ", ".csp", new Answer(".cs"));
            questions[4] = new Question("Who is the founder of C# programming language?", "Anders Hejlsberg", "Douglas Crockford ", "Rasmus Lerdorf ", "Brendan Eich", new Answer("Anders Hejlsberg"));

            int countTotal = 0;
            int countRight = 0;
            int countWrong = 0;

            foreach(Question q in questions)
            {
                Console.WriteLine(q.getQuestion());
                Console.WriteLine("A : " + q.getOption1());
                Console.WriteLine("B : " + q.getOption2());
                Console.WriteLine("C : " + q.getOption3());
                Console.WriteLine("D : " + q.getOption4());

                String answer = "";

                
                Console.WriteLine("Enter your answer");
                char ans = Console.ReadKey().KeyChar ;
                

                switch (ans)
                {
                    case 'A':
                        answer = q.getOption1();
                        break;
                    case 'B':
                        answer = q.getOption2();
                        break;
                    case 'C':
                        answer = q.getOption3();
                        break;
                    case 'D':
                        answer = q.getOption4();
                        break;
                    default: break;
                }
                Console.WriteLine("Your answer " + answer + " " + q.getAnswer());
                if (answer.Equals(q.getAnswer().getAnswer()))
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Correct Answer                      ");
                    Console.WriteLine("------------------------------------------------------");
                    countRight++;
                }
                else
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Wrong Answer                      ");
                    Console.WriteLine("------------------------------------------------------");
                    countWrong++;
                }
                Console.WriteLine("============================================================================================");
                countTotal++;
            }

            Result result = new Result(countTotal, countRight, countWrong);
            result.showResult();
        }
    }
    class Question
    {

        String question;
        String option1;
        String option2;
        String option3;
        String option4;
        Answer answer;

        public Question(String question, String option1, String option2, String option3, String option4, Answer answer)
        {
            this.question = question;
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.option4 = option4;
            this.answer = answer;
        }

        public String getQuestion()
        {
            return question;
        }

        public String getOption1()
        {
            return option1;
        }

        public String getOption2()
        {
            return option2;
        }

        public String getOption3()
        {
            return option3;
        }

        public String getOption4()
        {
            return option4;
        }

        public Answer getAnswer()
        {
            return answer;
        }
    }

    class Answer
    {
        String answer;

        public Answer(String answer)
        {
            this.answer = answer;
        }

        public String getAnswer()
        {
            return answer;
        }
    }

    interface IResult
    {
        void showResult();
        double showPercentage(int correctAnswers, int totalQuestions);
        String showPerformance(double percentage);
    }

    class Result:IResult
    {
    int totalQuestions;
    int correctAnswers;
    int wrongAnswers;

    public Result(int totalQuestions, int correctAnswers, int wrongAnswers)
    {
        this.totalQuestions = totalQuestions;
        this.correctAnswers = correctAnswers;
        this.wrongAnswers = wrongAnswers;
    }

    
    public void showResult()
    {
            Console.WriteLine("Your results!");
            Console.WriteLine("Total Questions " + totalQuestions);
            Console.WriteLine("Number of correct answers " + correctAnswers);
            Console.WriteLine("Number of wrong answers " + wrongAnswers);
            Console.WriteLine("Percentage " + showPercentage(correctAnswers, totalQuestions));
            Console.WriteLine("Your performance " + showPerformance(showPercentage(correctAnswers, totalQuestions)));

    }

    
    public double showPercentage(int correctAnswers, int totalQuestions)
    {
        //System.out.println(correctAnswers + " " + totalQuestions);
        return (double)(correctAnswers / (double)totalQuestions) * 100;
    }

    
    public String showPerformance(double percentage)
    {
        String performance = "";

        if (percentage > 60)
        {
            performance = "Good";
        }
        else if (percentage < 40)
        {
            performance = "Poor";
        }

        return performance;

    }
    }
    

}
