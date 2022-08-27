using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.backend.pieces
{
    [Serializable]
    public class Piece
    {
        public bool player; //Player's color (black or white)
        protected bool canCastle; // For rooks and kings
        protected Chess.backend.Point location;
        public int distance;

        public Piece(int x, int y, bool player)
        {
            this.player = player;
            this.canCastle = false;
            this.distance = 7;
            this.location = new Chess.backend.Point(0, 0);
        }

		public virtual bool isValidMove(Piece[,] mat, Point from, Point to)
        {
            if (to.x < 0 || to.x > 7 || to.y < 0 || to.y > 7) return false;
            if (this.player == mat[to.x, to.y].player) return false;
            return true;
        }




	}

}
