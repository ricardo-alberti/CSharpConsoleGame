using Game.Character;

namespace Game.Base
{
    internal abstract class Scene
    {
        public World World;
        public Camera Camera;
        public Player Player;

        public int Top = 2;

        public Scene()
        {
            World = new World(30, 80);
            Player = Player.Instance;
            World.Fill();

            Camera = new Camera();
        }

        public void Space()
        {
            Top++;
        }

        public void Add(string _text, bool _margin = true)
        {
            int line = _margin == true ? (World.Columns) / 2 - _text.Length / 2 : 1;
            World.Add(Top, line, _text);

            Top++;
        }

        public void Add(int l, int c, string _text)
        {
            World.Add(l, c, _text);

            Top++;
        }

        public void SetMenuMargin()
        {
            Top = World.Lines / 2 + 6;
        }

        public void Show()
        {
            Camera.Draw(World);
        }

        public virtual string RequestUserOption()
        {
            Console.Write("Escolha uma opção: ");
            string option = Console.ReadLine();

            bool isNumeric = int.TryParse(option, out _);

            if (!isNumeric)
            {
                return RequestUserOption();
            }

            return option;
        }

        public abstract Scene ProccessUserOption(string option);

        public void Move(Scene scene)
        {
            Console.Clear();
            scene.Show();

            string option = scene.RequestUserOption();
            Scene newScene = scene.ProccessUserOption(option);

            scene.Move(newScene);
        }
    }
}
