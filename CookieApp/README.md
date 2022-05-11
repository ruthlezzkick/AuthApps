# CookieApp

 ## Logika i opis aplikacji 

   

   

  1. Aplikacja zawiera 3 podstrony + 1 niewidoczną (bez reprezentacji graficznej) która wykonuje w tle operację wylogowania i od razu robi redirect do strony logowania : Login, Todo, AdminPanel  +  LogOut 

  2. Strony są bardzo surowe, nie zawierają żadnego stylowania (css). Czysty i goły HTML.  

  3. Ponieważ nie skupiamy się tu na backendzie i bazie danych, to logikę symulującą klasy z danymi i ich pobieranie załatwia klasa DataProvider. 
  Dane w naszej imitacji bazy danych można opisać w skrócie tak: 

  - mamy 4 użytkowników: Janek, Adam, Admin i Admin2 
  - każdy z nich ma hasło dokładnie takie jak login (co nie jest nawet zawarte w klasach zawierających dane o użytkownikach, a w logice kodu) 
  - użytkownicy mają też pewne role, ale również są one zahardkodowane w logice a nie na poziomie klas użytkowników.  
    - Logika ta pozwala na dostęp do Listy zadań użytkownikom: Jan, Adam i Admin (Admin2 nie ma dostępu do swoich zadań, jest tylko adminem) 
    - Admin i Admin2 mają dodatkowo dostęp do panelu administratora 

  - lista zadań to zadania tylko danego użytkownika 
  - panel administracyjny pokazuje informacje o wszystkich użytkownikach i ilości ich zadań 
  - każda strona posiada linki do innych stron, aby łatwo można było nawigować po aplikacji 
  - aplikację można testować na różnych użytkownikach. Możliwe komunikaty związane z błędnym logowaniem i brakiem dostępu są takie: 
    - brak loginu 
    - błędny login lub hasło 
    - brak dostępu 

## Opis procesu budowy aplikacji i poszczególnych klas 

1. Tworzymy projekt typu ASP.NET Web Application (.NET Framework) na szablonie Empty ( dzięki czemu nie dostaniemy żadnych przykładów, domyślnych klas, ani dodatkowych wpisów do webConfig ) 

2. Klasa DataProvider dostarcza nam dane i metody do ich pobierania 

3. Dodajemy 4 x Web Form (celowo bezpośrednio do projektu, bez Master Page, bez wyszczególnionych kontrolek ascx, ani bardziej złożonych komponentów) 

4. Każdy z dodanych Web Form dostaje już jakieś domyślne ciało. Page, form i parametr runat= “server” 

5. Dodajemy komponenty (chodź można dodawać zwykłe tagi html, dzięki komponentom ASP.NET zyskujemy jednak możliwość dynamicznego operowania na nich, zdarzenia i pewną namiastkę stanu 

6. W niektórych ze stron mieszamy kod deklaratywny (HTML) z imperatywnym C#, który ląduje między znacznikami <%= =%> 

7. Każdy Web Form z automatu dostaje 2 dodatkowe pliki: cs i designer. W pliku cs możemy programować logikę do wywołania przed załadowaniem strony w przeglądarce (metoda Page_Load) oraz w razie potrzeby logikę obsługi zdarzeń np. kliknięcia w przycisk. W pliku designer dostajemy nasze kontrolki Asp.Net , dzięki czemu możemy się do nich dynamicznie odwoływać w kodzie i operować na nich. 

![Solucja](~/IMG/logowanie1.PNG)
