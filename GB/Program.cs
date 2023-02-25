// See https://aka.ms/new-console-template for more information
List<string> words = new List<string>();
int n = Convert.ToInt32(Console.ReadLine());
List<string> res = new List<string>();

for (int i = 0; i < n; i++)
{
    words.Add(Console.ReadLine());
}

foreach (string word in words)
{
    if (word.Length <= 3) res.Add(word);
}

Console.WriteLine(String.Join(", ", res));