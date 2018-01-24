#!/bin/bash

set -e

pushd Docker
docker-compose kill
popd
