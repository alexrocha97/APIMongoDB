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
