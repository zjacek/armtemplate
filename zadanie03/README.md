# Tydzień 3

## Treść zadania

TYDZIEN3.1 „Zbuduj prostą konwencję nazewniczą dla min. takich zasobów jak Grupa Zasobów, VNET, Maszyn Wirtualna, Dysk, Konta składowania danych. Pamiętaj o ograniczeniach w nazywaniu zasobów, które występują w Azure”

TYDZIEN3.2 „ Zbuduj prosty ARM Template (możesz wykorzystać już gotowe wzorce z GitHub), który wykorzystuje koncepcję Linked Templates. Template powinien zbudować środowisko złożone z jednej sieci VNET, podzielonej na dwa subnety. W każdy subnecie powinna powstać najprostsza maszyna wirtualna z systemem Ubuntu 18.04 a na każdym subnecie powinny zostać skonfigurowane NSG.”

TYDZIEN3.3 „Zbuduj najprostrzą właśną rolę RBAC, która pozwala użytkownikowi uruchomić maszynę, zatrzymać ją i zgłosić zgłoszenie do supportu przez Portal Azure”

TYDZIEN3.4 „Spróbuj na koniec zmodyfikować template tak, by nazwa użytkownika i hasło do każdej maszyny z pkt. 2 było pobierane z KeyVault.„

## Zadanie 3.1 Konwencja nazewnicza - polisy w 'zadanie3.1'

Konwencja nazewnicza

####Resource groups

<krótka nazwa projektu>-<rodzaj środowiska>-rg-<numer porządkowy>

- "krótka nazwa projektu" - nazwa identyfikująca projekt, 4 znaki
- "rodzaj środowiska" - np. [PRD|TST|DEV], 3 znaki
- "numer porządkowy" - 2 cyfry

####Storage

<krótka nazwa projektu><rodzaj środowiska>-st-<unikalny ciąg znaków>

- "krótka nazwa projektu" - nazwa identyfikująca projekt, 4 znaki
- "rodzaj środowiska" - np. [PRD|TST|DEV], 3 znaki
- "unikalny ciąg znaków" - unikalny ciąg znaków generowany z funkcji "uniqueString(resourceGroup().id))", 13 znaków
- <całość maksymalnie 24 znaki>

####Virtual Network

<krótka nazwa projektu>-<rodzaj środowiska>-vnet-<numer porządkowy>

- "krótka nazwa projektu" - nazwa identyfikująca projekt, 4 znaki
- "rodzaj środowiska" - np. [PRD|TST|DEV], 3 znaki
"- numer porządkowy" - 2 cyfry

####Virtual Machine

<krótka nazwa projektu><rodzaj środowiska><rola serwera><numer porządkowy>

- "krótka nazwa projektu" - nazwa identyfikująca projekt, 4 znaki
- "rodzaj środowiska" - np. [PRD|TST|DEV], 3 znaki
- "rola serwera" - np. [app|web|dba], 3 znaki
- "numer porządkowy" - 2 cyfry
- <całość maksymalnie 15 znaków>

####Disk

[nazwa maszyny wirtualnej]-disk-<numer porządkowy>
 
- "nazwa maszyny wirtualnej" - nazwa maszyny wirtualnej do której będzie przynależał dysk
- "numer porządkowy" - 2 cyfry

