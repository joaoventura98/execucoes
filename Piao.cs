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
    class Piao : Peca
    {
  
        public Piao(Point posicaoInicialForaTabuleiro, Point posicaoInicialDentroTabuleiro, bool selecionado, String nomePictureBox, String nomePainelActual, bool capturada, Point posicaoActual, Point posicaoPretendido)
        {
            this.posicaoForadoTabuleiro = posicaoInicialForaTabuleiro;
            this.posicaoDentrodoTabuleiro = posicaoInicialDentroTabuleiro;
            this.selecionado = selecionado;
            this.objGraficoAssociado = nomePictureBox;
            this.panelName = nomePainelActual;
            this.capturada = capturada;
            this.posicaoActual = posicaoActual;
            this.pretendida  = posicaoPretendido;
        }



        public override bool move(string nomePainelPrendido, int indicePosicaoActual)
        {
            string nomePainelActual = Global.listaPecas[indicePosicaoActual].getpanelName();
            string numeroPainelPretendida = Regex.Replace(nomePainelPrendido, @"\D", "");
            string numeroPainelActual = Regex.Replace(nomePainelActual,@"\D", "");

            int xPainelPretendido = Convert.ToInt16(numeroPainelPretendida.Substring(0, 1));
            int yPainelPretendido = Convert.ToInt16(numeroPainelPretendida.Substring(1, 1));
            int xpainelActual = Convert.ToInt16(numeroPainelActual.Substring(0, 1));
            int ypainelActual = Convert.ToInt16(numeroPainelActual.Substring(1, 1));



            if (Global.listaPecas[indicePosicaoActual].getobjGraficoAssociado().Contains("Preto") == true)
            {
                if (xpainelActual > xPainelPretendido)
                {
                    if (xPainelPretendido == xpainelActual - 1 && yPainelPretendido == ypainelActual)
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
                    else if (xPainelPretendido == xpainelActual - 2 && yPainelPretendido == ypainelActual)
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
                else
                {
                    return false;
                }


            }
            else if (Global.listaPecas[indicePosicaoActual].getobjGraficoAssociado().Contains("Branco") == true)
            {
                if (xpainelActual < xPainelPretendido)
                {
                    if (xPainelPretendido == xpainelActual + 1 && yPainelPretendido == ypainelActual)
                    {
                        return true;
                    }
                    else if (xPainelPretendido == xpainelActual + 2 && yPainelPretendido == ypainelActual)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            { 
                return false;
            }

     





            /*brancas: caso x da posicao atual for menor da posicao pp e o y da pa for igual a da pp
             * pa x+1 pa y = pa y
             * /
             *pretas: caso x da posicao atual for maior da posicao pp e o y da pa for igual a da pp
             * pa x-1 pa y = pa y
             * 
             * Comer:
             * 
             * *brancas peca a comer lado direito: x da posicao atual +1 e o y da pa for igual a da pa
             * +1
             * /
             *pretas lado esquerdo: x da posicao atual +1 e o y da pa -1 */
        }
        
    }
}

