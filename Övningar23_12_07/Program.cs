namespace Övningar23_12_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Laws of freach */
            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            //int currentMin = int.MaxValue;

            //foreach (int value in array)
            //{
            //    if (value < currentMin)
            //        currentMin = value;
            //}
            //Console.WriteLine(currentMin);

            //int total = 0;

            //foreach (int value in array)
            //    total += value;

            //float average = (float)total / array.Length;

            //Console.WriteLine(average);

            string[] usernames = new string[100]; //Antalet användare begränsat till 100
            string[] passwords = new string[100];
            int userCount = 0; //Håller reda på antalet användare

            while (true)
            {
                Console.WriteLine("Väj en åtgärd: ");
                Console.WriteLine("1. Sign in");
                Console.WriteLine("2. Log in");
                Console.WriteLine("3. Avsluta");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("== Sign In ==");
                        Console.WriteLine("Ange ett användarnamn: ");
                        string newUsername = Console.ReadLine();
                        Console.WriteLine("Ange ett lösenord: ");
                        string newPassword = Console.ReadLine();

                        //Lägg till användaren i arrayerna
                        usernames[userCount] = newUsername;
                        passwords[userCount] = newPassword;

                        userCount++; //Öka antalet användare
                        Console.WriteLine("Du har skapat ett konto. " +
                            "Gå tillbaka till huvudmenyn och logga in");
                        break;

                    case "2":
                        Console.WriteLine("== Log In ==");
                        Console.WriteLine("Användarnamn: ");
                        string username = Console.ReadLine();

                        Console.WriteLine("Lösenord: ");
                        string password = Console.ReadLine(); 

                        bool loginSuccessful = false;

                        for (int i = 0; i < userCount; i++) 
                        {
                            if (usernames[i] == username && passwords[i] == password)
                            {
                                loginSuccessful = true;
                                break;
                            }
                        }
                        if (loginSuccessful)
                        {
                            Console.WriteLine("Inloggning lyckades!");
                        }
                        else
                        {
                            Console.WriteLine("Fell användarnamn eer lösenord. Försök igen.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Avslutar programmet. Hejdå!");
                        return;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;

                }
            }

        }
    }
}