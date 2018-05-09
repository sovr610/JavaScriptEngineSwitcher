set project_name=JavaScriptEngineSwitcher.ChakraCore.Native.win-arm
set lib_dir=..\..\lib\ChakraCore
set licenses_dir=..\..\Licenses
set nuget_package_manager=..\..\.nuget\nuget.exe

call "..\setup.cmd"

rmdir runtimes /Q/S
del chakra-core-license.txt /Q/S

xcopy "%lib_dir%\runtimes\win-arm\native\ChakraCore.dll" runtimes\win-arm\native\
copy "%licenses_dir%\chakra-core-license.txt" chakra-core-license.txt /Y

%nuget_package_manager% pack "..\%project_name%\%project_name%.nuspec"