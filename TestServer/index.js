const path = require('path');
const util = require('util');
const express = require('express');
const EventEmitter = require('events');
const bodyParser = require('body-parser');
const { authParser } = require('./helpers');

const app = express();
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.get('/', (request, response) => {
  // useful for testing.
  response
    .status(200)
    .sendFile(path.resolve('demo/index.html'));
});

app.get('/main.css', (request, response) => {
  // useful for testing.
  response
    .status(200)
    .sendFile(path.resolve('demo/main.css'));
});

app.get('/demo.js', (request, response) => {
  // useful for testing.
  response
    .status(200)
    .sendFile(path.resolve('demo/demo.js'));
});

app.post('/test', (request, response) => {
  const { err, auth } = authParser(request.get('authorization'));
  response.send(err || `
  Request parsed successfully
  -----------------------------------
  Authorization: ${auth}
  Received data:
  ${util.format('%o', request.body)}
  `);
});

class Manager extends EventEmitter {}
const manager = new Manager();

const port = +process.env.PORT || 9991;
var server = app.listen(port, () => {
  console.log(`Testing Server started at ${port}`);
  startTests();
});

function startTests() {
  manager.emit('server-started', server);
}

module.exports = manager;
