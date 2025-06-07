#!/usr/bin/env bash
set -euo pipefail

if ! command -v docfx >/dev/null 2>&1; then
  if ! command -v dotnet >/dev/null 2>&1; then
    echo "dotnet SDK is required but not installed." >&2
    exit 1
  fi
  echo "DocFX not found. Installing locally..."
  dotnet tool update -g docfx
fi

docfx docfx.json

echo "Documentation generated in docs/_site"
