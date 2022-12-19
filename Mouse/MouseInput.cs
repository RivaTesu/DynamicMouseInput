using static Dynamic_Mouse_Input.WinAPI.PInvoke;

namespace Dynamic_Mouse_Input.Mouse;

public static class MouseInput
{
    public static unsafe void Inject(MouseInfo input)
    {
        if (_injectMouseInput != null)
            _injectMouseInput(new[] { input }, 1);

        var libAddress = LoadLibraryW("win32u.dll");

        if (libAddress == default)
            throw new Exception("Failed to import user32.dll");

        var methodAddress = GetProcAddress(libAddress, "NtUserInjectMouseInput");

        if (methodAddress == default)
            throw new Exception("Could not find InjectMouseInput method in user32.dll");

        _injectMouseInput = (delegate* unmanaged[Stdcall]<MouseInfo[], int, nint>)methodAddress;
        _injectMouseInput(new[] { input }, 1);
    }

    private static unsafe delegate* unmanaged[Stdcall]<MouseInfo[], int, nint> _injectMouseInput;
}