@echo off
if not DEFINED IS_MINIMIZED set IS_MINIMIZED=1 && start "" /min "%~dpnx0" %* && exit
TITLE XboxManager - Save Game Importer

cd "%DurangoXDK%\bin"


for /r C:\installpath\ %%a in (*) do if "%%~nxa"=="installpath.txt" set installpath=%%~dpnxa
if defined installpath (
echo %installpath%
) else (
echo File not found
)
for /f "delims=" %%x in (%installpath%)do set pathtolook=%%x
echo pathtolook=%p%

for /r %pathtolook%\AppxManifest %%a in (*) do if "%%~nxa"=="scid.txt" set p=%%~dpnxa
if defined p (
echo %p%
) else (
echo File not found
)
for /f "delims=" %%x in (%p%)do set SCID=%%x
echo SCID=%p%


for /r %pathtolook%\locations %%a in (*) do if "%%~nxa"=="xbImportLocation.txt" set loc=%%~dpnxa
if defined loc (
echo %loc%
) else (
echo File not found
)
for /f "delims=" %%x in (%loc%)do set pathToSave=%%x
echo pathToSave=%p%

set "command=xbconfig defaultuser"

FOR /F "tokens=* USEBACKQ" %%F IN (`%command%`) DO (
SET var=%%F
)
set userEmail=%var:*: =%

echo Importing %fileName%
xbstorage import "%pathToSave%" /msa:%userEmail% /scid:%SCID%
exit