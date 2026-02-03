# YTPGen Deluxe (Windows 8.1)

YTPGen Deluxe is a rebuilt, Windows 8.1-focused C# Windows Forms application inspired by the CTPoop revision 1.0 workflow. This repository provides a SharpDevelop-friendly project layout and a clear feature plan for a deluxe automatic YTP generator designed to accelerate Sony Vegas-based YTP workflows.

## Highlights

- **Enhanced processing** with clear visual presentation and accessible controls.
- **Easy project setup** with SharpDevelop-compatible solution and project files.
- **Media import support** for common video and image formats.
- **Flexible stream controls** for clip duration and count.
- **Audio and visual effect toggles** for creative variation.
- **Style presets** for classic, modern, and experimental YTP workflows.

## Media Support

### Video Sources
- MP4
- WMV
- AVI

### Image Sources
- PNG
- JPG
- WEBP

## Core Workflow Features

- Video preview within the app.
- Automatic stream duration (30 seconds to 25 minutes) with configurable min/max durations.
- Clip count control (1–70,000).
- Recall and post-render recall tooling.
- Create, export, and save outputs.

## Audio/Video Effects (Toggleable)

- Random sound, mute, speed up, slow down, reverse
- Chorus, vibrato, stutter, dance, squidward, sus, lagfun
- Low/high harmony, confusion, random chords, trailing reverses
- Low quality meme, audio crust, pitch-shifting loop, mashup mixing
- Framerate reduction, random cuts, speed loop boost, scrambling/random chopping

## Visual Effects

- Invert, rainbow, mirror, mirror symmetry
- Screen clip, overlay images and sources
- Spadinner, sentence mixing
- Shuffle/loop frames

## Resources

- Add intros and outros
- Overlay memes
- Spadinner/meme references
- Random images

## YTP Style Selection

- YTP 2007–2012 (classic)
- YTP 2013–2021 (modern)
- YTP Advance (experimental)

## Status

YTPGen Deluxe is still in development, but this repository ships a stable preview build layout and a Windows Forms entry point for rapid iteration in SharpDevelop.

## Build Notes (SharpDevelop)

1. Open `YTPGenDeluxe.sln` in SharpDevelop.
2. Build the solution targeting **.NET Framework 4.5** (Windows 8.1 compatible).
3. Run the `YTPGenDeluxe` project to launch the preview UI shell.

## Folder Structure

```
src/
  YTPGenDeluxe/
    MainForm.cs
    MainForm.Designer.cs
    Program.cs
    Properties/
      AssemblyInfo.cs
YTPGenDeluxe.sln
```
