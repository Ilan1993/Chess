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
        
        


    }

}
