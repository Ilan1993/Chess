using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessWFA
{
	class Board
	{
		const int SIZE = 8;
		Piece[,] mat;

		public Board()
		{
			mat = new Piece[SIZE, SIZE];
			cleanBoard(mat);
			newBoard(mat);
		}
		void cleanBoard(Piece[,] mat)
		{
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++)
					mat[i,j] = null;
		}

		void newBoard(Piece[,] mat)
		{
			mat[0, 0] = new Rook(0,0,false);
			mat[1, 0] = new Knight(1,0,false);
			mat[2, 0] = new Bishop(2,0,false);
			mat[3, 0] = new Queen(3,0,false);
			mat[4, 0] = new King(4,0,false);
			mat[5, 0] = new Bishop(5,0,false);
			mat[6, 0] = new Knight(6,0,false);
			mat[7, 0] = new Rook(7,0,false);
			mat[0, 7] = new Rook(0,7,true);
			mat[1, 7] = new Knight(1,7,true);
			mat[2, 7] = new Bishop(2,7,true);
			mat[3, 7] = new Queen(3,7,true);
			mat[4, 7] = new King(4,7,true);
			mat[5, 7] = new Bishop(5,7,true);
			mat[6, 7] = new Knight(6,7,true);
			mat[7, 7] = new Rook(7,7,true);
			for (int i = 0; i < 8; i++)
			{
				mat[i, 6] = new Pawn(i,6,true);
				mat[i, 1] = new Pawn(i,1,false);

			}
		}

	}
}
