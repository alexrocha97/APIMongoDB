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
