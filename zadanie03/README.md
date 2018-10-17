# Tydzieñ 3

## Treœæ zadania

TYDZIEN3.1 „Zbuduj prost¹ konwencjê nazewnicz¹ dla min. takich zasobów jak Grupa Zasobów, VNET, Maszyn Wirtualna, Dysk, Konta sk³adowania danych. Pamiêtaj o ograniczeniach w nazywaniu zasobów, które wystêpuj¹ w Azure”

TYDZIEN3.2 „ Zbuduj prosty ARM Template (mo¿esz wykorzystaæ ju¿ gotowe wzorce z GitHub), który wykorzystuje koncepcjê Linked Templates. Template powinien zbudowaæ œrodowisko z³o¿one z jednej sieci VNET, podzielonej na dwa subnety. W ka¿dy subnecie powinna powstaæ najprostsza maszyna wirtualna z systemem Ubuntu 18.04 a na ka¿dym subnecie powinny zostaæ skonfigurowane NSG.”

TYDZIEN3.3 „Zbuduj najprostrz¹ w³aœn¹ rolê RBAC, która pozwala u¿ytkownikowi uruchomiæ maszynê, zatrzymaæ j¹ i zg³osiæ zg³oszenie do supportu przez Portal Azure”

TYDZIEN3.4 „Spróbuj na koniec zmodyfikowaæ template tak, by nazwa u¿ytkownika i has³o do ka¿dej maszyny z pkt. 2 by³o pobierane z KeyVault.„

## Zadanie 3.1 Konwencja nazewnicza - polisy w 'zadanie3.1'

Konwencja nazewnicza

####Resource groups

<krótka nazwa projektu>-<rodzaj œrodowiska>-rg-<numer porz¹dkowy>

- "krótka nazwa projektu" - nazwa identyfikuj¹ca projekt, 4 znaki
- "rodzaj œrodowiska" - np. [PRD|TST|DEV], 3 znaki
- "numer porz¹dkowy" - 2 cyfry

####Storage

<krótka nazwa projektu><rodzaj œrodowiska>-st-<unikalny ci¹g znaków>

- "krótka nazwa projektu" - nazwa identyfikuj¹ca projekt, 4 znaki
- "rodzaj œrodowiska" - np. [PRD|TST|DEV], 3 znaki
- "unikalny ci¹g znaków" - unikalny ci¹g znaków generowany z funkcji "uniqueString(resourceGroup().id))", 13 znaków
- <ca³oœæ maksymalnie 24 znaki>

####Virtual Network

<krótka nazwa projektu>-<rodzaj œrodowiska>-vnet-<numer porz¹dkowy>

- "krótka nazwa projektu" - nazwa identyfikuj¹ca projekt, 4 znaki
- "rodzaj œrodowiska" - np. [PRD|TST|DEV], 3 znaki
"- numer porz¹dkowy" - 2 cyfry

####Virtual Machine

<krótka nazwa projektu><rodzaj œrodowiska><rola serwera><numer porz¹dkowy>

- "krótka nazwa projektu" - nazwa identyfikuj¹ca projekt, 4 znaki
- "rodzaj œrodowiska" - np. [PRD|TST|DEV], 3 znaki
- "rola serwera" - np. [app|web|dba], 3 znaki
- "numer porz¹dkowy" - 2 cyfry
- <ca³oœæ maksymalnie 15 znaków>

####Disk

<nazwa maszyny wirtualnej>-disk-<numer porz¹dkowy>

- "nazwa maszyny wirtualnej" - nazwa maszyny wirtualnej do której bêdzie przynale¿a³ dysk
- "numer porz¹dkowy" - 2 cyfry

