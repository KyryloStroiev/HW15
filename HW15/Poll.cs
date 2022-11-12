using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15;

public class Poll
{
    public string Question;
    public string Answer1;
    public string Answer2;
    public string Answer3;
    public Poll()
    {

    }
    public Poll(string question, string answer1, string answer2, string answer3)
    {
        Question = question;
        Answer1 = answer1;
        Answer2 = answer2;
        Answer3 = answer3;
    }
    public void ToPrint()
    {
        Console.WriteLine("Ведiть питання: ");
        Question = Console.ReadLine();
        Console.WriteLine("Ведiть ваарiанти вiдповiдей:");
        Answer1 = Console.ReadLine();
        Answer2 = Console.ReadLine();
        Answer3 = Console.ReadLine();   
    }
    public override string ToString()
        => $"{Question}\n 1.{Answer1}\n 2.{Answer2}\n 3.{Answer3}";



}

