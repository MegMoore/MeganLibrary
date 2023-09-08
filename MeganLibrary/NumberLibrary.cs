using System.Security.Cryptography.X509Certificates;

namespace MeganLibrary
{
    public static class Numberlibrary
    {
        public static double PI = 3.1415;

        public static int Add(int a, int b)
        { return a + b; }

        public static int Subtract(int a,int b) { return a - b; }

        public static int Multiply(int a,int b) { return a * b; }

        public static int Divide(int a,int b) { return a / b; }

        public static int Modulo(int a, int b) { return a - (a / b * b); }
                
        public static int Cubed(int a, int b) { return a * a * a; }

        public static bool IsEven(int a, int b) { return Modulo(a, 2) == 0;}

        public static bool IsOdd(int a, int b) { return Modulo(a, 2) != 0; }

        
    }
}