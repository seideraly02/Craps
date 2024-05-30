using System;
namespace Control
{
    class Program
    {
        public static void Main(string[] args)
        {
            string answer;
            string yes = "Y"; 
                do
                {
                Random random = new Random();

                int bone1 = random.Next(1, 7);
                int bone2 = random.Next(1, 7);
                int computerBone1 = random.Next(1, 7);
                int computerBone2 = random.Next(1, 7);

                int userInput;
                do
                {
                    Console.WriteLine("Загадайте число от 2 до 12");
                    userInput = Convert.ToInt32(Console.ReadLine());
                } while (userInput < 2 || userInput > 12);

                int userX = bone1 + bone2;
                int userY = userInput;
                int userResult = userX - Math.Abs(userX - userY)*2;
                Console.WriteLine("---          Start game          --- \n");
                Console.WriteLine($"Predict the points number (2..12): {userInput}");
                RollTheDice();
                PrintDice(bone1, bone2);
                Console.WriteLine($"On the dice fell  {userX} points.");
                Console.WriteLine($"Result is {userX}-abs({userX}-{userY})*2: {userResult} points \n");

                int computerInput = random.Next(2, 12);
                int computerX = computerBone1 + computerBone2;
                int computerY = computerInput;
                int computerResult = computerX - Math.Abs(computerX - computerY)*2;
                Console.WriteLine($"Predict the points number (2..12): {computerInput}");
                RollTheDiceComputer();
                PrintDiceComputer(computerBone1, computerBone2);
                Console.WriteLine($"On the dice fell  {computerX} points.");
                Console.WriteLine($"Result is {computerX}-abs({computerX}-{computerY})*2: {computerResult} points\n");

                int pointsDifference = Math.Abs(computerResult - userResult);
                if (computerResult < userInput)
                {
                    Console.WriteLine($"Users win {pointsDifference} points more. \nCongratulations!");
                }
                else if (computerResult > userInput)
                {
                    Console.WriteLine($"Computer win {pointsDifference} points more. \nCongratulations!\n");
                } 
                if (computerResult > userResult)
                {
                    Console.WriteLine($"---------- Current score ---------");
                    Console.WriteLine($"User:       {userResult} points");
                    Console.WriteLine($"Computer:   {computerResult} points");
                    Console.WriteLine($"Computer is ahead by {pointsDifference} points!\n"); 
                }
                else if (computerResult < userResult)
                {
                    Console.WriteLine($"---------- Current score ---------");
                    Console.WriteLine($"User:       {userResult} points");
                    Console.WriteLine($"Computer:   {computerResult} points");
                    Console.WriteLine($"User is ahead by {pointsDifference} points!\n");
                }

                int bone1SecondRepetition = random.Next(1, 7);
                int bone2SecondRepetition = random.Next(1, 7);
                int computerBone1SecondRepetition = random.Next(1, 7);
                int computerBone2SecondRepetition = random.Next(1, 7);

                int userInputSecondRepetition;
                do
                {
                    Console.WriteLine("Загадайте число от 2 до 12");
                    userInputSecondRepetition = Convert.ToInt32(Console.ReadLine());
                } while (userInputSecondRepetition < 2 || userInputSecondRepetition > 12);
                int userXSecondRepetition = bone1SecondRepetition + bone2SecondRepetition;
                int userYSecondRepetition = userInputSecondRepetition;
                int userResultSecondRepetition = userXSecondRepetition - Math.Abs(userXSecondRepetition - userYSecondRepetition)*2;
                Console.WriteLine("---          Start game          --- \n");
                Console.WriteLine($"Predict the points number (2..12): {userInputSecondRepetition}");
                RollTheDice();
                PrintDice(bone1SecondRepetition, bone2SecondRepetition);
                Console.WriteLine($"On the dice fell  {userXSecondRepetition} points.");
                Console.WriteLine($"Result is {userXSecondRepetition}-abs({userXSecondRepetition}-{userYSecondRepetition})*2: {userResultSecondRepetition} points \n");

                int computerInputSecondRepetition = random.Next(2, 12);
                int computerXSecondRepetition = computerBone1SecondRepetition + computerBone2SecondRepetition;
                int computerYSecondRepetition = computerInputSecondRepetition;
                int computerResultSecondRepetition = computerXSecondRepetition - Math.Abs(computerXSecondRepetition - computerYSecondRepetition)*2;
                Console.WriteLine($"Predict the points number (2..12): {computerInputSecondRepetition}");
                RollTheDiceComputer();
                PrintDiceComputer(computerBone1SecondRepetition, computerBone2SecondRepetition);
                Console.WriteLine($"On the dice fell  {computerXSecondRepetition} points.");
                Console.WriteLine($"Result is {computerXSecondRepetition}-abs({computerXSecondRepetition}-{computerYSecondRepetition})*2: {computerResultSecondRepetition} points\n");

                int pointsDifferenceSecondRepetition = Math.Abs(computerResultSecondRepetition - userResultSecondRepetition);
                if (computerResultSecondRepetition < userInputSecondRepetition)
                {
                    Console.WriteLine($"Users win {pointsDifferenceSecondRepetition} points more. \nCongratulations!");
                }
                else if (computerResultSecondRepetition > userInputSecondRepetition)
                {
                    Console.WriteLine($"Computer win {pointsDifferenceSecondRepetition} points more. \nCongratulations!\n");
                } 
                if (computerResultSecondRepetition > userResultSecondRepetition)
                {
                    Console.WriteLine($"---------- Current score ---------");
                    Console.WriteLine($"User:       {userResult + userResultSecondRepetition} points");
                    Console.WriteLine($"Computer:   {computerResult + computerResultSecondRepetition} points");
                    Console.WriteLine($"Computer is ahead by {pointsDifference + pointsDifferenceSecondRepetition} points!\n"); 
                }
                else if (computerResultSecondRepetition < userResultSecondRepetition)
                {
                    Console.WriteLine($"---------- Current score ---------");
                    Console.WriteLine($"User:       {userResult + userResultSecondRepetition} points");
                    Console.WriteLine($"Computer:   {computerResult + computerResultSecondRepetition} points");
                    Console.WriteLine($"User is ahead by {pointsDifference + pointsDifferenceSecondRepetition} points!\n");
                }

                int bone1RepeatThree = random.Next(1, 7);
                int bone2RepeatThree = random.Next(1, 7);
                int computerBone1RepeatThree = random.Next(1, 7);
                int computerBone2RepeatThree = random.Next(1, 7);

                int userInputRepeatThree;
                do
                {
                    Console.WriteLine("Загадайте число от 2 до 12");
                    userInputRepeatThree = Convert.ToInt32(Console.ReadLine());
                } while (userInputRepeatThree < 2 || userInputRepeatThree > 12);
                int userXRepeatThree = bone1RepeatThree + bone2RepeatThree;
                int userYRepeatThree = userInputRepeatThree;
                int userResultRepeatThree = userXRepeatThree - Math.Abs(userXRepeatThree - userYRepeatThree)*2;
                Console.WriteLine("---          Start game          --- \n");
                Console.WriteLine($"Predict the points number (2..12): {userInputRepeatThree}");
                RollTheDice();
                PrintDice(bone1RepeatThree, bone2RepeatThree);
                Console.WriteLine($"On the dice fell  {userXRepeatThree} points.");
                Console.WriteLine($"Result is {userXRepeatThree}-abs({userXRepeatThree}-{userYRepeatThree})*2: {userResultRepeatThree} points \n");

                int computerInputRepeatThree = random.Next(2, 12);
                int computerXRepeatThree = computerBone1RepeatThree + computerBone2RepeatThree;
                int computerYRepeatThree = computerInputRepeatThree;
                int computerResultRepeatThree = computerXRepeatThree - Math.Abs(computerXRepeatThree - computerYRepeatThree)*2;
                Console.WriteLine($"Predict the points number (2..12): {computerInputRepeatThree}");
                RollTheDiceComputer();
                PrintDiceComputer(computerBone1RepeatThree, computerBone2RepeatThree);
                Console.WriteLine($"On the dice fell  {computerXRepeatThree} points.");
                Console.WriteLine($"Result is {computerXRepeatThree}-abs({computerXRepeatThree}-{computerYRepeatThree})*2: {computerResultRepeatThree} points\n");

                int pointsDifferenceRepeatThree = Math.Abs(computerResultRepeatThree - userResultRepeatThree);
                if (computerResultRepeatThree < userInputRepeatThree)
                {
                    Console.WriteLine($"Users win {pointsDifferenceRepeatThree} points more. \nCongratulations!");
                }
                else if (computerResultRepeatThree > userInputRepeatThree)
                {
                    Console.WriteLine($"Computer win {pointsDifferenceRepeatThree} points more. \nCongratulations!\n");
                } 

                if (computerResultRepeatThree > userResultRepeatThree)
                {
                    Console.WriteLine($"---------- Current score ---------");
                    Console.WriteLine($"User:       {userResult + userResultSecondRepetition + userResultRepeatThree} points");
                    Console.WriteLine($"Computer:   {computerResult + computerResultSecondRepetition + computerResultRepeatThree} points");
                    Console.WriteLine($"Computer is ahead by {pointsDifference + pointsDifferenceSecondRepetition + pointsDifferenceRepeatThree} points!\n"); 
                }
                else if (computerResultRepeatThree < userResultRepeatThree)
                {
                    Console.WriteLine($"---------- Current score ---------");
                    Console.WriteLine($"User:       {userResult + userResultSecondRepetition + userResultRepeatThree} points");
                    Console.WriteLine($"Computer:   {computerResult + computerResultSecondRepetition + computerResultRepeatThree } points");
                    Console.WriteLine($"User is ahead by {pointsDifference + pointsDifferenceSecondRepetition + pointsDifferenceRepeatThree} points!\n");
                }

                int userFinalResult = userResult + userResultSecondRepetition + userResultRepeatThree;
                int computerFinalResult = computerResult + computerResultSecondRepetition + computerResultRepeatThree;

                Console.WriteLine($"-------------- Finish game --------------");
                Console.WriteLine($" Round |           User  |      Computer");
                Console.WriteLine($"-------+-----------------+----------------");
                Console.WriteLine($"       | Predicted:  {userInput,3} | Predicted:   {computerInput,3}");
                Console.WriteLine($" - 1 - | Dice:       {userX,3} | Dice:        {computerX,3}");
                Console.WriteLine($"       | Result:     {userResult,3} | Result:      {computerResult,3}");
                Console.WriteLine($"-------+-----------------+----------------");
                Console.WriteLine($"       | Predicted:  {userInputSecondRepetition,3} | Predicted:   {computerInputSecondRepetition,3}");
                Console.WriteLine($" - 2 - | Dice:       {userXSecondRepetition,3} | Dice:        {computerXSecondRepetition,3}");
                Console.WriteLine($"       | Result:     {userResultSecondRepetition,3} | Result:      {computerResultSecondRepetition,3}");
                Console.WriteLine($"-------+-----------------+----------------");
                Console.WriteLine($"       | Predicted:  {userInputRepeatThree,3} | Predicted:   {computerInputRepeatThree,3}");
                Console.WriteLine($" - 3 - | Dice:       {userXRepeatThree,3} | Dice:        {computerXRepeatThree,3}");
                Console.WriteLine($"       | Result:     {userResultRepeatThree,3} | Result:      {computerResultRepeatThree,3}");
                Console.WriteLine($"-------+-----------------+----------------");
                Console.WriteLine($"Total  | Points:     {userFinalResult,3} | Points:      {computerFinalResult,3}\n");
                
                int FinalResult = Math.Abs(userFinalResult - computerFinalResult);
                if (userFinalResult > computerFinalResult)
                {
                    Console.WriteLine($"Users win {pointsDifferenceRepeatThree} points more. \nCongratulations!");
                }
                else if (userFinalResult < computerFinalResult)
                {
                    Console.WriteLine($"Computer win {FinalResult} points more. \nCongratulations!\n");
                } 
                    Console.WriteLine("Do you want to play ones more (Y/N)”");
                    answer = Console.ReadLine();
                    Console.Clear();
                }
                while (answer == yes);
        }

        public static void PrintDiceComputer(int bone1, int bone2)
        {
            switch (bone1)
            {
                case 1:
                Console.WriteLine($"- - - - - - -  \n|  .  .  .  | \n|  .  #  .  | \n|  .  .  .  | \n- - - - - - - ");
                break;
                case 2:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  .  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 3:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  #  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 4:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  .  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 5:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  #  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 6:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  #  .  #  | \n|  #  .  #  | \n- - - - - - - ");
                break;
            }
            switch (bone2)
            {
                case 1:
                Console.WriteLine($"- - - - - - -  \n|  .  .  .  | \n|  .  #  .  | \n|  .  .  .  | \n- - - - - - - ");
                break;
                case 2:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  .  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 3:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  #  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 4:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  .  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 5:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  #  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 6:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  #  .  #  | \n|  #  .  #  | \n- - - - - - - ");
                break;
            }
        }
        public static void PrintDice(int bone1, int bone2)
        {
            switch (bone1)
            {
                case 1:
                Console.WriteLine($"- - - - - - -  \n|  .  .  .  | \n|  .  #  .  | \n|  .  .  .  | \n- - - - - - - ");
                break;
                case 2:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  .  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 3:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  #  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 4:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  .  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 5:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  #  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 6:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  #  .  #  | \n|  #  .  #  | \n- - - - - - - ");
                break;
            }
            switch (bone2)
            {
                case 1:
                Console.WriteLine($"- - - - - - -  \n|  .  .  .  | \n|  .  #  .  | \n|  .  .  .  | \n- - - - - - - ");
                break;
                case 2:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  .  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 3:
                Console.WriteLine($"- - - - - - -  \n|  .  .  #  | \n|  .  #  .  | \n|  #  .  .  | \n- - - - - - - ");
                break;
                case 4:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  .  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 5:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  .  #  .  | \n|  #  .  #  | \n- - - - - - - ");
                break;
                case 6:
                Console.WriteLine($"- - - - - - -  \n|  #  .  #  | \n|  #  .  #  | \n|  #  .  #  | \n- - - - - - - ");
                break;
            }
        }

        public static void RollTheDiceComputer()
        {
            Console.WriteLine("Computer rolls the dice:");
        }

        public static void RollTheDice()
        {
            Console.WriteLine("User rolls the dice:");
        }
    }
}