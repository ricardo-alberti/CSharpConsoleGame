using Game.Base;
using Game.Items;

namespace Game.Scenes
{
    internal class ItemSelection : Scene
    {
        Dictionary<int, Item> itemSelection;
        Scene scene;

        public ItemSelection(Scene _scene)
        {
            itemSelection = new Dictionary<int, Item>();
            scene = _scene;

            Space();
            Add("1) Voltar");
            Items();
        }

        private void Items()
        {
            int i = 2;
            foreach (var pair in Player.Backpack.Items())
            {
                Item item = pair.Value;
                string name = pair.Key;

                Add($"{i}) Usar {item.Name()}");
                itemSelection.Add(i, item);

                i++;
            }

            if (itemSelection.Count == 0)
            {
                Add(" - Sem items na mochila - ");
            }
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                return scene;
            }

            int optionNumber = option[0] - '0';
            if (!itemSelection.ContainsKey(optionNumber))
            {
                return new ItemSelection(scene);
            }

            itemSelection[optionNumber].Use();
            return scene;
        }
    }
}
