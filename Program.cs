using System;

namespace Lab_4_Powers_table_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // I declared int num1 but also could have deleted this and placed int num1 = int.Parse(Console.ReadLine()); line 16, because it was the only used in that method
            // I set string userResponse to "y" so that I could make a while loop to trigger the question again if the user would like to continue.

            int num1;
            string userResponse = "y";
            while (userResponse == "y")
            {
                //ask the user for an integer and then parse it so that the program can read the string as an int and use it later in the program.
                Console.WriteLine("Enter an integer: ");
                num1 = int.Parse(Console.ReadLine());

                // /t adds 5 spaces or a tab allowing me to label the table with names for each row
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t======\t======");

                //so I start i at 1 since its the minimum and then I set it less than or equal to the users input and then add i++ so that the loop keeps on adding 1 to the input.
                for (int i = 1; i <= num1; i++)
                {
                    //setting the values for i to be squared by multiplying itself. Then I do the same for cubed but twice.
                    int squared = i * i;
                    int cubed = i * i * i;
                    
                    //Here is where I display i which is 1 and then i being squared and then cubed.
                    Console.WriteLine($"{i}\t{squared}\t{cubed}");
                }
                
                //Ask the user if they would like to continue by pressing y and end program by n or any key that isnt y
                Console.WriteLine("Continue? (y/n)");
                userResponse = Console.ReadLine();
            }

        }


    }
}
