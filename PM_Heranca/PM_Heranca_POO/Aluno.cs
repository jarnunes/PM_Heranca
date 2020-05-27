using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Heranca_POO
{
    class Aluno : Pessoa
    {
        private int _idCurso;
        public int Curso
        {
            get { return this._idCurso; }
            set { this._idCurso = value; }
        }
        private int _cargaHoraria;
        public int CargaHorariaMatriculada
        {
            get { return this._cargaHoraria; }
            set
            { this._cargaHoraria = value; }
        }
        public Aluno(string nome, long mat, DateTime data_nas, int id, int cargaHora) : base(nome, mat, data_nas)
        {
            this._idCurso = id;
            this._cargaHoraria = cargaHora;
        }

        public double CalcularMensalidade(double vlHoraAula)
        {
            double valTotal = this._cargaHoraria * vlHoraAula;
            double mensalidade = valTotal / 6;
            return mensalidade;
        }
        public override string imprimir()
        {
            StringBuilder aux = new StringBuilder(base.imprimir());
            aux.AppendLine($"Carga Horária: {this._cargaHoraria.ToString("000")}");
            return aux.ToString();
        }
    }
}
