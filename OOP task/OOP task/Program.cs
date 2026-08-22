/*testi ai ile yazdirdim*/

using System;
using System.Collections.Generic;

namespace OOP_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== TEST 1: BANK ACCOUNT ==========");

            BankAccount account = new BankAccount();

            Console.WriteLine("Initial balance: " + account.Balance);

            Console.WriteLine("Deposit 100:");
            account.Deposite(100);
            Console.WriteLine("Balance: " + account.Balance);

            Console.WriteLine("Deposit 50:");
            account.Deposite(50);
            Console.WriteLine("Balance: " + account.Balance);

            Console.WriteLine("Deposit -20:");
            account.Deposite(-20);
            Console.WriteLine("Balance: " + account.Balance);

            Console.WriteLine("Deposit 0:");
            account.Deposite(0);
            Console.WriteLine("Balance: " + account.Balance);

            Console.WriteLine("Withdraw 30:");
            account.Withdraw(30);
            Console.WriteLine("Balance: " + account.Balance);

            Console.WriteLine("Withdraw 200:");
            account.Withdraw(200);
            Console.WriteLine("Balance: " + account.Balance);

            Console.WriteLine("Withdraw -10:");
            account.Withdraw(-10);
            Console.WriteLine("Balance: " + account.Balance);

            Console.WriteLine("Withdraw 0:");
            account.Withdraw(0);
            Console.WriteLine("Balance: " + account.Balance);


            Console.WriteLine("\n========== TEST 2: INHERITANCE ==========");

            Developer developer = new Developer();
            developer.Name = "Ali";
            developer.Salary = 2000;
            developer.ProgrammingLanguage = "C#";

            Console.WriteLine("Developer:");
            developer.Work();

            Console.WriteLine("Name: " + developer.Name);
            Console.WriteLine("Salary: " + developer.Salary);
            Console.WriteLine("Language: " + developer.ProgrammingLanguage);

            Manager manager = new Manager();
            manager.Name = "Leyla";
            manager.Salary = 3000;
            manager.TeamSize = 5;

            Console.WriteLine("\nManager:");
            manager.Work();
            manager.ConductMeeting();


            Console.WriteLine("\n========== TEST 3: UPCasting ==========");

            DeviceManager deviceManager = new DeviceManager();

            Laptop laptop = new Laptop();
            Smartphone smartphone = new Smartphone();
            Television television = new Television();

            Console.WriteLine("Laptop:");
            deviceManager.StartDevice(laptop);

            Console.WriteLine("Smartphone:");
            deviceManager.StartDevice(smartphone);

            Console.WriteLine("Television:");
            deviceManager.StartDevice(television);


            Console.WriteLine("\n========== TEST 4: VIRTUAL / OVERRIDE ==========");

            Notification notification = new Notification();
            EmailNotification email = new EmailNotification();
            SMSNotification sms = new SMSNotification();

            Console.WriteLine("Normal notification:");
            notification.Sent();

            Console.WriteLine("Email:");
            email.Sent();

            Console.WriteLine("SMS:");
            sms.Sent();

            Console.WriteLine("\nPolymorphism:");

            Notification n1 = new EmailNotification();
            Notification n2 = new SMSNotification();

            n1.Sent();
            n2.Sent();


            Console.WriteLine("\n========== TEST 5: VEHICLE ==========");

            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();

            Console.WriteLine("Set car speed to 100:");
            car.Speed = 100;
            Console.WriteLine("Car speed: " + car.Speed);
            car.Drive();

            Console.WriteLine("\nSet motorcycle speed to 80:");
            motorcycle.Speed = 80;
            Console.WriteLine("Motorcycle speed: " + motorcycle.Speed);
            motorcycle.Drive();

            Console.WriteLine("\nSet car speed to -50:");
            car.Speed = -50;
            Console.WriteLine("Car speed: " + car.Speed);
            car.Drive();


            Console.WriteLine("\n========== TEST 6: PAYMENT ==========");

            PaymentProcessor processor = new PaymentProcessor();

            CreditCard creditCard = new CreditCard();
            PayPal payPal = new PayPal();

            Console.WriteLine("Credit Card:");
            processor.Pay(creditCard, 100);

            Console.WriteLine("PayPal:");
            processor.Pay(payPal, 250);

            Console.WriteLine("\nPolymorphism:");

            PaymentMethod payment1 = new CreditCard();
            PaymentMethod payment2 = new PayPal();

            processor.Pay(payment1, 300);
            processor.Pay(payment2, 400);


            Console.WriteLine("\n========== TEST 7: PRODUCTS ==========");

            Electronics electronics = new Electronics();
            electronics.Name = "Laptop";
            electronics.Price = 1000;

            Clothing clothing = new Clothing();
            clothing.Name = "T-Shirt";
            clothing.Price = 100;

            Food food = new Food();
            food.Name = "Pizza";
            food.Price = 20;

            Console.WriteLine("Electronics:");
            Console.WriteLine("Name: " + electronics.Name);
            Console.WriteLine("Price: " + electronics.Price);
            Console.WriteLine("Final price: " + electronics.GetFinalPrice());

            Console.WriteLine("\nClothing:");
            Console.WriteLine("Name: " + clothing.Name);
            Console.WriteLine("Price: " + clothing.Price);
            Console.WriteLine("Final price: " + clothing.GetFinalPrice());

            Console.WriteLine("\nFood:");
            Console.WriteLine("Name: " + food.Name);
            Console.WriteLine("Price: " + food.Price);
            Console.WriteLine("Final price: " + food.GetFinalPrice());

            Console.WriteLine("\nNegative price test:");

            Food testFood = new Food();
            testFood.Price = -50;

            Console.WriteLine("Entered price: -50");
            Console.WriteLine("Stored price: " + testFood.Price);
            Console.WriteLine("Final price: " + testFood.GetFinalPrice());


            Console.WriteLine("\n========== TEST 7: POLYMORPHIC LIST ==========");

            List<Product> products = new List<Product>();

            products.Add(electronics);
            products.Add(clothing);
            products.Add(food);

            double total = 0;

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " -> " + product.GetFinalPrice());
                total += product.GetFinalPrice();
            }

            Console.WriteLine("Total: " + total);


            Console.WriteLine("\n========== ALL TESTS FINISHED ==========");
            Console.ReadKey();
        }
    }
}