<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest
{
    public partial class Quest : Form
    {
        //The form never interacts directly with the players, weapons, or enemies.
        
        private Game game;
        private Random random = new Random();
        private void Quest_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            
            game.NewLevel(random);
            UpdateCharacters();
        }

        public Quest()
        {        
            InitializeComponent();
        }


        public bool UpdateEnemySprite(Enemy enemy, PictureBox enemySprite, Label enemyHitPoints)
        {
            bool enemySpriteUpdated = false;

            enemyHitPoints.Text = enemy.HitPoints.ToString();

            if (enemy.HitPoints > 0)
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest
{
    public partial class Quest : Form
    {
        //The form never interacts directly with the players, weapons, or enemies.
        private int levelCounter = 1;
        private Game game;
        private Random random = new Random();
        private void Quest_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            
            game.NewLevel(random);
            UpdateCharacters();
        }

        public Quest()
        {        
            InitializeComponent();
        }


        public bool UpdateEnemySprite(Enemy enemy, PictureBox enemySprite, Label enemyHitPoints)
        {
            bool enemySpriteUpdated = false;

            enemyHitPoints.Text = enemy.HitPoints.ToString();

            if (enemy.HitPoints > 0)
>>>>>>> Adding Spear
            {
                enemySprite.Location = enemy.Location;
                enemySprite.Visible = true;
                enemySpriteUpdated = true;
<<<<<<< HEAD
            }
            else
=======
            }
            else
>>>>>>> Adding Spear
            {
                enemySprite.Visible = false;
            }

            return enemySpriteUpdated;
        }

<<<<<<< HEAD
        public void UpdateCharacters()
=======
        public void UpdateCharacters()
>>>>>>> Adding Spear
        {
            PlayerSprite.Location = game.PlayerLocation;
            PlayerHitPoints.Text = game.PlayerHitPoints.ToString();
            PlayerSprite.Visible = true;

            int enemiesShown = 0;

<<<<<<< HEAD
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    if (UpdateEnemySprite(enemy, BatSprite, BatHitPoints))
=======
            //If I add enemy the if statement goes here! And I will add it :D
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    if (UpdateEnemySprite(enemy, BatSprite, BatHitPoints))
>>>>>>> Adding Spear
                    {
                        enemiesShown++;
                    }
                }
<<<<<<< HEAD
                if (enemy is Ghost)
                {
                    if (UpdateEnemySprite(enemy, GhostSprite, GhostHitPoints))
=======
                if (enemy is Ghost)
                {
                    if (UpdateEnemySprite(enemy, GhostSprite, GhostHitPoints))
>>>>>>> Adding Spear
                    {
                        enemiesShown++;
                    }
                }
<<<<<<< HEAD
                if (enemy is Ghoul)
                {
                    if (UpdateEnemySprite(enemy, GhoulSprite, GhoulHitPoints))
=======
                if (enemy is Ghoul)
                {
                    if (UpdateEnemySprite(enemy, GhoulSprite, GhoulHitPoints))
>>>>>>> Adding Spear
                    {
                        enemiesShown++;
                    }
                }
            }

            SwordSprite.Visible = false;
            BowSprite.Visible = false;
            MaceSprite.Visible = false;
            RedPotionSprite.Visible = false;
            BluePotionSprite.Visible = false;
<<<<<<< HEAD

            if (game.WeaponInRoom != null)
            {
                Control weaponControl = null;
                switch (game.WeaponInRoom.Name)
=======
            SpearSprite.Visible = false;

            if (game.WeaponInRoom != null)
            {
                Control weaponControl = null;
                switch (game.WeaponInRoom.Name)
>>>>>>> Adding Spear
                {
                    case "Sword":
                        weaponControl = SwordSprite;
                        break;
                    case "Bow":
                        weaponControl = BowSprite;
                        break;
                    case "Mace":
                        weaponControl = MaceSprite;
                        break;
                    case "Red Potion":
                        weaponControl = RedPotionSprite;
                        break;
                    case "Blue Potion":
                        weaponControl = BluePotionSprite;
                        break;
                }

<<<<<<< HEAD
                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
=======
                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
>>>>>>> Adding Spear
                {
                    weaponControl.Visible = true;
                    weaponControl.Location = game.WeaponInRoom.Location;
                }
            }
            SwordInvSprite.Visible = false;
            BowInvSprite.Visible = false;
            MaceInvSprite.Visible = false;
            RedPotionInvSprite.Visible = false;
            BluePotionInvSprite.Visible = false;
<<<<<<< HEAD

            if (game.CheckPlayerInventory("Sword"))
=======
            SpearInvSprite.Visible = false;

            if (game.CheckPlayerInventory("Sword"))
>>>>>>> Adding Spear
            {
                SwordInvSprite.Visible = true;
            }

<<<<<<< HEAD
            if (game.CheckPlayerInventory("Bow"))
=======
            if (game.CheckPlayerInventory("Bow"))
>>>>>>> Adding Spear
            {
                BowInvSprite.Visible = true;
            }

<<<<<<< HEAD
            if (game.CheckPlayerInventory("Mace"))
            {
                MaceInvSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Red Potion"))
            {
                if (!game.CheckPotionUsed("Red Potion"))
=======
            if (game.CheckPlayerInventory("Mace"))
            {
                MaceInvSprite.Visible = true;
            }
            if (game.CheckPlayerInventory("Spear"))
            {
                SpearInvSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Red Potion"))
            {
                if (!game.CheckPotionUsed("Red Potion"))
>>>>>>> Adding Spear
                {
                    RedPotionInvSprite.Visible = true;
                }
            }

<<<<<<< HEAD
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                if (!game.CheckPotionUsed("Blue Potion"))
=======
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                if (!game.CheckPotionUsed("Blue Potion"))
>>>>>>> Adding Spear
                {
                    BluePotionInvSprite.Visible = true;
                }
            }

<<<<<<< HEAD
            if (game.PlayerHitPoints <= 0)
=======

            //I can add some cool images here like gifs or more powerful images..
            if (game.PlayerHitPoints <= 0)
>>>>>>> Adding Spear
            {
                MessageBox.Show("You died");
                
                Application.Exit();
            }

<<<<<<< HEAD
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                
=======
            
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");


                if (levelCounter++ == 5)
                    MessageBox.Show("WoW!!You Get to Level 5,Here is your gift :D",
                        "I give you a gift");
>>>>>>> Adding Spear

                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        //Selected picture box (In inventary()..)
<<<<<<< HEAD
        private void SelectInventoryItem(PictureBox itemSprite, string itemName, string weaponType)
        {
            if (game.CheckPlayerInventory(itemName))
=======
        private void SelectInventoryItem(PictureBox itemSprite, string itemName, string weaponType)
        {
            if (game.CheckPlayerInventory(itemName))
>>>>>>> Adding Spear
            {
                game.Equip(itemName);
                RemoveInventorySpriteBorders();
                
                itemSprite.BorderStyle = BorderStyle.FixedSingle;
                SetupAttackButtons(weaponType);
            }
        }

<<<<<<< HEAD
        private void RemoveInventorySpriteBorders()
=======
        private void RemoveInventorySpriteBorders()
>>>>>>> Adding Spear
        {
            SwordInvSprite.BorderStyle = BorderStyle.None;
            RedPotionInvSprite.BorderStyle = BorderStyle.None;
            BowInvSprite.BorderStyle = BorderStyle.None;
            BluePotionInvSprite.BorderStyle = BorderStyle.None;
            MaceInvSprite.BorderStyle = BorderStyle.None;
        }

<<<<<<< HEAD
        private void SetupAttackButtons(string weaponType)
        {
            switch (weaponType.ToLower())
=======
        private void SetupAttackButtons(string weaponType)
        {
            switch (weaponType.ToLower())
>>>>>>> Adding Spear
            {
                case "weapon":
                    AttackUp.Text = "Up";
                    AttackRight.Visible = true;
                    AttackDown.Visible = true;
                    AttackLeft.Visible = true;
                    break;
                case "potion":
                    AttackUp.Text = "Drink";
                    AttackRight.Visible = false;
                    AttackDown.Visible = false;
                    AttackLeft.Visible = false;
                    break;
            }
<<<<<<< HEAD
        }


        //---------------------------------------------------
        //Click Events----------------------------------

        private void SwordInvSprite_Click(object sender, EventArgs e)
=======
        }


        //---------------------------------------------------
        //Click Events----------------------------------

        private void SwordInvSprite_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            SelectInventoryItem(SwordInvSprite, "Sword", "weapon");
        }

<<<<<<< HEAD
        private void RedPotionInvSprite_Click(object sender, EventArgs e)
=======
        private void RedPotionInvSprite_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            SelectInventoryItem(RedPotionInvSprite, "Red Potion", "potion");
        }

<<<<<<< HEAD
        private void BowInvSprite_Click(object sender, EventArgs e)
=======
        private void BowInvSprite_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            SelectInventoryItem(BowInvSprite, "Bow", "weapon");
           
        }
<<<<<<< HEAD

        private void BluePotionInvSprite_Click(object sender, EventArgs e)
=======
        private void SpearInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(SpearInvSprite, "Spear", "weapon");
        }

        private void BluePotionInvSprite_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            SelectInventoryItem(BluePotionInvSprite, "Blue Potion", "potion");
        }

<<<<<<< HEAD
        private void MaceInvSprite_Click(object sender, EventArgs e)
=======
        private void MaceInvSprite_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            SelectInventoryItem(MaceInvSprite, "Mace", "weapon");
        }

<<<<<<< HEAD
        private void MoveUp_Click(object sender, EventArgs e)
=======
        private void MoveUp_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

<<<<<<< HEAD
        private void MoveRight_Click(object sender, EventArgs e)
=======
        private void MoveRight_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

<<<<<<< HEAD
        private void MoveDown_Click(object sender, EventArgs e)
=======
        private void MoveDown_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

<<<<<<< HEAD
        private void MoveLeft_Click(object sender, EventArgs e)
=======
        private void MoveLeft_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

<<<<<<< HEAD
        private void AttackUp_Click(object sender, EventArgs e)
=======
        private void AttackUp_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            

            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

<<<<<<< HEAD
        private void AttackRight_Click(object sender, EventArgs e)
=======
        private void AttackRight_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

<<<<<<< HEAD
        private void AttackDown_Click(object sender, EventArgs e)
=======
        private void AttackDown_Click(object sender, EventArgs e)
>>>>>>> Adding Spear
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

<<<<<<< HEAD
        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }
    }
}
=======
        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

       
    }
}
>>>>>>> Adding Spear
