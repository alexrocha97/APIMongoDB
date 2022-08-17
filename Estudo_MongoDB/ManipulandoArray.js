// Resgatar um dado que está em um document em um outro document
// Ex.: find({"chave1.chave2": "valor"})
db.pessoas.find({"caracteristicas.cor_dos_olhos": "pretos"}).pretty()
db.pessoas.insertMany([
    {
        nome: "Alex",
        caracteristicas: {
            peso: "80kg",
            altura: "1.80m",
            cor_dos_olhos: "verdes",
            idade: 25,
        }
    },
    {
        nome: "Maria",
        caracteristicas: {
            peso: "28kg",
            altura: "1.60m",
            cor_dos_olhos: "azuls",
            idade: 19,
        }
    },
    {
        nome: "Andre",
        caracteristicas: {
            peso: "40kg",
            altura: "1.50m",
            cor_dos_olhos: "pretos",
            idade: 30,
        }
    },
    {
        nome: "Julia",
        caracteristicas: {
            peso: "90kg",
            altura: "1.3m",
            cor_dos_olhos: "amarelos",
            idade: 40,
        }
    },

])
// Seleção em embedded com operador
// Ex.: find({"chave1.chave2": {$gt: 20}})
db.pessoas.find({"caracteristicas.idade": {$gt: 30}}).pretty()
db.pessoas.find({"caracteristicas.idade": {$gte: 30}}).pretty()
db.pessoas.find({"caracteristicas.idade": {$lt: 30}}).pretty()
db.pessoas.find({"caracteristicas.idade": {$lte: 30}}).pretty()

// Exercicio
db.pessoas.find(
    {"caracteristicas.cor_dos_olhos": 
        {$in: ["pretos", "azuls"]},
        "caracteristicas.idade": {$gt: 18}
    }).pretty()

// Busca item pelo array
// Ex.:
db.alunos.find({notas: 8})
// Para valores exatos, precisamos colocar o array inteiro
db.alunos.find({}).pretty()
db.alunos.insertMany([
    {
        nome: "Alex",
        matematica: [8,7,10,8]
    },
    {
        nome: "Pedro",
        matematica: [8,8,9,7]
    },
    {
        nome: "Maria",
        matematica: [6,4,10,9]
    },
])
db.alunos.find({matematica: [8,8,9,7]}).pretty()
// Operador $all
//Ex.:
db.alunos.find({matematica: {$all: [8,7]}})
// Consulta pelo tamanho do array
// Ex.:
db.alunos.find({matematica: {$size: 4}})
// Seleção de array de documentos
// Ex.:
db.produtos.insertMany([
    {
        nome: "Camisa",
        variacoes: [
            {
                cor: "Vermelha",
                tamanho: "P",
                qtd: 10
            },
            {
                cor: "Azul",
                tamanho: "M",
                qtd: 25
            },
            {
                cor: "Verde",
                tamanho: "G",
                qtd: 48
            },
        ]
    },
    {
        nome: "Calça",
        variacoes: [
            {
                cor: "Preta",
                tamanho: "P",
                qtd: 5
            },
            {
                cor: "Marron",
                tamanho: "M",
                qtd: 15
            },
            {
                cor: "Azul",
                tamanho: "G",
                qtd: 42
            },
        ]
    }
])
db.produtos.find({"variacoes": {cor: "verde", tamanho: "G"}}).pretty()
// Array de documentos e operadores 
// Ex.: 
db.produtos.find({"variacoes.qtd": {$gt: 30}})
db.produtos.find({"variacoes.qtd": {$lte: 5}})
// Utilizando o $elemMatch
db.produtos.find({"variacoes": {$elemMatch: {tamanho: {$gt: 40}, cor: "Azul"}}})
// Retornando campos específicos
db.pessoas.find({}, {nome: 1, idade: 1})
// Remover o id
db.pessoas.find({}, {_id:0,nome: 1, "caracteristicas.idade": 1})
