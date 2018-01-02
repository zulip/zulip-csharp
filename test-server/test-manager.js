const { spawnSync } = require('child_process');

// this would export app instance of
// already started server and
// manager that will be eventemitter
const manager = require('./index');

manager.on('server-started', (server) => {
  const test = spawnSync('npm', ['test'], {
    encoding: 'utf8',
    stdio: 'inherit',
    windowsHide: true
  });

  server.close();
  process.exit(test.status);
});
