int[] numbers = Console.ReadLine() //"5 3 6 3 4"
                .Split(" ") // ["5", "3", "6", "3", "4"]
                .Select(int.Parse) // [5, 3, 6, 3, 4]
                .ToArray();

int sum = 0;
for  (int index = 0; index < numbers.Length; index++)
{
    sum += numbers[index];
}
Console.WriteLine(sum);