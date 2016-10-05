using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] a={1,3,5,4};
            bool swap = false;
            
            int[,] b=new int[10,10];
            int x=0;
            int y=0;

            for (int i=0; i < a.Length; i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                if(a[i]>a[j])
                {
                    count++;
                    y=0;
                    b[x,y]=i;
                    y=1;
                    b[x,y]=j;
                    x++;
                    
                }
                }
            }

            int pl = x;

            if (count == 1)
                swap=true;
            if (count == 0)
                swap = true;
            x=0;
            for(int z=0;z<pl;z++)
            {
                int[] array=new int[a.Length];
                 Array.Copy(a, array,a.Length);

                int index1=b[x,0];  
                int index2=b[x,1];

                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
               
                

                int flag2=0;
                for (int t = 1; t < array.Length; t++)
            {

                if (array[t - 1] > array[t])
                    {
                        flag2 = 1;
                    }
                
                
            }
                if (flag2 == 0)
                    swap = true;

                
                x++;
                //Console.WriteLine(x);
            }



            Console.WriteLine(swap);
            Console.ReadLine();

        }
    }
}
