const mongoose = require('mongoose');

const UserSchema = new mongoose.Schema({
    name: {
        type: String
    },
    email: 
    {
        type: String,
        require: true
    },
    password: 
    {
        type: String,
        required: true
    }
})

const User = mongoose.model('User', UserSchema);

module.exports = User;
