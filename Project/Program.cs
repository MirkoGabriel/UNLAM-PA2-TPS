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

        /* Numerations Ex 1 and 2 */
        daysOfWeek();

        /* Conversions */
        // Ex 1
        //boolConvertions();
        // Ex 2
        dataParsing();
        // Ex 3
        Console.WriteLine(colorSwitch("aul"));
        // Ex 4 and 5
        Console.WriteLine(gratterThanTen(65));

        /* Ex6 la sentencia for se usa para controlar cantidad de iteraciones donde se necersite un contador y
            foreach se usa para recorrer colecciones sin necesidad de un contador
        */

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

        /* can convert 'true' and 'false' string into boolean, but not with '1' an '0' values */
        Console.WriteLine("TryParse");
        foreach (var value in values) {
            bool flag;
            if (Boolean.TryParse(value, out flag))
                Console.WriteLine("'{0}' --> {1}", value, flag);
            else
                Console.WriteLine("Unable to parse '{0}'.",
                                value == null ? "<null>" : value);
        }

        /* can convert 'true' and 'false' string into boolean, but not with '1' an '0' values */
        Console.WriteLine("Parse");
        foreach (var value in values) {
            Console.WriteLine(bool.Parse(value));
        }
    }

    public static void dataParsing(){
        decimal a = 10;
        int b = 443444;
        short c = (short)b;
        /* parse to integer value */
        Console.WriteLine((int)344.4);
        /* its decimal value */
        Console.WriteLine(a);
        /* parse current value into negative number */
        Console.WriteLine(c);
    }

    public static string colorSwitch(string color){
        switch (color)
        {
            case "blanco":
                return "blanco";
                break;
            case "azul":
                return "azul";
                break;
            case "negro":
                return "negro";
                break;
            default:
                return "unknow color";
                break;
        }
    }

    public static int gratterThanTen(int a){
        if(a > 10){
            return a;
        }else{
            Console.WriteLine("Error invalid number");
            return -1;
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