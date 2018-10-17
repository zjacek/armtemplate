# Tydzie� 3

## Tre�� zadania

TYDZIEN3.1 �Zbuduj prost� konwencj� nazewnicz� dla min. takich zasob�w jak Grupa Zasob�w, VNET, Maszyn Wirtualna, Dysk, Konta sk�adowania danych. Pami�taj o ograniczeniach w nazywaniu zasob�w, kt�re wyst�puj� w Azure�

TYDZIEN3.2 � Zbuduj prosty ARM Template (mo�esz wykorzysta� ju� gotowe wzorce z GitHub), kt�ry wykorzystuje koncepcj� Linked Templates. Template powinien zbudowa� �rodowisko z�o�one z jednej sieci VNET, podzielonej na dwa subnety. W ka�dy subnecie powinna powsta� najprostsza maszyna wirtualna z systemem Ubuntu 18.04 a na ka�dym subnecie powinny zosta� skonfigurowane NSG.�

TYDZIEN3.3 �Zbuduj najprostrz� w�a�n� rol� RBAC, kt�ra pozwala u�ytkownikowi uruchomi� maszyn�, zatrzyma� j� i zg�osi� zg�oszenie do supportu przez Portal Azure�

TYDZIEN3.4 �Spr�buj na koniec zmodyfikowa� template tak, by nazwa u�ytkownika i has�o do ka�dej maszyny z pkt. 2 by�o pobierane z KeyVault.�

## Zadanie 3.1 Konwencja nazewnicza - polisy w 'zadanie3.1'

Konwencja nazewnicza

####Resource groups

<kr�tka nazwa projektu>-<rodzaj �rodowiska>-rg-<numer porz�dkowy>

- "kr�tka nazwa projektu" - nazwa identyfikuj�ca projekt, 4 znaki
- "rodzaj �rodowiska" - np. [PRD|TST|DEV], 3 znaki
- "numer porz�dkowy" - 2 cyfry

####Storage

<kr�tka nazwa projektu><rodzaj �rodowiska>-st-<unikalny ci�g znak�w>

- "kr�tka nazwa projektu" - nazwa identyfikuj�ca projekt, 4 znaki
- "rodzaj �rodowiska" - np. [PRD|TST|DEV], 3 znaki
- "unikalny ci�g znak�w" - unikalny ci�g znak�w generowany z funkcji "uniqueString(resourceGroup().id))", 13 znak�w
- <ca�o�� maksymalnie 24 znaki>

####Virtual Network

<kr�tka nazwa projektu>-<rodzaj �rodowiska>-vnet-<numer porz�dkowy>

- "kr�tka nazwa projektu" - nazwa identyfikuj�ca projekt, 4 znaki
- "rodzaj �rodowiska" - np. [PRD|TST|DEV], 3 znaki
"- numer porz�dkowy" - 2 cyfry

####Virtual Machine

<kr�tka nazwa projektu><rodzaj �rodowiska><rola serwera><numer porz�dkowy>

- "kr�tka nazwa projektu" - nazwa identyfikuj�ca projekt, 4 znaki
- "rodzaj �rodowiska" - np. [PRD|TST|DEV], 3 znaki
- "rola serwera" - np. [app|web|dba], 3 znaki
- "numer porz�dkowy" - 2 cyfry
- <ca�o�� maksymalnie 15 znak�w>

####Disk

<nazwa maszyny wirtualnej>-disk-<numer porz�dkowy>

- "nazwa maszyny wirtualnej" - nazwa maszyny wirtualnej do kt�rej b�dzie przynale�a� dysk
- "numer porz�dkowy" - 2 cyfry

