using Mocker;
using Test;

var generator = new Generator();

var pessoa = generator.Generate<PessoaModel>();
Console.WriteLine(pessoa);