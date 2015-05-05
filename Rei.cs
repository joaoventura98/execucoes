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
    class Rei : Peca
    {

        public Rei(Point posicaoInicialForaTabuleiro, Point posicaoInicialDentroTabuleiro, bool selecionado, String nomePictureBox, String nomePainelActual, bool capturada, Point posicaoActual, Point posicaoPretendido)
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

            if (xPainelPretendido == xpainelActual + 1 && yPainelPretendido == ypainelActual + 1)
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
            else if (xPainelPretendido == xpainelActual - 1 && yPainelPretendido == ypainelActual - 1)
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
            else if (xPainelPretendido == xpainelActual + 1 && yPainelPretendido == ypainelActual - 1)
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
            else if (xPainelPretendido == xpainelActual - 1 && yPainelPretendido == ypainelActual + 1)
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
            else if (xPainelPretendido == xpainelActual + 1 && yPainelPretendido == ypainelActual)
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
            else if (xPainelPretendido == xpainelActual - 1 && yPainelPretendido == ypainelActual)
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
                return false;
            }
        }

       
        /*uma casa
         * aumentar x e y
         * diminuir x e y
         * aumentar y e diminuir x
         * aumentar x e diminuir y
         * aumentar x e manter y
         * diminuir x e manter y
         
         */
    }
}
