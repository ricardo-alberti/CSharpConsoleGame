using Game.Items;
using Game.Base;

namespace Game.Scenes
{
    internal class Store : Scene
    {
        private readonly int[] stock;

        private readonly Dictionary<Item, int> items = 

        new Dictionary<Item, int> { 
            {new DragonSlayer(), 1},
            {new Potion(100), 1},
            {new KnightArmor(), 1},
            {new UltimateGreatSwordOfDoom(), 1}
        };

        public Store(string _msg = "")
        {
            Space();
            Add("                 ____________ ");
            Add("  _,            |            |");
            Add(",'*l            |            |");
            Add("`'l #-----_     |____________|");
            Add("   `.#===========l _      _ / ");
            Add("    H`**'H        /.l____/.l  ");
            Add("    H    H        l_/    l_/  ");
            Space();
            Add($"{_msg}");
            Space();
            Add($"HP: {Player.HP}");
            Add($"Stamina: {Player.Stamina}");
            Add($"Gold: {Player.Gold}");
            SetMenuMargin();
            Add("1) Voltar para a cidade");
            ShowStock();
        }

        private void ShowStock()
        {
            int i = 2;
            foreach (var pair in items)
            {
                Item item = pair.Key;
                int stock = pair.Value;

                if (stock > 0 && !Player.Backpack.Contains(item.Name()))
                {
                    Add($"{i}) Comprar {item.Name()} por {item.Price()} gold x{stock}");
                }
                else
                {
                    Add($"{i}) {item.Name()} por {item.Price()} gold  - Comprado");
                }
                //Add($"     -> {item.Description()}", false);
                i++;
            }
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                return new City();
            }

            int itemBoughtIdx = Convert.ToInt32(option) - 2;
            if (itemBoughtIdx >= 0 && itemBoughtIdx < items.Count)
            {
                var pair = items.ElementAt(itemBoughtIdx);
                Item item = pair.Key;
                int stock = pair.Value;
                string message = "";

                if (Player.Backpack.Contains(item.Name()))
                {
                    message = "-- Item já adquirido --";
                }

                else if (stock == 0)
                {
                    message = "-- Sem estoque do item --";
                }

                else if (item.Price() > Player.Gold)
                {
                    message = "-- Sem gold suficiente --";
                }

                else
                {
                    Player.Backpack.AddItem(item);
                    Player.Gold = Player.Gold - item.Price();
                    items[item] = stock - 1;
                }

                return new Store(message);
            }

            return new Store();
        }
    }
}
