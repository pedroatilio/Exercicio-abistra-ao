using Atv___03;

Produto produto1 = new Produto(10, "Mouse gpro", 645.99, 60);
Produto produto2 = new Produto(20, "Gabinete Redragon", 455.99, 80);
Produto produto3 = new Produto(30, "Teclado switch red", 987.99, 90);


Console.WriteLine($"O codigo do produto 1 é: {produto1.Codigo}, O nome é: {produto1.Nome}, o preco é: {produto1.Preco} e a quantidade em estoque é: {produto1.Estoque}");
Console.WriteLine($"O codigo do produto 2 é: {produto2.Codigo}, O nome é: {produto2.Nome}, o preco é: {produto2.Preco} e a quantidade em estoque é: {produto2.Estoque}");
Console.WriteLine($"O codigo do produto 3 é: {produto3.Codigo}, O nome é: {produto3.Nome}, o preco é: {produto3.Preco} e a quantidade em estoque é: {produto3.Estoque}");
produto1.ValorEstoque();
produto2.ValorEstoque();
produto3.ValorEstoque();




