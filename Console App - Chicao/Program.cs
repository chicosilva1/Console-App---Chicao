using Console_App___Chicao;

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao() +" " + p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1L");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

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


Console.WriteLine(c2.GetEndereco().GetRua() + " "+ c2.GetEndereco().getN());