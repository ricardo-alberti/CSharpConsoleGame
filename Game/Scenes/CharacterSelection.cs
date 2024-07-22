using Game.Base;
using Game.Character;

namespace Game.Scenes
{
    internal class CharacterSelection : Scene
    {
        public CharacterSelection()
        {
            Add("Digite o nome do personagem.");
        }

        public override string RequestUserOption()
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            return name;
        }

        public override Scene ProccessUserOption(string _name)
        {
            Player.Name = _name;

            return new City();
        }
    }
}
