Console.Write( "Введите начальное значеине: " );
int startValue = Convert.ToInt32( Console.ReadLine() );
Console.Write( "Введите конечное значеине: " );
int endValue = Convert.ToInt32( Console.ReadLine() );

for ( int i =  startValue; i < endValue; ++i )
{
    Console.Write(i + " ");
}