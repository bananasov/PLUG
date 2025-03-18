# P.L.U.G.
Add certain "Quality of Life" features to R.E.P.O.!

## Mod Usage

### Requirements
- [Intiface Central](https://github.com/intiface/intiface-central/releases) or [Intiface Engine](https://github.com/intiface/intiface-engine/releases) (former preferred)
- A buttplug or a device that can vibrate and has [buttplug.io](https://buttplug.io) support (See [here](https://iostindex.com/?filter0Availability=Available%2CDIY&filter1ButtplugSupport=4&filter2Features=OutputsVibrators) for a list of supported devices)

### Installation

#### Automatic

- For a quick installation and organiser, [r2modman](https://github.com/ebkr/r2modmanPlus) or [Gale](https://github.com/Kesomannen/gale) can be used

#### Manual
- Install BepInEx (see [BepInEx Installation Guide](https://docs.bepinex.dev/articles/user_guide/installation/index.html))
- Launch Lethal Company once with BepInEx installed to ensure that its working and needed folders are present
- Navigate to your Lethal Company install directory and go to `./BepInEx/plugins`
- Download the mod and unzip it in the installation directory

### Usage
- Open Intiface Central (or Engine if you know how to use that)
- Start it via the big play button
- Launch Lethal Company with the mod installed
    - If it doesn't work, go to Intiface settings and enable `Listen on all network interfaces` in the server settings

## For developers
Copy the `Config.Build.user.props.template` file to `Config.Build.user.props`
and edit the `GameDir` and `HookgenDir` properties in the second `PropertyGroup`

Set `GameDir` to the path where R.E.P.O. is installed and set `HookgenDir` to
the path where the auto-generated MMHOOK files are located (e.g. `BepInEx/plugins/MMHOOK/Managed`)

To build the plugin run `dotnet build -p:BuildStaging=true` in your terminal
(make sure that you are in the correct directory).

### Preparing a Thunderstore publish
TODO, WRITE THIS
