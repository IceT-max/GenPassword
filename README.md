# GenPassword

Generatore di password casuali per Windows.

## Funzionalità

- Scelta degli ingredienti:
  - Maiuscole (A-Z)
  - Minuscole (a-z)
  - Numeri (0-9)
  - Simboli (`,` `.` `;` `:` `-` `+` `*` `?` `!` `$` `%` `&` `(` `)` `[` `]`)
- Lunghezza configurabile da 4 a 128 caratteri (default: 20)
- Generazione di 1-50 password in un colpo solo
- Copia negli appunti con un click
- Generazione crittograficamente sicura tramite `RandomNumberGenerator`

## Utilizzo

Avvia `GenPassword.exe`, scegli tra le varie opzioni, imposta lunghezza e quantità, premi **Genera Password**.

## Requisiti

Nessuno. L'eseguibile è self-contained e non richiede l'installazione di .NET.

## Build

```bash
# Debug
dotnet build

# Eseguibile definitivo (single file, self-contained)
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -o publish
```
