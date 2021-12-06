using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POETask2
{
    class Map
    {
        public static Tile[,] map;
        public Hero playerCharacter;
        public Enemy[] enemies;
        public Gold gold;
        private int mapHeight;
        private int mapWidth;
        private int MinHeight;
        private int MaxHeight;
        private int MinWidth;
        private int MaxWidth;
        public int borderHeight;
        public int borderWidth;
        private int AmtEnemy;
        private static Random numbers = new Random();
        private static Random rand = new Random();
        private static int enemyAmount = rand.Next(1, 9);
        private static Random goblinAmount = new Random();
        private static int goblinAmt = goblinAmount.Next(1, enemyAmount);
        private static Random mageAmount = new Random();
        private static int mageAmt = mageAmount.Next(1, enemyAmount);
        private static Random goldAmount = new Random();
        private static int goldennAmt = goblinAmount.Next(1, 5);
        public static int goldCollected = 0;
        public static bool canMove = true;
        public static Hero player;
        Enemy enemy;


        public Map(int minHeight, int maxHeight, int minWidth, int maxWidth, int amtEnemy)
        {
            MinHeight = minHeight;
            MaxHeight = maxHeight;
            MinWidth = minWidth;
            MaxWidth = maxWidth;
            AmtEnemy = amtEnemy;

            mapHeight = numbers.Next(minHeight, maxHeight);
            mapWidth = numbers.Next(minWidth, maxWidth);

            borderHeight = mapHeight + 2;
            borderWidth = mapWidth + 2;

            map = new Tile[borderWidth, borderHeight];

            enemies = new Enemy[AmtEnemy];

            MakeMap();
        }

        private Tile Create(Tile.TileType type, Type EnemyType = null)
        {
            int positionX = numbers.Next(1, mapWidth);
            int positionY = numbers.Next(1, mapHeight);

            if (positionX > mapHeight || positionY > mapWidth)
            {
                return Create(type, EnemyType);
            }

            if (type == Tile.TileType.Enemy)
            {
                return (Enemy)Activator.CreateInstance(EnemyType, positionX, positionY, type, EnemyType == typeof(Goblin) ? 'G' : 'M', 1, 10);
            }
            else if (type == Tile.TileType.Hero)
            {
                return new Hero(positionX, positionY, type, 'H', 20, 20);
            }
            else if (type == Tile.TileType.Gold)
            {
                return new Gold(positionX, positionY);
            }
            else if (type == Tile.TileType.Enemy)
            {
                return (Enemy)Activator.CreateInstance(EnemyType, positionX, positionY, type, EnemyType == typeof(Leader) ? 'L' : 2, 20);
            }

            return new Hero(positionX, positionY, Tile.TileType.Hero, 'H', 20, 20);

        }

        private void MakeMap()
        {
            for (int x = 0; x < borderWidth; x++)
            {
                for (int y = 0; y < borderHeight; y++)
                {
                    map[x, y] = new EmptyTile(x, y, Tile.TileType.EmptyTile);

                    if (x == 0 || x == borderWidth - 1 || y == 0 || y == borderHeight - 1)
                    {
                        map[x, y] = new Obstacle(x, y, Tile.TileType.Obstacle);
                    }
                }
            }

            player = (Hero)Create(Tile.TileType.Hero);
            map[player.GetX(), player.GetY()] = player;

            for (int i = 0; i < AmtEnemy; i++)
            {
                enemies[i] = (Goblin)Create(Tile.TileType.Enemy, typeof(Goblin));
                map[enemies[i].GetX(), enemies[i].GetY()] = enemies[i];
            }

            for (int i = 0; i < AmtEnemy; i++)
            {
                enemies[i] = (Mage)Create(Tile.TileType.Enemy, typeof(Mage));
                map[enemies[i].GetX(), enemies[i].GetY()] = enemies[i];
            }

            for (int i = 0; i < goldennAmt + 1; i++)
            {
                gold = (Gold)Create(Tile.TileType.Gold);
                map[gold.GetX(), gold.GetY()] = gold;
            }

        }

        public void MoveHero(Character.MovementEnum move)
        {
            int x = player.GetX();
            int y = player.GetY();

            switch (move)
            {
                case Character.MovementEnum.Up:
                    {
                        x--;
                        break;
                    }

                case Character.MovementEnum.Down:
                    {
                        x++;
                        break;
                    }

                case Character.MovementEnum.Left:
                    {
                        y--;
                        break;
                    }

                case Character.MovementEnum.Right:
                    {
                        y++;
                        break;
                    }
            }

            if (map[x, y] is Goblin || map[x, y] is Obstacle || map[x,y] is Mage)
            {
                canMove = false;
                return;
            }

            map[player.GetX(), player.GetY()] = new EmptyTile(player.GetX(), player.GetY(), Tile.TileType.EmptyTile);
            player.ReturnMove(move);

            if (map[player.GetX(), player.GetY()] is Gold)
            {
                goldCollected = goldCollected + 1;
            }

            map[player.GetX(), player.GetY()] = player;
        }

        public void HeroAttack(Character.AttackEnum attack)
        {
            int x = player.GetX();
            int y = player.GetY();

            switch (attack)
            {
                case Hero.AttackEnum.Up:
                    {
                        Tile tile = map[x - 1, y];
                        if (tile is Enemy)
                        {
                            Enemy enemy = (Enemy)tile;
                            enemy.TakeDamage();
                            enemy.IsDead();

                            if (enemy.IsDead())
                            {
                                map[x - 1, y] = new EmptyTile(x - 1, y, Tile.TileType.EmptyTile);
                            }
                        }
                        break;
                    }

                case Hero.AttackEnum.Down:
                    {
                        if (map[x + 1, y] is Enemy)
                        {
                            Tile tile = map[x + 1, y];
                            if (tile is Enemy)
                            {
                                Enemy enemy = (Enemy)tile;
                                enemy.TakeDamage();
                                enemy.IsDead();

                                if (enemy.IsDead())
                                {
                                    map[x + 1, y] = new EmptyTile(x+1, y, Tile.TileType.EmptyTile);
                                }
                            }
                        }
                        break;
                    }

                case Hero.AttackEnum.Left:
                    {
                        if (map[x, y - 1] is Enemy)
                        {
                            Tile tile = map[x, y - 1];
                            if (tile is Enemy)
                            {
                                Enemy enemy = (Enemy)tile;
                                enemy.TakeDamage();
                                enemy.IsDead();

                                if (enemy.IsDead())
                                {
                                    map[x, y - 1] = new EmptyTile(x, y - 1, Tile.TileType.EmptyTile);
                                }
                            }
                        }
                        break;
                    }

                case Hero.AttackEnum.Right:
                    {
                        if (map[x, y + 1] is Enemy)
                        {
                            Tile tile = map[x, y + 1];
                            if (tile is Enemy)
                            {
                                Enemy enemy = (Enemy)tile;
                                enemy.TakeDamage();
                                enemy.IsDead();

                                if (enemy.IsDead())
                                {
                                    map[x, y + 1] = new EmptyTile(x, y + 1, Tile.TileType.EmptyTile);
                                }
                            }
                        }
                        break;
                    }
            }




           // public void UpdateVision()  //Updates the vision array for each character 
            //{

            //}
        }

        public void MoveEnemy(Character.MovementEnum move)
        {
            for(int i = 0; i < AmtEnemy; i++)
            {


                int x = enemies[i].GetX();
                int y = enemies[i].GetY();

                switch (move)
                {
                    case Character.MovementEnum.Up:
                        {
                            x--;
                            break;
                        }

                    case Character.MovementEnum.Down:
                        {
                            x++;
                            break;
                        }

                    case Character.MovementEnum.Left:
                        {
                            y--;
                            break;
                        }

                    case Character.MovementEnum.Right:
                        {
                            y++;
                            break;
                        }
                }

                if (map[x, y] is Goblin || map[x, y] is Obstacle || map[x, y] is Mage)
                {
                    canMove = false;
                    return;
                }

                map[enemies[i].GetX(), enemies[i].GetY()] = new EmptyTile(enemies[i].GetX(), enemies[i].GetY(), Tile.TileType.EmptyTile);
                enemies[i].ReturnMove(move);

                map[x, y] = enemies[i];
            }
        }
    }
}
