const util = require('util')
const path = require('path')
const fs = require('fs')

const data = require('./data')
const { errorJSON } = data

function formatJSON(json) {
  return util.format("%o", json)
}

exports.authParser = function(auth) {
  if(!auth) {
    let error = {
      err: formatJSON(errorJSON)
    }
    return error;
  }

  // credentials passed will be base_64 encoded
  let credentials = new Buffer(auth.split(" ").pop(), "base64")
  credentials = credentials.toString("ascii").split(":")
  let result = {
    auth: credentials

  }
  return result
}
