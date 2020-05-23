using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_atm
{
    class Program
    {
        static void Main(string[] args)
        {

            bool backToStart = true;

            User[] users = new User[5];
            users[0] = new User("Tom", "Ellis") { PAN = "123456", PIN = "1111", CVC = "345", ExpireDate = "12/21", Balance = 9 };
            users[1] = new User("Benedict", "Cumberbach") { PAN = "123456", PIN = "2222", CVC = "345", ExpireDate = "12/21", Balance = 400 };
            users[2] = new User("James", "McAvoy") { PAN = "123456", PIN = "3333", CVC = "345", ExpireDate = "12/21", Balance = 1000 };
            users[3] = new User("Brad", "Pitt") { PAN = "123456", PIN = "4444", CVC = "345", ExpireDate = "12/21", Balance = 54750000 };
            users[4] = new User("Angelina", "Jolie") { PAN = "123456", PIN = "5555", CVC = "345", ExpireDate = "12/21", Balance = 570.67m };


            while (backToStart)
            {
                Console.WriteLine("Enter Your 4 Digit Pin ");
                string pin = Console.ReadLine();

                for (int i = 0; i < users.Length; i++)
                {
                    if (pin == users[i].PIN)
                    {
                        Console.WriteLine($"{users[i].Name} {users[i].Surname} , xos gelmisiniz. Zehmet olmasa asagidakilardan birini secin:");
                        Console.WriteLine("1. Balans");
                        Console.WriteLine("2. Nagd pul");
                        string choise = Console.ReadLine();
                        switch (choise)
                        {
                            case "1":
                                Console.WriteLine(users[i].Balance);
                                break;
                            case "2":
                                Console.WriteLine("1. 10 AZN");
                                Console.WriteLine("2. 20 AZN");
                                Console.WriteLine("3. 50 AZN");
                                Console.WriteLine("4. 100 AZN");
                                Console.WriteLine("5. Diger");
                                string amountChoise = Console.ReadLine();
                                switch (amountChoise)
                                {
                                    case "1":
                                        if (users[i].Balance >= 10)
                                        {
                                            users[i].Balance = users[i].Balance - 10;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        break;
                                    case "2":
                                        if (users[i].Balance >= 20)
                                        {
                                            users[i].Balance = users[i].Balance - 20;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        break;
                                    case "3":
                                        if (users[i].Balance >= 50)
                                        {
                                            users[i].Balance = users[i].Balance - 50;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        break;
                                    case "4":
                                        if (users[i].Balance >= 100)
                                        {
                                            users[i].Balance = users[i].Balance - 100;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        break;
                                    case "5":
                                        Console.WriteLine("Meblegi daxil edin");
                                        decimal freeChoise = int.Parse(Console.ReadLine());
                                        if (users[i].Balance >= freeChoise)
                                        {
                                            users[i].Balance = users[i].Balance - freeChoise;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        }
                                        break;
                                }
                                break;
                        }

                        break;
                    }

                    else if (i == users.Length - 1)
                    {
                        Console.WriteLine("Bu PIN koda aid kart tapilmadi.");
                    }
                }
            }
        }
    }



    public abstract class Card
    {

        public string PAN { get; set; }
        public string PIN { get; set; }
        public string CVC { get; set; }
        public string ExpireDate { get; set; }
        public decimal Balance { get; set; }


    }
    public class User : Card
    {
        public string Name;
        public string Surname;
        Card CreditCard;
        public User(Card creditCard)
        {
            CreditCard = creditCard;
        }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

    }


}
