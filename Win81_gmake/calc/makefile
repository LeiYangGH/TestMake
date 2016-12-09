edit:calc.exe sum.dll CSCalc.exe
calc.exe:calc.c
	gcc calc.c sum.c -o calc.exe
sum.dll:sum.c
	"C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\bin\cl.exe" /D_USRDLL /D_WINDLL sum.c /link /DLL     /libpath:"C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\lib" /libpath:"C:\Program Files (x86)\Microsoft SDKs\Windows\v7.1A\Lib" /libpath:"C:\Program Files (x86)\Windows Kits\10\Lib\10.0.14393.0\ucrt\x86" /MACHINE:X86 /OUT:sum.dll
CSCalc.exe:CSCalc.cs
	"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /platform:x86 CSCalc.cs

