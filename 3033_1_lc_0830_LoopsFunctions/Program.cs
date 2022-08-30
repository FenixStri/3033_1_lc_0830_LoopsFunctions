//Fenix Strickland 113437176
// August 30th Lecture notes over Loops and Functions


//loops
Console.WriteLine("Loops Review\n");

Console.WriteLine("For loop results:\n");
//for loop

//for (0 ; 1; 2)
//    //loop body
//{
//    3
//}
//0->1->3->2-> 1->3->2 ->1->3->2 ......
//10 20
int i = 10;
for(; ; ) // i=i+1
{
    if (i > 20)
    {
        break;
    }
    if (i==11 || i==13) 
    {
        i++;
        continue;
    }

    Console.WriteLine(i);
    i = i + 1;
}

//while loop
Console.WriteLine("while loop results:\n");

int sumOfNums;
sumOfNums = 0;
i = 20;
int numOfDeposit = 0;
while ( i>8 ) 
{
    numOfDeposit++;
    sumOfNums = sumOfNums + i;
    Console.WriteLine(i);
    i--;
    //sumOfNums += i;
}
string outStr = string.Format($"The balance is: {sumOfNums:C2}");

Console.WriteLine(outStr);
Console.WriteLine(numOfDeposit);
Console.WriteLine(sumOfNums*1.0/numOfDeposit);

Console.WriteLine(3 / 4);

//while(){}

// do{} while()
Console.WriteLine("do while loop results:\n");
i = 20;
do 
{
    Console.WriteLine(i);
    i--;
} 
while (i>9);

//functions methods

//datatype1 function_name(DataType var1, DataType var2, ... )
//{
//    return datatype1_value;
//}
Console.WriteLine("functions/methods results");
double num1 = 20.6;
double largerOne;
largerOne = _finderLargeDbl(num1, 3.6);
Console.WriteLine(largerOne);

Console.ReadLine();

double _finderLargeDbl(double var1, double var2)
{
    if (var1 > var2)
    {
        return var1;
    }
    else
    {
        return var2;
    }
    //return 0;
}