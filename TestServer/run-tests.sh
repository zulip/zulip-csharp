#!/bin/bash

set -e
set -x

cd ../ZulipCSharp-xUnitTests
dotnet xunit
