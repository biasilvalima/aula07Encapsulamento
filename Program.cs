using System;

namespace aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartão card = new Cartão();

            Mastercard master = new Mastercard();
            master.titular = "Beatriz";
            master.parcelas = 5;
            master.ComprarComDescontoMastercard(150f);

            //desconto aplicado na compra

        }
    }
}
