﻿using Console_App___Chicao;
using Console_App___Chicao.HERANCA;
using System.Net;

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

//Console.WriteLine(p1.getDescricao() +" " + p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1L");

//Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco endereco = new Endereco(
    "Rua Mario Miziara",
    91,
    "Sobral",
    "15806304",
    "Taquaritinga",
    "SP"
    );

Cliente c1 = new Cliente(1, "A", "991340448",endereco);
Cliente c2 = new Cliente(2, "B", "991340449", endereco);
Cliente c3 = new Cliente(3, "C", "991340450", endereco);
Cliente c4 = new Cliente(4, "D", "991340451", endereco);
Cliente c5 = new Cliente(5, "E", "991340452", endereco);


//Console.WriteLine(c2.GetEndereco().GetRua() + " "+ c2.GetEndereco().getN());
//Console.WriteLine(c2.GetEndereco().EnderecoCompleto());

Carro gol = new Carro();
gol.TemMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;
gol.cintoSeguranca = true;
gol.ArCondicionado = true;
gol.fabricante = "VM";

Bike caloi = new Bike();
caloi.TemMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;

Carro ecosport = new Carro();
Carro Santana = new Carro();

Santana.fabricante = "WM";
ecosport.fabricante = "FORD";

Bike speed = new Bike();
speed.TemMotor = false;
speed.numeroPortas = 0;
speed.numeroAssentos = 1;

//Console.WriteLine(speed.ExibirDados());
//Console.WriteLine(gol.ExibirDados());

List<Carro> listaCarros = new List<Carro>();    
listaCarros.Add(ecosport);
listaCarros.Add(Santana);
listaCarros.Add(gol);

//Console.WriteLine(listaCarros[0].fabricante);

foreach(var item in listaCarros)
{
    //Console.WriteLine(item.ExibirMarca());
}
int i;
List<Produto> listaProdutos = new List<Produto>();
for (i = 0; i < 560; i++)
{
    Produto p = new Produto(i, i*64M,"A:" + i);

    listaProdutos.Add(p);
}
foreach (var item in listaProdutos)
{
    Console.WriteLine(item.ExibirDados());
}
