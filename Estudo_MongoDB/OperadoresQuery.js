// Importar o banco
// mongoimport restaurant.json -d restaurantsData -c restaurants

// Operador de igualdade
// $eq
// Aqui estamos buscando um restaurante que tem a nota igual a 5
db.restaurants.findOne({rating: { $eq: 5 }})


// Operador maior ou maior igual a que
db.restaurants.findOne({rating: { $gte: 5}}) // Maior ou igual a que
db.restaurants.findOne({rating: { $gt: 5}}) // Maior que 
// Selecionar restaurante maior ou igual a 3
db.restaurants.find(
    {
        type_of_food: "Breakfast",
        rantig: { $gte: 3 }
}).pretty()

// Operador menor e menor ou igual
db.restaurants.find({rating: { $lt:  2}})
db.restaurants.find({rating: { $lte:  2}})

// Operador $in
// O operador $in verifica registros que se
// encaixam em aoenas um dos passados como lista na consulta
db.restaurants.find({type_of_food: { $in: ["Pizza","Chinese"]}}).pretty()

// Operador $ne
// Operador que traz o resultado que não é informado
db.restaurants.find({type_of_food: { $ne: "Chinese"}}).pretty()
 // Operador $exists
 // Vai retornar os dados que possuem determinado campo
db.restaurants.find({nigh_score: {$exists: true}}).pretty()
// Operador $text
// Vai fazer a busca sobre o texto do campo que foi informado no filtro
// Porém é preciso criar um índice em alguns campos
// Criando índex:
db.restaurants.createIndex({name: "text"})
// A busca -- Semelhante ao LIKE no banco relacional
db.restaurants.find({$text: {$search: "Pizza"}})
db.restaurants.find({$text: {$search: "Chinese"}})
