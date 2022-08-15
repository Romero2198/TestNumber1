string[] array = new string[4] {"hello", "2", "world", ";-)"};
string[] array1 = new string[array.Length];
void ArrayConditionCheck(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array1[count] = array[i];
        count++;
        }
    }
}