using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWFA
{
    [Serializable]
    public class Piece
    {
        public bool player; //Player's color (black or white)
        protected bool canCastle; // For rooks and kings
        protected Point location;
        public int distance = 7;

		bool validMove(Piece[,] mat, Point from, Point to)
        {
            if (to.x < 0 || to.x > 7 || to.y < 0 || to.y > 7) return false;
            if (mat[to.x, to.y] != null || this.player == mat[to.x, to.y].player) return false;
            return true;
        }


	}

}
