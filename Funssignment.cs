using System;

namespace Funssignment
{
    class Program
	{
		static void Question_1() //Standard Hello World that accepts an input//
		{
			Console.WriteLine("Please enter your name:");
			string input_name = Console.ReadLine();
			Console.WriteLine("Hello, " + input_name + "! Welcome to the world of C#. Let the adventure begin!");
			return; 
		}
		static void Question_2() //Fibonacci seqence with n sequences (user determined)//
		{
			Console.WriteLine("Please enter the number of interations for the fibonacci sequence:");
			string input_str = Console.ReadLine();
			int input_int = Int32.Parse(input_str); //converts inputted string into an int//
			
			int Fn1 = 0, Fn2 = 0, combined = 0; //initalizing varibles for fibonacci sequence//
			for(int i = 0; i < input_int - 1; i++)
			{
				if (i == 0) //accounts for first iteration of fibonacci sequence//
				{
					Fn1 = 0;
					Fn2 = 1;
				} 
				combined = Fn1 + Fn2;
				Fn1 = Fn2;
				Fn2 = combined;
			}
			Console.WriteLine("after " + input_str + " interations, the sequence is " + combined + "."); //Output//
			return;
		}
		static bool Palindrome_Detector(string word) //function (called from Question_3) to test a palindrome, returns bool to determine output//
		{
		    word = word.ToUpper();
			int length = word.Length;
			int right_check = length - 1;

			
			if (length%2 == 1) //Checks if the word is odd (ignores the middle character)//
			{
				length -= 1;

			}

			for(int i = 0; i < length; i++) //Actual Palindrome Detector//
			{
				if (word[i] != word[right_check])
				{
					return false;
				}
				right_check--;
			}
			return true;
		}
		static void Question_3() //Palidome detector with user inputted word//
		{
			Console.WriteLine("Please enter a word for the palindrome detector:");
			string input_str = Console.ReadLine();

			bool checker = Palindrome_Detector(input_str); //Output bool//

			if (checker == true) //if-elif-else to determine proper output//
			{
				Console.WriteLine("The word: " + input_str + " is a palindrome.");
			}
			else if (checker == false)
			{
				Console.WriteLine("The word: " + input_str + " is not a palindrome.");
			}
			else
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		static bool guessing(int secret_num)
		{
			int guess_attempts = 7;

			while (guess_attempts > 0)
			{
				string user_guess = Console.ReadLine();
				int user_guess_int = Int32.Parse(user_guess); //Casts the user input into integer to compare//

				if (user_guess_int == secret_num)
				{
					return true;
				}
				else if (user_guess_int > secret_num)
				{
					Console.WriteLine("Too high");
					Console.WriteLine(guess_attempts + " guesses left.");
				}
				else if (user_guess_int < secret_num)
				{
					Console.WriteLine("Too low");
					Console.WriteLine(guess_attempts + " guesses left.");
				}
				else
				{
					Console.WriteLine("Please input a number, no attempt used");
					continue;
				}
				guess_attempts--;
			}
			return false;
		}
		static void Question_4() //Mystery Number Game//
		{
			Random rng = new Random(); 
			int mystery_num = rng.Next(1,101);

			Console.WriteLine("Welcome to the Mystery number game! Guess a number between 1 to 100");
			Console.WriteLine("You get 7 guesses");

			bool outcome = guessing(mystery_num); //Output bool//

			if (outcome == true) //Checks output to display correct message.//
			{
				Console.WriteLine("Congratulations! you guessed the mystery number corrrect");
			}
			else
			{
				Console.WriteLine("All attempts used");
				Console.WriteLine("The mystery number is: " + mystery_num + ".");
			}
		}
		static void Main(string[] args)
		{
			//Made each question into a different function for readability//
			Console.WriteLine("Question 1: Hello World with a twist");
			Question_1();
			Console.WriteLine("Question 2: Fibonacci sequence");
			Question_2();
			Console.WriteLine("Question 3: Palindrome detector");
			Question_3();
			Console.WriteLine("Question 4: Mystery Number Game");
			Question_4();
			Console.WriteLine("Question 5: Simple Mastermind");
		}
	}
}