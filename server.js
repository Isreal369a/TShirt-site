// console.log('hello izzy');

var express = require('express'); // requre the express framework
var bodyParser = require('body-parser')//add this


var myWebApp = express();
myWebApp.use(bodyParser())

myWebApp.post('/izzy', function(req, res){  
        res.send('hello izzy'); 
})

myWebApp.post('/izzy1', function(req, res){  
    res.send('T shirt 1'); 
})

myWebApp.post('/izzy2', function(req, res){  
    res.send('T shirt 2'); 
})

myWebApp.post('/izzy3', function(req, res){ 
    console.log(req.body) 
    res.send('T shirt 3'); 
})




// Create a server to listen at port 8080
var server = myWebApp.listen(1234, function(){
    var host = server.address().address
    var port = server.address().port
    console.log("REST API demo app listening at http://%s:%s", host, port)
});
