// CONEXÃO MONGODB
const mongoose = require('mongoose');
mongoose
    .connect(
        'mongodb://localhost:27017/test', 
        {useNewUrlParser: true, 
        useUnifiedTopology: true
    })

const db = mongoose.connection;
db.on('error', console.error.bind(console, 'connection error:'));
db.once('open', function()
{
    console.log("Estamos conectados ao MongoDB!");
});
// Criar Schema
const pessoaSchema = new mongoose.Schema(
    {
        nome: String,
        idade: Number,
        profissao: String
    }
);

// Criar Model
const Pessoa = mongoose.model("Pessoa", pessoaSchema);
// Criação de um dado
const alex = new Pessoa({
    nome: "Alex",
    idade: 25,
    profissao: "Programador"
})
const tailane = new Pessoa({
    nome: "Tailane",
    idade: 23,
    profissao: "Técnica em enfermagem"
})

// Listar todos os dados salvos
async function getPessoa()
{
    const pessoas = await Pessoa.find({}).exec()
    console.log(pessoas);
}

tailane.save()
// Inserir dados
alex.save(function(err) {
    if(err)
    {
        console.log(err)
    }
});

// Encontrando dados
Pessoa.findOne({nome: "Alex"}, function(err, pessoa)
{
    console.log(pessoa)
});

// Inserindo vários dados de uma vez só
Pessoa.insertMany([
    {
        nome: "Maria",
        idade: 19,
        profissao: "Professora"
    },
    {
        nome: "Pedro",
        idade: 40
    },
    {
        nome: "Maria",
        profissao: "Advogada"
    }
]);

// Deletar dados
async function getPessoa(nome)
{
    const pessoa = await Pessoa.find({nome : nome}).exec();
    if(pessoa.length === 0)
    {
        console.log("Esta pessoa não existe!")
    }
    else
    {
        console.log(pessoa);
    }
}
getPessoa("Maria");

Pessoa.deleteOne({nome: "Maria"}).exec();

// Atualizar dados
Pessoa.updateOne({nome: "Pedro"},{profissao: "Garimpeiro"}).exec();


// Utilizando o where(Operador especial)
async function getPessoaNomeIdade(nome, idade)
{
    const pessoa = await Pessoa
        .where('idade').gte(idade)
        .where('nome', nome).exec()
    if(pessoa.length === 0)
    {
        console.log("Esta pessoa não existe!");
    }
    else
    {
        console.log(pessoa);
    }
}

getPessoaNomeIdade("Tailane", 25);
