using System;

namespace lesson_7
{

    class Program
    {
        static int Size_Y = 5;
        static int Size_X = 5;
        static char[,] Field = new char[Size_Y, Size_X];
        static char Empty = '.';
        static char Player = 'X';
        static char AI = 'O';

        static Random zxc = new Random();

        protected static void EmptyField()
        {
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Field[i, j] = Empty;
                }
            }
        }

        protected static void MainField()
        {
            Console.Clear();
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Console.Write(Field[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        protected static void SetPoint(int y, int x, char sim)
        {
            Field[y, x] = sim;
        }

        protected static bool FieldIsFull()
        {
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    if (Field[i, j] == Empty) return false;
                }
            }
            return true;
        }

        protected static bool IsMoveRight(int x, int y)
        {
            if (x < 0 || y < 0 || x > Size_X - 1 || y > Size_Y - 1) return false;
            return Field[y, x] == Empty;
        }

        protected static void PlayerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Введите координату точки по стороке");
                Console.Write($"Введите число в диапазоне от 1 до {Size_Y} --> ");
                x = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Введите координату точки по столбцу");
                Console.Write($"Введите число в диапазоне от 1 до {Size_X} --> ");
                y = int.Parse(Console.ReadLine()) - 1;
            } while (!IsMoveRight(y, x));
            SetPoint(y, x, Player);
        }

        protected static void AiMove()
        {
            if (Field[2, 2] == Empty) SetPoint(2, 2, AI);
            else
            {
                int t = zxc.Next(0, 5);
                if (t == 0 && Field[3, 1] != Player) SetPoint(3, 1, AI);
                else if (t == 1 && Field[0, 0] != Player) SetPoint(0, 0, AI);
                else if (t == 2 && Field[3, 0] != Player) SetPoint(3, 0, AI);
                else if (t == 3 && Field[0, 3] != Player) SetPoint(0, 3, AI);
                else if (t == 4 && Field[3, 3] != Player) SetPoint(3, 3, AI);
            }
        }

        protected static bool Win(char symb)
        {
            for (int i = 0; i < 5 - 4 + 1; i++)
            {
                for (int j = 0; j < 5 - 4 + 1; j++)
                {
                    if (Diagonal(symb, i, j) || Lines(symb, i, j)) return true;
                }
            }
            return false;
        }

        protected static bool Diagonal(char symb, int x, int y)
        {
            bool toright = true, toleft = true;
            for (int i = 0; i < 4; i++)
            {
                toright &= (Field[i + x, i + y] == symb);
                toleft &= (Field[4 - i - 1 + x, i + y] == symb);
            }
            if (toright || toleft) return true;
            return false;
        }

        protected static bool Lines(char symb, int x, int y)
        {
            bool cols, rows;
            for (int i = x; i < 4 + x; i++)
            {
                cols = true;
                rows = true;
                for (int j = y; j < 4 + y; j++)
                {
                    cols &= (Field[i, j] == symb);
                    rows &= (Field[j, i] == symb);
                }
                if (cols || rows) return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            EmptyField();
            MainField();

            do
            {
                PlayerMove();
                Console.WriteLine("Ваш ход на поле");
                MainField();
                if (Win(Player))
                {
                    Console.WriteLine("Вы выиграли");
                    break;
                }
                else if (FieldIsFull()) break;
                AiMove();
                Console.WriteLine("Ход Компа на поле");
                MainField();
                if (Win(AI))
                {
                    Console.WriteLine("Выиграли Комп");
                    break;
                }
                else if (FieldIsFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
        }
    }
}



















