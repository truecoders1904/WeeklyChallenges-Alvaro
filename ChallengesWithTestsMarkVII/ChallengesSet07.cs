using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null)
            {
                return 0;
            }
            int count = 0;
            foreach (Business biz in businesses)
                if (biz.TotalExpenses < biz.TotalRevenue)
                {
                    count += 0;
                }
                else
                {
                    count += 1;
                }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            List<string> list = new List<string>();
            foreach (Business biz in businesses)
            {
                if (biz.TotalRevenue > biz.TotalExpenses)
                {
                    list.Add(biz.Name);
                }
            }
            return string.Join(",", list.ToArray());
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            /* while(business.ParentCompany != null)
             {
                 business.ParentCompany = business;
             }
             return business.Name;*/

            if (business.ParentCompany == null)
            {
                return business.Name;
            }
            return GetNameOfHighestParentCompany(business.ParentCompany);
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            for (int col = 0; col < finalBoard.GetLength(0); col++)
            {

                if ((finalBoard[col, 0] == 'X' && finalBoard[col, 1] == 'X' && finalBoard[col, 2] == 'X') ||
                    (finalBoard[0, col] == 'X' && finalBoard[1, col] == 'X' && finalBoard[2, col] == 'X'))
                {
                    return TicTacToeResult.X;
                }
                else if ((finalBoard[col, 0] == 'O' && finalBoard[col, 1] == 'O' && finalBoard[col, 2] == 'O') ||
                     (finalBoard[0, col] == 'O' && finalBoard[1, col] == 'O' && finalBoard[2, col] == 'O'))
                {
                    return TicTacToeResult.O;
                }
                else if (finalBoard[0,0] == 'O' && finalBoard[1,1] == 'O' && finalBoard[2,2] == 'O')
                {
                    return TicTacToeResult.O;
                }
                else if (finalBoard[2, 0] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[0, 2] == 'X')
                {
                    return TicTacToeResult.X;
                }
            }
            return TicTacToeResult.Draw;
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            foreach (int[] a in numbers)
            {
                bool check = false;
                foreach (int b in a)
                {
                    if (targetNumber == b)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
