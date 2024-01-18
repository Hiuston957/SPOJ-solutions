using System;
using System.Text;

public class Test
{
    public static void Main()
    {
        StringBuilder st = new StringBuilder();
        ulong[] tab = new ulong[Int32.Parse(Console.ReadLine())];
        for (int i = 0; i < tab.Length; i++)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            tab[i] = (a * a + a + 2) / 2;
            st.Append(tab[i]);
            st.Append(Environment.NewLine);
        }


            Console.WriteLine(st);


    }
}