const express = require('express');
const app = express();

app.use(express.json());

app.post('/api/login', (req, res) => {
    const {email, password} = req.body;

    if (email !== "admin@gmail.com" || password !== "1234") {
        return res.json({status: 'error', msg: 'email or password is incorrect'})
    } 

    res.status(200)
       .json({
           status: "success",
           msg: 'login successfully'
        });  
})

app.post('/api/forget-password', (req, res) => {
    if(req.body.email !== "admin@gmail.com") return res.json({status: 'error', msg: 'this email is not exist !!!!'});

    res.status(200)
        .json({
            status: "success",
            msg: 'please check your email'
        });
})

app.listen(8000, () => console.log('server is running on port 8000...'))