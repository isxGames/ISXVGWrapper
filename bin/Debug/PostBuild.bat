@ECHO OFF
:: delims is a TAB followed by a space
FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B


copy ISXVGWrapper.dll "%InnerSpacePath%\.NET Programs"
copy ISXVGWrapper.XML "%InnerSpacePath%\.NET Programs"

REM copy ISXVGWrapper.dll "s:\.NET Programs"