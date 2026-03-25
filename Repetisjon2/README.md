# Repetisjon2 – Prosjektbeskrivelse

Et konsolprosjekt for .NET 10 (C# 14) som demonstrerer sentrale objektorienterte designmønstre:
**grensesnitt (interface)**, **abstrakt klasse**, og **Factory Method**.

---

## Prosjektstruktur

```
Repetisjon2/
├── Program.cs
├── Melding.cs
├── IMeldingSender.cs
├── AbstraktMeldingSender.cs
├── BrevMeldingSender.cs
├── SmsMeldingSender.cs
└── MeldingSenderFabrikk.cs
```

---

## Klassediagram

```
         ┌─────────────────────┐
         │   «interface»       │
         │   IMeldingSender    │
         │─────────────────────│
         │ + SendMelding(m)    │
         └──────────┬──────────┘
                    │ implementerer
         ┌──────────┴──────────┐
         │                     │
┌────────┴────────┐   ┌────────┴────────┐
│ BrevMeldingSender│   │ SmsMeldingSender │
│─────────────────│   │─────────────────│
│ +SendMelding(m) │   │ +SendMelding(m) │
└────────┬────────┘   └────────┬────────┘
         │                     │
         └──────────┬──────────┘
                    │ arver fra
         ┌──────────┴──────────┐
         │  AbstraktMelding-   │
         │      Sender         │
         │─────────────────────│
         │ #SkrivUtMelding(m)  │
         └─────────────────────┘

         ┌─────────────────────┐
         │  MeldingSender-     │        ┌───────────────┐
         │     Fabrikk         │───────>│ IMeldingSender│
         │─────────────────────│        └───────────────┘
         │ +LagMeldingSender() │
         └─────────────────────┘

         ┌─────────────────────┐
         │      Melding        │
         │─────────────────────│
         │ + Avsender: string  │
         │ + Mottaker: string  │
         │ + Innhold:  string  │
         └─────────────────────┘
```

---

## Klasser og filer

### `Melding` — dataobjekt
Representerer en melding som skal sendes. Inneholder tre egenskaper:

| Egenskap   | Type     | Beskrivelse              |
|------------|----------|--------------------------|
| `Avsender` | `string` | Hvem som sender meldingen |
| `Mottaker` | `string` | Hvem som mottar meldingen |
| `Innhold`  | `string` | Selve meldingsteksten     |

---

### `IMeldingSender` — grensesnitt (interface)
Definerer kontrakten alle meldingssendere må følge.

```csharp
void SendMelding(Melding melding);
```

Alle klasser som implementerer dette grensesnittet garanterer at de kan sende en `Melding`.
Dette gjør det mulig å bruke ulike sendere om hverandre uten å kjenne til den konkrete typen.

---

### `AbstraktMeldingSender` — abstrakt basisklasse
Felles basisklasse for alle konkrete sendere. Inneholder den beskyttede hjelpemetoden `SkrivUtMelding`,
som skriver avsender, mottaker og innhold til konsollen.

- Kan **ikke** instansieres direkte.
- Underklasser arver `SkrivUtMelding` og slipper å duplisere den logikken.

---

### `BrevMeldingSender` — konkret sender
Arver fra `AbstraktMeldingSender` og implementerer `IMeldingSender`.

**Atferd ved `SendMelding`:**
1. Skriver `Sender Brev` til konsollen.
2. Kaller `SkrivUtMelding` (arvet) for å vise detaljer.

---

### `SmsMeldingSender` — konkret sender
Arver fra `AbstraktMeldingSender` og implementerer `IMeldingSender`.

**Atferd ved `SendMelding`:**
1. Skriver `Sender SMS` til konsollen.
2. Kaller `SkrivUtMelding` (arvet) for å vise detaljer.

---

### `MeldingSenderFabrikk` — fabrikkmønsteret (Factory Method)
Oppretter og returnerer riktig `IMeldingSender`-implementasjon basert på en tekststreng.

| Inndata     | Returnerer           | Merknad                        |
|-------------|----------------------|--------------------------------|
| `"brev"`    | `BrevMeldingSender`  |                                |
| `"sms"`     | `SmsMeldingSender`   |                                |
| `"epost"`   | (kaster unntak)      | `NotImplementedException`      |
| Annet       | `null`               | Ukjent type                    |

Fabrikkklassen skjuler opprettelseslogikken slik at resten av koden bare forholder seg til
`IMeldingSender`-grensesnittet.

---

## Kjøreeksempel (`Program.cs`)

```csharp
var melding = new Melding
{
    Avsender = "Espen",
    Mottaker = "Rania",
    Innhold  = "Hei sveis!"
};

var fabrikk = new MeldingSenderFabrikk();
IMeldingSender brevSender = fabrikk.LagMeldingSender("brev");
IMeldingSender smsSender  = fabrikk.LagMeldingSender("sms");

brevSender.SendMelding(melding);
smsSender.SendMelding(melding);
```

**Forventet konsollutskrift:**

```
Hello, repetisjonsforelesning 2
Sender Brev
Avsender: Espen
Mottaker: Rania
Innhold: Hei sveis!
Sender SMS
Avsender: Espen
Mottaker: Rania
Innhold: Hei sveis!
```

---

## Designmønstre og prinsipper illustrert

| Konsept                   | Hvor det brukes                                      |
|---------------------------|------------------------------------------------------|
| **Interface**             | `IMeldingSender` – definerer kontrakten              |
| **Abstrakt klasse**       | `AbstraktMeldingSender` – delt logikk uten instans   |
| **Arv**                   | `BrevMeldingSender` og `SmsMeldingSender` arver base |
| **Factory Method**        | `MeldingSenderFabrikk.LagMeldingSender()`            |
| **Polymorfisme**          | Begge sendere brukes via `IMeldingSender`-typen      |
| **Enkeltansvarsprinsipp** | Hver klasse har én klart definert oppgave            |
