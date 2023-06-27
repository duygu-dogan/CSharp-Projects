namespace degisken;

class Program
{
    static void Main(string[] args)
    {
        //define variables and print them to the terminal
        byte b = 5;     //1 byte, 0-255
        sbyte c = 5;    //1 byte, -128 ile 127 

        short s = 5;    //2 byte, -32768 ile +32767 
        ushort us = 5;  //2 byte, 0-65365 

        Int16 i16 = 2;  //2 byte
        int i = 2;      //2 byte
        Int32 i32 = 2;  //4 byte
        Int64 i64 = 2;  //8 byte 

        uint ui = 2;    //4 byte
        long l = 4;     //8 byte
        ulong ul = 4;   //8 byte

        // Real numbers
        float f = 5;    //4 byte 
        double d = 5;   //8 byte / "
        decimal de = 5; //16 byte / "

        char ch = '2';  //2 byte
        string str = "Duygu"; //limitless 

        //boolean expressions
        bool b1 = true;
        bool b2 = false;

        bool bool1 = 10<2; //false
        bool bool2 = 5>2;  //true

        //using DateTime
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
        



        //Object
        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        // String expressions
        string str1 = string.Empty;
        str1 = "Duygu Dogan";
        string name = "Duygu";
        string surname = "Dogan";
        string fullName = name + " " + surname;

        // integer definitions
        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;
        
        // varible conversions
        string str20 = "20";
        int int20 = 20;

        string newVar = str20 + int20.ToString();
        Console.WriteLine(newVar); //output: 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); //output: 40

        //Parse is often used for conversion from string
        int int22 = int20 + int.Parse(str20); // output: 40







    }
}
