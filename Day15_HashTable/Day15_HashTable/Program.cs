using Day15_HashTable;
class program
{
    MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
    public void Frequencystr(string sentence)
    {
        string[] sentnc = sentence.Split(' ');
        for (int i = 0; i < sentnc.Length; i++)
        {
            string word = sentnc[i];
            int count = 0;
            for(int j = 0; j < sentnc.Length; j++)
            {
                if (word.Equals(sentnc[j]))                   
                    count++;
            }
            Console.WriteLine($"The frequency of {sentnc[i]} is {count}");
            hash.Add($"{i}", word);
            Console.WriteLine($"Key - {i} Value - {hash.Get($"{i}")}");
        }
     }
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the HashTable Program");
        string sentence ="Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        program obj= new program();
        obj.Frequencystr(sentence);
        Console.WriteLine("Enter index value from 0 to 18 ");
        int i = Convert.ToInt32(Console.ReadLine());
        string code = obj.hash.Get($"{i}");
        Console.WriteLine($"\nIndex {i}'s value is : {code}" );

    }
}