# zulip-csharp [![Build Status](https://travis-ci.com/zulip/zulip-csharp.svg?branch=master)](https://travis-ci.com/github/zulip/zulip-csharp)
ZulipCSharp is a library to connect to a Zulip server via API based on .NET Core

## Devlopment
Fork the repo, clone it and
then follow instructions per platform

Join us at [zulip chat ZulipAPI.NET stream](https://chat.zulip.org/#narrow/stream/ZulipAPI.2ENET)

### Windows and MacOS
If you haven't already downloaded these:

* [Visual Studio IDE](https://www.visualstudio.com/vs/)
* [node.js](https://nodejs.org/en/download/).

```
# download dependencies for local server
cd test-server
npm i
```

### Linux
Since Visual Studio IDE is not available for Linux we need
to get `dotnet core`. Node for test server.

 - To get dotnet follow instructions here https://www.microsoft.com/net/download/linux, download the SDK
 - To get node follow instructions here https://nodejs.org/en/download/


```
# build the project
# will output some error ignore it
./build-project

# to run tests
./run-tests
```


### Pull Request
commit messages should be formatted like below (present tense)
```
unit tests: add tests for file
(part of project): (summary of changes made)
```

Test the code. We use xUnit for testing.
Our test need a local server so install
dependencies in `test-server`


```bash
# start the server
# and then run tests using Visual Studio IDE
npm start
```

or to run test on command prompt / terminal

```
# on root directory
.\run-tests.cmd # for windows
./run-tests # for MacOS and linux
```

linting
```
npm run lint
# if you have common error use
npm run lint-fix
```
