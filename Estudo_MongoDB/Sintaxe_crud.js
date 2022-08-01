// Insert One
db.pessoas.insertOne(
    {nome: "Alex", idade: 25, 
    profissao: "Dev back-end .Net", 
    esta_trabalhando: true
})
// Insert Many
db.pessoas.insertMany([
    {nome: "Ventura", 
    idade: 19, 
    profissao: "Programador Java", 
    esta_trabalhando: true},
    {nome: "Araujo", 
    idade: 15, 
    profissao: "Programador Js", 
    esta_trabalhando: false},
    {nome: "Rocha", 
    idade: 12, 
    profissao: "Programador Front", 
    esta_trabalhando: true},
])
// ----------------------------------------------------------
// Update One
db.pessoa.updateOne(
    {_id: 20},
    { $set: { esta_trabalhando: false}
})
// Update Many
db.pessoa.updateMany(
    {}, 
    { $set: { idade: 18}
})
db.pessoa.updateMany(
    { $gt: { idade: 15}},
    { $set: { ModoTrabalho: "Presencial"}
})
// ----------------------------------------------------------
db.pessoas.deleteOne(
    {_id: 20}
)
// Deletar todos os registros
db.pessoas.deleteOne({})
// Select
db.pessos.find({}).pretty() // => Retorna todos
// Select + filtro(AND)
db.pessoas.find({nome: "Ventura"}).pretty()
// Select + filtro(OR)
db.pessoas.find(
    {
        $or: [
                {idade: { $gt: 10}},
                {esta_trabalhando : false}
        ]
    }
).pretty()
