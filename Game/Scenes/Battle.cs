using Game.Base;
using Game.Character;
using Game.Enemies;

namespace Game.Scenes
{
    internal class Battle : Scene
    {
        private readonly Enemy enemy;

        public Battle(Enemy _enemy)
        {
            enemy = _enemy;

            renderEnemy();
            Space();
            renderBattleMenu();
        }

        public void renderEnemy()
        {
            foreach (string layer in enemy.Body())
            {
                Add(layer);
            }

            Space();
            Add(enemy.Name());
            Add(enemy.HealthBar());
        }

        public void renderBattleMenu()
        {
            SetMenuMargin();
            Space();
            Add($"HP:      {Player.HP}");
            Add($"Stamina: {Player.Stamina}");
            Space();
            Add("1) Atacar   ");
            Add("2) Dormir    ");
            Add("3) Usar item");
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                Player.Attack(enemy);
                enemy.PlayTurn();

                return checkBattle();
            }

            if (option == "2")
            {
                Player.Sleep();
                enemy.PlayTurn();

                return checkBattle();
            }

            if (option == "3")
            {
                return new ItemSelection(new Battle(enemy));
            }

            return new Battle(enemy);
        }

        private Scene checkBattle()
        {
            if (Player.HP <= 0)
            {
                return new DeathMessage();
            }

            else if (enemy.HP <= 0)
            {
                return new Transition(
                    new City(), 
                    $"Você derrotou o adversário! +{enemy.Gold()}",
                    enemy.Gold()
                );
            }

            return new Battle(enemy);
        }
    }
}
