/*TASK 1*/
int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };
for(int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Student {i+1}: {grades[i]}");

}
/*TASK 2*/

Console.WriteLine($"Average Grade:{CalculateAverage(grades):F2}");

static double CalculateAverage(int[] grades) 
{
    int total = 0;
    for (int i = 0; i < grades.Length; i++)
    {
        total += grades[i];
    }
    return (double)total / grades.Length;
}
/*TASK 3*/

static double CalculateAverage1(int grade1,int grade2)
{
    return (grade1+grade2) / 2.0;
}
static double CalculateAverage2(int grade1, int grade2,int grade3)
{
    return (grade1+ grade2+grade3) / 3.0;
}

Console.WriteLine(CalculateAverage1(70,90));
Console.WriteLine(CalculateAverage2(60,75,90));

Console.WriteLine($"Highest Grade:{FindMaximum(grades)}");

static int FindMaximum(int[] grades)
{
    int maximum = grades[0];
    for (int i = 0;i < grades.Length; i++)
    {
      
        if (grades[i] > maximum)
        {
            maximum = grades[i];
        }
    }
    return maximum;
}

Console.WriteLine($"Lowest Grade:{FindMinimum(grades)}");

static int FindMinimum(int[] grades)
{
    int minimum=grades[0];
    for(int i = 1; i < grades.Length; i++)
    {
        if (grades[i] < minimum)
        {
            minimum = grades[i];
        }
    }
    return minimum;
}



/*TASK 4*/

static int CalculateTotal(params int[] grades)
{
    int total = 0;
    for (int i = 0; i < grades.Length; i++)
    {
        total += grades[i];
    }
    return total;
}

Console.WriteLine(CalculateTotal(10,20));
Console.WriteLine(CalculateTotal(10, 20,30));
Console.WriteLine(CalculateTotal(grades));
Console.WriteLine(CalculateTotal());