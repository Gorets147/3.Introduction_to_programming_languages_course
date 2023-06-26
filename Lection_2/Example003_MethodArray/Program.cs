int[] array = {1, 12, 14, 43, 17, 12, 13, 22, 11};

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

