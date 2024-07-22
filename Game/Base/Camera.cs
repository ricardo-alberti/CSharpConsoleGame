namespace Game.Base
{
    internal class Camera
    {
        public void Draw(World world)
        {
            for (int l = 0; l < world.Lines; l++)
            {
                for (int c = 0; c < world.Columns; c++)
                {
                    Console.Write(world.Map[l, c]);
                }

                Console.WriteLine();
            }
        }
    }
}
