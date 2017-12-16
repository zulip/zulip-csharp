const util = require('util');

const data = require('./data');
const { errorJSON } = data;

function formatJSON(json) {
  return util.format('%O', json);
}

exports.authParser = function(auth) {
  if (!auth) {
    let error = {
      err: formatJSON(errorJSON)
    };
    return error;
  }

  // credentials passed will be base_64 encoded
  // eslint-disable-next-line
  let credentials = new Buffer.from(auth.split(' ').pop(), 'base64');
  credentials = credentials.toString('ascii').split(':');
  const result = {
    auth: credentials
  };
  return result;
};
