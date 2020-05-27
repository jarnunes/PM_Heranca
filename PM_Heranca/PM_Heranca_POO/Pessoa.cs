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
        protected long _matricula;
        public long matricula
        {
            get { return _matricula; }
            set { _matricula = value; }

        }
        protected DateTime _dataNasc;
        public  DateTime data_nasc
        {
            get { return _dataNasc; }
            set
            {
                _dataNasc = value;
            }
        }
        public Pessoa(string nome, long mat, DateTime data_nas)
        {
            this.nome = nome;
            if (mat >= 100000 && mat < 1000000)
                matricula = mat;
            else
                matricula = 0;
            this.data_nasc = data_nas;
        }
        public int  idade()
        {
            int diferenca = DateTime.Now.Year - (this.data_nasc.Year);
            return diferenca;
        } 
    }
}
