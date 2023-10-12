// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("---------------------");

for (int i = 1; i < 101; i++)
{   
    if((i % 3 == 0 || i % 5 == 0)  && !(i % 3 == 0 && i % 5 == 0)){
        Console.WriteLine(i);
    }
}
Console.WriteLine("---------------------");

for (int i = 1; i < 101; i++)
{   
    if((i % 3 == 0 && i % 5 == 0)){
        Console.WriteLine( i +" "+"FizzBuzz");
    }
    else if(i % 3 == 0){
        Console.WriteLine(i +" "+"Fizz");
    }else if(i % 5 == 0){
        Console.WriteLine(i +" "+"Buzz");    
    }
}

Console.WriteLine(" ------- Bucle while ----");

int index = 1;
while (index <= 255)
{
    Console.WriteLine(index);
    index++;
}

Console.WriteLine(" ---------------------");
int j = 1;
while (j <= 100)
{
    if((j % 3 == 0 || j % 5 == 0)  && !(j % 3 == 0 && j % 5 == 0)){
        Console.WriteLine(j);
    }
    
    j++;
}

int k = 1;
while (k <=100)
{
    if((k % 3 == 0 && k % 5 == 0)){
        Console.WriteLine( k +" "+"FizzBuzz");
    }
    else if(k % 3 == 0){
        Console.WriteLine(k +" "+"Fizz");
    }else if(k % 5 == 0){
        Console.WriteLine(k +" "+"Buzz");    
    }
    k++;
}