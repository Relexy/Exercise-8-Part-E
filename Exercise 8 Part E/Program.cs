/* Exercise 8 Part E */

// User Score Input
int score = 0;

// User Score Input Storage
int total = 0;

Console.WriteLine("Enter Your Scores: ");
while (score != -1) // If User Enters -1, Ends Program
{
    if (score <= -2)
    {
        Console.WriteLine("ERROR. \nEnter Positive Numbers Only: ");
        
    }
    else if(score > -1)
    {
        total = total + score;
    }
    score = Convert.ToInt32(Console.ReadLine());
}

if (total == 0)
{
    Console.WriteLine("There Were No Scores To Be Added. "); //If First Input Is -1 Or == 0 
}
else if (total > 0)
{
    Console.WriteLine("Your Total Score Is: " + total); //If -1 Is After First Input And Is > 0
}