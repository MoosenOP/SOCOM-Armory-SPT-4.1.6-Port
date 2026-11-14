# SOCOM Armory — Unofficial SPT 4.1.6 Port

This repository is for the **SPT 4.1.6 compatibility port** of [SOCOM Armory](https://sp-mod.com/mod/1835/socom-armory-new-quests-story-line), originally created by **MT_Militia**.

All original creative credit belongs to MT_Militia. The original author explicitly granted permission for this unofficial port to be published on the Forge. This is not an official update by the original author.

## Scope of changes

- Updated compatibility with SPT 4.1.6 server APIs.
- Changed `"unlockedByDefault": false` to `true` to avoid potential starting quest lockouts with different profiles.

No other gameplay changes are intended.

## Installation

Download the **player release archive** from the Forge, not this source repository. Extract into the directory containing `SPT_Runtime`, resulting in `SPT_Runtime/user/mods/SOCOM/`. Install the dependencies listed on the Forge page.

## Source and building

The source project targets SPT 4.1.6 and requires the matching SPT development assemblies and WTT CommonLib references. See `SOCOM.csproj` and the source archive's build guidance for project-specific details. Third-party reference DLLs are intentionally not distributed here.

**Note:** The correspondence between the published source and the tested compiled DLL has not yet been independently verified by a reproducible build.

## License and attribution

The original mod's applicable license and third-party asset permissions should be reviewed against the [original project](https://sp-mod.com/mod/1835/socom-armory-new-quests-story-line). No separate license is asserted for the original creator's work here. The unrelated SPT server project license is not included as a SOCOM license.
