// modules
const express = require('express');
const mongoose = require('mongoose');
const bodyparser = require('body-parser');
const cors = require('cors');

// Routes
const authRouter = require("./routes/authRoutes")
const userRoutes = require("./routes/userRoutes")

// Middlewares

// Config
const dbName = "partytimeb";
const port = 3000;
const portMongo = 27017;
const app = express();


app.use(cors());
app.use(express.json());
app.use(express.static("public"));
// Atrelar as rotas no express
app.use("/api/auth", authRouter)
app.use("/api/user", userRoutes)

// Conexão com o mongodb
mongoose
    .connect(
        `mongodb://localhost:${portMongo}/${dbName}`, 
        {
            useNewUrlParser: true, 
            useUnifiedTopology: true
    })

const db = mongoose.connection;
db.on('error', console.error.bind(console, 'connection error:'));
db.once('open', function()
{
    console.log("Estamos conectados ao MongoDB!");
});

app.get('/', (req, res) =>
{
    res.json({ message: "Rota Teste"})
});

app.listen(port, () =>
{
    console.log(`O backend está rodando na porta ${port}`);
})

