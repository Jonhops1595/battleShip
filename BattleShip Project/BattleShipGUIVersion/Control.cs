using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/*
 * Jonathan Hopkins
 * 10/8/20
 * Contol is the controller for the Battleship GUI.
 * It uses states in order to determine actions from the View and translates them to the Model and back
 */
namespace BattleShipGUIVersion
{
    
    class Control
    {
        //Instance Vars
        private string stateOfBattleShip;
        private string stateOfMain;
        public Game game;
        private string userName;
        private string fileName;

        //Constructor
        public Control()
        {
            stateOfBattleShip = "main";
            stateOfMain = "file";
            game = new Game();
        }
        //Getters for the states
        public string getStateOfBattleShip()
        {
            return stateOfBattleShip;
        }

        public string getStateOfMain()
        {
            return stateOfMain;
        }
        //Private methods that go between the states 
        private void goStatePlay()
        {
            stateOfMain = "play";
            stateOfBattleShip = "main";
        }

        private void goStateDiff()
        {
            stateOfMain = "diff";
        }

        private void goStateSave()
        {
            stateOfMain = "save";
            stateOfBattleShip = "main";
         
        }

        private void goStateQuit()
        {
            stateOfBattleShip = "quit";
            stateOfMain = "null";
            System.Windows.Forms.Application.Exit();
        }

        private void goStateStat()
        {
            stateOfMain = "stat";
        }

        private void goStateEnd()
        {
            stateOfMain = "null";
            stateOfBattleShip = "end";
        }

        //The event when the prompt is inputed
        public void prompt_Inputed(string promptInput)
        {
            if (stateOfMain == "file" && promptInput != "")
            {
                this.userName = promptInput;
                fileName = this.userName + "Save.ser";
                if (File.Exists(fileName))
                {
                    Stream loadStream = File.OpenRead(fileName);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    game = (Game)(deserializer.Deserialize(loadStream));
                    loadStream.Close();
                    File.Delete(fileName);
                    goStatePlay();
                }
                else
                {
                    goStateDiff();
                }
                
            }
            else if(stateOfMain == "diff")
            {
                if (promptInput.Equals("Easy") || promptInput.Equals("Medium") || promptInput.Equals("Hard"))
                {
                    game.Initialize(promptInput, "player");
                    goStatePlay();
                }
            }
        }

        //Event when the location on the board is entered
        public void enter_Location(string target)
        {
            if(stateOfMain == "save" || stateOfMain == "play")
            {
                try
                {
                    game.GuessLocation(target);
                }
                catch (Exception)
                {

                }
                game.VictoryStatus();
                if (game.Status != "onGoing")
                    end_game();
            }
        }

        //Quit event
        public void quit_button()
        {
            if (stateOfBattleShip == "main")
                goStateQuit();
        }

        //Save event
        public void save_button()
        {
            if(stateOfMain == "play")
            {
                BinaryFormatter serializer = new BinaryFormatter();
                Stream saveStream = File.Create(fileName);
                serializer.Serialize(saveStream, game);
                saveStream.Close();
                goStateSave();
            }
        }

        //Display event
        public void display_button()
        {
            if(stateOfMain == "play")
            {
                goStateStat();
            }

            else if(stateOfMain == "stat")
            {
                goStatePlay();
            }
        }
        
        //end of game event
        public void end_game()
        {
            goStateEnd();
        }

        //Gets the text for the stat screen
        public string getStatText()
        {
            string statText = "";
            statText += "Ships Destoyed: ";
            bool[] shipArray = game.GameBoard.ShipCheck;
            if (shipArray[0])
                statText += ("\n\tCarrier(5)");
            if (shipArray[1])
                statText += ("\n\tBattleShip(4)");
            if (shipArray[2])
                statText += ("\n\tDestroyer(3)");
            if (shipArray[3])
                statText += ("\n\tSubmarine(3)");
            if (shipArray[4])
                statText += ("\n\tPatrol Boat(2)");

            statText +=
            "\n\n\tNumber of shots: " + game.NumTurns +
            "\n\tNumber of hits: " + game.NumHits +
            "\n\tNumber of misses: " + game.NumMiss;

            return statText;
        }



    }
}
