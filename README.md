# Magic Staircase

The Game cardgame implementation 

https://boardgamegeek.com/boardgame/173090/game


[![Continuous integration](https://github.com/Middlederg/MagicStaircase/actions/workflows/ci.yml/badge.svg)](https://github.com/Middlederg/MagicStaircase/actions/workflows/ci.yml)


[![Netlify Status](https://api.netlify.com/api/v1/badges/b3568a69-649a-40f8-b859-aa9c149eef2b/deploy-status)](https://app.netlify.com/sites/competent-saha-cde062/deploys)


- In Blazor webassembly 

[Demo deployed to netlify](https://competent-saha-cde062.netlify.app/)

![winforms](Resources/netlify.jpg)


- In windows forms

![winforms](Resources/winforms-main.JPG)

---

# How to release new versions in blazor wasm

- Pushes to master are automatically deployed to a netlify site in https://competent-saha-cde062.netlify.app/


# How to release new versions in winforms

1. Change version in MagicStaircase.Core.csproj file
2. Change version in installation project
3. Upload to github the generated file (MagisStaircase.msi) y and tag it with "v" and version number

