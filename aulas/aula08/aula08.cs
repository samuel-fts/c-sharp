using System;

namespace Principal{

    class Aula08{
        public string saldo(){
            string saldo = "1920,00";
            return saldo;
        }



        public void processarOption(string option){
            if(option.Length != 1){
                Console.WriteLine("digite somente um numero!");
                receberOption();
            }else if(option == "1" || option == "2" || option == "3"){
                if(option == "1"){
                    Console.WriteLine("Consultando saldo");
                    Console.WriteLine(saldo());
                    Interface();

                }else if(option == "2"){
                    Console.WriteLine("Direcionando para sacar");
                    Interface();
                }else if(option == "3"){
                    Console.WriteLine("Direcionando deposito");
                    Interface();
                }else{
                    Console.WriteLine("algum erro inesperado aconteceu \nDigite novamente!");
                    Interface();
                }
            }else{
                Console.WriteLine("Digite um valor valido!");
                receberOption();
            }
        }
        public void receberOption(){
            string option = Console.ReadLine();
            processarOption(option);
        } 
        public void Interface(){
            Console.WriteLine("Ola! como posso ajudar?");
            Console.WriteLine("Digite [1] para poder consultar seu saldo \nDigite [2] para sacar seu dinheiro \nDigite [3] para depositar uma quantia"); 
            receberOption();
        } 
        static void Main(){
            
            Aula08 op = new Aula08();
            op.Interface();
        }  

        
    }
}
