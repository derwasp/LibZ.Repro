"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe" .\LibzRepro.sln
artifacts\bin\Debug\LibzRepro\LibzRepro.exe
"NuGet.exe" "Install" "libz.tool" "-ExcludeVersion" "-OutputDirectory" "packages"
packages\LibZ.Tool\tools\libz inject-dll --assembly artifacts\bin\Debug\LibzRepro\LibzRepro.exe --include artifacts\bin\Debug\LibzRepro\*.dll --move
artifacts\bin\Debug\LibzRepro\LibzRepro.exe