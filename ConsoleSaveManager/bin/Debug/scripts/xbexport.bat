@echo off
if not DEFINED IS_MINIMIZED set IS_MINIMIZED=1 && start "" /min "%~dpnx0" %* && exit
TITLE XboxManager - Save Game Exporter
cd "%DurangoXDK%\bin"

rem Read install path of the Savemanager
for /r C:\installpath %%a in (*) do if "%%~nxa"=="installpath.txt" set installpath=%%~dpnxa
if defined installpath (
echo %installpath%
) else (
echo File not found
)
for /f "delims=" %%x in (%installpath%)do set appinstallpath=%%x

for /r %appinstallpath%\AppxManifest %%a in (*) do if "%%~nxa"=="scid.txt" set p=%%~dpnxa
if defined p (
echo %p%
) else (
echo File not found
)
for /f "delims=" %%x in (%p%)do set SCID=%%x



rem Find the location where the saves are exported-
for /r %appinstallpath%\locations %%a in (*) do if "%%~nxa"=="xbExportLocation.txt" set loc=%%~dpnxa
if defined loc (
echo %loc%
) else (
echo File not found
)
for /f "delims=" %%x in (%loc%)do set pathToSave=%%x



rem Get the user email from the xbox manager
set "command=xbconfig defaultuser"

FOR /F "tokens=* USEBACKQ" %%F IN (`%command%`) DO (
SET var=%%F
)
set userEmail=%var:*: =%
echo Your email is: %userEmail%




rem Export the save to your desired location
xbstorage export "%pathToSave%\%userEmail%.xml" /msa:%userEmail% /scid:%SCID%
start %appinstallpath%\saves\xbox%
exit