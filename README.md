# Wstęp
Projekt jest częścią artykułu o przesyłaniu plików na serwer i do Blazor WASM. Artykuł znajduje się tutaj: https://masterbranch.pl/przesylanie-plikow/

# Jak uruchomić?
Solucja składa się z projektów:
- BlazorClient
- Common
- RazorApp
- WebApi

RazorApp jest projektem samodzielnym. BlazorClient powinien być uruchamiany wraz z WebApi.

Aby uruchomić aplikację RazorApp należy wybrać taką konfigurację w VisualStudio:
![image](https://user-images.githubusercontent.com/36266826/210059109-41b59541-faf2-40f2-9233-a311bf0ea001.png)

Następnie należy zaznaczyć ten projekt jako projekt startowy:
![image](https://user-images.githubusercontent.com/36266826/210059154-18ca6f88-d7fb-48e3-ad45-5da5d1d6b680.png)


Aby uruchomić BlazorClient należy wybrać odpowiednią konfigurację z VisualStudio:
![image](https://user-images.githubusercontent.com/36266826/210059203-b9ab4114-fb43-4643-9290-2c9d7cfc176f.png)

A następnie wybrać projekty BlazorClient i WebApi jako projekty startowe. W tym celu trzeba kliknąć prawym klawiszem myszy na solucję i wybrać opcję Properties. A następnie:
![image](https://user-images.githubusercontent.com/36266826/210059317-08b44875-5a99-4839-943a-73ed9bb71a0a.png)
