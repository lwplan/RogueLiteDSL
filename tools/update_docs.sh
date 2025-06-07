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

# Ensure the global tool path is on PATH
export PATH="$PATH:$HOME/.dotnet/tools"

# Generate Markdown API docs directly into docs/api
docfx metadata docfx.json \
  --output docs/api \
  --outputFormat Markdown

# Move generated files up one level if they were placed under obj/api
if [ -d docs/api/obj/api ]; then
  mv docs/api/obj/api/* docs/api/
  rm -rf docs/api/obj
fi

echo "Markdown API documentation generated in docs/api"
