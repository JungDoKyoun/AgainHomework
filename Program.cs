using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //과제1

            //우선 4개의 정수를 받은 배열을 생성한다
            //그후 정수가 아니라면 다시 입력하도록 반복문을 작성한다

            //int[] num = new int[4];
            //bool isCorrect = false;

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("4개의 정수중" + (i + 1) + "번째 숫자를 입력해주세요");
            //    Console.WriteLine();
            //    isCorrect = int.TryParse(Console.ReadLine(), out num[i]);
            //    Console.WriteLine();

            //    while (isCorrect == false)
            //    {
            //        Console.WriteLine((i + 1) + "번째 숫자를 정수로 입력해주세요");
            //        Console.WriteLine();
            //        isCorrect = int.TryParse(Console.ReadLine(), out num[i]);
            //        Console.WriteLine();
            //    }

            //}

            //BiggestNum(num);


            //과제2
            //실수 5개를 받은 folat형 배열을 만들어준다
            //그후 실수를 입력받고 실수가 아닐때 계속 다시 입력하도록 한다

            //float[] floatArr = new float[5];
            //bool isCorrect = false;

            //for(int i = 0; i < floatArr.Length; i++)
            //{
            //    Console.WriteLine((i+1) + "번째 실수를 입력해주세요");
            //    Console.WriteLine();
            //    isCorrect = float.TryParse(Console.ReadLine(), out floatArr[i]);
            //    Console.WriteLine();

            //    while(isCorrect == false)
            //    {
            //        Console.WriteLine("실수로 입력해주세요");
            //        Console.WriteLine();
            //        isCorrect = float.TryParse(Console.ReadLine(), out floatArr[i]);
            //        Console.WriteLine();
            //    }
            //}

            //받아온 결과값을 저장할 sum이란 변수 생성후
            //생성한 변수를 출력
            //float sum = Sum(floatArr);
            //Console.WriteLine(sum);


            //과제3
            //입력받을 숫자 2개가 들어가 배열을 만들어 주고
            //정수가 아닐때 다시입력하도록 시킴
            //함수에서 참거짓을 받을 bool 변수를 하나 선언후 그 변수에 함수값 대입 후 출력

            //int[] intArr = new int[2];
            //bool isCorrect = false;
            //bool under100 = false;

            //for(int i = 0; i< intArr.Length; i++)
            //{
            //    Console.WriteLine("2개의 정수중 " + (i + 1) + "번째 정수를 입력하시오");
            //    Console.WriteLine();
            //    isCorrect = int.TryParse(Console.ReadLine(), out intArr[i]);
            //    Console.WriteLine();

            //    while(isCorrect == false)
            //    {
            //        Console.WriteLine((i+1) + "번째 정수를 다시 입력하시오");
            //        Console.WriteLine();
            //        isCorrect = int.TryParse(Console.ReadLine(), out intArr[i]);
            //        Console.WriteLine();
            //    }
            //}
            //under100 = IsCorrect(intArr);
            //Console.WriteLine(under100);



            //심화 과제1
            //하나의 정수만 입력해주면되니 int로 변수선언 후 입력하도록 함
            //입력된 값이 정수가 아니라면 다시 입력하도록 시킴
            //결과를 받을 변수를 선언하고 그 변수로 함수를 받은뒤 출력

            //int inputNum = 0;
            //bool isCorrect = false;
            //Console.WriteLine("하나의 정수를 입력하여 주세요");
            //isCorrect = int.TryParse(Console.ReadLine(), out inputNum);

            //while(isCorrect == false)
            //{
            //    Console.WriteLine("정수를 입력해주세요");
            //    isCorrect = int.TryParse(Console.ReadLine(), out inputNum);
            //}

            //int result;
            //result = Sum(inputNum);
            //Console.WriteLine(result);


            //심화과제2
            //입력할 변수를 선언후 1이상의 정수를 입력하라고 출력후 정수를 입력 받음
            //만약 정수가 아닌 것이 입력되었다면 다시 입력하라고함
            //함수의 결과를 받을 변수를 선언후 함수 결과 받은뒤 출력

            //int inputNum = 0;
            //bool isCorrect = false;

            //Console.WriteLine("1이상의 정수를 입력하여 주세요");
            //isCorrect = int.TryParse(Console.ReadLine(), out inputNum);
            //while(isCorrect == false)
            //{
            //    Console.WriteLine("1이상의 정수를 입력하여 주세요");
            //    isCorrect = int.TryParse(Console.ReadLine(), out inputNum);
            //}

            //int result = DigitNumSum(inputNum);
            //Console.WriteLine(result);



            //심화 과제3
            

            int inputNum = 0;
            bool isCorrect = false;

            Console.WriteLine("몇번째 피보나치 함수를 볼지 입력하시오");
            isCorrect = int.TryParse(Console.ReadLine(), out inputNum);
            while(isCorrect == false)
            {
                Console.WriteLine("숫자를 입력해주세요");
                isCorrect = int.TryParse(Console.ReadLine(), out inputNum);
            }

            int result = Fibonacci(inputNum);
            Console.WriteLine(result);

        }
        //과제1

        //static void BiggestNum(int[] num)
        //{

        //가장 큰수를 입력할 변수를 하나 선언해주고, 그 변수를 배열 1번째수로 정해준다
        //그 후 선언한 변수를 조건문으로 배열의 각 수와 비교해주고 
        //선언한 변수가 작다면 더 큰 입력된 배열의 수로 변수를 바꿔주고
        //출력해주면 된다
        //int bigNum = num[0];

        //for (int i = 0; i < num.Length; i++)
        //{
        //    if(bigNum < num[i])
        //    {
        //        bigNum = num[i];
        //    }
        //}
        //Console.WriteLine(bigNum);
        //}


        //과제2
        //버블정렬 오름차순 으로 배열을 정리
        //static float Sum(float[] arr)
        //{
        //    float result = 0;
        //    for(int i = 0; i < arr.Length -1; i++)
        //    {
        //        for(int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                float temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //            }
        //        }
        //    }
        //    result = arr[arr.Length - 1] + arr[arr.Length - 2];
        //    return result;
        //}


        //과제3
        //bool값으로 돌려줘야되니 bool로 함수를 선언
        //1번째 수와 2번째 수를 뺀 값이 100 미만일시 참 거짓을 판별할 bool값 선언후 식 대입
        //참 거짓 판별할 bool값 반환

        //static bool IsCorrect(int[] intArr)
        //{
        //    bool under100 = false;
        //    under100 = intArr[0] - intArr[1] < 100;

        //    return under100;
        //}



        //심화과제 1
        //int로 반환해야하니 int로 함수 선언
        //위에서  입력받은 숫자 사이의 합을 구해야하니 배열을 선언하고 범위를 입력받은 값이 들어가도록 함
        //합이 들어갈 변수 선언뒤 3의 배수에 걸리거나 5의 배수에 걸리면 현재의 i값이 더해지도록 함
        //위에서 받은 값이 들어가야 함으로 i의 범위는 배열을 Lenghth값과 같아야한다

        //static int Sum(int a)
        //{
        //    int[] intArr = new int[a];
        //    int sum = 0;
        //    for(int i = 0; i <= intArr.Length; i++)
        //    {
        //        if (i % 3 == 0)
        //        {
        //            sum += i;
        //        }
        //        else if(i % 5 == 0)
        //        {
        //            sum += i;
        //        }
        //    }
        //    return sum;
        //}


        //심화과제 2
        //위에서 입력받은 숫자의 자릿수 합을 구할려면
        //받은수 나누기 10을 하고 나온 나머지들을 구하면 된다.
        //그러므로 위에서 입력한 수를 받을 변수 선언후 모든 자릿수의 합을 받을 변수도 선언
        //10을 나눈 나머지를 자릿수 합을 받을 변수에 계속 더하게 한 후 
        //만약 나머지가 0이 되면 while문이 깨지도록 설정 하고 더한값을 저장한 변수를 리턴하도록 한다

        //static int DigitNumSum(int a)
        //{
        //    int quota = a;
        //    int result = 0;

        //    while(true)
        //    {
        //        result += quota % 10;
        //        quota /= 10;
        //        if(quota == 0)
        //        {
        //            break;
        //        }
        //    }
        //    return result;
        //}



        //심화과제3
        //배열을 이용한다면 1번째 수와 2번째수는 1이어야하니 
        //1로 지정해주고 위에서 입력한 자릿수를 넣을 변수를 선언한다
        //그후 배열은 3번째부터 시작해야되므로  i를 2로 넣고
        //피보나치 수열은 전전수 더하기 전수가 현재의 수 이므로 intArr[i - 2] + intArr[i - 1];
        //라는 식을 intArr[i]값으로 지정하면 현재 자리수의 값을 볼수있다
        //이것을 result에 넣어주고 반환시키면 된다

        //static int Fibonacci(int a)
        //{
        //    int[] intArr = new int[a];
        //    intArr[0] = 1;
        //    intArr[1] = 1;
        //    int result = 0;


        //    for(int i = 2; i < intArr.Length; i++)
        //    {
        //        intArr[i] =intArr[i - 2] + intArr[i - 1];
        //        result = intArr[i];

        //    }
        //    return result;
        //}


        //수열을 쓰지 않았을때
        //수열을 쓰지 않고 1을 받았을 때는 1을 돌려주고 0을 받았을때 0을 돌려주고
        //현재의 값이 들어갈 변수 선언뒤 Fibonacci(a - 1) + Fibonacci(a - 2);를 넣어준뒤 반환하면 된다

        //static int Fibonacci(int a)
        //{
        //    int result = 0;
        //    if (a == 1)
        //    {
        //        return 1;
        //    }
        //    else if (a == 0)
        //    {
        //        return 0;
        //    }
        //    result = Fibonacci(a - 1) + Fibonacci(a - 2);

        //    return result
        //}
    }
}
