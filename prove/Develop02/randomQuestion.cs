using System;

class randomQuestion
{
    public string callQuestion()
    {
        string[] questions = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"}; 

        Random selectQuestion = new Random();
        int questionIndex = selectQuestion.Next(questions.Length);

        string selectedQuestion = questions[questionIndex];

        return selectedQuestion;
    }
}