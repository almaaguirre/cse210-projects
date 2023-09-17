using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string letter = "";

        if (grade >= 97)
        { 
            letter = "A"; 
        }
        else if (grade >= 93)
        {
            letter = "A";
        }
        else if (grade >= 90)
        {
            letter = "A-";
        }
        else if (grade >= 87)
        {
            letter = "B+";
        }
        else if (grade >= 83)
        {
            letter = "B";
        }
        else if (grade >=80)
        {
            letter = "B-";
        }
        else if (grade >= 77)
        {
            letter = "C+";
        }
        else if (grade >= 73)
        {
            letter = "C";     
        }
        else if (grade >= 70)
        {
            letter = "C-";
        }
        else if (grade >= 67)
        {
            letter = "D+";
        }
        else if (grade >= 63)
        {
            letter = "D"; 
        }
        else if (grade >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Stay focused and you will get it next time.");
        }
        

    }

}
