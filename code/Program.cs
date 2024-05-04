int ReadIntFromConsole()
{
    int target_data;
data_input:
    Console.WriteLine("Input string array length:");
    target_data = Convert.ToInt32(Console.ReadLine());
    if (target_data == 0)
    {
        Console.WriteLine("Length of input string must differ from 0");
        goto data_input;
    }
    return target_data;
}
