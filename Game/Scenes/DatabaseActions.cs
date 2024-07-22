using Game.Base;
using Game.Database;

namespace Game.Scenes
{
    internal class DatabaseActions : Scene
    {
        private readonly Connection conn = new Connection();

        public DatabaseActions()
        {
            Add("1) Create new table");
            Add("2) Player list     ");
            Add("3) Insert my player");
            Add("4) Menu            ");
        }

        public override Scene ProccessUserOption(string option)
        {
            switch (option)
            {
                case "1":
                    {
                        conn.DropTable();
                        conn.CreateTable();
                        break;
                    }

                case "2":
                    {
                        return new LoadCharacter();
                    }

                case "3":
                    {
                        conn.SavePoint();
                        break;
                    }
                case "4":
                    {
                        return new Menu();
                    }
            }

            return new DatabaseActions();
        }
    }
}
