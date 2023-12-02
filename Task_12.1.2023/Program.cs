using Task_12._1._2023.Domain.Models;

Employee employeeSystem = new();
employeeSystem.Filter(new DateTime(1970,04,02),DateTime.Now,900,6000);
Console.WriteLine("---------------------------------------");
Celcius celcius = new(50);
Kelvin kelvin = celcius;
Console.WriteLine(kelvin.Degree);