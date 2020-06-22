namespace AULA22STATIC
{
public static class Conversor
    {
        
        private static float CotacaoDolar = 5.24f;
        private static float CotacaoEuro = 5.90f;


        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float DolarParaReais(float valorUS){
            return CotacaoDolar * valorUS;
        }

        public static float EuroParaReais(float valorUK){
            return CotacaoEuro * valorUK;
        }

        

        public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }
    }
}