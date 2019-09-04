using System;
using System.Collections.Generic;

namespace TrabalhoDeSO_1.Core
{
    public class DeadLock
    {
        #region Propiedades

        private decimal[] Vetor_E { get; set; }
        private decimal[] Vetor_D { get; set; }
        private decimal[,] Matriz_C { get; set; }
        private decimal[,] Matriz_R { get; set; }
        private decimal QtdLinha { get; set; }
        private decimal QtdColuna { get; set; }

        public string DescricaoExecucao { get; private set; } = string.Empty;

        #endregion Propiedades
        #region Construtor

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="parametros">Objeto de parametros para as Propiedades da classe</param>
        public DeadLock(DeadLockParams parametros)
        {
            Vetor_E = parametros.Vetor_E;
            Vetor_D = parametros.Vetor_D;
            Matriz_C = parametros.Matriz_C;
            Matriz_R = parametros.Matriz_R;
            QtdLinha = parametros.QtdLinha;
            QtdColuna = parametros.QtdColuna;
        }



        #endregion Construtor
        #region Metodos
        /// <summary>
        /// Verifica se uma estrutura de dados homogenia esta zerada(MATRIZ OU VETOR)
        /// </summary>
        /// <typeparam name="T">Tipo da estrutura</typeparam>
        /// <param name="ed">Estrutura</param>
        /// <returns>Se esta zerada</returns>
        private bool EdZerada<T>(T ed)
        {
            foreach (var item in (dynamic)ed)
                if (item != 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Verifica de uma linha da matriz esta zerada
        /// </summary>
        /// <param name="matriz">Matriz</param>
        /// <param name="linha">Linha</param>
        /// <returns>Se esta zerada</returns>
        private bool LinhaEstaZerada(decimal[,] matriz,int linha)
        {
            for(int j = 0; j < QtdColuna; ++j)
            {
                if(matriz[linha,j] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Seta um valor em um vetor boleano
        /// </summary>
        /// <param name="vet">vetor</param>
        /// <param name="tam">Tamanho do vetor</param>
        /// <param name="value">True OU False</param>
        private void SetValorVetorBoleano(bool[]vet,int tam,bool value)
        {
            for (int i = 0; i < tam; ++i)
            {
                vet[i] = value;
            }
        }

        /// <summary>
        /// Verifica de um  vetor booleano possui apenas valores true
        /// </summary>
        /// <param name="vet"></param>
        /// <param name="tam"></param>
        /// <returns></returns>
        private bool VetorEhTrue(bool[] vet,int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                if (!vet[i])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Valida se as EDS estão zeradas
        /// </summary>
        public void ValideDados()
        {
         
            if (EdZerada(Vetor_E))
            {
                throw new Exception("O Vetor de Recursos existentes esta zerado!");
            }

            if (EdZerada(Matriz_C) && EdZerada(Matriz_R))
            {
                throw new Exception("Todos os Processos Foram executados!");
            }
        }

        /// <summary>
        /// Executa os processos
        /// </summary>
        /// <returns>null se nenhum processo for executado, um objeto DeadLockParams se foi executado</returns>
        public DeadLockParams Execute()
        {
            string descProcessosQueNaoExecutaram = string.Empty;
            bool[] vetorIndicacaoRodouProcesso = new bool[(int)QtdColuna];
            decimal qtdProcesso = QtdColuna;
            ValideDados();
            int i = default(int);
            for (i = 0; i < QtdLinha; ++i)
            {
                if(!LinhaEstaZerada(Matriz_C,i) || !LinhaEstaZerada(Matriz_R, i))
                {
                    SetValorVetorBoleano(vetorIndicacaoRodouProcesso, (int)QtdColuna,false);
                    DescricaoExecucao = $"Processo de numero {i} em verificação";
                    for (int j = 0; j < QtdColuna; ++j)
                    {
                        DescricaoExecucao += $"\nRecurso {j}";

                        decimal quantidadeQuePrecisa = Matriz_R[i, j];
                        decimal quantidadeDisponivel = Vetor_D[j];
                        decimal quantidadeQueOhProcessoPrecissa = quantidadeQuePrecisa + Matriz_C[i,j];



                        DescricaoExecucao += $"\nQuantidade necessária de recurso {j} : {quantidadeQuePrecisa}";
                        DescricaoExecucao += $"\nQuantidade disponivel de recurso {j} : {quantidadeDisponivel}";

                        bool condicao = 
                              quantidadeQuePrecisa > quantidadeDisponivel 
                            || quantidadeQueOhProcessoPrecissa > Vetor_E[j];

                        //A Quantidade disponivel não é o bastante para o processo executar
                        if (condicao)
                        {
                            j = (int)QtdColuna + 2;
                            DescricaoExecucao = string.Empty;
                            descProcessosQueNaoExecutaram += $"Processo de numero {i} não executado\n\n";
                        }
                        else
                        {
                            vetorIndicacaoRodouProcesso[j] = true;
                        }
                        
                    }

                    //Se todos os dados do vetor for verdadeiro então é possivel rodar o processo[i]
                    if(VetorEhTrue(vetorIndicacaoRodouProcesso,(int)QtdColuna))
                    {
                        for (int k = 0; k < QtdColuna; ++k)
                        {
                            Matriz_C[i, k] = Matriz_C[i, k] + Matriz_R[i, k];
                            Vetor_D[k] = Vetor_D[k] - Matriz_R[i, k];
                            Matriz_R[i, k] = 0;
                            Vetor_D[k] = Vetor_D[k] + Matriz_C[i, k];
                            Matriz_C[i, k] = 0;

                        }
                        
                        DescricaoExecucao += $"\n\n\nO Processo {i} pode ser executado!";
                        DescricaoExecucao = descProcessosQueNaoExecutaram + "\n\n" + DescricaoExecucao;
                        return new DeadLockParams()
                        {
                            Matriz_C = Matriz_C,
                            Matriz_R = Matriz_R,
                            QtdColuna = QtdColuna,
                            QtdLinha = QtdLinha,
                            Vetor_D = Vetor_D,
                            Vetor_E = Vetor_E
                        };
                    }

                }
            }
            return null;
        }

        #endregion Metodos

    }

    public class DeadLockParams
    {
        public decimal[] Vetor_E { get; set; }
        public decimal[] Vetor_D { get; set; }
        public decimal[,] Matriz_C { get; set; }
        public decimal[,] Matriz_R { get; set; }
        public decimal QtdLinha { get; set; }
        public decimal QtdColuna { get; set; }
    }
}
