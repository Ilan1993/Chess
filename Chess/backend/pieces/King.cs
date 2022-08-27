using System;

namespace ChessWFA
{
    [Serializable]
    class King : Queen
    {
        public King(int x, int y, bool player) : base(player)
        {
            distance = 1;
            this.location.x = x;
            this.location.y = y;
            this.player = player;
        }
    }
}
