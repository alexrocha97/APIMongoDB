// Tipos de dados 
// Strings => pode ser salva tanto com aspas duplas ou simples
db.pessoas.find({nome: "Alex"})
db.pessoas.find({nome: 'Alex'})
// Verificando os dados
const nomePessoa = db.pessoas.findOne({nome: "Alex"})
typeof nomePessoa.nome
// retorno: string
// Array => Você pode salvar varios itens em um campo, basta adicionar entre [] 
// separadados por virgulas
db.carro.insertOne({carros: ["BMW", "Ferrari", "Fusca"]})
// Datas
// As datas são salvas em formatos ISO
// Para gerar uma data você pode usar new Date()
// db.pessoas.insertOne({data: create_at: new Date()})

// Document
// Semelhante ao JavaScript, guardamos chave e valores.
db.pessoas.insertOne(
    {nome: "Alex", 
    desc: 
        {profissao: "Programador", 
        hobbies: 
            ["basquete", 
            "handebol"
            ]
        }
    }
)
// Boleans
// Só aceita true ou false
db.pessoas.insertOne({nome: "Alex", iswork: true})
db.pessoas.insertOne({nome: "Alex", iswork: false})
