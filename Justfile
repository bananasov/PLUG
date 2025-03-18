set shell := ["sh", "-c"]
set windows-shell := ["pwsh.exe", "-c"]

version := `git cliff --context | jq -r .[0].version`

# Build the project
build:
    dotnet build -p:BuildStaging=true

# Package the project for Thunderstore
package: (build)
    tcli build --config-path .\Thunderstore\thunderstore.toml --package-version {{version}}
