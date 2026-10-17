using Lab_LINQ.Model;

namespace Lab_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30 };
            var cities = new List<string> { "New York", "London", "Tokyo", "Paris", "Berlin", "Sydney", "Toronto", "Mumbai", "Barcelon" };

            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Smith", Department = "IT", Salary = 75000, Age = 28 },
                new Employee { Id = 2, Name = "Sarah Johnson", Department = "HR", Salary = 65000, Age = 32 },
                new Employee { Id = 3, Name = "Mike Wilson", Department = "IT", Salary = 85000, Age = 35 },
                new Employee { Id = 4, Name = "Emily Davis", Department = "Finance", Salary = 70000, Age = 29 },
                new Employee { Id = 5, Name = "David Brown", Department = "IT", Salary = 95000, Age = 40 },
                new Employee { Id = 6, Name = "Lisa Garcia", Department = "Marketing", Salary = 60000, Age = 26 },
                new Employee { Id = 7, Name = "Robert Taylor", Department = "Finance", Salary = 80000, Age = 38 },
                new Employee { Id = 8, Name = "Jennifer Lee", Department = "HR", Salary = 55000, Age = 24 }
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, CustomerName = "Alice", Amount = 150.50m, OrderDate = new DateTime(2024, 1, 15) },
                new Order { Id = 2, CustomerName = "Bob", Amount = 89.99m, OrderDate = new DateTime(2024, 2, 10) },
                new Order { Id = 3, CustomerName = "Alice", Amount = 200.00m, OrderDate = new DateTime(2024, 1, 25) },
                new Order { Id = 4, CustomerName = "Charlie", Amount = 75.25m, OrderDate = new DateTime(2024, 3, 5) },
                new Order { Id = 5, CustomerName = "Bob", Amount = 120.75m, OrderDate = new DateTime(2024, 2, 20) },
                new Order { Id = 6, CustomerName = "Diana", Amount = 300.00m, OrderDate = new DateTime(2024, 1, 30) }
            };


            #region tast1
            //List<int> evens = numbers.Where(x => x % 2 == 0).ToList();
            //foreach(int e in evens)
            //{
            //    Console.Write(e+" ");
            //} 
            #endregion

            #region task2
            //List<string> startings = cities.Where(x => x.ToLower()[0] == 'l'|| x.ToLower()[0] == 't').ToList();
            //foreach (string city in startings)
            //{
            //    Console.Write(city + " ");
            //} 
            #endregion

            #region task3
            //List<Employee> highest = employees.Where(e => e.Salary > 70000).ToList();
            //foreach (Employee e in highest)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion

            #region task4
            //List<Employee> highest = employees.Where(e => e.Age < 30).ToList();
            //foreach (Employee e in highest)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion

            #region task5
            //List<int> squares= numbers.Select(x=>x*x).ToList();
            //foreach (int s in squares)
            //{
            //    Console.Write(s + " ");
            //} 
            #endregion

            #region task6
            //var letterCounts = cities.Select(x => x+" has "+x.Length.ToString()+" letters").ToList();
            //foreach(var i in letterCounts)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region task7
            //var names = employees.Select(x=>x.Name).ToList();
            //foreach (string e in names)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion

            #region task8
            //var anonymous=employees.Select(x=> new { x.Name, x.Department, isAboveAvg = x.Salary>employees.Average(x=>x.Salary)}).ToList();
            //foreach (var e in anonymous)
            //{
            //    Console.WriteLine(e.Name+" " + e.Department+" "+e.isAboveAvg);
            //} 
            #endregion

            #region task9
            //var sortByName = cities.OrderBy(x=>x).ToList();
            //foreach (string c in sortByName)
            //{
            //    Console.Write(c + " ");
            //} 
            #endregion

            #region task10
            //var employeeOrder = employees.OrderByDescending(x=>x.Salary).ToList();
            //foreach (var e in employeeOrder)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion

            #region task11
            //var employeeOrder = employees.OrderBy(x => x.Department).ThenBy(x=>x.Age).ToList();
            //foreach (var e in employeeOrder)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion

            #region task12
            //var numRev = numbers.OrderByDescending(x=>x).ToList();
            //foreach (int e in numRev)
            //{
            //    Console.Write(e + " ");
            //} 
            #endregion

            #region task16
            //Console.WriteLine(employees.Average(x=>x.Salary)); 
            #endregion


            #region extra group by
            //var depDetail= employees.GroupBy(x=>x.Department)
            //    .Select(x=>new
            //    {
            //        Name= x.Key,
            //        EmployeeCount=x.Count(),
            //        Avg=x.Average(e=>e.Salary)
            //    })
            //    .OrderByDescending(g=>g.Avg)
            //    .ToList();
            //foreach(var g in depDetail)
            //{
            //    Console.WriteLine(g.Name+" "+g.EmployeeCount+" "+g.Avg);
            //} 
            #endregion




        }
    }
}
