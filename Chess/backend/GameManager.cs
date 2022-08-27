using Chess.backend.players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.backend
{
    class GameManager
    {
        //start game
        // create 2 players
        // create borad + init pieces
        // show shows turn msg

        public Player p1;
        public Player p2;
        public Board board;

        public GameManager()
        {
            p1 = new Player();
            p2 = new Player();
            Console.WriteLine(p1.name);
            board = new Board();
        }

        
    }
}
