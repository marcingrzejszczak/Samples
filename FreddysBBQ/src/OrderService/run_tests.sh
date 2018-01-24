#!/bin/bash

set -e

# Start docker infra
./stop_infra.sh
./setup_infra.sh

# Kill & Run app
pkill -9 -f "dotnet exec" || echo "Nothing running"
pkill -9 -f "dotnet run" || echo "Nothing running"
export ASPNETCORE_ENVIRONMENT=ContractTests
nohup dotnet run --framework netcoreapp2.0 --server.urls http://*:5000 &

# Execute contract tests
./run_contract_tests.sh

# Kill app
pkill -9 -f "dotnet exec"
pkill -9 -f "dotnet run"
