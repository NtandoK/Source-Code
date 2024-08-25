import java.util.*;
class Nodes
{
   public static void main(String[]args)
   {
      Scanner input=new Scanner(System.in);
      System.out.print("Enter total number of nodes: ");
      int total=input.nextInt();
   
      int[]nodes=new int[total];
      for(int i=0;i<total;i++)
      {
      System.out.println("Enter node "+(i+1)+" ");
      nodes[i]=input.nextInt();
      }
      System.out.println("Before Removal");
      for(int i=0;i<total;i++)
      {
      System.out.print(nodes[i]+" -> ");
      }
      System.out.println("null");
   }
}