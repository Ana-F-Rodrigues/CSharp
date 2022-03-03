using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjetos
{
    public interface IPessoa
    {
        string CorDosOlhos { get; set; }
        decimal Altura { get; set; }

        decimal Peso { get; set; }

        void Andar();
        void Correr();
    }

    public class Ana : IPessoa
    {
        private string corOlhos;
        public string CorDosOlhos { get => corOlhos; set => corOlhos = value; }
        public decimal Altura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Peso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Andar()
        {
            throw new NotImplementedException();
        }

        public void Correr()
        {
            throw new NotImplementedException();
        }
    }

    public class Generoso : IPessoa
    {
        public string CorDosOlhos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Altura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Peso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Andar()
        {
            throw new NotImplementedException();
        }

        public void Correr()
        {
            throw new NotImplementedException();
        }
    }
}
