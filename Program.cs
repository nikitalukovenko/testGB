public class ArrTransistor
{
        
    public static void Main(string[] args)
    {
        var array = new[] {"Tom", "Sam", "Bob", "Kate", "Alice", "Sa"};

           string[] newArray = Array.FindAll(array, arr => arr.Length <= 3);

              PrintArray(array);
        PrintArray(newArray);
        
    }

 static void PrintArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
}
