using System.Runtime.InteropServices;

namespace Dynamic_Mouse_Input.WinAPI;

public static class PInvoke
{
    [DllImport("kernel32.dll", SetLastError = false, CharSet = CharSet.Ansi)]
    internal static extern nint GetProcAddress(nint hModule, string name);
  
    [DllImport("kernel32.dll", SetLastError = false, CharSet = CharSet.Unicode)]
    internal static extern nint LoadLibraryW(string lpFileName);
}