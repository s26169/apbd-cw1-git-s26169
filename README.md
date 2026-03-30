1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Fast-forward jest możliwy, gdy gałąź docelowa nie ma nowych commitów od momentu utworzenia gałęzi bocznej. Jeśli obie gałęzie mają własną historię, Git tworzy merge commit.

2. Czym w praktyce różni się merge od rebase?

Merge łączy historie i zachowuje rozgałęzienie. Rebase przepisuje commity gałęzi na nową bazę, dzięki czemu historia staje się liniowa.

3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Konflikt został rozwiązany ręcznie przez wybór jednej wersji zmienionego fragmentu kodu i usunięcie znaczników konfliktu. Następnie plik został ponownie dodany do indeksu i zakończono merge commit.