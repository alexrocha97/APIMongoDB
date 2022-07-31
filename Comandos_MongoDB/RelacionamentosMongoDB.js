// Relacionamentos
// Registros que possuem ligações entre si
// Tipos: one to one, one to many, e many to many


// Embedded document ==> é uma forma simples 
// de fazer relacionamento entre documents
// Funciona bem para One to One e One to Many

// One to One
db.embedded.insertOne({
    nome: "Maria",
    idade: 25,
    endereco: {
        rua: "Rua Dr. Cassio Scaff",
        numero: "200",
        complemento: "Descenco a viela 30, casa 134A"
    }
})
// One to Many
db.embedded.insertOne({
    nome: "João",
    idade: 19,
    enderecos:
    {
        casa: {
            rua: "Maria Joaquina",
            numero: "31",
            complemento: "Descenco a viela vinte, casa 144A"
        },
        trabalho:{
            rua: "Rua Maria Alexandrina",
            numero: "134",
            complemento: "Rua da escola Massaranduba"
        }
    }
})

// One to One => Registro possui 
// uma ligação única com outro, e o inverso também é verdadeiro
db.pessoas.insertOne(
    {
        nome: "João",
        idade: 19,
        profissao: "Professor"
    }
)

db.enderecos.insertOne({
    rua: "Rua Maria Alexandrina",
    numero: "134",
    complemento: "Rua da escola Massaranduba",
    pessoa_id: user._id
})

//db.enderecos.find().pretty()
//{
//         "_id" : ObjectId("62e7084cb83284efc841c61f"),
//         "rua" : "Rua Maria Alexandrina",
//         "numero" : "134",
//         "complemento" : "Rua da escola Massaranduba",
//         "pessoa_id" : ObjectId("62e70728b83284efc841c61e")
//}
//const pessoaJoao = db.pessoas.findOne()
//db.enderecos.find({pessoa_id: pessoaJoao._id}).pretty()
//{
//         "_id" : ObjectId("62e7084cb83284efc841c61f"),
//         "rua" : "Rua Maria Alexandrina",
//         "numero" : "134",
//         "complemento" : "Rua da escola Massaranduba",
//         "pessoa_id" : ObjectId("62e70728b83284efc841c61e")
//}

// One to Many
// Relação One to Many é quando um 
// registro pode possuir mais vínculos com uma outra collection
db.pessoas.insertOne(
    {
        nome: "Gustavo",
        idade: 34,
        profissao: "Gerente"
    }
)
// Cadastrar compras
db.compras.insertMany([
    {produtos: ["Livro", "Celular"], pessoa_id: gustId},
    {produtos: ["Mouse", "Teclado"], pessoa_id: gustId},
    {produtos: ["Mesa", "Cadeira Gamer"], pessoa_id: joaoId},
    {produtos: ["Cabo HDMI", "Monitor"], pessoa_id: joaoId},
])
// const joao02 = db.pessoas.findOne({nome: "João"})
// db.compras.find({pessoa_id: joaoId}).pretty()           
// {                                                         
//         "_id" : ObjectId("62e70d80b83284efc841c623"),     
//         "produtos" : [                                    
//                 "Mesa",                                   
//                 "Cadeira Gamer"                           
//         ],                                                
//         "pessoa_id" : ObjectId("62e70728b83284efc841c61e")
// }                                                         
// {                                                         
//         "_id" : ObjectId("62e70d80b83284efc841c624"),     
//         "produtos" : [                                    
//                 "Cabo HDMI",                              
//                 "Monitor"                                 
//         ],                                                
//         "pessoa_id" : ObjectId("62e70728b83284efc841c61e")
// }   

// db.compras.find({pessoa_id: gustId}).pretty()           
// {                                                         
//         "_id" : ObjectId("62e70d80b83284efc841c621"),     
//         "produtos" : [                                    
//                 "Livro",                                  
//                 "Celular"                                 
//         ],                                                
//         "pessoa_id" : ObjectId("62e70b39b83284efc841c620")
// }                                                         
// {                                                         
//         "_id" : ObjectId("62e70d80b83284efc841c622"),     
//         "produtos" : [                                    
//                 "Mouse",                                  
//                 "Teclado"                                 
//         ],                                                
//         "pessoa_id" : ObjectId("62e70b39b83284efc841c620")
// }                                                         

// Many to Many
// Acontece quando os registros 
// das duas collections possuem mais de uma relação entre si
// Normalmente se cria uma estrutura intermediária
db.pessoas.insertOne({
    nome: "Pedro",
    idade: 44,
    profissao: "Motorista"
})

db.cursos.insertMany([
    {nome: "PHP avançado"},
    {nome: "JavaScript básico"},
    {nome: "Banco de dados NoSQL"}
])
// Collection intermediária
db.curso_pessoa.insertMany([
    {curso_id: phpId, pessoa_id: pedro01._id},
    {curso_id: js._id, pessoa_id: pedro01._id},
    {curso_id: phpId, pessoa_id: gustavoPessoa._id},
])

// db.curso_pessoa.find().pretty()
// {
//         "_id" : ObjectId("62e713aab83284efc841c629"),
//         "curso_id" : ObjectId("62e7118cb83284efc841c626"),
//         "pessoa_id" : ObjectId("62e7118bb83284efc841c625")
// }
// {
//         "_id" : ObjectId("62e713aab83284efc841c62a"),
//         "curso_id" : ObjectId("62e7118cb83284efc841c627"),
//         "pessoa_id" : ObjectId("62e7118bb83284efc841c625")
// }
// {
//         "_id" : ObjectId("62e713aab83284efc841c62b"),
//         "curso_id" : ObjectId("62e7118cb83284efc841c626"),
//         "pessoa_id" : ObjectId("62e70b39b83284efc841c620")
// }

// # Todos os alunos que cursam JS
const idsAlunos02 = [];
db.curso_pessoa.find({curso_id: js._id}).forEach(function(aluno)
{
    idsAlunos02.push(aluno.pessoa_id);
});

// Operador $in
db.pessoas.find({_id: { $in: idsAlunos }})
// Inclusão de um aluno cursando um curso
db.curso_pessoa.insertOne({curso_id: js._id, pessoa_id: gustavoPessoa._id})
