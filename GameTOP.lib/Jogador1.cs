using GameTop.Interface;

namespace GameTOP.lib
{
     public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        

        /*CTOR CONTRUTOR*/
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        /*METODOS*/
        //Chuta
        public string Chuta()
        {
            return $"{_Nome} está Chutando. \n";
        }
        //Corre
        public string Corre()
        {
            return $"{_Nome} está Correndo. \n";
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} está Passando. \n";
        }
    }

}