using System;
using System.Collections.Generic;

namespace LerningWithWarzone.source.person
{
    public class Person
    {
        public String name { get; }

        public  int idade { get; }

        public  List<String> principaisTrabalhos { get; }

        public Person(String name, int idade, List<String> principaisTrabalhos)
        {
            this.name = name;
            this.idade = idade;
            this.principaisTrabalhos = principaisTrabalhos;
        }
    }
}