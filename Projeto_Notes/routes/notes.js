const Router = require('express').Router;
const db = require('../db/connection');
const { ObjectId } = require('mongodb');
const router = Router();

// Form criação de rota
router.get('/', function(req, res){
    res.render('notes/create');
})

// Envio da nnota para inserção no banco
router.post('/', function(req, res){
    const data = req.body;
    const title = data.title;
    const description = data.description;

    db.getDb()
        .db()
        .collection('notes')
})

module.exports = router;
