using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtividadeTres.RegrasDeNegocio
{
    class Candidato
    {
        private string nomeCandidato;
        private int numeroCandidato;
        private int quantDeVotos;

        public Candidato(string nomeCandidato, int numeroCandidato)
        {
            this.nomeCandidato = nomeCandidato;

            this.numeroCandidato = numeroCandidato;
        }

        public void SetNomeCandidato(string nomeCandidato)
        {
            this.nomeCandidato = nomeCandidato;
        }
        public string GetNomeCandidato()
        {
            return nomeCandidato;
        }

        public void SetNumeroCandidato(int numeroCandidato)
        {
            this.numeroCandidato = numeroCandidato;
        }
        public int GetNumero()
        {
            return numeroCandidato;
        }
       
        public void Votacao()
        {
            quantDeVotos++;
        }
      
        public void SetQuantDeVotos(int quantDeVotos)
        {
            this.quantDeVotos = quantDeVotos;
        }
        public int GetQuantDeVotos()
        {
            return quantDeVotos;
        }
    }
}
