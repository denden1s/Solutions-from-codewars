using System;

public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
    if(Sum(board) >= 13)
      return 0;
    else
      return GiveState(board);
  }

  private int Sum(int[,] board)
  {
    int res = 0;
    for(int i = 0; i < board.GetLength(0); i++)
      for(int j = 0; j < board.GetLength(1); j++)
        res += board[i,j];
    return res;
  }

  private int GiveState(int[,] board)
  {
    int winOnDiagonal = IsWinOnDiagonal(board);
    if(winOnDiagonal == -1)
    {
      for(int i = 0; i < board.GetLength(0); i++)
      {
        int winOnRow = 0;
        int winOnColumn = 0;
        winOnRow = IsWinOnSeries(board, i, true);
        winOnColumn =  IsWinOnSeries(board, i, false);
        if((winOnRow == 1) ||(winOnColumn == 1))
          return 1;
        if((winOnRow == 8) ||(winOnColumn == 8))
          return 2;
      }
      return -1;
    }
    else 
      return winOnDiagonal;
  }

  private int IsWinOnSeries(int[,] board,  int rowOrCol, bool state)
  {
    int multi = 1;
    for(int j = 0; j < board.GetLength(1); j++)
      multi *= state == true? board[rowOrCol, j] : board[j,rowOrCol];
    return multi;
  }

  private int IsWinOnDiagonal(int[,] board)
  {
    int first = 1;
    int second = 1;
    int j = 2;
    for(int i = 0; i < board.GetLength(0); i++)
    {
      first *= board[i,i];
      second *= board[i,j--];
    }
    if((first == 8) || (second == 8))
      return 2;
    else if((first == 1) || (second == 1))
      return 1;
    return -1; 
  }
}