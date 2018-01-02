# Zulip csharp test-server

The purpose of the test-server is to mimic zulip api server
and cover all the endpoints for testing by C# Unit Tests.

```bash
# to start the testing server
npm start

# to run test 
# note that this command will run C# server tests too.
npm test 

# linting
npm run lint
npm run lint-fix
```

All the responses recived for this TestServer is in JSON
and by POST method only, in exception of endpoint `/` and `/test`.
You will recive html which is our demo page to test out all the other,
endpoint `POST` request will no work here. `/test` endpoint is purley to
test out and what happend to the request you made and it will no send JSON
rather send details in text of what you did.

### Testing out endpoint without demo page using curl

```bash
# For Linux and MacOS
$ curl localhost:9991/test -u email:api_token -d "purpose=endpoint-testing&works=true" -X POST
  Request parsed successfully
  -----------------------------------
  Authorization: email,api_token
  Received data:
  { purpose: 'endpoint-testing', works: 'true' }
```
