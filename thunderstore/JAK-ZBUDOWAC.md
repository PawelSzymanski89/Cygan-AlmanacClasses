# Paczka Thunderstore (team Cygan)

Ten katalog to *tylko* opis paczki. DLL-a nie trzymamy w repo - bierze sie go z release'a
`v0.6.9-valheim1.0` (build z brancha `valheim-1.0`, ~18 MB po ILRepacku).

```sh
gh release download v0.6.9-valheim1.0 -R PawelSzymanski89/AlmanacClasses -D /tmp/rel
cd thunderstore && unzip -o /tmp/rel/AlmanacClasses_v0.6.9-valheim1.0.zip AlmanacClasses.dll
zip -r ../Cygan-AlmanacClassSystem-0.6.9.zip manifest.json README.md CHANGELOG.md icon.png AlmanacClasses.dll
```

Wrzucamy na https://thunderstore.io pod teamem **Cygan** (upload wymaga zalogowania albo tokenu API -
to robi wlasciciel konta, nie skrypt).

Branch jest celowo osobny od `valheim-1.0`: z tego drugiego idzie
[PR #31](https://github.com/RustyMods/AlmanacClasses/pull/31) do RustyMods i nie chcemy mu tam wrzucac
naszego packagingu.
