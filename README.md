# RC-Ranya — offline PowerPoint remote for the classroom (Wi-Fi + Bluetooth)

[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.24195032.svg)](https://doi.org/10.5281/zenodo.24195032)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

An Android phone becomes a **touchpad + remote** for **real PowerPoint on Windows**.
PowerPoint itself plays the show, so every **animation, transition, trigger, morph and video
works exactly as on the laptop**. No internet, no uploading.

```
 Android phone (RC-Ranya.apk)  ──  Wi-Fi (primary)  or  Bluetooth (backup)  ──►  RC-Ranya.exe  ──►  PowerPoint
```

Developed at the University of Raparin, Ranya, Kurdistan Region of Iraq, for classrooms where
internet access is limited or unreliable. The interface is in English, with Kurdish (Sorani,
right-to-left) available as an option.

## Download
Get the latest files from **[Releases](../../releases)**:

| File | Where |
|---|---|
| `RC-Ranya.apk` | Android 8+ phone ("install unknown apps" once) |
| `RC-Ranya.exe` | Windows 10/11 with PowerPoint — **portable**: one file, no install, no .NET. Its settings live in a `RC-Ranya-data` folder next to it, so it runs from a USB stick too. |
| `RC-Ranya-Setup.exe` | Optional normal installer with Start-menu and desktop shortcuts. |

## Main features
- **PC dashboard** — Wi-Fi / Bluetooth / PowerPoint status, big PIN, hotspot with QR, present & send files with drag-and-drop, activity log, English / کوردی, dark and light. Uses the Edge engine built into Windows; a classic window is kept as a fallback.
- **🔈 Sound only on PC** (Mouse mode): the PC becomes the phone's Bluetooth speaker, so the phone's own speaker is silent. The phone must be paired with the PC in Bluetooth settings (Windows 10 2004 or newer).
- **Quiz** with a question editor and ⚡ Quick question (a few words next to each letter).

## Connecting — Wi-Fi first, Bluetooth as backup
**Wi-Fi is the default** (Settings → Connection → *Automatic*): it's several times faster
(instant slide pictures, smooth laser/spotlight/pen) and reaches across a classroom.
Bluetooth needs no network and takes over automatically if Wi-Fi drops; when Wi-Fi comes back
RC-Ranya switches back without a gap.

**Wi-Fi, any of these (no internet needed):**
1. **Laptop hotspot** — in RC-Ranya.exe press **Turn hotspot on** (or tick *Turn the hotspot on when
   RC-Ranya opens*). Scan the QR code with the phone camera to join it.
   *Windows only allows this when the laptop has some network to share; if it says "not available", use option 2.*
2. **Phone hotspot** — turn on the phone's hotspot and connect the laptop to it. Always works offline.
3. **Same Wi-Fi/router** — works unless the network isolates devices (some campus Wi-Fi does).

Then on the phone: **Connect** → pick the PC marked 📶 → type the **4-digit PIN** shown in RC-Ranya.exe (once).
The PC never accepts incoming connections (it connects out to the phone after the PIN check),
so **Windows Firewall never asks anything**.

**Bluetooth:** pair the phone with the PC once in Windows Settings → Bluetooth, then pick the PC marked 💻.
If both are available, RC-Ranya learns they're the same PC and uses Wi-Fi.

## In class
| Phone | On the projector |
|---|---|
| **NEXT / ◀**, volume keys | PowerPoint's own next/previous animation or slide. ◀ on a slide whose animations start automatically goes back correctly (fully-built previous slide, like ← on the laptop). |
| 🖱 Mouse | Laptop-style touchpad |
| 🔴 Laser | Size 8–48, 6 colours, ✍️ caption that follows the dot |
| 🔦 Spotlight | Size 60–400 and 8 styles: Classic, Theater, Minimal, Glass, Stage, Neon, Celebrate (confetti on/off), Colorful (cycling or fixed colour) |
| 🔍 Zoom | − / + (0.25 steps, 1–4×), Reset, drag to pan, pinch with two fingers in any pointer tool. Live — videos/animations keep playing while zoomed. |
| ✏️ Pen / 🖍 Highlight / 🧽 Eraser | Real PowerPoint ink |
| 🔢 Number | Tap to drop 1, 2, 3… in cycling colours (size 16–64); tap a number to remove it. Placed just above your finger with a live preview. |
| 📍 Text | Pin / Plain / Box styles, size, font colour, background (or none). Tap a label to edit/delete. Kurdish shows right-to-left. |
| 🗑 Clear | Clears ink, numbers and text on this slide |
| ⏱ Timer | Countdown **or stopwatch**; tick *Show on the projector* for a corner timer with big 59 / 3 / 2 / 1 / ⏰ flashes |
| ⬛ ⬜ ☰ 📝 | Black/white screen, jump to slide, speaker notes |

Numbers and text are saved per presentation (in `RC-Ranya-data`), so they're still there next lesson.

## 🎓 Class tools
| Phone | On the projector |
|---|---|
| 📷 **Camera** (Mouse mode) | Document camera: the real camera picture, live and full-screen (turned the right way up automatically). Pinch = zoom, tap = focus, ⚡ light, ⏸ freeze (volume keys freeze too), 🔄 rotate. Laser / pen / zoom work on top. |
| 🧑‍🏫 **Whiteboard** (Mouse mode) | Blank board (white, grid, black, green). Write with pen / highlighter / numbers / text; NEXT = next page (➕ new page at the end). 💾 Save → every page as a picture in `Desktop\RC-Ranya\Whiteboard …`. Pages are kept for next lesson. |
| 📑 **PDF / Word** (Mouse mode) | Pick a file on the phone — it opens full-screen on the PC and NEXT / ◀ turn pages like slides (with previews on the phone). Word files are converted with the Word installed on the PC; PowerPoint files open in PowerPoint and start. On the PC: **📑 Present a file…** in RC-Ranya.exe does the same. |
| 🗳️ **Quiz** | Kahoot-style: students scan the QR, **type their name** and answer questions with **written choices**. Faster correct answers score more, and 🏆 **Scores** shows the leaderboard on the projector. Results show counts **and percentages**. Quizzes with several questions are **saved on the phone** and can be edited or deleted. ⚡ Quick question (A/B/C…) is one tap away. The laptop hotspot allows up to 8 phones; for bigger classes use the classroom Wi-Fi. |
| 🎲 **Picker** | Random student picker with class lists (or type `1-30` for numbers), as big names **or a spinning wheel 🎡**. Optional "no repeats until everyone had a turn". |
| 🔎 **Lens** (tool) | A round live magnifier that follows your finger: size, 1.5×–4×, softer brightness and an optional dim around it. |

## Troubleshooting
- **No 📶 PC in the list** → phone and PC must be on the same hotspot/network, RC-Ranya.exe open.
- **Wi-Fi keeps asking for the PIN** → check the PIN in RC-Ranya.exe; some networks block device-to-device traffic, use a hotspot.
- **Bluetooth: "Could not connect"** → paired? RC-Ranya.exe open? Toggle Bluetooth on both.
- **Nothing happens in PowerPoint** → don't run RC-Ranya.exe "as administrator".

## Building from source
Every push to `main` runs **GitHub Actions**, which builds the APK and the EXE and publishes them as a Release.
The Android signing key is kept in the repository's GitHub Secrets (`ANDROID_KEYSTORE_B64`, `ANDROID_KEYSTORE_PASSWORD`), never in the code.

## Layout
```
android/   Kotlin app, no libraries   – MainActivity, TouchpadView, Link (both transports), WifiSide
windows/   .NET 8 WinForms tray app   – BtServer, WifiLink, Hotspot, PowerPointController (COM), Overlay (spotlight/zoom/…)
mac/       experimental macOS version – not part of the tested release
```
Protocol: one JSON object per line. Bluetooth UUID `7a1c2e90-5b3d-4f6a-9c1e-2d4b8f0a6e31`; Wi-Fi beacons UDP 47801, phone listens TCP 47802.

## How to cite
If you use RC-Ranya in teaching or research, please cite it:

> Mohammed, N. R. (2026). *RC-Ranya: An offline smartphone-based PowerPoint remote and classroom toolkit* (Version 1.0.4) [Computer software]. Zenodo. https://doi.org/10.5281/zenodo.24195032

## License
Released under the [MIT License](LICENSE). © 2026 Nawzad Rasul Mohammed, University of Raparin.
