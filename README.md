# MorseCourse

> A Windows Forms desktop application for learning, practicing, and testing Morse code knowledge. Built with .NET Framework 4.7.2 and C#.

MorseCourse provides a complete environment for working with Morse code: a two-way translator between text and Morse, audio playback via PC speaker beeps, a visual reference chart, randomized quizzes sourced from real English sentences, and a bug-reporting system integrated with Telegram.

---

## Features

### Text & Morse Translation

The core of the application is a bidirectional translation engine implemented as a static class (`Utils\Translate.cs`). It converts letters (a–z), digits (0–9), and spaces to their International Morse Code equivalents and back, using a character-by-character lookup via `switch` statements. Unknown characters produce an `"ERROR!"` string.

- **Text → Morse (Criptare):** Enter plain text — each character is translated and appended with a trailing space. Spaces in the input become `/`.
- **Morse → Text (Decriptare):** Enter Morse code (dots `.`, dashes `-`, and spaces separating letters). The output reassembles the original text.
- **Long output handling:** If the translated result exceeds 10 characters, a popup window (`TranslatedForm`) displays the full result alongside the main output box.

### Audio Playback

The translated Morse code can be played through the PC speaker using `Console.Beep()`:

| Morse Symbol | Sound         | Duration |
|-------------|---------------|----------|
| `.` (dot)   | 500 Hz beep   | 150 ms   |
| `-` (dash)  | 500 Hz beep   | 450 ms   |
| ` ` (space) | Silence       | 500 ms   |

Playback runs on a background task so the UI remains responsive. A **Stop** button sets a flag that interrupts the current playback loop.

### Morse Reference Chart

The **Info** tab displays the full Morse code alphabet and digit chart as embedded images. A warning label notes that special characters (accents, punctuation) are not supported.

### Test Mode (Quiz)

The **Tests** tab allows users to practice Morse translation with randomized exercises:

1. The user selects how many exercises to attempt (1–10, via a `NumericUpDown` control).
2. Clicking **Start** sends an HTTP GET request to `https://randomwordgenerator.com/json/sentences.json`.
3. The JSON response (`{ data: [{ sentence: "..." }] }`) is deserialized using **Newtonsoft.Json** into `DB_JSON_TESTS` / `Datum` objects.
4. For each exercise, an `ExerciseForm` modal dialog is shown containing:
   - A `RichTextBox` with the English sentence to translate.
   - A `TextBox` for the user's Morse answer.
   - **Answer** button — validates the answer against `Translate.translateToMorse()` (auto-appends a trailing space for format tolerance).
   - **Skip** button — moves to the next exercise.
5. After all exercises, a `DataGridView` row is appended showing:
   - Test ID (auto-incrementing)
   - Number of exercises
   - Correct, wrong, and skipped counts
   - Result percentage

### Bug Reporting

A **Report** button opens `ReportForm`, a simple dialog with a `RichTextBox` for describing an issue. On submission, the report text is sent to a Telegram bot via:

```
https://api.telegram.org/bot{token}/sendMessage?chat_id={id}&text={message}
```

> **Security note:** The bot token and chat ID are currently hardcoded in `Utils\ReportForm.cs:22`. These should be externalized or secured before deployment.

---

## Architecture

### Entry Point

`Program.cs` — Standard WinForms startup enabling visual styles and running `Form1`.

### Main Form (`Form1.cs`)

A `TabControl` with three tabs:

| Tab       | Designer Label | Content |
|-----------|---------------|---------|
| Translate | `tabPage1`    | Text/Morse translation UI, Play/Stop/Clear buttons, Report button |
| Info      | `tabPage2`    | Morse chart images, usage warning |
| Tests     | `tabPage3`    | Exercise count selector, Start button, results `DataGridView` |

### Translation Engine (`Utils\Translate.cs`)

- `translateToMorse(string letters)` — Lowercases input, iterates characters, calls `translateLetters()`.
- `translateToText(string morse)` — Splits on spaces, looks up each token via `translateMorse()`.
- Both public methods return `"ERROR!"` on unrecognized input.
- `translateLetters(char)` — Switch mapping `a → ".- "`, `b → "-... "`, ..., `0 → "----- "`, space ` → "/ "`.
- `translateMorse(string)` — Reverse switch mapping `".-" → "a"`, etc.

### Test Infrastructure (`Utils\Test.cs` + `Utils\ExerciseForm.cs`)

- `Test` is a simple class with static counters (`score`, `wrong`, `skiped`, `id`). Its constructor creates and shows an `ExerciseForm` modally.
- `ExerciseForm` is a `Form` that validates the user's answer, updates the static counters, and displays a `MessageBox` with "right" or "wrong".
- The main form resets counters before each test batch and populates the `DataGridView` after completion.

### Report Form (`Utils\ReportForm.cs`)

- Sends an HTTP GET to the Telegram Bot API using `WebClient.DownloadString()`.
- Token: `1800285503:AAEvxDNxiw1vD0a2GtJ_aN-gRgDjG2A9XoY`
- Chat ID: `1028090772`

### Data Models (`Utils\DB_JSON_TESTS.cs`)

```csharp
public class DB_JSON_TESTS {
    public Datum[] data { get; set; }
}
public class Datum {
    public string sentence { get; set; }
}
```

---

## Getting Started

### Prerequisites

- Windows 7+ (for `Console.Beep` support)
- [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) (or later) with the **.NET desktop development** workload
- NuGet package manager (included with Visual Studio)

### Build & Run

```powershell
# Restore NuGet packages
nuget restore MorseCourse.sln

# Build (Debug)
msbuild MorseCourse.csproj /p:Configuration=Debug

# Run
.\bin\Debug\MorseCourse.exe
```

Alternatively, open `MorseCourse.sln` in Visual Studio and press **F5**.

### Build Configurations

| Configuration | Command |
|--------------|---------|
| Debug        | `msbuild MorseCourse.csproj /p:Configuration=Debug` |
| Release      | `msbuild MorseCourse.csproj /p:Configuration=Release` |
| Clean        | `msbuild MorseCourse.csproj /t:Clean` |

---

## UI Labels (Romanian → English)

The application interface uses Romanian labels:

| Romanian         | English                |
|------------------|------------------------|
| Criptare         | Encrypt (Text → Morse) |
| Decriptare       | Decrypt (Morse → Text) |
| Aplicarea codului Morse | Applying Morse Code |
| Text             | Text (input/output)    |
| Morse            | Morse (input/output)   |
| Translate        | Translate button       |
| Clear            | Clear button           |
| Play             | Play Morse audio       |
| Report           | Submit bug report      |
| Info             | Reference chart tab    |
| Tests            | Quiz tab               |
| Start            | Start test             |
| number of exercises | Number of exercises |

---

## Project Structure

```
MorseCourse/
├── Form1.cs                    # Main form: translate, audio, test logic
├── Form1.Designer.cs           # Main form UI layout (WinForms designer)
├── Form1.resx                  # Embedded Morse chart images
├── MorseCourse.csproj          # MSBuild project file (v4.7.2)
├── MorseCourse.sln             # Visual Studio solution file
├── Program.cs                  # Application entry point
├── TranslatedForm.cs           # Popup dialog for long translations
├── TranslatedForm.Designer.cs  # Translated form UI layout
├── TranslatedForm.resx         # Translated form resources
├── App.config                  # .NET runtime config / binding redirects
├── packages.config             # NuGet package references
├── Properties/
│   ├── AssemblyInfo.cs         # Assembly metadata (v1.0.0.0)
│   ├── Resources.Designer.cs   # Auto-generated resource accessors
│   ├── Resources.resx          # Resources manifest
│   ├── Settings.Designer.cs    # Auto-generated settings accessors
│   └── Settings.settings       # Application settings
└── Utils/
    ├── Translate.cs            # Static translation engine (Morse ↔ Text)
    ├── Test.cs                 # Test runner (creates ExerciseForm instances)
    ├── ExerciseForm.cs         # Modal dialog for individual quiz questions
    ├── ExerciseForm.Designer.cs
    ├── ExerciseForm.resx
    ├── ReportForm.cs           # Bug report form (Telegram API integration)
    ├── ReportForm.Designer.cs
    ├── ReportForm.resx
    └── DB_JSON_TESTS.cs        # JSON deserialization models
```

---

## NuGet Dependencies

| Package                              | Version        | Used In                  |
|--------------------------------------|----------------|--------------------------|
| `Newtonsoft.Json`                    | 13.0.1         | `Form1.cs` — API response deserialization |
| `HtmlAgilityPack`                    | 1.11.33        | Referenced, not used     |
| `RestSharp`                          | 106.11.8-alpha | Referenced, not used     |
| `Telegram.Bot`                       | 16.0.0-alpha   | Referenced, not used     |
| `Intercom.Dotnet.Client`             | 2.1.1          | Referenced, not used     |
| `MorseCodeToAudio`                   | 1.0.1          | Referenced, not used     |

Several packages are listed in the project but unused — the application uses `System.Net.WebClient` for Telegram and `Console.Beep()` for audio instead.

---

## License

Copyright &copy; 2021. All rights reserved.
