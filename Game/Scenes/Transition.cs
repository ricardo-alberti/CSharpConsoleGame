using Game.Base;
using Game.Database;

namespace Game.Scenes
{
    internal class Transition : Scene
    {
        Scene nextScene;
        private readonly Connection conn = new Connection();

        public Transition(Scene _nextScene, string _msg, int gold)
        {
            nextScene = _nextScene;
            Player.Gold += gold;

            Add(_msg);
        }
        
        public override string RequestUserOption()
        {
            Console.Write(" - Pressione Enter para continuar - ");
            string option = Console.ReadLine();

            return option;
        }

        public override Scene ProccessUserOption(string option)
        {
            //conn.SavePoint();

            return nextScene;
        }
    }
}
