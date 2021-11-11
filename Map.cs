using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    class Map
    {
        public Tile[,] map;
        public Hero playerCharacter;
        public Enemy[] enemies;
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
        Hero player;
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

            player = (Hero)Create(Tile.TileType.Hero);

            MakeMap();
        }

        private Tile Create(Tile.TileType type)
        {
            int positionX = numbers.Next(1, mapWidth);
            int positionY = numbers.Next(1, mapHeight);

            if (positionX > mapHeight || positionY > mapWidth)
            {
                return Create(type);
            }

            if (type == Tile.TileType.Enemy)
            {
                return new Goblin(positionX, positionY, type, 'G', 1, 10);
            }
            else if (type == Tile.TileType.Hero)
            {
                return new Hero(positionX, positionY, type, 'H', 20, 20);
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


            for(int i = enemyAmount; i < 9; i++)
            {
                enemy = (Enemy)Create(Tile.TileType.Enemy);
                map[enemy.GetX(), enemy.GetY()] = enemy;
            }
        }

        public void MoveHero(Character.MovementEnum move)
        {
            map[player.GetX(), player.GetY()] = new EmptyTile(player.GetX(), player.GetY(), Tile.TileType.EmptyTile);
            player.ReturnMove(move);
            map[player.GetX(), player.GetY()] = player;
        }

        public void UpdateVision()  //Updates the vision array for each character 
        {

        }
    }
}
