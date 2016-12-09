edit:calc.exe sum.dll CSCalc.exe
calc.exe:calc.c
	gcc calc.c sum.c -o calc.exe
sum.dll:sum.c
	"C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\bin\cl.exe" /D_USRDLL /D_WINDLL sum.c /link /DLL  /MANIFEST /NXCOMPAT   /libpath:"C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\lib" /libpath:"C:\Program Files (x86)\Microsoft SDKs\Windows\v7.1A\Lib" /libpath:"C:\Program Files (x86)\Windows Kits\10\Lib\10.0.14393.0\ucrt\x86" /DYNAMICBASE "fltkd.lib" "wsock32.lib" "comctl32.lib" "fltkjpegd.lib" "fltkimagesd.lib" "kernel32.lib" "user32.lib" "gdi32.lib" "winspool.lib" "comdlg32.lib" "advapi32.lib" "shell32.lib" "ole32.lib" "oleaut32.lib" "uuid.lib" "odbc32.lib" "odbccp32.lib" /DEBUG /MACHINE:X86 /NODEFAULTLIB:"libcd.lib" /INCREMENTAL  /SUBSYSTEM:WINDOWS  /TLBID:1 /OUT:sum.dll
CSCalc.exe:CSCalc.cs
	"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" CSCalc.cs

