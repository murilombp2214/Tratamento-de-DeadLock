using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoDeSO_1.Core;
using TrabalhoDeSO_1;
using System.IO;
using Microsoft.Office;
namespace TrabalhoDeSO_1
{
    public partial class FrmPrincipal : Form
    {
        #region Atributos
        private string numeroDeLinha = string.Empty;
        private string numeroDeColuna = string.Empty;
        private bool pedirQtdProcessosRecursos = !false;
        private bool gerouErro = false;
        #endregion Atributos

        #region Construtor
        /// <summary>
        /// Construtor
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            labelDescricao.Text = string.Empty;
        }

        #endregion Construtor
        #region Propiedades
        /// <summary>
        /// Objeto de parametros para a class DeadLock
        /// </summary>
        private DeadLockParams Parametros { get; set; }
        #endregion Propiedades
        #region Metodos
        /// <summary>
        /// Responsavel por Inicializar todos as configurações do formulario
        /// </summary>
        private void Inicializar()
        {
            gridMatriz_C.Columns.Clear();
            gridMatriz_R.Columns.Clear();
            gridVetor_D.Columns.Clear();
            gridVetor_E.Columns.Clear();
            if(pedirQtdProcessosRecursos)
            {
                using (var frmCampoUmGenerico = new FrmUmCampoGenerico())
                {
                    //obtem quantidade de linha
                    frmCampoUmGenerico.Valor = string.Empty;
                    frmCampoUmGenerico.Descricao = "Processo:";

                    frmCampoUmGenerico.ShowDialog();
                    numeroDeLinha = frmCampoUmGenerico.Valor;

                    //obtem quantidade de coluna
                    frmCampoUmGenerico.Descricao = "Recurso:";
                    frmCampoUmGenerico.Valor = string.Empty;

                    frmCampoUmGenerico.ShowDialog();

                    numeroDeColuna = frmCampoUmGenerico.Valor;
                }
            }
        }

        /// <summary>
        /// Monta a grid com o tamanho especificado de linha e coluna
        /// </summary>
        private void MonteGrids()
        {

            for (int i = 0; i < decimal.Parse(numeroDeColuna); ++i)
            {
                gridVetor_D.Columns.Add(i.ToString(), i.ToString());
                gridVetor_E.Columns.Add(i.ToString(), i.ToString());
                gridMatriz_C.Columns.Add(i.ToString(), i.ToString());
                gridMatriz_R.Columns.Add(i.ToString(), i.ToString());
            }

            gridVetor_D.Rows.Add();
            gridVetor_E.Rows.Add();

            for (int i = 0; i < decimal.Parse(numeroDeLinha); ++i)
            {

                gridMatriz_C.Rows.Add();
                gridMatriz_R.Rows.Add();
            }
        }

        /// <summary>
        /// Popula a grid com um objeto deadlockparams  passado por parametro
        /// </summary>
        /// <param name="lockParams">Objeto DeadLockParams</param>
        private void PopuleGrids(DeadLockParams lockParams)
        {
            for (int i = 0; i < decimal.Parse(numeroDeColuna); ++i)
            {
                gridVetor_E.Rows[0].Cells[i].Value = lockParams.Vetor_E[i];

                gridVetor_D.Rows[0].Cells[i].Value = lockParams.Vetor_D[i];
            }

            for (int i = 0; i < decimal.Parse(numeroDeColuna); ++i)
            {
                for (int j = 0; j < decimal.Parse(numeroDeLinha); ++j)
                {
                    gridMatriz_C.Rows[i].Cells[j].Value = lockParams.Matriz_C[i, j];
                    gridMatriz_R.Rows[i].Cells[j].Value = lockParams.Matriz_R[i, j];

                }
            }
        }

        /// <summary>
        /// Soma Todos de uma coluna da Matriz C
        /// </summary>
        /// <param name="coluna">Número da coluna</param>
        /// <returns>Quantidade da soma</returns>
        private int SomeTodosDaColuna_C(int coluna)
        {
            int saida = 0;
            for (int i = 0; i < int.Parse(numeroDeLinha); ++i)
            {
                saida += int.Parse(gridMatriz_C.Rows[i].Cells[coluna].Value.ToString());
            }
            return saida;
        }

        /// <summary>
        /// Mostra os resultados em uma label e atualiza no form
        /// </summary>
        /// <param name="texto">Texto a setar</param>
        private void MostraTextoLabel(string texto)
        {
            labelDescricao.Text = texto;
            labelDescricao.Refresh();
        }

        /// <summary>
        /// Popula grid com objeto local de DeadLockParams, Se o check do form for setado, mostra a mudança lentamente
        /// </summary>
        private void PopuleGrids()
        {
            for (int i = 0; i < Parametros.QtdColuna; ++i)
            {
                gridVetor_D.Rows[0].Cells[i].Selected = false;
                gridVetor_E.Rows[0].Cells[i].Selected = false;
            }

            for (int i = 0; i < Parametros.QtdLinha; ++i)
            {
                for (int j = 0; j < Parametros.QtdColuna; ++j)
                {
                    gridMatriz_C.Rows[i].Cells[j].Selected = false;
                    gridMatriz_R.Rows[i].Cells[j].Selected = false;
                }
            }
            gridVetor_D.Refresh();
            gridVetor_E.Refresh();
            gridMatriz_C.Refresh();
            gridMatriz_R.Refresh();


            for (int i = 0; i < Parametros.QtdColuna; ++i)
            {
                if (checkBoxLentamente.Checked)
                {
                    MostraTextoLabel($"Vetor_D[{i}] passa de {gridVetor_D.Rows[0].Cells[i].Value.ToString()} para {Parametros.Vetor_D[i]}");

                    System.Threading.Thread.Sleep(500);
                }

                gridVetor_D.Rows[0].Cells[i].Value = Parametros.Vetor_D[i];
                gridVetor_D.Rows[0].Cells[i].Selected = true;
                gridVetor_D.Refresh();
                if (checkBoxLentamente.Checked)
                {
                    MostraTextoLabel($"Vetor_E[{i}] passa de {gridVetor_E.Rows[0].Cells[i].Value.ToString()} para {Parametros.Vetor_E[i]}");
                    System.Threading.Thread.Sleep(500);
                }
                gridVetor_E.Rows[0].Cells[i].Value = Parametros.Vetor_E[i];
                gridVetor_E.Rows[0].Cells[i].Selected = true;
                gridVetor_E.Refresh();
            }

            for (int i = 0; i < Parametros.QtdLinha; ++i)
            {
                for (int j = 0; j < Parametros.QtdColuna; ++j)
                {
                    if (checkBoxLentamente.Checked)
                    {
                        MostraTextoLabel(
                            $"Matriz_C[{i}][{j}] passa de { gridMatriz_C.Rows[i].Cells[j].Value.ToString()} para {Parametros.Matriz_C[i, j]}"
                            );
                        System.Threading.Thread.Sleep(500);
                    }
                    gridMatriz_C.Rows[i].Cells[j].Value = Parametros.Matriz_C[i, j];
                    gridMatriz_C.Rows[i].Cells[j].Selected = true;
                    gridMatriz_C.Refresh();
                    if (checkBoxLentamente.Checked)
                    {
                        MostraTextoLabel(
                            $"Matriz_R[{i}][{j}] passa de { gridMatriz_R.Rows[i].Cells[j].Value.ToString()} para {Parametros.Matriz_R[i, j]}"
                            );
                        System.Threading.Thread.Sleep(500);
                    }
                    gridMatriz_R.Rows[i].Cells[j].Value = Parametros.Matriz_R[i, j];
                    gridMatriz_R.Rows[i].Cells[j].Selected = true;
                    gridMatriz_R.Refresh();
                }
            }
            MostraTextoLabel("Fim de Processamento");
            System.Threading.Thread.Sleep(500);
            MostraTextoLabel("..");
            System.Threading.Thread.Sleep(500);
            MostraTextoLabel(".....");
            System.Threading.Thread.Sleep(500);
            MostraTextoLabel("...........");
            System.Threading.Thread.Sleep(500);
            MostraTextoLabel(string.Empty);


        }

        /// <summary>
        /// Bloqueia todas as grids
        /// </summary>
        /// <param name="bloquear">tipo primitivo booleano que define se é para bloquear</param>
        private void BloqueiGrids(bool bloquear = true)
        {
            gridMatriz_C.Enabled = bloquear;
            gridMatriz_R.Enabled = bloquear;
            gridVetor_D.Enabled = bloquear;
            gridVetor_E.Enabled = bloquear;
        }
        #endregion Metodos

        #region Eventos
        /// <summary>
        /// Evento Clik - Reinicia Ou Inicia Todo form
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Inicializar();
            MonteGrids();
            btnIniciar.Visible = true;
            btnLimpar.Visible = true;
            btnGerarVetorDAutomaticamente.Visible = true;
            btnGerarVetorDAutomaticamente.Visible = true;
            Parametros = null;
            gerouErro = false;
        }

        /// <summary>
        /// Inicia as configurações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                BtnGerarVetorDAutomaticamente_Click(null, null);
                if(gerouErro)
                {
                    gerouErro = false;
                    return;
                }
                gerouErro = false;
                if (string.IsNullOrEmpty(numeroDeColuna) || string.IsNullOrEmpty(numeroDeLinha))
                {
                    throw new Exception("Deve se iniciar a quatidade de Processos e recursos!");
                }
                int qtdLinha = int.Parse(numeroDeLinha);
                int qtdColuna = int.Parse(numeroDeColuna);

                Parametros = new DeadLockParams()
                {
                    Vetor_E = new decimal[qtdColuna],
                    Vetor_D = new decimal[qtdColuna],
                    Matriz_C = new decimal[qtdLinha, qtdColuna],
                    Matriz_R = new decimal[qtdLinha, qtdColuna]

                };

                //apenas os vetores
                for (int i = 0; i < int.Parse(numeroDeColuna); ++i)
                {
                    decimal decOut_D = 0;
                    decimal decOut_E = 0;
                    string aux = gridVetor_D.Rows[0].Cells[i].Value?.ToString()?.Trim();
                    if (aux == null || aux.Equals(string.Empty))
                    {
                        throw new Exception("A Linha do vetor D não pode ser vazia");
                    }
                    else if (!decimal.TryParse(aux, out decOut_D))
                    {
                        throw new Exception("A Linha do vetor D não pode conter letra");
                    }


                    aux = gridVetor_E.Rows[0].Cells[i].Value?.ToString().Trim();
                    if (aux == null || aux.Equals(string.Empty))
                    {
                        throw new Exception("A Linha do vetor E não pode ser vazio");
                    }
                    else if (!decimal.TryParse(aux, out decOut_E))
                    {
                        throw new Exception("A Linha do vetor E não pode conter letra");
                    }

                    Parametros.Vetor_D[i] = decOut_D;
                    Parametros.Vetor_E[i] = decOut_E;
                }

                var vetAux = new decimal[qtdColuna];

                //apenas as matrizes
                for (int i = 0; i < int.Parse(numeroDeLinha); ++i)
                {
                    for (int j = 0; j < int.Parse(numeroDeColuna); ++j)
                    {
                        
                        decimal decOut_C;
                        decimal decOut_R;
                        string aux = gridMatriz_C.Rows[i].Cells[j].Value?.ToString().Trim();
                        if (string.IsNullOrEmpty(aux))
                        {
                            throw new Exception("A Linha da Matriz C não pode ser vazio");
                        }
                        else if (!decimal.TryParse(aux, out decOut_C))
                        {
                            throw new Exception("A Linha da Matriz C não pode conter letra");
                        }

                        aux = gridMatriz_R.Rows[i].Cells[j].Value?.ToString().Trim();
                        if (string.IsNullOrEmpty(aux))
                        {
                            throw new Exception("A Linha da Matriz R não pode ser vazio");
                        }
                        else if (!decimal.TryParse(aux, out decOut_R))
                        {
                            throw new Exception("A Linha da Matriz R não pode conter letra");
                        }

                        Parametros.Matriz_C[i, j] = decOut_C;
                        Parametros.Matriz_R[i, j] = decOut_R;
                    }

                }
                btnProximoPasso.Visible = true;
                btnIniciar.Visible = false;
                btnLimpar.Visible = false;
                btnGerarVetorDAutomaticamente.Visible = false;
                BloqueiGrids();
            }

            catch (Exception ex)
            {
                gerouErro = true;
                MessageBox.Show(ex.Message, Program.TitleProgram, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Limpa as Configurações
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            bool resposta = MessageBox.Show("Limpar Configuração ? ", Program.TitleProgram,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
            if (resposta)
            {
                BtnReiniciar_Click(null, null);
            }
        }
        /// <summary>
        /// Vai para o promixo passo se possivel
        /// </summary>        
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void BtnProximoPasso_Click(object sender, EventArgs e)
        {
            try
            {
                Parametros.QtdLinha = decimal.Parse(numeroDeLinha);
                Parametros.QtdColuna = decimal.Parse(numeroDeColuna);
                if (Parametros == null)
                {
                    throw new Exception("O estado não é seguro e os processos foram finalizados!");
                }

                var objDeadLock = new DeadLock(Parametros);
                Parametros = objDeadLock.Execute();

                if (Parametros == null)
                {
                    throw new Exception("Erro - DeadLock - A quantidade necessaria para a execução do processo é maior que a quantidade disponivel!");
                }

                MessageBox.Show(objDeadLock.DescricaoExecucao,
                                Program.TitleProgram, MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopuleGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
                                Program.TitleProgram, 
                                MessageBoxButtons.OK, 
                                ex.Message.Contains("DeadLock") 
                                    ?MessageBoxIcon .Error 
                                    :MessageBoxIcon.Warning);
                btnProximoPasso.Visible = false;
                btnIniciar.Visible = true;
                btnLimpar.Visible = true;
                btnGerarVetorDAutomaticamente.Visible = true;
                BloqueiGrids();
            }
        }

        /// <summary>
        /// Gera o vetor D Automaticamente
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event</param>
        private void BtnGerarVetorDAutomaticamente_Click(object sender, EventArgs e)
        {
            try
            {
                gerouErro = false;
                gridVetor_D.Rows.Clear();
                gridVetor_D.Rows.Add();
                int qtdLinha = int.Parse(numeroDeLinha);
                int qtdColuna = int.Parse(numeroDeColuna);

                for (int i = 0; i < qtdColuna; ++i)
                {
                    if (string.IsNullOrEmpty(gridVetor_E.Rows[0].Cells[i]?.Value?.ToString()))
                    {
                        throw new ArgumentNullException("Deve se preencher totalmente o Vetor E!");
                    }
                    int valor = int.Parse(gridVetor_E.Rows[0].Cells[i]?.Value.ToString());
                    valor -= SomeTodosDaColuna_C(i);

                    if(valor < 0)
                    {
                        throw new Exception("O Calculo do vetor de Recursos disponivel gerou um valor negativo, verifique!");
                    }

                    gridVetor_D.Rows[0].Cells[i].Value = valor;
                    gridVetor_D.Refresh();
                    if (checkBoxLentamente.Checked)
                    {
                        System.Threading.Thread.Sleep(500);
                    }

                }


            }
            catch (Exception ex)
            {
                gerouErro = true;
                MessageBox.Show(ex.Message, Program.TitleProgram, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Busca as informações do sobre o projeto senão existir então cria
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event</param>
        private void SobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caminho = Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\AppData";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            if(!File.Exists(caminho + @"/sobre.dbx"))
            {
                File.Create(caminho + @"/sobre.dbx").Close();

                StringBuilder sobre = new StringBuilder().AppendLine("Criado por:")
                .AppendLine("Murilo Barros Peixoto")
                .AppendLine("Lais")
                .AppendLine("Reverson")
                .AppendLine("Trabalho feito com intuito de tirar OITO na materia da professora");
                File.WriteAllBytes(caminho + @"/sobre.dbx",Encoding.UTF8.GetBytes(sobre.ToString()));
                MessageBox.Show(sobre.ToString(), Program.TitleProgram, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(File.ReadAllText(caminho + @"/sobre.dbx"), Program.TitleProgram, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        /// <summary>
        /// Busca e seta uma configuração 
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event</param>
        private void BuscarConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog()
                {
                    Filter = "type files|*.dbx",
                    Title = "Selecione o Arquivo"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string texto = File.ReadAllText(openFileDialog.FileName);
                    int i = 0;
                    int contC = -1;
                    int contR = -1;
                    foreach (var linha in texto.Split('\n'))
                    {
                        int j = 0;
                        foreach (var item in linha.Split(';'))
                        {
                            var valor = item;
                            valor = valor.Replace('\r', ' ').Trim();
                            switch (i)
                            {
                                case 0://Processos e Recursos
                                    switch (j)
                                    {
                                        case 0:
                                            numeroDeLinha = valor;
                                            break;
                                        case 1:
                                            numeroDeColuna = valor;
                                            pedirQtdProcessosRecursos = false;
                                            BtnReiniciar_Click(null, null);
                                            pedirQtdProcessosRecursos = true;
                                            break;
                                    }
                                    break;
                                case 1://Vetor E

                                    gridVetor_E.Rows[0].Cells[j].Value = valor;
                                    break;
                                default:
                                    if (contC < int.Parse(numeroDeLinha))//Matriz C
                                    {
                                        if (contC == -1)
                                        {
                                            contC = 0;
                                        }
                                        gridMatriz_C.Rows[contC].Cells[j].Value = valor;
                                    }
                                    else//Matriz R
                                    {
                                        if (contR == -1)
                                        {
                                            contR = 0;
                                        }
                                        gridMatriz_R.Rows[contR].Cells[j].Value = valor;
                                    }
                                    break;
                            }
                            ++j;
                        }
                        ++i;
                        if (contR != -1)
                        {
                            contR++;
                        }
                        if (contC != -1)
                        {
                            contC++;
                        }
                    }

                }
            }
            catch (Exception ex) 
            {
                string msg = "Não foi possivel abrir essa configuração, mensagem com o erro : ";
                MessageBox.Show($"{msg}{ ex.Message}", Program.TitleProgram, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLimpar_Click(null, null);

            }
            finally
            {
                btnProximoPasso.Visible = false;
            }
        }

        private void RelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    #endregion Eventos
}
