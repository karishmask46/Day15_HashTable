using Day15_HashTable;
Console.WriteLine("Hash table demo"); //() []
MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
hash.Add("0", "To");
hash.Add("1", "be");
hash.Add("2", "or");
hash.Add("3", "not");
hash.Add("4", "to");
hash.Add("5", "be");
string hash5 = hash.Get("5");
Console.WriteLine("5th index value: " + hash5);
string hash2 = hash.Get("2");
Console.WriteLine("2th index value: " + hash2);
MyMapNode<string, int> LinkedHashMap = new MyMapNode<string, int>(5);
string sentence = "to be or not to be";
string[] words = sentence.ToLower().Split(" ");
foreach (string word in words)
{
    int value = LinkedHashMap.Get(word);
    if (value == default)
    {
        value = 1;
    }
    else value += 1;
    LinkedHashMap.Add(word, value);
}
int frequency = LinkedHashMap.Get("to");
Console.WriteLine(frequency);
