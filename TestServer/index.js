const path = require('path')
const util = require('util')
const express = require('express')
const bodyParser = require('body-parser')
const { authParser } = require('./helpers')

const app = express()
app.use(bodyParser.urlencoded({ extended: false }))
app.use(bodyParser.json())

app.get('/', (request, response) => {
  // useful for testing.
  response
  .status(200)
  .sendFile(path.resolve('index.html'))
})

app.post('/test', (request, response) => {
  const { auth } = authParser(request.get("authorization"), response)
  response.send(`
  <pre><code>
  Request parsed successfully
  -----------------------------------
  Received data:
    ${util.format('%o', request.body)}

  </code></pre>
  `);
})

const port = +process.env.PORT || 9991
app.listen(port, () => {
  console.log(`Testing Server started at ${port}`)
});
