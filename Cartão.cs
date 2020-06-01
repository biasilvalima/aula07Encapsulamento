namespace aula07Encapsulamento
{
    public class Cartão
    {
        // o get e set serve pra voce conseguir manipular as informaçoes em outros momentos
        public string numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        protected int cvc { get; set; }
        private int MyProperty { get; set; }

        public string AprovarCompra(){
            return "compra aprovada";
        }
        // o bool é sim ou nao sempre (true or false)
        public bool ValidarToken(string tokenValidacao){
            if(tokenValidacao != null && tokenValidacao != ""){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
     }
}