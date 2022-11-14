Console.Write( "Введите количество чисел: " );
int N = Convert.ToInt32( Console.ReadLine() );

Console.Write( "Введите первое значение: " );
int firstValue = Convert.ToInt32( Console.ReadLine() );

Console.Write( "Введите второе значение: " );
int secondValue = Convert.ToInt32( Console.ReadLine() );

int [] arr = new int[N];

    arr[0] = firstValue;
    arr[1] = secondValue;

Console.Write(arr[0] + " " + arr[1] + " ");

for( int i = 2; i < N; ++i)
{
    arr[i] = arr[i - 1] + arr[i - 2]; 
    Console.Write(arr[i] + " ");
}