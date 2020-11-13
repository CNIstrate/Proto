@echo off
if not DEFINED IS_MINIMIZED set IS_MINIMIZED=1 && start "" /min "%~dpnx0" %* && exit
TITLE XboxManager - Save Game Importer

rem Read install path of the Savemanager
for /r C:\installpath %%a in (*) do if "%%~nxa"=="installpath.txt" set installpath=%%~dpnxa
if defined installpath (
echo %installpath%
) else (
echo File not found
)
for /f "delims=" %%x in (%installpath%)do set appinstallpath=%%x


for /r %appinstallpath%\locations\ %%a in (*) do if "%%~nxa"=="nswsaveimportpath.txt" set p=%%~dpnxa
if defined p (
echo %p%
) else (
echo File not found
)
for /f "delims=" %%x in (%p%)do set nswSaveImportPath=%%x



set "command=%NINTENDO_SDK_ROOT%\Tools\CommandLineTools\ControlTarget.exe get-default"

FOR /f "tokens=* USEBACKQ" %%F IN (`%command%`) DO (
SET var=%%F
)
rem removes everything after the 14th character
set console=%var:~0,14%
echo %console%
echo Importing save file for Target %consoleIP% ...
"%NINTENDO_SDK_ROOT%\Tools\CommandLineTools\BackupSaveData.exe" import --target="%console%" --follow-exist-account %nswSaveImportPath%
exit