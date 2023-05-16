double[] array = { 1.2, -3.5, 4.7, -2.0, 5.1 };
double max = array[0];
int maxIndex = 0;
double sum = 0;
bool foundPositive = false;
int firstPositiveIndex = -1;


for (int i = 0; i < array.Length; i++)
{
    if (Math.Abs(array[i]) > Math.Abs(max))
    {
        max = array[i];
        maxIndex = i;
    }
    if (!foundPositive && array[i] > 0)
    {
        foundPositive = true;
        firstPositiveIndex = i;
    }
    if (foundPositive)
    {
        sum += array[i];
    }
}

Console.WriteLine($"The number of the maximum element modulo: {maxIndex}");
Console.WriteLine($"The sum of the array elements after the first positive element: {sum}");

double a = 2; // replace with your desired value
double b = 3; // replace with your desired value

double[] sortedArray = new double[array.Length];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if ((int)array[i] >= a && (int)array[i] <= b)
    {
        sortedArray[index] = array[i];
        index++;
    }
}

for (int i = 0; i < array.Length; i++)
{
    if ((int)array[i] < a || (int)array[i] > b)
    {
        sortedArray[index] = array[i];
        index++;
    }
}

Console.WriteLine("The sorted array:");
foreach (double element in sortedArray)
{
    Console.Write($"{element} ");
}