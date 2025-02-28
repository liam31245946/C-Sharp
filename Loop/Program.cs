int i = 0;
while ( i <= 5){
    
    Console.WriteLine(i++);

}

for( int a = 0; a <= 5; a++){
    Console.WriteLine(a);
}

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}