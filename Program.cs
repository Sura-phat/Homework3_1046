class Program
{
    static void Main(string[] args)
    {
        Queue<int>q1 = new Queue<int>();

        char SizeFruit = 'f';
        int count = 0;

        while(SizeFruit == 'f' || SizeFruit == 'L'  || SizeFruit == 'M' || SizeFruit == 'S')
        {
            SizeFruit = char.Parse(Console.ReadLine());
            if (SizeFruit == 'L')
            {
                q1.Push(1);
                count++;
            }
            else if (SizeFruit == 'M')
            {
                q1.Push(2);
                count++;
            }
            else if (SizeFruit == 'S')
            {
                q1.Push(3);
                count++;
            }
        }
        for(int x = 0;x <= 1 ;x++)
        {
            int numbercount = q1.GetLength()-1;
            if (x == 0)
            {
                for(int i = 0;i <= numbercount;i++)
                {
                    if (q1.Get(i) == 1)
                    {
                        q1.Push(2);
                        q1.Push(2);
                    }
                    else if (q1.Get(i) == 2)
                    {
                        q1.Push(3);
                        q1.Push(3);
                        q1.Push(3);
                    }
                }
            }
            else if (x == 1)
            {
                for(int f = count ;f <= numbercount; f++)
                {
                    if (q1.Get(f)== 1)
                    {
                        q1.Push(2);
                        q1.Push(2);
                    }
                    else if (q1.Get(f)== 2)
                    {
                        q1.Push(3);
                        q1.Push(3);
                        q1.Push(3);
                    }
                }
            }
        }
        for(int p = 0 ;p <= q1.GetLength()-1 ;p++)
        {
            Console.Write(q1.Get(p));
        }
    }
}
