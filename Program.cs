using System;
namespace MANGHAICHIEU
{
    class TaoBanDoTroChoiMineSweeper
    {
        static void Main(string[] arrgs)
        {
            Console.WriteLine("Nhap chieu cao cua ban do:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chieu dai cua ban do:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ban do da danh dau vi tri min:");
            char[, ] bandotrochoi = new char[y, x];
            for (int chieucao = 0; chieucao < y; chieucao++)
            {
                string hangngang = Console.ReadLine();
                char[] cacphantu = hangngang.ToCharArray();
                for (int chieudai = 0; chieudai < x; chieudai++)
                {
                    bandotrochoi[chieucao, chieudai] = cacphantu[chieudai];
                }
            }
            for (int chieucao = 0; chieucao < y; chieucao++)
            {
                for(int chieudai = 0; chieudai < x; chieudai++)
                {
                    int[,] toadovunglancan = {
                        {chieucao - 1, chieudai - 1},
                        {chieucao - 1, chieudai},
                        {chieucao - 1, chieudai + 1},
                        {chieucao, chieudai - 1},
                        {chieucao, chieudai + 1},
                        {chieucao + 1, chieudai - 1},
                        {chieucao + 1, chieudai},
                        {chieucao + 1, chieudai + 1}
                    };
                    if (bandotrochoi[chieucao, chieudai] != '*')
                    {
                        bandotrochoi[chieucao, chieudai] = '0';
                        for (int olancan = 0; olancan < toadovunglancan.GetLength(0); olancan++)
                        {
                            int y0 = toadovunglancan[olancan, 0];
                            int x0 = toadovunglancan[olancan, 1];
                            bool namtrongbando = y0 >= 0 && y0 < y && x0 >= 0 && x0 < x;
                            if (namtrongbando && bandotrochoi[y0, x0] == '*')
                            {
                                bandotrochoi[chieucao, chieudai]++;
                            }
                        }
                    }
                }
            }
            for (int chieucao = 0; chieucao < y; chieucao++)
            {
                Console.WriteLine();
                for (int chieudai = 0; chieudai < x; chieudai++)
                {
                    Console.Write(bandotrochoi[chieucao,chieudai]);
                }
            }
        }
    }
}