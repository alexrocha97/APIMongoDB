// $in
// Sintaxe:
db.books.find(
    {categories: 
        { $in: ["Java", "Internet"]}
    })
// filtro que vai retornar o que contiverem na lista de valores
// Semelhante ao operador "Ou"

// Condição mais especifica
// Sintaxe:
db.books.find(
    {pageCount: 592, 
    _id: 63}).pretty()
// Condição que vai filtrar e buscar um document que tenha 592 paginas E o id 63
// Esta sintaxe é semelhante ao AND do SQL

// $gt
// Sintaxe:
db.books.find(
    {pageCount: { $gt: 450 }}
).pretty()
// Operador maior que
// Como o nome dele diz ele retornará quantidade de pagina maior que 450


// $lt
// Sintaxe:
db.books.find(
    {pageCount: 
        { $lt: 120 }
    }).pretty()
// Operador menor que



// $or
// Sintaxe:
db.books.find({ 
    $or: [
        {pageCount: 
            {$gt: 500},  
        _id: 
            { $lt: 5}
        }
    ]
}).pretty()
// A diferença do operador or para o in é que o in eu só posso usar no mesmo campo
// no caso do or eu posso usar para campos diferente.


// Mesclando consulta com operador AND e Or
db.books.find({
    status: "PUBLISH", 
    $or: [
            {pageCount: 500}, 
            {authors: "Robi Sen"}
    ]
}
).pretty()
// Contar o números de resultado
// sintaxe:
db.books.find({pageCount: 600}).count()


// Update One 
db.books.updateOnde({_id: 314}, { $set: {pageCount: 1000}})
// Exemplo de um atualização e sua sintaxe
// O operador $set é onde fica os valores que serão atualizados

// Update Many
db.books.updateMany(
    {categories: "JAVA"}, 
    { $set: {status: "UNPUBLISHED"}
})
// Update Many com adição de uma chave e um valor
db.books.updateMany(
    {authors: "Vikram Goyal"},
    { $set: {download: 1000}
})
// Fazendo um update em arquivos com filtro
db.books.updateMany(
    {pageCount: { $gt: 500}}
    ,{ $set: {bestseller: true}
})
// ReplaceOne
// essa sintaxe vai substituir os arquivos salvo nesse id e colocar o novo document
db.books.replaceOne(
    {_id: 120},
    {foi: "Subistiuido"}
);
// Adicionando um item em um array
// Nessa sintaxe passamos o id do documento, depois abrimos outro documento
// usamos o operador $push e colocamos a chave do array e o valor que queremos
// adicionar
db.books.updateOne(
    {_id: 201},
    { $push: {categories: "PHP"}
})
// Para atualizar todos os registros do banco
db.books.updateMany(
    {},
    { $set: {atualizando: true}
})
// Nesse caso eu estou adicionando em todos document uma chave e valor nova


// DELETE
// Sintaxe
db.books.deleteOne({_id: 20});
// Deletar varios documentos
db.books.deleteMany({categories: "Java"})
// Remover todos registro de uma collection
db.books.deleteMany({})
