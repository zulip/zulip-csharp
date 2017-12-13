#!/bin/bash

set -e
set -x

cd ../UnitTests
dotnet xunit
