using System;
public class Program
{
    static void Main(string[] args){
        /* Generalities */
        // Ex 1
        Console.WriteLine(sumNumbers(4,5));
        // Ex 2
        Console.WriteLine(trimString("GoodMorning"));
        // Ex 3
        Console.WriteLine(currentDate());

        /* Numerations */
        daysOfWeek();

        /* Conversions */
        // Ex 1
        //boolConvertions();
        // Ex 2
        dataParsing();
        // Ex 3
        colorSwitch("aul");
        // Ex 4 and 5
        gratterThanTen(65);
        // Ex 7
        fiftyBucle();

    }

    public static int sumNumbers(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public static string trimString(string word)
    {
        if(word.Length == 8){
            return word.Substring(0,4);
        }
        return "Error we need a word with 8 characters";
    }

    public static DateTime currentDate()
    {
        return DateTime.Now;
    }

    public static void daysOfWeek()
    {
        string[] days = { "Sunday", "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday"};
        foreach (string day in days)
        {
            Console.WriteLine(Array.IndexOf(days, day)+1 + " " + day);
        }
    }

    public static void boolConvertions(){
        string[] values = { "True", "False","true", "false","0", "1"};

        Console.WriteLine("TryParse");
        foreach (var value in values) {
            bool flag;
            if (Boolean.TryParse(value, out flag))
                Console.WriteLine("'{0}' --> {1}", value, flag);
            else
                Console.WriteLine("Unable to parse '{0}'.",
                                value == null ? "<null>" : value);
        }
        Console.WriteLine("Parse");
        foreach (var value in values) {
            Console.WriteLine(bool.Parse(value));
        }
    }

    public static void dataParsing(){
        decimal a = 10;
        int b = 443444;
        short c = (short)b;

        Console.WriteLine((int)344.4);
        Console.WriteLine(a);
        Console.WriteLine(c);
    }

    public static void colorSwitch(string color){
        switch (color)
        {
            case "blanco":
                Console.WriteLine(color);
                break;
            case "azul":
                Console.WriteLine(color);
                break;
            case "negro":
                Console.WriteLine(color);
                break;
            default:
                Console.WriteLine("color desconocido");
                break;
        }
    }

    public static void gratterThanTen(int a){
        if(a > 10){
            Console.WriteLine("Value is {0}",a);
        }else{
            Console.WriteLine("Error invalid number");
        }
    }

    public static void fiftyBucle(){
        int a = 0;
        while (a<=50)
        {
            Console.WriteLine(a);
            a+=5;
        }
    }
}