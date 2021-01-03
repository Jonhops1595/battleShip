using System;
using System.IO;
/*
 * Jonathan Hopkins
 * 9/2/20
 * Is the model for the game BattleShip
 * Runs the game using statuses, gameboard functions, and trackable stats
 * Contains only input from GameSettings file
 */
namespace BattleShipGUIVersion
{
    [Serializable]
    class Game
    {
        //Instance Vars
        private Board gameBoard;
        private BoardPool gamePool;
        private string status;
        private int numTurns;
        private int numHits;
        private int numMiss;
        private int turnLim;
        private string user; //Either be player or admin

        public static int EASY;
        public static int MED;
        public static int HARD;

        //Constructor
        public Game()
        {
            StreamReader settingsStream = new StreamReader("GameSettings.txt");
            string easySetting = settingsStream.ReadLine();
            EASY = int.Parse(easySetting.Substring(easySetting.IndexOf('=') + 1));
            string medSetting = settingsStream.ReadLine();
            MED = int.Parse(medSetting.Substring(medSetting.IndexOf('=') + 1));
            string hardSetting = settingsStream.ReadLine();
            HARD = int.Parse(hardSetting.Substring(hardSetting.IndexOf('=') + 1));
            string boardSetting = settingsStream.ReadLine();
            if (boardSetting.Substring(boardSetting.IndexOf('=') + 1).Equals("Default"))
            {
                
                gamePool = new BoardPool();
            }
            else
            {
                string fileName = boardSetting.Substring(boardSetting.IndexOf('=') + 1);
                gamePool = new BoardPool(fileName);
            }
            status = "NewGame";
            numTurns = 0;
            numHits = 0;
            numMiss = 0;
        }
        //Intializes the game given a difficulty and type of user(player or admin)
        public void Initialize(string difficulty,string user)
        {
            gameBoard = gamePool.GetRandomBoard();
            status = "Initialized";
            numTurns = 0;
            numHits = 0;
            numMiss = 0;
            this.user = user;
            if (difficulty.Equals("Hard"))
                turnLim = HARD;
            else if (difficulty.Equals("Medium"))
                turnLim = MED;
            else 
                turnLim = EASY;
        }
        //Returns the status of the game
        public string Status
        {
            get { return status; }
        }

        public int NumTurns
        {
            get { return numTurns; }
        }

        public int TurnLimit
        {
            get { return turnLim; }
        }

        public int NumMiss
        {
            get { return numMiss; }
        }

        public int NumHits
        {
            get { return numHits; }
        }

        public Board GameBoard
        {
            get { return gameBoard; }
        }

        //Uses given target location and either hits or misses a spot on the board.
        //Updates the game status
        //Ups the turn count
        public void GuessLocation(string target)
        {
            
            char spot = gameBoard.GetSpot(target);
            if (spot == 'B' || spot == 'C' || spot == 'S' || spot == 'D' || spot == 'P')
            {
                gameBoard.SetSpot(target, 'X');
                status = "Hit";
                numTurns++;
                numHits++;
                gameBoard.CheckBoard();
            }
            else
            {
                gameBoard.SetSpot(target, '0');
                status = "Miss";
                numTurns++;
                numMiss++;
            }
        }
 
    
        //Changes status to reflect if user is won or lost
        public void VictoryStatus()
        {
            if (gameBoard.CheckVictory())
                status = "Victory";
            else if (numTurns >= turnLim)
                status = "Lost";
            else
                status = "onGoing";        }

    }
}
