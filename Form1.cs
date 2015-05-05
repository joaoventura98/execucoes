using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace csXadrez
{
    public partial class Form1 : Form
    {
        private string fileAndLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PEÇAS ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //----------------------------------------------------------------------------------BRANCAS : ---------------------------------------------------------------------------------------

            //-----------------------------------------------------------------------------PIÕES BRANCOS : ---------------------------------------------------------------------------------
            //PIÃO BRANCO 1 -------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB1 = new Piao(pictureBoxPiaoBranco1.Location, panel21.Location, false, pictureBoxPiaoBranco1.Name, panel21.Name, false, pictureBoxPiaoBranco1.Location, panel21.Location);                         //cria o objecto
            Global.setNewPeca(pB1);
            //Global.addNewPeca.Add(pB1);                                                                                                            //adiciona o objecto à lista


            //PIÃO BRANCO 2 ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB2 = new Piao(pictureBoxPiaoBranco2.Location, panel22.Location, false, pictureBoxPiaoBranco2.Name, panel22.Name, false, pictureBoxPiaoBranco2.Location, panel22.Location);
            Global.setNewPeca(pB2);


            //PIÃO BRANCO 3 -------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB3 = new Piao(pictureBoxPiaoBranco3.Location, panel23.Location, false, pictureBoxPiaoBranco3.Name, panel23.Name, false, pictureBoxPiaoBranco3.Location, panel23.Location);
            Global.setNewPeca(pB3);


            //PIÃO BRANCO 4 ----------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB4 = new Piao(pictureBoxPiaoBranco4.Location, panel24.Location, false, pictureBoxPiaoBranco4.Name,panel24.Name, false, pictureBoxPiaoBranco4.Location,panel24.Location);
            Global.setNewPeca(pB4);


            //PIÃO BRANCO 5 ----------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB5 = new Piao(pictureBoxPiaoBranco5.Location, panel25.Location, false, pictureBoxPiaoBranco5.Name,panel25.Name,false, pictureBoxPiaoBranco5.Location,panel25.Location);
            Global.setNewPeca(pB5);


            //PIÃO BRANCO 6 ------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB6 = new Piao(pictureBoxPiaoBranco6.Location, panel26.Location,false, pictureBoxPiaoBranco6.Name,panel26.Name,false,pictureBoxPiaoBranco6.Location,panel26.Location);
            Global.setNewPeca(pB6);


            //PIÃO BRANCO 7 ---------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB7 = new Piao(pictureBoxPiaoBranco7.Location,panel27.Location, false,pictureBoxPiaoBranco7.Name,panel27.Name,false,pictureBoxPiaoBranco7.Location,panel27.Location);
            Global.setNewPeca(pB7);


            //PIÃO BRANCO 8 --------------------------------------------------------------------------------------------------------------------------------------------------------------

            Piao pB8 = new Piao(pictureBoxPiaoBranco8.Location,panel28.Location, false,pictureBoxPiaoBranco8.Name,panel28.Name,false,pictureBoxPiaoBranco8.Location,panel28.Location);
            Global.setNewPeca(pB8);




            //----------------------------------------------------------------------------CAVALOS BRANCOS : --------------------------------------------------------------------------
            //CAVALO BRANCO 1 ----------------------------------------------------------------------------------------------------------------------------------------------------

            Cavalo cB1 = new Cavalo(pictureBoxCavaloBranco1.Location, panel12.Location, false,pictureBoxCavaloBranco1.Name,panel12.Name,false,pictureBoxCavaloBranco1.Location,panel12.Location);
            Global.setNewPeca(cB1);


            //CAVALO BRANCO 2 ------------------------------------------------------------------------------------------------------------------------------------------------------

            Cavalo cB2 = new Cavalo(pictureBoxCavaloBranco2.Location, panel17.Location, false,pictureBoxCavaloBranco2.Name,panel17.Name,false,pictureBoxCavaloBranco2.Location,panel17.Location);
            Global.setNewPeca(cB2);



            //-----------------------------------------------------------------------------BISPOS BRANCOS---------------------------------------------------------------------------
            //BISPO BRANCO 1 -------------------------------------------------------------------------------------------------------------------------------------------------------

            Bispo bB1 = new Bispo(pictureBoxBispoBranco1.Location, panel13.Location, false, pictureBoxBispoBranco1.Name, panel13.Name, false, pictureBoxBispoBranco1.Location, panel13.Location);
            Global.setNewPeca(bB1);


            //BISPO BRANCO 2 -------------------------------------------------------------------------------------------------------------------------------------------------------

            Bispo bB2 = new Bispo(pictureBoxBispoBranco2.Location, panel16.Location, false, pictureBoxBispoBranco2.Name, panel16.Name, false, pictureBoxBispoBranco2.Location, panel16.Location);
            Global.setNewPeca(bB2);



            //-------------------------------------------------------------------------------REI BRANCOS-----------------------------------------------------------------------------
            //REI BRANCO 1 -----------------------------------------------------------------------------------------------------------------------------------------------------------

            Rei rMB1 = new Rei(pictureBoxReiBranco.Location, panel14.Location, false, pictureBoxReiBranco.Name, panel14.Name, false, pictureBoxReiBranco.Location, panel14.Location);
            Global.setNewPeca(rMB1);



            //----------------------------------------------------------------------------RAINHA BRANCOS-------------------------------------------------------------------------

            Rainha rFB1 = new Rainha(pictureBoxRainhaBranca.Location, panel15.Location, false, pictureBoxRainhaBranca.Name, panel15.Name, false, pictureBoxRainhaBranca.Location, panel15.Location);
            Global.setNewPeca(rFB1);



            //----------------------------------------------------------------------------TORRES BRANCOS--------------------------------------------------------------------------
            //TORRE BRANCA 1 ------------------------------------------------------------------------------------------------------------------------------------------------------

            Torre tB1 = new Torre(pictureBoxTorreBranca1.Location,panel11.Location, false,pictureBoxTorreBranca1.Name,panel11.Name,false,pictureBoxTorreBranca1.Location,panel11.Location);
            Global.setNewPeca(tB1);


            //TORRE BRANCA 2 ------------------------------------------------------------------------------------------------------------------------------------------------------

            Torre tB2 = new Torre(pictureBoxTorreBranca2.Location, panel18.Location, false,pictureBoxTorreBranca2.Name,panel18.Name,false,pictureBoxTorreBranca2.Location,panel18.Location);
            Global.setNewPeca(tB2);








            //-------------------------------------------------------------------------PRETAS-----------------------------------------------------------------------
            //----------------------------------------------------------------------PIÕES PRETOS---------------------------------------------------------------------------

            //PIÃO PRETO 1-------------------------------------------------------------------------------------------------------------------------------------------

            Piao pP1 = new Piao(pictureBoxPiaoPreto1.Location, panel71.Location, false, pictureBoxPiaoPreto1.Name, panel71.Name, false, pictureBoxPiaoPreto1.Location, panel71.Location);
            Global.setNewPeca(pP1);

            //PIÃO PRETO 2----------------------------------------------------------------------------------------------------------------------------

            Piao pP2 = new Piao(pictureBoxPiaoPreto2.Location, panel72.Location, false, pictureBoxPiaoPreto2.Name, panel72.Name, false, pictureBoxPiaoPreto2.Location, panel72.Location);
            Global.setNewPeca(pP2);

            //PIÃO PRETO 3-------------------------------------------------------------------------------------------------------------------------------------

            Piao pP3 = new Piao(pictureBoxPiaoPreto3.Location, panel73.Location, false, pictureBoxPiaoPreto3.Name, panel73.Name, false, pictureBoxPiaoPreto3.Location, panel73.Location);
            Global.setNewPeca(pP3);

            //PIÃO PRETO 4----------------------------------------------------------------------------------------------------------------------------------------

            Piao pP4 = new Piao(pictureBoxPiaoPreto4.Location, panel74.Location, false, pictureBoxPiaoPreto4.Name, panel74.Name, false, pictureBoxPiaoPreto4.Location, panel74.Location);
            Global.setNewPeca(pP4);

            //PIÃO PRETO 5-----------------------------------------------------------------------------------------------------------------------------------------

            Piao pP5 = new Piao(pictureBoxPiaoPreto5.Location, panel75.Location, false, pictureBoxPiaoPreto5.Name, panel75.Name, false, pictureBoxPiaoPreto5.Location, panel75.Location);
            Global.setNewPeca(pP5);

            //PIÃO PRETO 6-----------------------------------------------------------------------------------------------------------------------------------------

            Piao pP6 = new Piao(pictureBoxPiaoPreto6.Location, panel76.Location, false, pictureBoxPiaoPreto6.Name, panel76.Name, false, pictureBoxPiaoPreto6.Location, panel76.Location);
            Global.setNewPeca(pP6);

            //PIÃO PRETO 7-----------------------------------------------------------------------------------------------------------------------------------------

            Piao pP7 = new Piao(pictureBoxPiaoPreto7.Location, panel77.Location, false, pictureBoxPiaoPreto7.Name, panel77.Name, false, pictureBoxPiaoPreto7.Location, panel77.Location);
            Global.setNewPeca(pP7);

            //PIÃO PRETO 8-------------------------------------------------------------------------------------------------------------------------------------------

            Piao pP8 = new Piao(pictureBoxPiaoPreto8.Location, panel78.Location, false, pictureBoxPiaoPreto8.Name, panel78.Name, false, pictureBoxPiaoPreto8.Location, panel78.Location);
            Global.setNewPeca(pP8);





            //----------------------------------------------------------------CAVALOS PRETOS-----------------------------------------------------------------
            //CAVALO PRETO 1----------------------------------------------------------------------------------------------------------------------------

            Cavalo cP1 = new Cavalo(pictureBoxCavaloPreto1.Location, panel82.Location, false, pictureBoxCavaloPreto1.Name, panel82.Name, false, pictureBoxCavaloPreto1.Location, panel82.Location);
            Global.setNewPeca(cP1);

            //CAVALO PRETO 2-----------------------------------------------------------------------------------------------------------------------------------------
            Cavalo cP2 = new Cavalo(pictureBoxCavaloPreto2.Location, panel87.Location, false, pictureBoxCavaloPreto2.Name, panel87.Name, false, pictureBoxCavaloPreto2.Location, panel87.Location);
            Global.setNewPeca(cP2);



            //-----------------------------------------------------------------BISPO PRETOS--------------------------------------------------------------------------
            //BISPO PRETO 1----------------------------------------------------------------------------------------------------------------------------------------

            Bispo bP1 = new Bispo(pictureBoxBispoPreto1.Location, panel83.Location, false, pictureBoxBispoPreto1.Name, panel83.Name, false, pictureBoxBispoPreto1.Location, panel83.Location);
            Global.setNewPeca(bP1);

            //BISPO PRETO 2--------------------------------------------------------------------------------------------------------------------------------------------------

            Bispo bP2 = new Bispo(pictureBoxBispoPreto2.Location, panel86.Location, false, pictureBoxBispoPreto2.Name, panel86.Name, false, pictureBoxBispoPreto2.Location, panel86.Location);
            Global.setNewPeca(bP2);



            //-----------------------------------------------------------------REI PRETO-----------------------------------------------------------------------

            Rei rMP1 = new Rei(pictureBoxReiPreto.Location, panel84.Location, false, pictureBoxReiPreto.Name, panel84.Name, false, pictureBoxReiPreto.Location, panel84.Location);
            Global.setNewPeca(rMP1);


            //----------------------------------------------------------------RAINHA PRETOS---------------------------------------------------------------

            Rainha rFP1 = new Rainha(pictureBoxRainhaPreta.Location, panel85.Location, false, pictureBoxRainhaPreta.Name, panel85.Name, false, pictureBoxRainhaPreta.Location, panel85.Location);
            Global.setNewPeca(rFP1);


            //--------------------------------------------------------------TORRES PRETOS-----------------------------------------------------------
            //TORRE PRETA 1-------------------------------------------------------------------------------------------------------------------------------------------

            Torre tP1 = new Torre(pictureBoxTorrePreto1.Location, panel81.Location, false, pictureBoxTorrePreto1.Name, panel81.Name, false, pictureBoxTorrePreto1.Location, panel81.Location);
            Global.setNewPeca(tP1);

            //TORRE PRETA  2-----------------------------------------------------------------------------------------------------------------------------------------

            Torre tP2 = new Torre(pictureBoxTorrePreto2.Location, panel88.Location, false, pictureBoxTorrePreto2.Name, panel88.Name, false, pictureBoxTorrePreto2.Location, panel88.Location);
            Global.setNewPeca(tP2);  

        }

        //vai fazer movimentar as peças até a posiçao dentro do tabuleiro
        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        //todo: descobrir porque e que as pecas nao se  movimentao
        private void timerReposiçaoPeças_Tick(object sender, EventArgs e)
        {
         

        }

        public void buttonColocarPecasTabuleiro_Click(object sender, EventArgs e)
        {
            foreach (int Key in Global.listaPecas.Keys)
            {
                Global.listaPecas[Key].setPretendida(Global.listaPecas[Key].getPosicaoDentrodoTabuleiro());
            
            }
          
            // todo: metodo para posicionar as peças na sua posiçao inicial no tabuleiro.
            //       Cada peça, na sua posiçao actual, vai tomar a localizaçao da
            //       posicao inicial dentro do tabuleiro
            //       atualização da posição atual na peça
            timerReposiçaoPeças.Start();
        }

        public void pecaClick_Click(object sender, EventArgs e)
        {
            //panelA1.BackColor = Color.Red;

            //para cada uma das pecas na lista 
            foreach (int Key in Global.listaPecas.Keys)
            {
                //se a peca da lista em analise for igual a peca clicada 
                //muda a imagem de fundo da respectiva picbox para selecionada
                //muda o atributo selecionado da peca da lista em analisa 
                //caso contrario 
                //muda o fundo da imagem  

                //if(peca.getSelecionado())
            }
        }

        private void timerReposiçaoPeças_Tick_1(object sender, EventArgs e)
        {

            foreach (int Key in Global.listaPecas.Keys)                //para cada objecto peca, do tipo Peca, que exista na listaPecas  
            {
                if (Global.listaPecas[Key].getposicaoActual() != Global.listaPecas[Key].getPretendida())                      // se a sua posicao atual nao for igual à sua posicao dentro do tabuleiro, faz:
                {

                    //se a posicao atual for no quandrante inferior direito superior em X e Y em relacao 
                    //a posicao dentro do tabuleiro ira diminuir 1 em 1 as cordenadas em X e Y 

                    if (Global.listaPecas[Key].getposicaoActual().X > Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y > Global.listaPecas[Key].getPretendida().Y)             //X>X && Y>Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X - 1, Global.listaPecas[Key].getposicaoActual().Y - 1));
                    }

                    //se a posicao atual for entre quandrante inferior e superior direito superior em X e igual em Y em relacao 
                    //a posicao dentro do tabuleiro ira diminuir 1 em 1 as cordenadas em X e manter a Y 

                    else if (Global.listaPecas[Key].getposicaoActual().X > Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y == Global.listaPecas[Key].getPretendida().Y)     //X>X && Y==Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X - 1, Global.listaPecas[Key].getposicaoActual().Y));
                    }

                    //se a posicao atual for no quandrante Superior direito superior em X e inferior Y em relacao 
                    //a posicao dentro do tabuleiro ira diminuir 1 em 1 as cordenadas em X e  aumentar em Y 

                    else if (Global.listaPecas[Key].getposicaoActual().X > Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y < Global.listaPecas[Key].getPretendida().Y)       //X>X && Y<Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X - 1, Global.listaPecas[Key].getposicaoActual().Y + 1));
                    }

                    //se a posicao atual for no quandrante inferior esquerdo inferior em X e superior em Y em relacao 
                    //a posicao dentro do tabuleiro ira aumentar 1 em 1 as cordenadas em X e diminuir em Y 

                    else if (Global.listaPecas[Key].getposicaoActual().X < Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y > Global.listaPecas[Key].getPretendida().Y)         //X<X && Y>Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X + 1, Global.listaPecas[Key].getposicaoActual().Y - 1));
                    }

                    //se a posicao atual for no quandrante superior esquerdo inferior em X e Y em relacao 
                    //a posicao dentro do tabuleiro ira aumentar 1 em 1 as cordenadas em X e Y 

                    else if (Global.listaPecas[Key].getposicaoActual().X < Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y < Global.listaPecas[Key].getPretendida().Y)         //X<X && Y<Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X + 1, Global.listaPecas[Key].getposicaoActual().Y + 1));
                    }

                    //se a posicao atual for no quandrante inferior ou superior esquerdo inferior em X e igual em Y em relacao 
                    //a posicao dentro do tabuleiro ira aumentar 1 em 1 as cordenadas em X e manter as de Y 

                    else if (Global.listaPecas[Key].getposicaoActual().X < Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y == Global.listaPecas[Key].getPretendida().Y)        //X<X && Y==Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X + 1, Global.listaPecas[Key].getposicaoActual().Y));
                    }

                    //se a posicao atual for no quandrante inferior esquerdo ou direito igual em X e superior em Y em relacao 
                    //a posicao dentro do tabuleiro ira manter as cordenadas em X e diminuir  1 em 1 as cordenadas em Y 

                    else if (Global.listaPecas[Key].getposicaoActual().X == Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y > Global.listaPecas[Key].getPretendida().Y)         //X==X && Y>Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X, Global.listaPecas[Key].getposicaoActual().Y - 1));
                    }

                    //se a posicao atual for no quandrante superior esquerdo ou direito igual em X e inferior em Y em relacao 
                    //a posicao dentro do tabuleiro ira manter as cordenadas em X e aumentar  1 em 1 as cordenadas em Y 

                    else if (Global.listaPecas[Key].getposicaoActual().X == Global.listaPecas[Key].getPretendida().X && Global.listaPecas[Key].getposicaoActual().Y < Global.listaPecas[Key].getPretendida().Y)         //X==X && Y<Y
                    {
                        Global.listaPecas[Key].setPosicaoActual(new Point(Global.listaPecas[Key].getposicaoActual().X, Global.listaPecas[Key].getposicaoActual().Y + 1));
                    }
                }


                //aquisiçao do controlo do objecto grafico associado à peça em manipulaçao no foreach, para a respectiva movimentaçao 
                PictureBox objAssociado = (PictureBox)this.Controls[Global.listaPecas[Key].getobjGraficoAssociado()];

                objAssociado.Location = Global.listaPecas[Key].getposicaoActual();
             
               
            }

         
            
        }

        private void AtivaPeca_Click(object sender, EventArgs e)//ao clicar num picbox o painel vai ser enviado para o object sender
        {
            foreach (int Key in Global.listaPecas.Keys)
            {
              
                if (Global.listaPecas[Key].getobjGraficoAssociado() == ((PictureBox)sender).Name)
                {
                    Global.listaPecas[Key].setSelecionado(true);
                    ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    Global.listaPecas[Key].setSelecionado(false);
                  

                     PictureBox pic = (PictureBox)this.Controls[Global.listaPecas[Key].getobjGraficoAssociado()];
                    pic.BorderStyle = BorderStyle.FixedSingle; //Muda o borderstyle para fixed single


                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timerReposiçaoPeças.Stop();
        }

        private void PanelClick_Click(object sender, EventArgs e)    //ao clicar num painel o painel vai ser enviado para o object sender
        {
            foreach (int Key in Global.listaPecas.Keys)
            {
                if (Global.listaPecas[Key].getSelecionado() == true)
                {

                    int temp = Key;     //

                    if (Global.listaPecas[Key].move(((Panel)sender).Name, temp) == true)
                    {
                        //Altera a posiçao actual
                        Global.listaPecas[Key].setPosicaoActual(((Panel)sender).Location);  // posicao pretendida toma o valor da minha posicao actual

                        //Actualiza o painel em que se encontra actualmente
                        Global.listaPecas[Key].setPanelName(((Panel)sender).Name);// o nome painel pretendido passa a ser o nome do painel actual

                        PictureBox pic = (PictureBox)this.Controls[Global.listaPecas[Key].getobjGraficoAssociado()];
                        pic.Location = ((Panel)sender).Location;
                    }




                
                }
            }
        }






        //*************
        //*   Gravar  *
        //*************

        static void serializeWithBinaryFormatter(Object obj, string fileLocation)
        {
            try
            {
                Stream streamToFile = File.OpenWrite(fileLocation);     //Cria stream para abrir e escrever na file
                BinaryFormatter bf = new BinaryFormatter();             //Serializador / Deserializador
                bf.Serialize(streamToFile, obj);
                streamToFile.Close();
            }//Escreve os bits do objecto na file binaria
            catch (Exception ex)
            {
                MessageBox.Show(""+ ex.Message);
            }
          
        }







        //*************
        //*   Ler     *
        //*************

        static Object DeserializeWithBinaryFormatter(string fileLocation)
        {
            Stream streamFromFile = File.OpenRead(fileLocation);    //Cria stream para abrir e ler a file
            BinaryFormatter bf = new BinaryFormatter();             //Serializador / Deserializador
            Object obj = bf.Deserialize(streamFromFile);            //Recebe os dados num objecto(generico)
            streamFromFile.Close();
            return obj;                                             //Devolve o objecto, mas será ainda necessário fazer a conversão do obj.
        }





        private void btnGravarDados_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)   //Verifica se tem uma directoria valida
            {
                fileAndLocation = saveFileDialog1.FileName;
                serializeWithBinaryFormatter(Global.listaPecas, fileAndLocation);
                        //Atribui o directorio á variavel onde ira ser guardo o ficheiro .bin
            }

            //Objecto a serializar
            //serializeWithBinaryFormatter(Global.listaPecas, fileAndLocation);
        }






        private void btnLerDados_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)   //Verifica se tem uma directoria valida
            {
                fileAndLocation = openFileDialog1.FileName;  
                Global.listaPecas = (Dictionary<int, Peca>)DeserializeWithBinaryFormatter(fileAndLocation);
                      //Atribui o directorio á variavel + o nome do ficheiro .bin que ira ser lido
            }


            Global.listaPecas.Clear();

            foreach (int Key in Global.listaPecas.Keys)
            {

                PictureBox objAssociado = (PictureBox)this.Controls[Global.listaPecas[Key].getobjGraficoAssociado()];
                objAssociado.Location = Global.listaPecas[Key].getposicaoActual();
            
            }       
        }



   
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void timerCaptura_Tick(object sender, EventArgs e)
        {
            foreach (int key in Global.listaPecas.Keys)
            {
                if (Global.listaPecas[key].getCapturada() == true)
                {

                    PictureBox pic = (PictureBox)this.Controls[Global.listaPecas[key].getobjGraficoAssociado()];
                    pic.Location = Global.listaPecas[key].getPosicaoForadoTabuleiro();
                }
            }
        }

       

    
    }
}
