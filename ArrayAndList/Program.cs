class Program
{
    public static void Main(string[] args)
    {
        // array
        // list > collection,Enumarable,IQuearylable

        Console.WriteLine("Arry");

        var arry1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        var list1 = new List<int> { 3, 6, 7, 4, 2, 1, 9, 10};

        for(int i = 0; i < arry1.Length; i++)
        {
            Console.WriteLine(arry1[i]);
        }

        Console.WriteLine("List Örneği");
        for(int i=0;i<list1.Count; i++)
        {
            Console.WriteLine(list1[i]);
        }

        for(int i = arry1.Length-1; i >= 0; i--) // length => Arrayde eleman sayısını veriri
        {
            Console.WriteLine(arry1[i]);
        }

        for(int i = list1.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list1[i]);
        }

        Console.WriteLine("Array ile foreach");

        foreach(int i in arry1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("List ile foreach");

        foreach (int i in list1)
        {
            Console.WriteLine(i);
        }

        var erkek = new[] { "Ahmet", "Kadir", "Umut", "Ali", "Veli", "Osman", "Yusuf", "İsmail", "Onur", "Mehmet" };

        var kadin = new List<string> { "Burcu", "Tuğba", "Selin", "Nuray", "Pelin", "Ahu", "Zeynep", "Hatice", "Banu", "Zehra" };

        Console.WriteLine("For ile isimleri yazdırma");

        for (int i = 0; i < erkek.Length; i++)
        {
            if (erkek[i] == "Umut")
            {
                continue;
            }

            Console.WriteLine(erkek[i]);
        }

        Console.WriteLine("Foreach ile isimleri yazdırma");
        foreach (var item in erkek)
        {
            if (item == "Umut")
            {
                continue;
            }
            Console.WriteLine(item);
        }

    }
}
