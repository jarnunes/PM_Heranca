using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Heranca_POO
{
    class Pessoa

    {
        protected string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        protected int matricula
        {
            get { return matricula; }
            set { matricula = value; }

        }
        protected DateTime data_nasc
        {
            get { return data_nasc; }
            set
            {
                data_nasc = value;
            }
        }
        public Pessoa(string nome, int mat, DateTime data_nas)
        {
            this.nome = nome;
            this.matricula = mat;
            this.data_nasc = data_nas;
        }
        public int idade()
        {
            TimeSpan diferenca = DateTime.Now.Subtract(this.data_nasc);
            return int.Parse(diferenca.TotalDays.ToString());
        }
    }
}
