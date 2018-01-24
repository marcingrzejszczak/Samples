#!/bin/bash

set -e

pushd Docker
docker-compose build
docker-compose up -d
popd
