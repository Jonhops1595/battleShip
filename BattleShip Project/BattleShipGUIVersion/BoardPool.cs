using System;
using System.Collections.Generic;
using System.Text;
/*
 * Jonathan Hopkins
 * 9/2/20
 * Creates a pool of boards for BattleShip.
 * Can either search for file (not implemented yet) or just creates a pool from three preset hardcoded boards.
 */
namespace BattleShipGUIVersion
{
    [Serializable]
    class BoardPool
    {
        //Instance var for pool of boards
        private Board[] pool;

        //Constructor 
        public BoardPool()
        {
            LoadBoards();
        }
        //Constructor, brings boards from a file (not implemented yet)
        public BoardPool(string fileName)
        {
            LoadBoards(fileName);
        }
        //Loads three default hardcoded boards
        public void LoadBoards()
        {
            pool = new Board[3];
            string [] stringBoards = new string[3];
                 stringBoards[0] =  "----------" +
                                    "B-----PP--" +
                                    "B---------" +
                                    "B---S-----" +
                                    "B---S-----" +
                                    "DDD-S-----" +
                                    "----------" +
                                    "----------" +
                                    "-----CCCCC" +
                                    "----------";

                 stringBoards[1] =  "-------SSS" +
                                    "----------" +
                                    "----------" +
                                    "----C-PP--" +
                                    "----C-----" +
                                    "----C--DDD" +
                                    "----C-----" +
                                    "----C-----" +
                                    "BBBB------" +
                                    "----------";

                 stringBoards[2] =    "--CCCCC---" +
                                      "----------" +
                                      "-S--------" +
                                      "-S-------P" +
                                      "-S-------P" +
                                      "----------" +
                                      "----BBBB--" +
                                      "----------" +
                                      "---DDD----" +
                                      "----------";
            for (int boardCount = 0; boardCount < 3; boardCount++)
            {
                char[,] newBoard = new char[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        newBoard[i, j] = stringBoards[boardCount][(i * 10) + j];
                    }
                }
                pool[boardCount] = new Board(newBoard);
            }
        }
        //Loads boards from file (not implemented yet)
        public void LoadBoards(string fileName)
        {

        }
        //Returns a random board from the pool
        public Board GetRandomBoard()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, pool.Length);
            return pool[num];
        }

 
    }
}
