internal class Program
{
    private static void Main(string[] args)
    {
       int[] array = {1,2,3,4,5,6,7,8,9};
       Console.WriteLine("Nhap gia tri can xoa");
       int x = int.Parse(Console.ReadLine());
       int n=0;
       for (int i =0; i < array.Length;i++)
       {
        if(array[i]==x)
        {
            n=i;
        }
       }
       for (int i= n; i< array.Length-1; i++)
        {
            array[i] = array[i+1];
        }
       Console.WriteLine("Mang noi la");
       for (int i = 0; 1 < array.Length; i++)
       {
        Console.WriteLine(array[1]);
        Console.Write(" ");
       }

    }
}