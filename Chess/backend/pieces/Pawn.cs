using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.backend.pieces
{
    [Serializable]
    public class Pawn : Piece
    {

        public Pawn(int x, int y, bool player) : base(x, y, player)
        {
            this.location.x = x;
            this.location.y = y;
            this.player = player;
        }
        public override bool isValidMove(Piece[,] mat, Point from, Point to)
        {
            if (base.isValidMove(mat, from, to))
            {
                if (this.player && from.y == 6)
                    if (from.y < to.y && from.y - to.y <= 2) return true;
                if (!this.player && from.y == 1)
                    if (from.y > to.y && to.y - from.y <= 2) return true;
                if (this.player)
                    if (from.y < to.y && from.y - to.y == 1) return true;
                if (!this.player)
                    if (from.y > to.y && to.y - from.y == 1) return true;
            }
            return false;
        }
    }
}
