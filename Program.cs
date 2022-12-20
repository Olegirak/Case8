// Напишите программу , на вход принимающую число Н, а на выходе все четные
int N = int.Parse(Console.ReadLine());

for (int i=1;i<N+1;i++)
    {
        if( i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        
    }