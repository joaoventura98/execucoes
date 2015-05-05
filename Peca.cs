using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace csXadrez
{
    [Serializable]
    abstract class Peca
    {
        //ATRIBUTOS-------------------------------------------------------------------------------------------------------
        protected bool selecionado;                                         //sim ou Nao
        protected bool capturada;                               //Se esta dentro ou Fora de jogo
        protected Point posicaoActual;                         //Coordenada actual da peça no precisso momento
        protected Point posicaoForadoTabuleiro;               //coordenada da posiçao fora do tabuleiro
        protected Point posicaoDentrodoTabuleiro;             //coordenada da posiçao dentro do tabuleiro          
        protected string panelName;                                    //recebe o nome do +painel associado no grafico
        protected string objGraficoAssociado;                               //recebe o nome do objecto grafico associado
        protected Point pretendida;

        //METODOS----------------------------------------------------------------------------------------------------------

        public abstract bool move(string nomePainelPrendido, int indicePosicaoActual); 

        //-----------------------------------------------------SET--------------------------------------------------------- 
        public void setPretendida(Point pretendida)                            //Recebe e trata a informação recebida
        {
            this.pretendida = pretendida;
        }

        public Point getPretendida()                            //Recebe e trata a informação recebida
        {
            return pretendida;
        }

        public void setObjGraficoAssociado(string objGraficoAssociado)                            //Recebe e trata a informação recebida
        {
            this.objGraficoAssociado = objGraficoAssociado;
        }

        public string getobjGraficoAssociado()                            //Recebe e trata a informação recebida
        {
            return objGraficoAssociado;
        }

        //reorganizar todos o sets


        public void setPanelName(string paineleName)                            //Recebe e trata a informação recebida
        {
            panelName = paineleName;
        }

        public void setPosicaoActual(Point posicaoActual)                            //Recebe e trata a informação recebida
        {
            this.posicaoActual = posicaoActual;
        }

        public void setPosicaoForadoTabuleiro(Point PosicaoForadoTabuleiro)                 //Recebe e trata a informação recebida
        {
            posicaoForadoTabuleiro = PosicaoForadoTabuleiro;
        }

        public void setPosicaoDentrodoTabuleiro(Point PosicaoDentrodoTabuleiro)               //Recebe e trata a informação recebida
        {
            posicaoDentrodoTabuleiro  = PosicaoDentrodoTabuleiro;
        }

        public void setSelecionado(bool elecionado)               //recebe um sim caso esteija selecionado ou um nao caso nao esteja
        {
            selecionado = elecionado;
        }

        public void setCapturada(bool captura)                         // recebe o estado caso esteija ja fora do jogo ou ainda esteija em jogo
        {
            capturada = captura;
        }

        //----------------------------------------------------GETS----------------------------------------------------------
        public Point getposicaoActual()                                              //Devove a informaçao
        {
            return posicaoActual;
        }

        public Point getPosicaoForadoTabuleiro()                                            //Devove a informaçao
        {
            return posicaoForadoTabuleiro;
        }

        public Point getPosicaoDentrodoTabuleiro()                                            //Devove a informaçao
        {
            return posicaoDentrodoTabuleiro;
        }

        public bool getSelecionado()                              //devolve o valor(sim ou nao)
        {
            return selecionado;
        }

        public bool getCapturada()                                    //devlove o valor(em jogo/fora de jogo)
        {
            return capturada;
        }
        public string getpanelName()
        {
            return panelName;
        }

    }
}

