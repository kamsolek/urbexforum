## 🏙️ Opis projektu

**UrbexForum** to aplikacja stworzona w technologii **ASP.NET Core Razor Pages**, która pełni rolę prostego forum dla miłośników **urbexu (urban exploration)**.  
Projekt umożliwia podstawowe operacje CRUD (Create, Read, Update, Delete) na postach — użytkownik może dodawać, przeglądać, edytować i usuwać wpisy dotyczące opuszczonych miejsc.  

Każdy post zawiera:
- **tytuł**,  
- **opis**,  
- **zdjęcie** (z lokalnego dysku),  
- **datę dodania**,  
- oraz **lokalizację** (np. miasto lub współrzędne).  

Aplikacja została zaprojektowana w celu nauki pracy z **Razor Pages**, **obsługą danych w pamięci** (bez bazy danych w pierwszej wersji) oraz późniejszej integracji z relacyjną bazą danych (np. SQL Server lub SQLite).  

Interfejs zawiera:
- **pasek nawigacyjny** po lewej stronie,  
- **przycisk do dodawania nowych postów**,  
- oraz widok szczegółów posta w osobnym oknie (`PostDetailsWindow`), gdzie można obejrzeć pełne dane i zdjęcie.  

Projekt rozwijany jest jako aplikacja edukacyjna, z planami dalszego rozwoju — m.in. dodania komentarzy, połączenia z bazą danych i wdrożenia prostego systemu użytkowników.
