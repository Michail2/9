Console.Write( "Введите начальное значение: " );
int startValue = Convert.ToInt32( Console.ReadLine() );
Console.Write( "Введите конечное значение: " );
int endValue = Convert.ToInt32( Console.ReadLine() );
int sum = 0;
for ( int i =  startValue; i < endValue; ++i )
{
    sum = sum + i;
}
Console.Write(sum);