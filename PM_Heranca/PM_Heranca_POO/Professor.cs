using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Heranca_POO
{
    class Professor : Pessoa
    {
        private double salario;
        public double Salario
        {
            get { return salario; }
            set { this.salario = value; }
        }
        private int _cargaHoraria;
        public int CargaHoraria
        {
            get { return _cargaHoraria; }
            set { this._cargaHoraria = value; }
        }
        public void calcSalario(double valHoraAula)
        {
            double sal_base = valHoraAula * this._cargaHoraria;
            double extraClasse = sal_base * 0.2;

            this.salario = sal_base + extraClasse * 4.5;
        }

        private DateTime dataAdmss;
        public DateTime DataAdmissao
        {
            get { return dataAdmss; }
            private set { }
        }

        public Professor(string nome, long mat, DateTime data_nas, int carHoraria, DateTime dataAdmissao, double horaAula) : base(nome, mat, data_nas)
        {
            this._cargaHoraria = carHoraria;
            this.dataAdmss = dataAdmissao;
            calcSalario(horaAula);
        }
    }
}
