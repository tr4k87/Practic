
static void Print(string[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length > 0)
        {
            Console.Write($"'{a[i]}',");
        }
    }
    Console.WriteLine("]");
}
static string[] AddArray(string[] a)
{
    string[] res = new string[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            res[i] = a[i];
        }
    }
    return res;
}
string[] a = { "hello", "2", ":-)" };
string[] b = AddArray(a);
b = b.Where(x => x != null).ToArray();
Print(b);
