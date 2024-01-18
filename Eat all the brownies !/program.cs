using System;
using System.Text;

public class Test
{
    public static void Main()
    {


        StringBuilder st = new StringBuilder();
        ulong size = ulong.Parse(Console.ReadLine());


        for (ulong j = 0; j < size; j++)
        {


            ulong solution = 0;
            ulong quest = ulong.Parse(Console.ReadLine());

            for (ulong i = 0; i < quest; i++)
            {

                ulong tmp = (i * i + i + 2) / 2;
                if (tmp >= quest)
                {
                    st.Append(i);
                    st.Append(Environment.NewLine);
                    break;
                }

            }


        }
        st.Remove(st.ToString().LastIndexOf('\n'), st.Length - st.ToString().LastIndexOf('\n'));
        Console.WriteLine(st);


    }
}