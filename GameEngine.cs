using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace POETask2
{
    class GameEngine
    {
        private static readonly char Hero = 'H';
        private static readonly char Empty = '.';
        private static readonly char Goblin = 'G';
        private static readonly char Obstacle = 'X';
        private static readonly char Gold = '@';

        private Map map;

        public GameEngine()
        {
            map = new Map(20, 20, 20, 20, 5);
        }

        public Map GetMap()
        {
            return map;
        }

        public bool MovePlayer(Character.MovementEnum direction)
        {
            return false;
        }

        public override String ToString()
        {
            string text = "";

            for (int x = 0; x < map.borderWidth; x++)
            {
                for (int y = 0; y < map.borderHeight; y++)
                {
                    text += Map.map[x, y].getSymbol();
                }
                text += "\n";
            }

            return text;
        }

        public string Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsOut = new FileStream("MapData.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            string Output = "";
            try
            {
                using (fsOut)
                {
                    bf.Serialize(fsOut, map);
                    Output = "Game Saved Successfully!";
                }
            }
            catch (Exception e)
            {
                Output = e.Message;
            }
            return Output;
        }

       /* public bool Load()
        {
            bool Output = false;
            Random r = new Random();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsIN = new FileStream("MapData.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            r.Next(4);
            //map.Merchant.r = r;

            try
            {
                using (fsIN)
                {
                    map = (Map)bf.Deserialize(fsIN);
                    for (int i = 0; i < map.; i++)
                    {
                        Goblin GoblinUpdate;
                        Leader LeaderUpdate;
                        if (map.enemies[i].Symbol == "G")
                        {
                            GoblinUpdate = (Goblin)map.enemies[i];
                            r.Next(4);
                            GoblinUpdate.r = r;
                        }
                        if (map.enemies[i].Symbol == "L")
                        {
                            LeaderUpdate = (Leader)map.enemies[i];
                            r.Next(4);
                            LeaderUpdate.r = r;
                        }

                    }
                }
                Output = true;
            }
            catch (Exception)
            {

                Output = false;
            }
            return Output;
        }*/
    }
}
