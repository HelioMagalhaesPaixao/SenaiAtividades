namespace Atividade1
[
    class Pessoa_juridica: Clientes 
    {
        public string cnpj {get;set;};
        public string ie {get;set;};

        public overrride void Pagar_Imposto(float v)
        {
        this.valor = v;
        this.valor_imposto = this.valor * 20/100;
        this.total = this.valor + this.valor_imposto;
        }
    }
]