#!/bin/bash

set -e
set -x

cd ../Tests
dotnet xunit
