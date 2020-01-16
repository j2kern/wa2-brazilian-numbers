using System;
using static System.Console;
using static System.Math;

namespace c
{
    class Program
    {
        static void Main( )
        {
			
            Write("Enter a positive integer: ");
            int n = int.Parse (ReadLine( ));
            
				for(int b = n - 1 ; b > 1 ; b--) //finds first remainder
				{
					bool digitsSame = true;
					bool notDone = true;
					int m = n;
					int counter = 0;
					counter ++;
					int r = n % b;
					
					while(notDone && digitsSame) //removes rightmost digit and finds new remainder
					{
					m = m / b;
					int newr = m % b;
					
						if(newr == r)
						{
						counter ++;
						}
						else if(m == 0)
						{
							notDone = false;
						}
						else
						{
							digitsSame = false;
						}
					}
					
					if(digitsSame && counter > 1) //conditions allow remainders to be printed counter # of times
					{
						Write($"{n} " + "in base 10 is ");
						
						for(int i = 0; i < counter; i++)
						{ 
							if(i == counter - 1)
								{
								Write(r + " ");
								}
							else
								{
								Write( r + ",");
								}
						}
						WriteLine("in base" + $" {b}");
						
					}
				}
        }
    }
}
