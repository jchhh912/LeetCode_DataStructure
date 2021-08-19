using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class AlgorithmsClass
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<int> line = new HashSet<int>();
                HashSet<int> col = new HashSet<int>();
                HashSet<int> box = new HashSet<int>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j].ToString() != "." && !line.Add(board[i][j]))
                    {
                        return false;
                    }
                    if (board[j][i].ToString() != "." && !col.Add(board[j][i]))
                    {
                        return false;
                    }
                    int l = (i / 3) * 3 + j / 3;
                    int c = (i % 3) * 3 + j % 3;
                    if (board[l][c].ToString() != "." && !box.Add(board[l][c]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}