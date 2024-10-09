using Atv_01;
using System.Security.Cryptography;

Aluno l1 = new Aluno(2500, "Pedro", (new DateTime(2008,05,14)), "pedro.@gmail.com");
Aluno l2 = new Aluno(1994, "Malu", (new DateTime(2008, 07, 30)), "Malu@gmail.com" );
Aluno l3 = new Aluno(2782, "Bia", (new DateTime(2008, 09, 17)), "Bia.com@gmail.com");


Console.WriteLine($"O RM do primeiro aluno é: {l1.RM} \n O nome dele é: {l1.Nome} \nO ano de nascimento do aluno é: {l1.Nascimento} \n O email de contato é: {l1.Email} ");
Console.WriteLine($"O RM do segundo aluno é: {l2.RM} \n O nome dele é: {l2.Nome} \nO ano de nascimento do aluno é: {l2.Nascimento} \n O email de contato é: {l2.Email} ");
Console.WriteLine($"O RM do terceiro aluno é: {l3.RM} \n Onome dele é: {l3.Nome} \nO ano de nascimento do aluno é: {l3.Nascimento} \n O email de contato é: {l3.Email} ");


Console.ReadKey();
