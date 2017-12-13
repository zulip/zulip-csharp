const { spawnSync } = require('child_process')
const path = require('path')

// this would export app instance of
// already started server and
// manager that will be eventemitter
const manager = require('./index')

manager.on('server-started', (server) => {
  const test = spawnSync('npm', ['test'], {
    encoding: 'utf8',
    stdio: 'inherit',
    windowsHide: true
  })

  console.log(`[Test Manager] test exit code: ${test.status}`)

  server.close()
  process.exit(test.status)
})
