using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_de_interface_03
{
    public class Cat
    {
        private string _nome;
        private string _dono;
        
        public string Nome 
        { 
            get 
            {
                return _nome;
            }
            set 
            {
                if (value == "gato")
                {
                    Console.WriteLine("Dê um nome para o gato...");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public string Dono 
        { 
            get 
            {
                return _dono;
            } 
            set 
            {
                _dono = value.ToUpper();
            } 
        }
        public Cat(string nome, string dono)
        {
            Nome = nome;
            Dono = dono;
        }
    }
}