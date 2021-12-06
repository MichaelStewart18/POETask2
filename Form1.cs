using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POETask2
{
    public partial class Form1 : Form
    {
        GameEngine engine;

        public void UpdateAttackLog()
        {
            attackLog_RTB.Text = "some stuff";
        }

        public Form1()
        {
            InitializeComponent();

            engine = new GameEngine();
            lblMap.Text = engine.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WeaponRange_Label_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.MovementEnum somethingElse = (Character.MovementEnum)enemyMove;

            engine.GetMap().MoveHero(Character.MovementEnum.Right);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = Map.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void btnUp_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.MovementEnum somethingElse = (Character.MovementEnum)enemyMove;

            engine.GetMap().MoveHero(Character.MovementEnum.Up);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = Map.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void btnLeft_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.MovementEnum somethingElse = (Character.MovementEnum)enemyMove;

            engine.GetMap().MoveHero(Character.MovementEnum.Left);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = Map.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void btnDown_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.MovementEnum somethingElse = (Character.MovementEnum)enemyMove;

            engine.GetMap().MoveHero(Character.MovementEnum.Down);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = Map.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void attackUp_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.AttackEnum.Up);
            lblMap.Text = engine.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.AttackEnum.Down);
            lblMap.Text = engine.ToString();
        }

        private void attackRight_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.AttackEnum.Right);
            lblMap.Text = engine.ToString();
        }

        private void attackLeft_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.AttackEnum.Left);
            lblMap.Text = engine.ToString();
        }

        private void attackDown_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.AttackEnum.Down);
            lblMap.Text = engine.ToString();
        }
    }
}
