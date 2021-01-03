using System;
using System.Collections.Generic;
using System.Text;
/*
 Jonathan Hopkins
 8/29/20
 Acts as the game board for BattleShip
 Is 10X10 in size
 */
namespace BattleShipGUIVersion
{
    [Serializable]
    class Board
    {
        //Instance Vars
        public static int SIZE = 10; //BattleShip Board is 10 X 10
        public char[,] charBoard;

        public static readonly char[] rowNames = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        public static readonly char[] shipTypes = new char[5] { 'C', 'B', 'D', 'S', 'P' };
        private bool[] shipCheck = new bool[5] { false, false, false, false, false };
        //Constructor (new array)
        public Board()
        {
            charBoard = new char[SIZE, SIZE];
        }
        //Constructor (existing array)
        public Board(char[,] charBoard)
        {
            this.charBoard = charBoard;
        }

        public bool[] ShipCheck
        {
            get { return shipCheck; }
        }

        //Returns the spot on the board given the BattleShip Syntax (LetterDigit)
        public char GetSpot(string target)
        {
            char first = target[0];
            char second = target[1];
            if (!Char.IsLetter(first))
                throw new FormatException();
            else if (!char.IsDigit(second))
                throw new FormatException();
            else
            {
                int secondInt;
                if (target.Length > 2)
                {
                    if (target.Substring(1, 2).Equals("10"))
                        secondInt = 9;
                    else
                        throw new FormatException();
                }
                else
                    secondInt = int.Parse(second.ToString()) - 1;
                switch (first)
                {
                    case 'A':
                        return charBoard[0, secondInt];
                    case 'B':
                        return charBoard[1, secondInt];
                    case 'C':
                        return charBoard[2, secondInt];
                    case 'D':
                        return charBoard[3, secondInt];
                    case 'E':
                        return charBoard[4, secondInt];
                    case 'F':
                        return charBoard[5, secondInt];
                    case 'G':
                        return charBoard[6, secondInt];
                    case 'H':
                        return charBoard[7, secondInt];
                    case 'I':
                        return charBoard[8, secondInt];
                    case 'J':
                        return charBoard[9, secondInt];
                    default:
                        throw new FormatException();
                }
            }
        }
        //Sets the target spot to newChar
        public void SetSpot(string target, char newChar)
        {
            char first = target[0];
            char second = target[1];
            if (!Char.IsLetter(first))
                throw new FormatException();
            else if (!char.IsDigit(second))
                throw new FormatException();
            else
            {
                int secondInt;
                if (target.Length > 2)
                    secondInt = 9;
                else
                    secondInt = int.Parse(second.ToString()) - 1;
                switch (first)
                {
                    case 'A':
                        charBoard[0, secondInt] = newChar;
                        break;
                    case 'B':
                        charBoard[1, secondInt] = newChar;
                        break;
                    case 'C':
                        charBoard[2, secondInt] = newChar;
                        break;
                    case 'D':
                        charBoard[3, secondInt] = newChar;
                        break;
                    case 'E':
                        charBoard[4, secondInt] = newChar;
                        break;
                    case 'F':
                        charBoard[5, secondInt] = newChar;
                        break;
                    case 'G':
                        charBoard[6, secondInt] = newChar;
                        break;
                    case 'H':
                        charBoard[7, secondInt] = newChar;
                        break;
                    case 'I':
                        charBoard[8, secondInt] = newChar;
                        break;
                    case 'J':
                        charBoard[9, secondInt] = newChar;
                        break;
                    default:
                        throw new FormatException();
                }
            }
        }

        //Checks the board for ships. Changes shipCheck if all cells of a ship are destoryed
        public void CheckBoard()
        {
            for(int shipCheckIndex = 0; shipCheckIndex < shipCheck.Length; shipCheckIndex++)
            {
                if (!shipCheck[shipCheckIndex])
                {
                    bool foundShip = false;
                    for (int i = 0; i < SIZE; i++) 
                    { 
                        for (int j = 0; j < SIZE; j++)
                        {
                            if (charBoard[i, j] == shipTypes[shipCheckIndex])
                                foundShip = true;
                        }
                    }
                    if (!foundShip)
                        shipCheck[shipCheckIndex] = true;
                }
            }
        

        }
        //Checks the gameboard to see if victory has occured, true if clear, false if not.
        public bool CheckVictory()
        {
            foreach(bool clearShip in shipCheck)
            {
                if (!clearShip)
                    return false;
            }
            return true;
        }
        //String of the board in console game form
        public override string ToString()
        {
            String boardString = "";
            for(int i = 0; i < SIZE + 1; i++)
            {
                if (i > 0)
                {
                    boardString += "\n";
                    boardString += rowNames[i - 1] + "\t";
                }
                else
                {
                    boardString += " \t";
                }
                for(int j = 0; j < SIZE; j++)
                {
                    if (i == 0)
                        boardString += (j + 1) + " ";
                    else
                    {
                        if (charBoard[i - 1, j] == 'C' || charBoard[i - 1, j] == 'B' || charBoard[i - 1, j] == 'S' || charBoard[i - 1, j] == 'D' || charBoard[i - 1, j] == 'P')
                            boardString += "- ";
                        else
                            boardString += charBoard[i - 1, j] + " ";
                    }
                }
            }
            return boardString;
        }
    }
}
