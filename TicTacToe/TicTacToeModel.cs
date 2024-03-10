using System;

namespace TicTacToe
{
    internal class TicTacToeModel
    {
        private readonly int?[] map;
        private readonly int size;
        private readonly Random rnd;
        public delegate int StrategyDelegate();

        public TicTacToeModel(int size)
        {
            this.size = size;
            map = new int?[size * size];
            rnd = new Random();
        }
        public int? this[int index]
        {
            get => map[index];
            set { map[index] = value; }
        }
        public bool IsCheck()
        {
            int sum;
            //проверка rows
            for (int i = 0; i < size * size; i += size)
            {
                if (map[i] == null)
                    continue;
                sum = 0;
                for (int j = 0; j < size; j++)
                    if (map[i].Equals(map[i + j]))
                        sum++;
                if (sum == size)
                    return true;
            }
            //проверка collums
            for (int i = 0; i < size; i++)
            {
                if (map[i] == null)
                    continue;
                sum = 0;
                for (int j = 0; j < size; j++)
                    if (map[i].Equals(map[i + size * j]))
                        sum++;
                if (sum == size)
                    return true;
            }
            //проверка diagonal_1
            sum = 0;
            if (map[0] != null)
            {
                for (int i = 0; i < size; i++)
                    if (map[0].Equals(map[i + size * i]))
                        sum++;
                if (sum == size)
                    return true;
            }
            //проверка diagonal_2
            if (map[size - 1] != null)
            {
                sum = 0;
                for (int i = 1; i <= size; i++)
                    if (map[size - 1].Equals(map[size * i - i]))
                        sum++;
                if (sum == size)
                    return true;
            }
            return false;
        }
        public void NewInitianal()
        {
            for (int i = 0; i < size * size; i++)
                map[i] = null;
        }
        public bool IsStandoff()
        {
            foreach (int? i in map)
                if (i == null)
                    return false;
            return true;
        }
        public int RundomPositionComputer(StrategyDelegate strategyDelegate)
        {
            return strategyDelegate() == -1 ? EasyStrategyAttackOrProtection() : strategyDelegate();
        }
        public int EasyStrategyAttackOrProtection()
        {
            int position;
            while (true)
            {
                position = rnd.Next(size * size);
                for (int i = 0; i < size * size; i++)
                    if (map[i] == null && --position == 0)
                        return i;
            }
        }
        public int AverageStrategyAttackOrProtection()
        {
            int sum;
            int pos = -1;
            int[] move = {1, 0};
            for(int k = 0; k < move.Length; k++)
            {
                //проверка rows
                for (int i = 0; i < size * size; i += size)
                {
                    sum = 0;

                    for (int j = 0; j < size; j++)
                    {
                        if (map[i + j] == null)
                            pos = i + j;

                        if (map[i + j] == move[k])
                            sum++;
                    }

                    if (sum == size - 1 && pos != -1)
                        return pos;

                    pos = -1;
                }
            }
        
            return pos;
        }
        public int DifficultStrategyAttackOrProtection()
        {
            if (AverageStrategyAttackOrProtection() != -1)
                return AverageStrategyAttackOrProtection();

            int sum;
            int pos = -1;
            int[] move = { 1, 0 };

            for (int k = 0; k < move.Length; k++)
            {
                //проверка collums
                for (int i = 0; i < size; i++)
                {
                    sum = 0;
                    for (int j = 0; j < size; j++)
                    {
                        if (map[i + size * j] == null)
                            pos = i + size * j;
                        if (map[i + size * j] == move[k])
                            sum++;
                    }

                    if (sum == size - 1 && pos != -1)
                    {
                        return pos;
                    }
                        

                    pos = -1;
                }
            }
    
            return pos;
        }
        public int SuperDifficultStrategyAttackOrProtection()
        {
            if (DifficultStrategyAttackOrProtection() != -1)
                return DifficultStrategyAttackOrProtection();
            
            int[] move = { 1, 0 };
            int sum = 0;
            int pos = -1;
            //проверка diagonal_1
            for (int k = 0; k < move.Length; k++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (map[i + size * i] == null)
                        pos = i + size * i;
                    if (map[i + size * i] == move[k])
                        sum++;
                }

                if (sum == size - 1 && pos != -1)
                    return pos;
            }

            //проверка diagonal_2
            sum = 0;
            pos = -1;
            for (int k = 0; k < move.Length; k++)
            {
                for (int i = 1; i <= size; i++)
                {
                    if (map[size * i - i] == null)
                        pos = size * i - i;
                    if (map[size * i - i] == move[k])
                        sum++;
                }
                if (sum == size - 1 && pos != -1)
                    return pos;
            }
        
            return -1;
        }
    }
}
