using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace csXadrez
{
    [Serializable]
    class Cavalo : Peca
    {

        public Cavalo(Point posicaoInicialForaTabuleiro, Point posicaoInicialDentroTabuleiro, bool selecionado, String nomePictureBox, String nomePainelActual, bool capturada, Point posicaoActual, Point posicaoPretendido)
        {
            this.posicaoForadoTabuleiro = posicaoInicialForaTabuleiro;
            this.posicaoDentrodoTabuleiro = posicaoInicialDentroTabuleiro;
            this.selecionado = selecionado;
            this.objGraficoAssociado = nomePictureBox;
            this.panelName = nomePainelActual;
            this.capturada = capturada;
            this.posicaoActual = posicaoActual;
            this.pretendida = posicaoPretendido;
        }

        public override bool move(string nomePainelPrendido, int indicePosicaoActual)
        {
            string nomePainelActual = Global.listaPecas[indicePosicaoActual].getpanelName();
            string numeroPainelPretendida = Regex.Replace(nomePainelPrendido, @"\D", "");
            string numeroPainelActual = Regex.Replace(nomePainelActual, @"\D", "");

            int xPainelPretendido = Convert.ToInt16(numeroPainelPretendida.Substring(0, 1));
            int yPainelPretendido = Convert.ToInt16(numeroPainelPretendida.Substring(1, 1));
            int xpainelActual = Convert.ToInt16(numeroPainelActual.Substring(0, 1));
            int ypainelActual = Convert.ToInt16(numeroPainelActual.Substring(1, 1));

            if(xPainelPretendido == xpainelActual - 2 && yPainelPretendido == ypainelActual + 1)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else if (xPainelPretendido == xpainelActual - 2 && yPainelPretendido == ypainelActual - 1)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else if (xPainelPretendido == xpainelActual - 1 && yPainelPretendido == ypainelActual - 2)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else if (xPainelPretendido == xpainelActual + 1 && yPainelPretendido == ypainelActual - 2)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else if (xPainelPretendido == xpainelActual + 2 && yPainelPretendido == ypainelActual + 1)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else if (xPainelPretendido == xpainelActual + 2 && yPainelPretendido == ypainelActual - 1)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else if (xPainelPretendido == xpainelActual + 1 && yPainelPretendido == ypainelActual + 2)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else if (xPainelPretendido == xpainelActual - 1 && yPainelPretendido == ypainelActual + 2)
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return true;
            }
            else
            {
                foreach (int key in Global.listaPecas.Keys)
                {
                    if (Global.listaPecas[key].getpanelName() == nomePainelPrendido)
                    {
                        Global.listaPecas[key].setCapturada(true);
                        Global.listaPecas[key].setPanelName("none");
                        return true;
                    }
                }
                return false;
            }

        }
       /*
        diminuir x duas casas e aumentrar y uma casa
         * 
         * diminuir o x duas casas e o y uma
         * 
         * diminuir o y uma casa e o x uma casa 
         * 
         * diminuir o y duas casas e aumentar o y uma casa
         * 
         * vai ter que aumentar o x duas casas e o y uma 
         * 
         * vai ter que aumentar o x uma casa e o y 2 casas
         * 
         * vai ter que aumnetar o x uma casa e o y 2
         * 
         * vai ter que aumnetar o y 2 casas e o x diminuir uma
          */
    }
}
