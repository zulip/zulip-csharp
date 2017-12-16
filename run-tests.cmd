@echo off

cd TestSever
node TestServer

@echo on
npm run lint
npm test-manager