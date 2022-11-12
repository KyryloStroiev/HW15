using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15;

public class Voices
{
    private int Numb;
    private int Sum1;
    private int Sum2;
    private int Sum3;
    public Voices()
    {

    }
    public Voices(int numb, int sum1, int sum2, int sum3 )
    {
        Numb = numb;
        Sum1 = sum1;
        Sum2 = sum2;
        Sum3 = sum3;
    }
    public void Count()
    {
        Console.WriteLine("Проголосуйте за один iз трьох варiантiв вiдповiдi\n\rПiсля голосування натиснiть 0 ");

        do
        {
            Numb = Int32.Parse(Console.ReadLine());

            if (Numb == 1)
            {
                Sum1 += Numb;
            }
            else if (Numb == 2)
            {
                Sum2 += Numb / 2;
            }
            else if (Numb == 3)
            {
                Sum3 += Numb / 3;
            }

        }
        while (Numb != 0);
        Console.WriteLine($"За перший варiант проголосували: {Sum1} людей");
        Console.WriteLine($"За другий варiант проголосували: {Sum2} людей");
        Console.WriteLine($"За третiй варiант проголосували: {Sum3} людей");
    }
    
}

