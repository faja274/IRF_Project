A beadandó dolgozat egy könyvesbolt napi forgalmát hivatott kezelni.
Az aznapi készletet a nap elején betöltjük csv fájlból, majd ezt követően tudjuk a bal oldali kezelőfelület segítségével irányítani, hogy eladás történik, raktárfeltöltés, vagy pedig éppen az aznapi eladásokról szeretnénk egy kimutatást megtekinteni.
Ami az eladásokat illeti, a bolt tartja magát egy régi hagyományhoz, mégpedig hogy vásárlóinak lehetősége van háromszor dobni egy dobókockával, ha pedig sikerül háromszor is hatost dobni, a könyvet ingyen megkapja a vásárló.
Nap végén a készletet kivezetik egy csv fájlba.

A felület pontos működése:
A szoftvert megnyitva egy UserControl fogad minket, amelyen a könyvesboltunk eladásait tudjuk kezelni. Amikor egy vevő érdeklődik egy könyvről, azt keresőnk segítségével ellenőrizni tudjuk, hogy van-e raktáron, valamint a lista alatt megtekinthetjük, pontosan mennyi is elérhető azon könyvből. Ezt követően az ablak jobb oldalán tudjuk eladni a könyvet a gomb megnyomásával. Ekkor a program dob nekünk három kockával, amin ha három hatos jön ki, a vevő ingyen megkapja a könyvet.
Ezen kívül a második oldalon, ahová a 'Stats' gomb lenyomásával jutunk el ismerhetjük meg a raktáron tartott könyvek kategória szerinti megoszlását. Ezen felül ugyanezt a kimutatást megnézhetjük az aznapi eladásokra is.
A harmadik oldal pedig a raktárkészlet feltöltésére alkalmas. Amennyiben már rendelkezünk a könyvvel, azon esetben elég a listából kiválasztanunk és darabszámot megadnunk. Amennyiben ilyen könyvünk még nincs raktáron, az adatainak megfelelő formátumú felvitelével adhatjuk hozzá.
Végezetül pedig a nap zárása gombbal kiírható csv-be mind a készlet, mind a napi forgalom. Ezt követően az applikáció bezáródik.
