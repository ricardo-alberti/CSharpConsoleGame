namespace Game.Base
{
    internal class World
    {
        public int Lines;

        public int Columns;

        public char[,] Map;

        public World(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;

            Map = new char[Lines, Columns];
        }

        public void Fill()
        {
            // ╝ ╔ ╚ ╗ ═ ║ 
            for (int l = 0; l < Lines; l++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    if (c == 0 && l == 0)
                    {
                        Map[l, c] = '╔';
                    }
                    else if (l == 0 && c == (Columns - 1))
                    {
                        Map[l, c] = '╗';
                    }
                    else if (l == (Lines - 1) && c == 0)
                    {
                        Map[l, c] = '╚';
                    }
                    else if (l == (Lines - 1) && c == (Columns - 1))
                    {
                        Map[l, c] = '╝';
                    }
                    else if (l == 0 || l == (Lines - 1))
                    {
                        Map[l, c] = '═';
                    }
                    else if (c == 0 || c == (Columns - 1))
                    {
                        Map[l, c] = '║';
                    }
                    else
                    {
                        Map[l, c] = ' ';
                    }
                }
            }
        }

        public void Add(int l, int c, string text)
        {
            string[] vet;
            vet = text.Split('\n');

            int pos = c;

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet[i].Length; j++)
                {
                    string palavra = vet[i];
                    palavra = palavra.Replace('\r', ' ');
                    Map[l, pos] = palavra[j];
                    pos++;
                }
                pos = c;
                l++;
            }
        }}
}
