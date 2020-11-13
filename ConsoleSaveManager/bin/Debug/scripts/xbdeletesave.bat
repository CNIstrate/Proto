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


for /f "delims=" %%x in (%appinstallpath%\AppxManifest\scid.txt) do set SCID=%%x
set "command=xbconfig defaultuser"

FOR /F "tokens=* USEBACKQ" %%F IN (`%command%`) DO (
SET var=%%F
)
set userEmail=%var:*: =%

xbstorage delete /msa:%userEmail% /scid:%SCID%
exit