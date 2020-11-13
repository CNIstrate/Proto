@echo off
if not DEFINED IS_MINIMIZED set IS_MINIMIZED=1 && start "" /min "%~dpnx0" %* && exit
TITLE XboxManager - Connect
cd "%DurangoXDK%\bin"

rem Read install path of the Savemanager
for /r C:\installpath %%a in (*) do if "%%~nxa"=="installpath.txt" set installpath=%%~dpnxa
if defined installpath (
echo %installpath%
) else (
echo File not found
)
for /f "delims=" %%x in (%installpath%)do set appinstallpath=%%x


for /r %appinstallpath%\locations\ %%a in (*) do if "%%~nxa"=="xbconsoleip.txt" set loc=%%~dpnxa
if defined loc (
echo %loc%
) else (
echo File not found
)
for /f "delims=" %%x in (%loc%)do set ip=%%x
echo %ip%

xbconnect %ipaddress%
pause