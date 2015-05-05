using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csXadrez
{
    static class Global
    {
        static public Dictionary<int,Peca> listaPecas = new Dictionary<int,Peca>();

        public static void setNewPeca(Peca p)
        {
            listaPecas.Add(listaPecas.Count(), p);
        }

    }
}
