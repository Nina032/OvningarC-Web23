using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Typen av värde som en ruta har
    /// </summary>
    internal enum MarkType
    {
        //Tomt
        Free,
        //Rutan innehåller O
        Nought,
        //Rutan innehåller X
        Cross
    }
}
