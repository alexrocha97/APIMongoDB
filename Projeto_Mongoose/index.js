// CONEXÃO MONGODB
const mongoose = require('mongoose');
mongoose
    .connect(
        'mongo://localhost/test', 
        {useNewUrlParser: true, 
        useUnifiedTopology: true
    })

const db = mongoose.connection;
db.on('error', console.error.bind(console, 'connection error:'));

db.once('open', function()
{
    console.log("Estamos conectados ao MongoDB!");
});
