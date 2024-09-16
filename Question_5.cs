using System;
using System.Linq;

namespace Question_5
{
	class Program
	{
		static bool Mastermind(int secret_code) //The game, STILL WIP (I need to figure out the code to properly evalute it)//
		{
			int attempts = 10;

			while (attempts > 0)
			{
				string guess = Console.ReadLine();

				//stuff here later//

				if (guess == secret_code)
				{
					return true;
				}
				else
				{
				attempts--;
				}
			}
		}
		static int mystery_num_generator() //MAJOR WIP//
		/* Makes a 4 element array of random ints from 1 - 10, then tries to use indexing to initalize 4 seperate arrays without each element.
			Then enters a for-loop which each iteration i determines a different path to evaluate uniqueness. If not unique then restarts the
			for-loop. When finished returns the unique result.*/
		{	
			int[] randomList = new int[4] {rng.Next(10), rng.Next(10), rng.Next(10), rng.Next(10)};

			var randomList_not_0 = randomList.Skip(1).Take(3);
			var randomList_not_1 = randomList.Skip(0).Take(1).Skip(1).Take(2);
			var randomList_not_2 = randomList.SKip(0).Take(2).Skip(1).Take(1);
			var randomList_not_3 = randomList.Skip(0).Take(3).Skip(1);

			restart:
			for (int i = 0; i < 4; i++)
			{
				switch (i)
				{
					case 0:
						foreach (int number in randomList_not_0)
						{
							if (number == randomList[1])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[2])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[3])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else
							{
								continue;
							}
						}
						break;
					case 1:
						foreach (int number in randomList_not_1)
						{
							if (number == randomList[0])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[2])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[3])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else
							{
								continue;
							}
						}
						break;
					case 2:
						foreach (int number in randomList_not_2)
						{
							if (number == randomList[0])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[1])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[3])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else
							{
								continue;
							}
						}
						break;
					case 3:
						foreach (int number in randomList_not_3)
						{
							if (number == randomList[0])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[1])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else if (number == randomList[2])
							{
								var randomList[i] = rng.Next(10);
								goto restart;
							} else
							{
								continue;
							}
						}
						break;
					default:
						break;
				}
			}
		}
		static void Main(string[] args)
		{
			Random rng = new Random(); //seeding rng//

			int code = mystery_num_generator(); //call function to make a unique random code

			Console.WriteLine("I chose a 4 digit code with no repeating numbers");
			Console.WriteLine("You have 10 guesses to guess the code");

			bool m_outcome = Mastermind(code); //Takes the generated code and initates the game. And generates an output//

			if (m_outcome == true) //Output to determine outcome of the game.//
			{
				Console.WriteLine("Congratulations! you guessed my secret code");
			}
			else 
			{
				Console.WriteLine("Too bad! The code was " + code + ".");
			}
		}
	}
}