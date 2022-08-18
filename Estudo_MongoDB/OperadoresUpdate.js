// Operador $inc
// Pode acrescentar ou diminuir uma quantidade especifica a um valor
db.blog.updateOne({author: "Alex Ventura"}, { $inc: {postCount: 2}})
db.blog.updateOne({author: "Alex Ventura"}, { $inc: {postCount:-2}})
db.blog.insertMany([
    {
        author: "Alex",
        postCount: 10,
        likesReceived: 150,
        categories: ["PHP", "JavaScript", "MongoDB"],
        active: true,
        maxPosts: 100
    },
    {
        author: "Maria",
        postCount: 8,
        likesReceived: 12,
        categories: ["Linux", "C#", "C"],
        active: false,
        maxPosts: 100
    },
    {
        author: "Jhon",
        postCount: 219,
        likesReceived: 12890,
        categories: ["Java", "DevOps", "Docker"],
        active: true,
        maxPosts: 100
    },
])
// Operador $min
// Atualizar um valor, caso o especificado do operador seja menor que o do registro
db.blog.updateOne(
    {author: "Maicon Santos"},
    {
        $min: {postCount: 25, 
            likesReceived: 0}
    })
// Operador $max
// Faz o inverso de $min, ou seja, atualiza o valor se ele for maior que o do campo

