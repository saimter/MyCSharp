using System.Diagnostics;

namespace MyCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //  int
            int n;
            n = 5;
            Console.WriteLine(n);

            //  float


            //  char -> 유니코드 한글자 'A' -> 65
            char c;
            c = 'A';
            Console.WriteLine(c);


            int korean = 10;     // camelcase
            int mathmatics = 100;
            int english = 50;

            int sum = korean + mathmatics + english;
            Console.WriteLine(sum);

            double average = Math.Round(sum / 3.0f, 2);
            Console.WriteLine(average);

            //  5개 기본 연산자 +,-,*,/,%


            //Sonar Qub -오류검사


            //  나눔고딕 코딩 il ol0
            //  https://github.com/naver/nanumfont/releases/tag/VER2.51

            //  배열 
            int[] koreans = new int[10];
            for (int i = 0; i < korean; i++)
            {
                koreans[i] = 1;
            }
        }
    }
}


