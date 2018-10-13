
namespace ExemploVetor
{
    class AlugarQuarto
    {
        public string nome { get; private set; }
        public string email { get; private set; }

        //contrutor
        public AlugarQuarto(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        /*  //sobrecarga
          public AlugarQuarto()
          {
              this.nome = " ";
              this.email = " ";
          }*/

        //para imprimir

        public override string ToString()
        {
            return nome + ", " + email;
        }
    }
}
