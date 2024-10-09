using Atv_01;
using System.Security.Cryptography;

Livro l1 = new Livro("Diario de um banana", "Jeff Kinney", "Amulet Books", 2007);
Livro l2 = new Livro("Dom Casmurro", "Machado de Assis", "Carambaia", 1899);
Livro l3 = new Livro("50 Tons de Cinza", "E.L. James", "Intrínseca", 2011);


Console.WriteLine($"O primeiro livro é: {l1.Titulo} \n Do autor: {l1.Autor} \nLançado pela editora: {l1.Editora} \n No ano de: {l1.Ano} ");
Console.WriteLine($"O segundo livro é: {l2.Titulo} \n Do autor: {l2.Autor} \nLançado pela editora: {l2.Editora} \n No ano de: {l2.Ano} ");
Console.WriteLine($"O terceiro livro é: {l3.Titulo} \n Do autor: {l3.Autor} \nLançado pela editora: {l3.Editora} \n No ano de: {l3.Ano} ");


Console.ReadKey();