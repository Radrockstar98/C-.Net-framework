using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
// Name: Chad Bowman
// Class: CS 3020
// Date: 12 May 2021
// Project: Final (RPG) 
/// <summary>
/// This project will make a simple RPG adventure where the user will have 3 characters that they will control and have the choice 
/// of attacking, defending, and a special move for each hero every term. There will also be enemies that the user must get through
/// these enemies will use their moves at random in an attemp to stop you
/// </summary>

namespace cBowman4Final
{
    public partial class Form1 : Form
    {
        #region Global variables
        // random Entity 
        Random randomEnity = new Random();

        // to get the number of levels passed (not fully implemented)
        int highestLevelsPassed = 0;
        int won = 0; 
        // to get the score (not fully implemented)
        int highestScore = 0;
        int score = 0;
        // to keep track of enemy and players as well as levels passed (for dragon spawning)
        int playerCounter;
        int enemyCounter;
        int levelCounter = 0;
        // to call the file we are writing to and reading from
        List<int> dataList = new List<int>();
        string fileHolder = "StatHolder.csv";

        // all the list that will be used to hold the entites and run the game logic
        List<Entity> entityList = new List<Entity>();
        List<Entity> sortedList = new List<Entity>();
        List<Entity> playerEntity = new List<Entity>();
        List<Entity> enemyEntity = new List<Entity>();
        Entity currentEntity = new Entity();

        // to get the picture box data
        PictureBox[] playerPictures = new PictureBox[3];
        PictureBox[] enemyPictures = new PictureBox[3];

        // to create the character entities needed
        Bandit banditEntity = new Bandit();
        Ogre ogreEntity = new Ogre();
        Dragon dragonEntity = new Dragon();
        Warrior warriorEntity = new Warrior();
        Mage mageEntity = new Mage();
        Cleric clericEntity = new Cleric();
        #endregion

        public Form1()
        {
            InitializeComponent();
            // this button will activate much of the GUI so it needs to be visible from the start
            startBtn.Click += OnStartClick;
            // stat reader is not fully implemented yet
            StatReader();
            highestLevelTxt.Text = $"{dataList[0]}";
            scoreTxt.Text = $"{dataList[1]}";
            // menu items not fully implemented due to stats but everything else is funcional 
            MenuItems();
            // to select what is visble before the start button is clicked
            FormStart();
            // the inital enemy boxes
            SpawnLocal();
        }

        #region Menu setup
        /// <summary>
        /// to get the positions of the enemies and players
        /// </summary>
        private void SpawnLocal()
        {
            // to know where each picture is and what to despawn when they are killed
            playerPictures[0] = playerPictureBox1;
            playerPictures[1] = playerPictureBox2;
            playerPictures[2] = playerPictureBox3;
            enemyPictures[0] = enemyPictureBox1;
            enemyPictures[1] = enemyPictureBox2;
            enemyPictures[2] = enemyPictureBox3;
            // for the enemies they will have a tag to get the enemy you are clicking to attack
            enemyPictureBox1.Tag = 0;
            enemyPictureBox2.Tag = 1;
            enemyPictureBox3.Tag = 2;
        }

        /// <summary>
        /// to set the menu scrip and button click events (so they actually do something)
        /// </summary>
        private void MenuItems()
        {
            MenuStrip();
            menu_Item_Quit.Click += OnQuitClick;
            menu_Item_About_Info.Click += OnInstructionClick;
            menu_Item_About_Profile.Click += OnProfileCLick;
            restartBtn.Click += OnRestartClick;
            attackBtn.Click += AttackBtnClick;
            defendBtn.Click += DefendBtnClick;
            specialBtn.Click += SpecialBtnClick;
            enemyPictureBox1.Click += EnemyClicked;
            enemyPictureBox2.Click += EnemyClicked;
            enemyPictureBox3.Click += EnemyClicked;
        }

        #region Form Start
        /// <summary>
        /// to have the player and enemies invisible as well as player txt buttons and buttons invisible, just makes stuff invisble on load
        /// </summary>
        public void FormStart()
        {
            gameLog.Visible = false;
            logLabel.Visible = false;
            specialBtn.Enabled = false;
            playerPictureBox2.Visible = false;
            playerPictureBox1.Visible = false;
            playerPictureBox3.Visible = false;
            enemyPictureBox1.Visible = false;
            enemyHealthBar1.Visible = false;
            enemyPictureBox2.Visible = false;
            enemyHealthBar2.Visible = false;
            enemyPictureBox3.Visible = false;
            enemyHealthBar3.Visible = false;
            attackBtn.Visible = false;
            defendBtn.Visible = false;
            specialBtn.Visible = false;
            warriorLbl.Visible = false;
            clericLbl.Visible = false;
            mageLbl.Visible = false;
            warriorHealthBar.Visible = false;
            mageHealthBar.Visible = false;
            clericHealthBar.Visible = false;
            warriorHealthLbl.Visible = false;
            mageHealthLbl.Visible = false;
            clericHealthLbl.Visible = false;
            restartBtn.Visible = false;
            restartBtn.Enabled = false;
        }
        #endregion

        /// <summary>
        /// to spawn the entites (also makes sure each round the player will start with 3, but they will be weaken)
        /// </summary>
        private void SetEntites()
        {
            WarriorType(); // spawns warrior
            MageType(); // spawns mage
            ClericType(); // spawns cleric
            SpawnEnemies(); // spawns the enemies
        }

        /// <summary>
        /// to spawn in the enemies
        /// </summary>
        private void SpawnEnemies()
        {
            for (int i = 0; i < 3; i++)
            {
                int random;
                if (levelCounter > 5) // the dragon will only have a chance to spawn from level 6 and onwards
                {
                    random = randomEnity.Next(0, 3);
                }
                else // before level 5 only bandit and ogre can spawn
                {
                    random = randomEnity.Next(0, 2);
                }
                switch (random)
                {
                    case 0: // bandit spawn
                        Bandit temp1 = new Bandit();
                        temp1.Location = i;
                        enemyEntity.Add(temp1);
                        break;
                    case 1: // ogre spawn
                        Ogre temp2 = new Ogre();
                        temp2.Location = i;
                        enemyEntity.Add(temp2);
                        break;
                    case 2: // dragon spawn
                        Dragon temp3 = new Dragon();
                        temp3.Location = i;
                        enemyEntity.Add(temp3);
                        break;
                }

            }
            // to place the pictures 
            for (int i = 0; i < 3; i++)
            {
                switch(enemyEntity[i].Name) // to place the right picutre for the enemy
                {
                    case "Bandit":
                        enemyPictures[i].Image = Properties.Resources.Bandit;
                        break;
                    case "Ogre":
                        enemyPictures[i].Image = Properties.Resources.Ogre;
                        break;
                    case "Dragon":
                        enemyPictures[i].Image = Properties.Resources.Dragon;
                        break;
                }
                enemyPictures[i].Visible = true;
            }
            entityList.AddRange(enemyEntity);
        }

        /// <summary>
        /// to spawn the enemies and playes
        /// </summary>
        private void Spawner()
        {
            entityList.Clear();
            enemyEntity.Clear();
            playerEntity.Clear();
            SetEntites();
            PlacePlayerPictures();
            // sort order
            SortOrder();
            // to set the player and enemy counter
            playerCounter = 3;
            enemyCounter = 3;
        }
        #endregion

        #region Player Entity types
        /// <summary>
        /// to spawn the warrior and add it to the player and entity list
        /// </summary>
        public void WarriorType()
        {
            entityList.Add(warriorEntity);
            playerEntity.Add(warriorEntity);
        }

        /// <summary>
        /// to spawn the mage and add it to the player and entity list
        /// </summary>
        public void MageType()
        {
            entityList.Add(mageEntity);
            playerEntity.Add(mageEntity);
        }

        /// <summary>
        /// to spawn the cleric and add it to the player and entity list
        /// </summary>
        public void ClericType()
        {
            entityList.Add(clericEntity);
            playerEntity.Add(clericEntity);
        }

        /// <summary>
        ///  to place the pictures of the players
        /// </summary>
        private void PlacePlayerPictures()
        {
            int heroIndex = 0; // simple loop control

            foreach(Entity e in entityList) // to loop the entity list
            {
                if(e.IsPlayer && heroIndex <= 2) // to make sure the entity is a player and the loop control is less than 2
                {
                    if (e.Name == "Warrior") // to spawn the warrior and set its helath properties 
                    {
                        playerPictures[heroIndex].BackgroundImage = Properties.Resources.Fighter;
                        playerPictures[heroIndex].Visible = true;
                        warriorHealthBar.Minimum = 0;
                        warriorHealthBar.Maximum = (int)warriorEntity.InitialHealth;
                        warriorHealthBar.Value = (int)warriorEntity.HitPoints;
                    }
                    else if(e.Name == "Mage") // to spawn the mage and set its helath properties 
                    {
                        playerPictures[heroIndex].BackgroundImage = Properties.Resources.Mage;
                        playerPictures[heroIndex].Visible = true;
                        mageHealthBar.Minimum = 0;
                        mageHealthBar.Maximum = (int)mageEntity.InitialHealth;
                        mageHealthBar.Value = (int)mageEntity.HitPoints;
                    }
                    else if (e.Name == "Cleric") // to spawn the cleric and set its helath properties 
                    {
                        playerPictures[heroIndex].BackgroundImage = Properties.Resources.Cleric;
                        playerPictures[heroIndex].Visible = true;
                        clericHealthBar.Minimum = 0;
                        clericHealthBar.Maximum = (int)clericEntity.InitialHealth;
                        clericHealthBar.Value = (int)clericEntity.HitPoints;
                    }
                    heroIndex++; // to make sure no more than three players can be spawned at once
                }
            }
        }
        #endregion

        #region Turn order
        /// <summary>
        /// to sort the list of current entities that are on the feild
        /// </summary>
        private void SortOrder()
        {
            // to help the list stay correct clear it
            sortedList.Clear();
            // then add the contets of the list to the sorted list
            sortedList.AddRange(entityList);

            // sort them from fastest to slowest using a bubble sort (not sure how else to do)
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < sortedList.Count - 1; i++)
                {
                    if (sortedList[i].Speed > sortedList[i + 1].Speed)
                    {
                        Entity temp = sortedList[i + 1];
                        sortedList[i + 1] = sortedList[i];
                        sortedList[i] = temp;
                        sorted = false;
                    }
                }
            }
            // as the above does slowest to fastest, reverse 
            sortedList.Reverse();
            // call the turn selector
            TurnSelector();
        }

        /// <summary>
        /// to get the current entity that is going to attack 
        /// </summary> 
        private void TurnSelector()
        {
            // to see if the player can use a speical attack
            if(currentEntity.IsPlayer) // first check to make sure it is a player
            {
                if(currentEntity.SkillPoints >= 5) // make sure they have the point total needed
                {
                    specialBtn.Enabled = true; // enable buntton
                }
                else // if not button is disabled
                {
                    specialBtn.Enabled = false;
                }
            }
            // set the current Entity to the fastest of the sorted list
            currentEntity = sortedList.ElementAt(0);
            // remove that entity from the sorted lise
            sortedList.RemoveAt(0);
            // update the player health bar
            HealthBar();
            // add that entity back to the end of the list
            sortedList.Add(currentEntity);
            // set the GUI
            TurnGUI();
            if (!currentEntity.IsPlayer) // if the entity is not a player let the AI take over
            {
                EnemyAction();
            }
        }

        /// <summary>
        /// this method will enable/disable the GUI for the player characters to allow for the player to know whose turn it is
        /// </summary>
        private void TurnGUI()
        {
            // here we just set the needed info to visble and the rest to invisble, same for all characters except the name changes
            if (currentEntity.Name == "Warrior") // when warrior is showing have its GUI visble everythings else invisble
            {
                warriorLbl.Visible = true;
                mageLbl.Visible = false;
                clericLbl.Visible = false;
                warriorHealthBar.Visible = true;
                mageHealthBar.Visible = false;
                clericHealthBar.Visible = false;
                warriorHealthLbl.Visible = true;
                mageHealthLbl.Visible = false;
                clericHealthLbl.Visible = false;
            }
            else if (currentEntity.Name == "Mage") // when mage is showing have its GUI visble everythings else invisble
            {
                warriorLbl.Visible = false;
                mageLbl.Visible = true;
                clericLbl.Visible = false;
                warriorHealthBar.Visible = false;
                mageHealthBar.Visible = true;
                clericHealthBar.Visible = false;
                warriorHealthLbl.Visible = false;
                mageHealthLbl.Visible = true;
                clericHealthLbl.Visible = false;
            }
            else if (currentEntity.Name == "Cleric") // when cleric is showing have its GUI visble everythings else invisble
            {
                warriorLbl.Visible = false;
                mageLbl.Visible = false;
                clericLbl.Visible = true;
                warriorHealthBar.Visible = false;
                mageHealthBar.Visible = false;
                clericHealthBar.Visible = true;
                warriorHealthLbl.Visible = false;
                mageHealthLbl.Visible = false;
                clericHealthLbl.Visible = true;
            }
        }
        #endregion

        #region Player turn   
        /// <summary>
        /// for when the attack button is clicked
        /// </summary>
        public void AttackBtnClick(object sender, EventArgs e)
        {
            currentEntity.SkillPoints++; // increase skill points
            currentEntity.Phase = "Attack"; // set attack phase
            HighlightEnemey(); // highlight enemies
        }

        /// <summary>
        /// for when the defend button is clicked
        /// </summary>
        public void DefendBtnClick(object sender, EventArgs e)
        {
            currentEntity.SkillPoints++; // increase skill points
            currentEntity.Defend(); // call defend
            gameLog.AppendText($"{currentEntity.Name} defended\r\n"); // update log
            TurnSelector(); // next turn
        }

        /// <summary>
        /// for when the special button is clicked
        /// </summary>
        public void SpecialBtnClick(object sender, EventArgs e)
        {
            currentEntity.SkillPoints -= 5; // since the player just used a speical decrease skill points by 5
            currentEntity.Phase = "Special"; // set the current phase
            HighlightEnemey(); // highlight enemies
            if (currentEntity.Name == "Cleric") // if it is the cleric it will heal the player characters by 5 if it can
            {
                ClearHighlight(); // clear enemy highlight
                if (clericEntity.HitPoints <= clericEntity.InitialHealth - 5)
                {
                    clericEntity.HitPoints += 5;
                }
                if(playerEntity.Contains(mageEntity) && mageEntity.HitPoints <= mageEntity.InitialHealth - 5)
                {
                    mageEntity.HitPoints += 5;
                }
                if(playerEntity.Contains(warriorEntity) && warriorEntity.HitPoints <= warriorEntity.InitialHealth - 5)
                {
                    warriorEntity.HitPoints += 5;
                }
                gameLog.AppendText("Cleric healed party by 5 hit points\r\n"); // update log
                TurnSelector(); // next turn
            }
        }

        /// <summary>
        /// to select which enemy is being attack
        /// </summary>
        private void EnemyClicked(object sender, EventArgs e)
        {
            // get the current enemy
            PictureBox temp = (PictureBox)sender; 
            var result = from selected in sortedList
                         where selected.IsPlayer == false
                         where selected.Location == int.Parse(temp.Tag.ToString())
                         select selected;
            if (currentEntity.Phase == "Attack") // if in the phase "attack"
            {
                // to target and deal damage to the enemy clicked on
                Entity target = result.ToList<Entity>()[0]; 
                double damage = currentEntity.Attack(target);
                // get the current damage 
                if (damage < target.HitPoints) // if the damage does not defeat the enemy
                {
                    // add the message to the game log
                    gameLog.AppendText($"{currentEntity.Name} dealt {damage} damage to {target.Name}\r\n");
                    // update health bar
                    target.HitPoints -= (int)damage;
                    TurnSelector(); // next turn
                }
                else // if it does player wins
                {
                    // update log
                    gameLog.AppendText($"{currentEntity.Name}  dealt {damage} damage and defeated {target.Name}\r\n");
                    EnemyDeath(temp, target);
                }
            }
            else if (currentEntity.Phase == "Special") // if in the phase "speical"
            {
                // to target and deal damage to the enemy clicked on
                Entity target = result.ToList<Entity>()[0];
                double damage = currentEntity.Special(target);
                // get the current damage 
                if (damage < target.HitPoints) // if the damage does not defeat the enemy
                {
                    // add the message to the game log
                    gameLog.AppendText($"{currentEntity.Name} dealt {damage} damage to {target.Name}\r\n");
                    // update health bar
                    target.HitPoints -= (int)damage;
                    TurnSelector(); // next turn
                }
                else // if it does player wins
                {
                    // update log
                    gameLog.AppendText($"{currentEntity.Name}  dealt {damage} damage and defeated {target.Name}\r\n");
                    EnemyDeath(temp, target);
                }
            }
            // clear highlight
            ClearHighlight();
        }

        /// <summary>
        /// if the enemy is killed
        /// </summary>
        private void EnemyDeath(PictureBox temp, Entity target)
        {
            // decrease number of enemies on screen
            enemyCounter -= 1;
            // make the enemy disapear and remove from list
            temp.Visible = false;
            temp.Enabled = false;
            sortedList.Remove(target);
            // update log
            gameLog.AppendText($"{target.Name} was defeated\r\n");

            if (enemyCounter <= 0) // if the enemy counter is less than or equal to 0 player wins
            {
                OnWin();
            }
            else // if not nex turn
            {
                TurnSelector();
            }
        }

        /// <summary>
        /// to highlight the enemies 
        /// </summary>
        private void HighlightEnemey()
        {
            foreach (Entity en in sortedList) // search the sorted list
            {
                if (!en.IsPlayer) // make sure it is not a player
                {
                    foreach (PictureBox pb in enemyPictures) // highlight enemy in yellow
                    {
                        pb.BackColor = Color.Yellow;
                        pb.Enabled = true;
                    }
                }
            }
        }
        /// <summary>
        /// to clear the highlight backgrounds for the enmies
        /// </summary>
        private void ClearHighlight()
        {
            foreach (PictureBox ePic in enemyPictures) // for all enemies turn back ground back to red
            {
                ePic.BackColor = Color.Red;
            }
        }
        #endregion

        #region Enemy turn
        /// <summary>
        /// to update the player characters health bar
        /// </summary>
        private void HealthBar()
        {
            // this method just keeps track of the health of the player characters and keeps the health bar/label up to date
            if (currentEntity.Name == "Warrior") // when the warrior gets hit
            {
                if (warriorHealthBar.Value > 0 && currentEntity.HitPoints >= 0) // make sure warrior is still alive
                {
                    warriorHealthBar.Value = (int)currentEntity.HitPoints; // update health
                }
                warriorHealthLbl.Text = $"Warrior Health: {(int)currentEntity.HitPoints} / {(int)currentEntity.InitialHealth}";
            }
            if (currentEntity.Name == "Mage") // when the mage gets hit
            {
                if (mageHealthBar.Value > 0 && currentEntity.HitPoints >= 0) // make sure warrior is still alive
                {
                    mageHealthBar.Value = (int)currentEntity.HitPoints; // update health
                }
                mageHealthLbl.Text = $"Mage Health: {(int)currentEntity.HitPoints} / {(int)currentEntity.InitialHealth}";
            }
            if (currentEntity.Name == "Cleric") // when the cleric gets hit
            {
                if (clericHealthBar.Value > 0 && currentEntity.HitPoints >= 0) // make sure warrior is still alive
                {
                    clericHealthBar.Value = (int)currentEntity.HitPoints; // update health
                }
                clericHealthLbl.Text = $"Mage Health: {(int)currentEntity.HitPoints} / {(int)currentEntity.InitialHealth}";
            }
        }

        /// <summary>
        /// to have the enemy attack the player
        /// </summary>
        private void EnemyAction()
        {
            // get the player health bar
            HealthBar();
            if(currentEntity.Name == "Dragon") // if it is a dragon it has three options
            {
                DragonActions();
            }
            else // if not it only has 2
            {
                // the ai decided which move the enemy does
                int randomChoice = randomEnity.Next(0, 2);
                if (randomChoice == 0) // if 0 then attack
                {
                    EnemyAttack();
                }
                else // if 1 then defend
                {
                    EnemyDefend();
                }
            }
        }
        
        /// <summary>
        /// to handle the dragon move
        /// </summary>
        private void DragonActions()
        {
            // the ai decided which move the enemy does
            int randomChoice = randomEnity.Next(0, 3);
            if (randomChoice == 0) // if 0 then attack
            {
                EnemyAttack();
            }
            else if (randomChoice == 1) // if 1 then defend
            {
                EnemyDefend();
            }
            else // if 3 then speical (hits everyone), no cooldown
            {
                EnemySpecial();
            }
        }
        /// <summary>
        ///  for when the enemy attacks
        /// </summary>
        public void EnemyAttack()
        {
            if (playerEntity.Count == 0) // if not players are left then death
            {
                OnLoss();
            }
            else// then a player can be attack
            {
                int randomPlayer;
                if (playerCounter > 1) // if there is more than 1 choice attack a random player
                {
                    randomPlayer = randomEnity.Next(0, playerEntity.Count);
                }
                else // else just attack who is first in the list
                {
                    randomPlayer = 0;
                }
                // get the target and damage
                Entity target = playerEntity.ElementAt(randomPlayer);
                double damage = currentEntity.Attack(playerEntity.ElementAt(randomPlayer));
                // add message to log
                gameLog.AppendText($"{target.Name} took {damage} damage \r\n");
                // update health bar
                UpdatePlayerHealth(target, damage);
                TurnSelector(); // next turn
            }
        }

        /// <summary>
        /// to update the players health
        /// </summary>
        private void UpdatePlayerHealth(Entity target, double damage)
        {
            int warriorNumber = 1, mageNumber = 1, clericNumber = 1; 
            if (target.Name == "Warrior" && warriorNumber != 0)
            {
                if (damage < warriorHealthBar.Value) // if the warrior is alive update
                {
                    warriorHealthBar.Value -= (int)damage;
                }
                else // if not remove from list
                {
                    gameLog.AppendText("Warrior has died\r\n");
                    playerPictureBox1.Visible = false;
                    playerPictures[0].Visible = false;
                    sortedList.Remove(warriorEntity);
                    warriorHealthBar.Value = 0;
                    warriorHealthLbl.Text = "0";
                    warriorNumber--;
                    playerEntity.Remove(warriorEntity);
                    playerCounter--;
                }
            }
            else if(target.Name == "Mage" && mageNumber != 0)
            {
                if (damage < mageHealthBar.Value) // if the mage is still alive update
                {
                    mageHealthBar.Value -= (int)damage;
                }
                else // else remove from list
                {
                    gameLog.AppendText("Mage has died\r\n");
                    playerPictureBox2.Visible = false;
                    playerPictures[1].Visible = false;
                    sortedList.Remove(mageEntity);
                    mageHealthBar.Value = 0;
                    mageHealthLbl.Text = "0";
                    playerEntity.Remove(mageEntity);
                    mageNumber--;
                    playerCounter--;
                }
            }
            else if (target.Name == "Cleric" && clericNumber != 0)
            {
                if (damage < clericHealthBar.Value) // if the cleric is still alive update
                {
                    clericHealthBar.Value -= (int)damage;
                }
                else // else remove from list
                {
                    gameLog.AppendText("Cleric has died\r\n");
                    playerPictureBox3.Visible = false;
                    playerPictures[2].Visible = false;
                    sortedList.Remove(clericEntity);
                    clericHealthBar.Value = 0;
                    clericHealthLbl.Text = "0";
                    playerEntity.Remove(clericEntity);
                    clericNumber--;
                    playerCounter--;
                }
            }
        }

        /// <summary>
        /// for when the enemy defends
        /// </summary>
        public void EnemyDefend()
        {
            // enemy defends update log, next turn
            gameLog.AppendText($"{currentEntity.Name} defended\r\n");
            TurnSelector();
        }

        /// <summary>
        /// for the enemy special (only done by dragon)
        /// </summary>
        private void EnemySpecial()
        {
            foreach(Entity target in playerEntity)
            {
                double damage = dragonEntity.Special(target);
                gameLog.AppendText($"{target.Name} took {damage} damage \r\n");
                UpdatePlayerHealth(target, damage);
            }
            gameLog.AppendText("Every body got hit... Dragon OP\r\n");
            TurnSelector();
        }
        #endregion

        #region On win/loss
        /// <summary>
        /// if the player wins
        /// </summary>
        private void OnWin()
        {
            PlayerBoost();
            // add message to log
            gameLog.AppendText("-----------------\r\nYou won!!\r\n--------------------\r\n");
            // give the player some points and a win
            won += 1;
            score += 250;
            if (won > highestLevelsPassed) // if the won total is bigger than the highest level past update
            {
                highestLevelsPassed = won;
                highestLevelTxt.Text = highestLevelsPassed.ToString();
                StatHolder(highestLevelsPassed, highestScore); // write the number in
            }
            if (score > highestScore) // if the score total is bigger than the highest score update
            {
                highestScore = score;
                scoreTxt.Text = highestScore.ToString();
                StatHolder(highestLevelsPassed, highestScore); // write the number in
            }
            // increment the level counter
            levelCounter++;
            // clear the list
            entityList.Clear();
            enemyEntity.Clear();
            playerEntity.Clear();
            // call the spawner
            Spawner();
        }

        /// <summary>
        /// to give the players a boost after beating a level
        /// </summary>
        private void PlayerBoost()
        {
            warriorEntity.SkillPoints += 10;
            mageEntity.SkillPoints += 10;
            clericEntity.SkillPoints += 10;
            // give 25 health to all player entities if they are missing at least 25 from their initial health
            if (warriorEntity.HitPoints <= warriorEntity.InitialHealth)
            {
                warriorEntity.HitPoints = warriorEntity.InitialHealth;
            }
            if (mageEntity.HitPoints <= mageEntity.InitialHealth)
            {
                mageEntity.HitPoints = mageEntity.InitialHealth;
            }
            if (clericEntity.HitPoints <= clericEntity.InitialHealth)
            {
                clericEntity.HitPoints = clericEntity.InitialHealth;
            }
        }

        /// <summary>
        /// if the player losses
        /// </summary>
        private void OnLoss()
        {
            // add message to log
            gameLog.AppendText("-----------------\r\nYou lost!!\r\n--------------------\r\n");
            restartBtn.Visible = true;
            restartBtn.Enabled = true;
            // make the player buttons invible 
            attackBtn.Visible = false;
            defendBtn.Visible = false;
            specialBtn.Visible = false;
            // make the player text invisble
            warriorLbl.Visible = false;
            mageLbl.Visible = false;
            clericLbl.Visible = false;
        }
        #endregion

        #region Menu Click
        /// <summary>
        /// to set the menuscrip info, background color to black, font color to yellow, and bold arial 12 font 
        /// </summary>
        public void MenuStrip()
        {
            menuStrip.BackColor = Color.LightGreen;
            menuStrip.ForeColor = Color.Blue;
            menuStrip.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        /// <summary>
        /// to close the application
        /// </summary>
        public void OnQuitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// to restart the application
        /// </summary>
        public void OnRestartClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// to see the creator of the game
        /// </summary>
        public void OnProfileCLick(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Chad Bowman\nClass: 3020\nHave a nice summer");
        }

        /// <summary>
        /// to see the instructions for the game
        /// </summary>
        public void OnInstructionClick(object sender, EventArgs e)
        {
            MessageBox.Show("This is an RPG adventure game, you have three heroes who are the only hopes to save the world" +
                "to do this however they need the help of someone like you. One to guide them in when to attack, defend, or " +
                "use a special move and on which enemy they attack. However it is only when their stamina has replenished" +
                "that you can guide them on their path. The mission it to hold off waves of enemies for as long as you can" +
                "to keep the world safe.");
        }

        /// <summary>
        /// to set all the peices needed for the game to be played
        /// </summary>
        public void OnStartClick(object sender, EventArgs e)
        {
            Spawner();
            startBtn.Visible = false;
            startBtn.Enabled = false;
            gameLog.Visible = true;
            logLabel.Visible = true;
            attackBtn.Visible = true;
            defendBtn.Visible = true;
            specialBtn.Visible = true;
            gameLog.AppendText("Game start\r\n");
        }
        #endregion

        #region Stat Keeper
        /// <summary>
        /// to write the stats to a csv file
        /// </summary>
        public void StatHolder(int levels, int score)
        {
            using (StreamWriter myFile = new StreamWriter(fileHolder))
            {
                // so that the format is highest level reach, highest score and then the stats underneath
                myFile.WriteLine("Highest level reached: ,Highest score: ");
                myFile.WriteLine(+levels + "," + score);
            }
        }

        /// <summary>
        /// to read the stats at the start of the game
        /// </summary>
        public void StatReader()
        {
            using (StreamReader myFile = new StreamReader(fileHolder))
            {
                // to toss the first line as it is the prefix of what each column is and does not hold the stats
                myFile.ReadLine();
                while (!myFile.EndOfStream) // while we have not gotten to the end of the file
                {
                    // now read the file
                    var dataInfo = myFile.ReadLine();
                    // add the data
                    AddStats(dataInfo);
                }
            }
        }

        /// <summary>
        /// to get the data from the file and assign it to the proper list location
        /// </summary>
        private void GetData(string[] dataPoints)
        {
            // to get the win total, loss total, win ratio, and the old average time from the file
            highestLevelsPassed = int.Parse(dataPoints[0]);
            highestScore = int.Parse(dataPoints[1]);
            dataList.Add(highestLevelsPassed);
            dataList.Add(highestScore);
        }

        /// <summary>
        /// mainly use to split the file and add that information to the list
        /// </summary>
        private void AddStats(string data)
        {
            // split the list when a comma is
            var dataSet = data.Split(',');
            // to modify the data
            GetData(dataSet);
        }
        #endregion
    }
}