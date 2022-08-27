using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWFA
{
    [Serializable]
    class Pawn : Piece
    {

        public Pawn(int x, int y, bool player)
        {
            this.location.x = x;
            this.location.y = y;
            this.player = player;
        }
        Pawn()
        {

        }
    }
}
