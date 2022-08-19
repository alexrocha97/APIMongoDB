const Router = require('express').Router;
const db = require('../db/connection');
const { ObjectId } = require('mongodb');
const router = Router();

// View de detalhe da nota
router.get('/:id', async function(req, res)
{
    const id = new ObjectId(req.params.id);
    const  note = await db.getDb().db().collection('notes').findOne({_id: id});
    res.render('notes/detail', {note});
})

// Form criação de rota
router.get('/', function(req, res){
    res.render('notes/create');
})

// Envio da nnota para inserção no banco // CREATE
router.post('/', function(req, res){
    const data = req.body;
    const title = data.title;
    const description = data.description;

    db.getDb()
        .db()
        .collection('notes')
        .insertOne({title: title, description: description});

    res.redirect(301, '/');
})

// View Edit
router.get('/edit/:id', async function(req, res)
{
    const id = new ObjectId(req.params.id);
    const note = await db.getDb().db().collection('notes').findOne({_id: id});
    
    res.render('notes/edit', {note})
})

// DELETE
router.post('/delete', function(req, res)
{
    const data = req.body;
    const id = new ObjectId(data.id);

    db.getDb()
        .db()
        .collection('notes')
        .deleteOne({_id: id});

    res.redirect(301, '/');
});

module.exports = router;
