using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.backend
{
    [Serializable]
    class Knight : Piece
    {
        public Knight(int x, int y, bool player)
        {
            this.location.x = x;
            this.location.y = y;
            this.player = player;
        }
        public override bool isValidMove(Piece[,] mat, Point from, Point to)
        {
            if (base.isValidMove(mat, from, to))
            {
                if (from.x + 1 == to.x && from.y + 2 == to.y) return true;
                if (from.x - 1 == to.x && from.y + 2 == to.y) return true;
                if (from.x + 1 == to.x && from.y - 2 == to.y) return true;
                if (from.x - 1 == to.x && from.y - 2 == to.y) return true;
                if (from.x + 2 == to.x && from.y + 1 == to.y) return true;
                if (from.x - 2 == to.x && from.y + 1 == to.y) return true;
                if (from.x + 2 == to.x && from.y - 1 == to.y) return true;
                if (from.x - 2 == to.x && from.y - 1 == to.y) return true;
            }
            return false;
        }

    }
}
