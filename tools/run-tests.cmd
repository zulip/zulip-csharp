@echo off

cd ..\test-server

@echo on
npm run lint
node test-manager
