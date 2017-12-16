const path = require('path');
const fs = require('fs');

function readJSON(filePath) {
  filePath = path.join(__dirname, filePath);
  const file = fs.readFileSync(filePath, 'utf8');
  return JSON.parse(file);
}

exports.errorJSON = readJSON('error.json');
