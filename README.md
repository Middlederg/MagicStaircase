# Magic Staircase

The Game cardgame implementation 

- In Blazor webassembly 

- In windows forms

https://boardgamegeek.com/boardgame/173090/game

---

# How to release new versions in blazor wasm

- Pushes to master are automatically deployed (see .github/workflows/cd.yaml)

# How to release new versions in winforms

1. Change version in MagicStaircase.Core.csproj file
2. Change version in installation project
3. Upload to github the generated file (MagisStaircase.msi) y and tag it with "v" and version number

