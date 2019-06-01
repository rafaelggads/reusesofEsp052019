using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Assinatura
    {
        private IPreco _preco;
        private IContentTransformer _qualidade;
        private IPreparadorNumeroTransmissoes _numeroLimite;

        public Assinatura(IPreco preco, IContentTransformer qualidade, IPreparadorNumeroTransmissoes numeroLimite)
        {
            this._preco = preco;
            this._qualidade = qualidade;
            this._numeroLimite = numeroLimite;
        }

        public double getPreco()
        {
            return _preco.getCalculaPreco();
        }

        public string disponibilizarConteudo()
        {
            return _qualidade.converterQaulidade();
        }

        public void permitirNumeroTransmissoesSimultaneas()
        {
            int numero = _numeroLimite.prepararAmbienteParaTransmissoesSimultanes();
            Console.Write(numero);
        }


    }
}
