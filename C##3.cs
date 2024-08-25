using System;
class LinkedList
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter total number of nodes: ");
        int total=int.Parse(Console.ReadLine());
       int[]nodes=new int[total];
       for(int i=0;i<total;i++)
       {
           Console.WriteLine("Enter node: "+(i+1));
           nodes[i]=int.Parse(Console.ReadLine());
       }
       Console.WriteLine("Before Removal:");
       for(int i=0;i<total;i++)
       {
           Console.Write(nodes[i]+" -> ");
       }
       Console.Write("null");
      
    }
}