
#region Problem 1
var number = 5;
var text = "Hello";
var salary = 544.8;
var isActive = true;
var array = new int[] { 1, 2, 4, 5 };
Console.WriteLine($"number type: {number.GetType()}");
Console.WriteLine($"text type: {text.GetType()}");
Console.WriteLine($"salary type: {salary.GetType()}");
Console.WriteLine($"isActive type: {isActive.GetType()}");
Console.WriteLine($"numbersArray type: {array.GetType()}");
#endregion

#region Problem 2
// Explicit 
int number = 10;
string name = "Shalaby";
double salary = 88.57;
bool isTrue = true;

// Implicit
var numberVar = 10;
var nameVar = "Shalaby";
var salaryVar = 88.57;
var isTrueVar = true;

#endregion

#region Problem 3   
var product = new
{
Name = "Laptop",
Price = 125000.0,
Quantity = 5
};
Console.WriteLine($"Product Name: {product.Name}");
Console.WriteLine($"Price: {product.Price}");
Console.WriteLine($"Quantity: {product.Quantity}");
#endregion

#region Problem 4
var Student = new[]
{
    new {Name = "Ahmed" ,Grade = 3.5},
    new {Name = "Mohamed" ,Grade = 3.4},
    new {Name = "Ali" ,Grade = 3.7}
};
foreach (var student in Student)
{
Console.WriteLine($"Student Name: {student.Name}, Grade: {student.Grade}");
}
#endregion

#region Problem 5
var order = new
{
OrderId = 1112,
OrderDate = DateTime.UtcNow,
Customer = new { Name = "Shalaby", City = "Cairo" }
};
Console.WriteLine($"Order ID: {order.OrderId}");
Console.WriteLine($"Date: {order.OrderDate}");
Console.WriteLine($"Customer Name: {order.Customer.Name}");
Console.WriteLine($"Customer City: {order.Customer.City}");
#endregion

#region Problem 6 & 7 & 8
string word1 = "Radar";
string word2 = "DotNet";
Console.WriteLine($"Is '{word1}' Palindrome? {word1.IsPalindrome()}");
Console.WriteLine($"Is '{word2}' Palindrome? {word2.IsPalindrome()}");

int num1 = 17;
int num2 = 20;
Console.WriteLine($"Is {num1} Prime? {num1.IsPrime()}");
Console.WriteLine($"Is {num2} Prime? {num2.IsPrime()}");

// Test Sum
int[] numbers = new int[] { 10, 20, 30, 40, 50 };
Console.WriteLine($"Array Sum: {numbers.Sum()}");
public static class Extensions
{
    public static bool IsPalindrome(this string text)
    {
        if (string.IsNullOrEmpty(text)) return false;

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (char.ToLower(text[left]) != char.ToLower(text[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    public static bool IsPrime(this int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    public static int Sum(this int[] arr)
    {
        if (arr == null) return 0;
        int sum = 0;
        foreach (var number in arr)
        {
            sum += number;
        }
        return sum;
    }
}
#endregion

#region Problem 9
List<string> employees = new List<string>() { "Ali", "Hassan", "Mona", "Kareem" };
// Add
employees.Add("Shalaby");
//Remove
for (int i = 0; i < employees.Count; i++)
{
    if (employees[i] == "Ali")
    {
        employees.RemoveAt(i);
        break;
    }
}
string target = "Shalaby";
bool isFound = false;
foreach (var name in employees)
{
    if (name == target)
    {
        isFound = true;
        break;
    }
}
Console.WriteLine($"Is '{target}' in employees list? {isFound}");

// Print final list
Console.WriteLine("Final Employee List:");
foreach (string name in employees)
{
    Console.WriteLine($"- {name}");
}
#endregion

#region Problem 10
List<Employee> employees = new List<Employee>()
{
    new Employee("Eman", 12000),
    new Employee("Tamer", 25000),
    new Employee("Salma", 18000),
    new Employee("Khaled", 30000)
};
decimal salaryThreshold = 20000;
Console.WriteLine($"Employees with salary above {salaryThreshold}:");
foreach (Employee emp in employees)
{
    if (emp.Salary > salaryThreshold)
    {
        Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
    }
}
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}
#endregion

#region Problem 11
Dictionary<string, int> productPrices = new Dictionary<string, int>();
productPrices.Add("Keyboard", 15000);
productPrices.Add("Mouse", 250);
productPrices["Monitor"] = 300;

foreach (KeyValuePair<string, int> item in productPrices)
{
    Console.WriteLine($"Product: {item.Key} | Price: ${item.Value}");
}

#endregion

#region Problem 12
Dictionary<int, string> studentDirectory = new Dictionary<int, string>()
{
    { 101, "Ayman" },
    { 102, "Fatma" },
    { 103, "Mostafa" }
};
Console.Write("Enter Student ID: ");

if (int.TryParse(Console.ReadLine(), out int inputId))
{
    if (studentDirectory.TryGetValue(inputId, out string studentName))
    {
        Console.WriteLine($"Student Name: {studentName}");
    }
    else
    {
        Console.WriteLine("ID not found.");
    }
}
else
{
    Console.WriteLine("Invalid ID format.");
}
#endregion

#region Problem 13
using System.Collections;

Hashtable hashtable = new Hashtable();

hashtable.Add(1, "Cairo");
hashtable.Add("Country", "Egypt");
hashtable.Add(2.5, true);

foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine($"Key: {entry.Key} ({entry.Key.GetType()}) -> Value: {entry.Value} ({entry.Value?.GetType()})");
}
#endregion

#region Problem 14
using System.Collections;

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Data");

Hashtable ht = new Hashtable();
ht.Add(1, "Data");
#endregion