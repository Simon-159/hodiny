## ASCII Hodiny
konzolová aplikace na zobrazení času
#### cíl projektu
vykreslit na konzoli hodiny, které získají čas ze systému
#### Zvolené technologie
c#, náročnost: středně lehká
## Projektová dokumentace
####  Úvod:
Projekt "ASCII hodiny" je jednoduchá aplikace, která funguje jako hodiny, které po spuštění programu vykreslí na konzoli aktuální systémový čas v ASCII číslicích.
####  Použité technologie:
Pro vytvoření hodin byl použit programovací jazyk C#. C# je moderní, objektově orientovaný jazyk, vyvinutý společností Microsoft a používaný pro vývoj aplikací pro platformu .NET Jazyk C# kombinuje výhody jazyků C++ a Java a poskytuje pokročilé funkce jako například garbage collection a podporu delegátů. Aplikace běží v konzolovém rozhraní, což znamená, že nevyužívá žádný grafický framework. Namísto toho využívá výstupní metody třídy Console, která umožňuje vypisovat text přímo do konzole.

Pro vykreslování čísel byl použit ASCII art. ASCII art je technika vytváření obrazců a tvarů pomocí ASCII znaků. Jedná se o jednoduchý způsob, jak vyjádřit grafiku pomocí textu, což umožňuje vytvářet zajímavé vizuální efekty bez použití grafických knihoven nebo jiných nástrojů.
#### Popis fungování:
ASCII hodiny fungují tak, že po spuštění programu uživatelem získávají aktuální systémový čas pomocí funkce DateTime.Now. Následně je tento čas rozložen na jednotlivé číslice (2 pro hodiny, 2 pro minuty, 2 pro sekundy) a vykreslí je pomocí ASCII artu ve formátu formátu hh:mm:ss. Pro každou číslici je vytvořeno pole řetězců, kde každý řetězec odpovídá jedné řádce ASCII artu. Předtím, než jsou vykresleny, provádí se umístění hodin do správných souřadnic a ujištění, že se číslice nebudou překrývat, protože by byly moc široké. Pakliže by byly, je mezi nimi vytvořena větší mezera. Nakonec jsou dané řetězce vykresleny na obrazovku pomocí funkce Console.Write. Aby se časy nepsaly znovu pod sebe každou sekundu, co je ten program obnovován, je potřeba každou sekundu volat funkci Console.Clear, aby byla konzole vyčištěna takže vykreslené hodiny se zobrazují na jednom místě a uživatel nemusel pořád sjíždět dolů na dolní konec konzole, který se pořád “propadá“, kde by viděl ten správný čas jen na chvíli, protože pak by mu to hned posunulo.
#### Návod na použití: 
Po stažení ASCII hodin stačí spustit přiložený kód v nějakém vývojovém prostředí, které podporuje jazyk C#. Potom jen stačí daný kód spustit. Po spuštění programu nemusí uživatel vůbec nic dělat, program vše dělá sám, a na obrazovce se zobrazí aktuální systémový čas v ASCII číslicích.
#### Možný rozvoj v budoucnu/Popis reálného využití projektu:
Tento projekt by mohl být dále rozvíjen například přidáním možnosti změny formátu zobrazovaného času (24h/12h), podpora různých časových pásem, kde by si člověk mohl vybrat, u jakého města/oblasti chce zjistit aktuální čas, a to by šlo udělat pomocí přičítání či odečítání v rámci hodin, popřípadě minut. Jeden z mých dalších nápadů je možnost přidání aktuálního datumu a roku, který právě je, nebo například zvukový signál po každé minutě co uběhne. Zajímavým, ale asi velmi náročným by bylo vylepšení vizuálních efektů, možnost nastavit si styl ASCII artu používaný k vykreslování času, anebo přidáním možnosti celkově nastavit vlastní barevné schéma. Tyto funkce a mnoho dalších by z projektu udělaly více komplexní a zajímavý projekt pro učení se programování a zároveň by mohl sloužit jako inspirace pro tvorbu vlastních ASCII art aplikací.

ASCII hodiny mohou být využity jako jednoduchý nástroj pro zobrazení přesného času, který není náročný na systémové prostředky, a navíc není závislý na internetu. Může být také užitečný pro učení se programování, nebo pro demonstraci základních konzolových funkcí v rámci výuky.
