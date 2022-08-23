const router = require("express").Router();
const bcrypt = require("bcrypt");
const jwt = require("jsonwebtoken");

// Model
const User = require("../models/user");

// Register
router.post("/register", async (req, res) => 
{
    const name = req.body.name;
    const email = req.body.email;
    const password = req.body.password;
    const confirmpassword = req.body.confirmpassword;

    // Check for required fields
    if(name == null || email == null || confirmpassword == null)
    {
        return res.status(400).json({error: "Por favor, preencha todos os campos!"})
    }

    // Check if passwords match
    if(password != confirmpassword)
    {
        return res.status(400).json({error: "A senha não estão iguais..."})
    }

    // Check id user exists
    const emailExists = await User.findOne({email: email});
    if(emailExists)
    {
        return res
        .status(400)
        .json(
            {error: "Email informado já existe na base de dados"
        })
    }

    // Create password
    const salt = await bcrypt.genSalt(12);
    const passwordHash = await bcrypt.hash(password, salt);
    
    const user = new User({name: name,email: email,password: passwordHash});

    try
    {
        const newUser = await user.save();
        // create token
        const token = jwt.sign(
            // payload
            {
                name: newUser.name,
                id: newUser._id
            },
            "nossosecret"
        );
        // return token
        res.json(
            { 
                error: null,
                msg: "Você realizou o cadastro com sucesso!", 
                token: token, 
                userId: newUser._id
            });
    } catch(error){
        res
        .status(400)
        .json(
            { error }
        );
    }
    
});

// Login
router.post("/login", async (req, res) =>
{
    const email = req.body.email;
    const password = req.body.password;

    // Check if user exists
    const user = await User.findOne({ email: email});
    if(!user)
    {
        return res
        .status(400)
        .json(
            {error: "Não há usuário cadastrado com esse email.."
        })
    }

    // Check if password macth
    const checkPassword = await bcrypt.compare(password, user.password);
    if(!checkPassword)
    {
        return res
        .status(400)
        .json(
            {error: "Senha inválida!"
        })
    }

    const token = jwt.sign(
        // payload
        {
            name: user.name,
            id: user._id
        },
        "nossosecret"
    );
    // return token
    res.json(
        { 
            error: null,
            msg: "Você está autenticado!", 
            token: token, 
            userId: user._id
        });

});

module.exports = router;
