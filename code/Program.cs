// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int input_data_size = 0;
int match_count = 0;
int required_string_length = 3;
input_data_size = ReadIntFromConsole();
Console.WriteLine(input_data_size);
bool[] match_string_adress = new bool[input_data_size];
string[] input_data = new string[input_data_size];
for (int i = 0; i < input_data_size; i++)
{
    input_data[i] = ReadStringFromConsole();
    if (CheckIfMatch(input_data[i], required_string_length))
    {
        match_string_adress[i] = true;
        match_count++;
    }
    else
    {
        match_string_adress[i] = false;
    }
}