// Script para inserir mais de um registro no MongoDb
db.provas.insertMany(
    [
        {nome: "Alex", notas: [5,7,1.5,10]}, 
        {nome: "Regina"}, 
        {nome: "Marcos", notas: [5,3,5.5,7]}
    ])
db.mercado.insertMany([
    {nome: "Arroz branco", preco: 9.99, disponibilidade: true},
    {nome: "Feijão preto", preco: 17.95, disponibilidade: true},
    {nome: "Ovo - 6/12", preco: 4.00, disponibilidade: true}
])
    
// Script para listar de forma organizada todos document da collection provas 
db.provas.find().pretty()
// Retorno:
// {
//     "_id" : ObjectId("62dae455c9c1a808106a5f73"),
//     "nome" : "Alex",
//     "notas" : [
//             5,
//             7,
//             1.5,
//             10
//     ]
// }
// { "_id" : ObjectId("62dae455c9c1a808106a5f74"), "nome" : "Regina" }
// {
//     "_id" : ObjectId("62dae455c9c1a808106a5f75"),
//     "nome" : "Marcos",
//     "notas" : [
//             5,
//             3,
//             5.5,
//             7
//     ]
// }


db.carros.insertMany([
    {_id: "01", nome: "Carro01", marca: "BMW", anoFabricacao: 2020, kilometragem: 0}
    ,{_id: "02", nome: "Carro02", marca: "HONDA", anoFabricacao: 2021, kilometragem: 100}
    ,{_id: "03", nome: "Carro03", marca: "FERRARI", anoFabricacao: 2022, kilometragem: 20}
    ,{_id: "04", nome: "Carro04", marca: "ALEXMOTORS", anoFabricacao: 2023, kilometragem: 15}
])
