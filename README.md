# TimerStopper

A TimerStopper egy WPF alkalmazás, amely .NET 8-on készült, és egyszerű stopper és időzítő funkciókat biztosít. Az alkalmazás két fő ablakot tartalmaz: `StopperWindow` a stopperhez és `TimerWindow` az időzítőhöz.

## Funkciók

- **Stopper**: A stopper indítása, leállítása és visszaállítása. Az eltelt idő órákban, percekben és másodpercekben jelenik meg.
- **Időzítő**: Visszaszámláló időzítő beállítása, indítása, leállítása és visszaállítása. A hátralévő idő órákban, percekben és másodpercekben jelenik meg. Értesítés jelenik meg, amikor az időzítő eléri a nullát.

## Telepítés

1. Győződjön meg róla, hogy a .NET 8 SDK telepítve van a gépére.
2. Klónozza a repot:
```bash
git clone https://github.com/yourusername/TimerStopper.git
```
3. Navigáljon a projekt könyvtárába:
```bash
cd TimerStopper
```
4. Építse fel a projektet:
```bash
dotnet build
```

## Használat

1. Futtassa az alkalmazást:
```bash
dotnet run
```
2. A főablak megnyílik, ahol lehetőség van a stopper vagy az időzítő ablakok megnyitására.

### Stopper

- **Indítás**: Kattintson az "Indítás" gombra a stopper indításához.
- **Leállítás**: Kattintson a "Leállítás" gombra a stopper leállításához.
- **Visszaállítás**: Kattintson a "Visszaállítás" gombra a stopper nullázásához.

### Időzítő

- **Időzítő beállítása**: Adja meg a kívánt időt `HH:MM:SS` formátumban vagy összes másodpercben, majd kattintson az "Időzítő beállítása" gombra.
- **Indítás**: Kattintson az "Indítás" gombra az időzítő indításához.
- **Leállítás**: Kattintson a "Leállítás" gombra az időzítő leállításához.
- **Visszaállítás**: Kattintson a "Visszaállítás" gombra az időzítő nullázásához.

## Függőségek

- .NET 8
- WPF

## Hozzájárulás

Hozzájárulások szívesen fogadottak! Kérjük, fork-olja a repozitóriumot és küldjön be egy pull request-et.

## Licenc

Ez a projekt az MIT Licenc alatt áll.
