using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWFA
{
    [Serializable]
    class Queen : Piece
    {
        public Queen(bool player)
        {
            this.player = player;
            
        }

        public Queen(int x, int y, bool player)
        {
            this.location.x = x;
            this.location.y = y;
            this.player = player;
        }

        public override bool isValidMove(Piece[,] mat, Point from, Point to)
        {
            if (base.isValidMove(mat, from, to))
            {
                for (int i = 1; i <= distance; i++)
                {
                    if (from.x + i == to.x && from.y + i == to.y) return true;
                    if (from.x - i == to.x && from.y + i == to.y) return true;
                    if (from.x + i == to.x && from.y - i == to.y) return true;
                    if (from.x - i == to.x && from.y - i == to.y) return true;
                    if (from.x + i == to.x && from.y == to.y) return true;
                    if (from.x - i == to.x && from.y == to.y) return true;
                    if (from.x == to.x && from.y + i == to.y) return true;
                    if (from.x == to.x && from.y - i == to.y) return true;
                }
            }
            return false;
        }

    }
}
