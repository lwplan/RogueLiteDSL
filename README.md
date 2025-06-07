# RogueLiteDSL

This repository contains the RogueLite domain specific language and related tooling.

## Documentation

The API reference and language guide are generated using [DocFX](https://dotnet.github.io/docfx/).
Metadata is generated into a temporary `obj/api` folder and only the static site
output under `docs/_site` is kept.

You can view the latest generated documentation [here](https://lwplan.github.io/RogueLiteDSL/).

To regenerate the docs locally run `tools/update_docs.sh` and open `docs/_site/index.html`.
