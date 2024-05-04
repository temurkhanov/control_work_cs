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
string ReadStringFromConsole()
{
    string input_string = "0";
data_input:
    Console.WriteLine("Input some characters:");
    input_string = Console.ReadLine();
    if (input_string.Length == 0)
    {
        Console.WriteLine("Length of input string must differ from 0");
        goto data_input;
    }
    else
    {
        return input_string;
    }
}