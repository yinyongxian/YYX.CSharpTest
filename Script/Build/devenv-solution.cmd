@echo off

echo Start Build %date% %time%
echo Start Build %date% %time%>build.log

devenv.exe ..\..\YYX.CSharpTest.sln  /build Debug

echo End Build  %date% %time%
echo End Build  %date% %time%>build.log

pause