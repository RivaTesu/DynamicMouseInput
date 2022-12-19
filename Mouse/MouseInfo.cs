namespace Dynamic_Mouse_Input.Mouse;

public struct MouseInfo
{
    // Gets or sets the change in value of an x-coordinate since the last mouse wheel event.
    public int DeltaX;

    // Gets or sets the change in value of an y-coordinate since the last mouse wheel event.
    public int DeltaY;

    // Gets or sets a value used by other properties. The value is based on the MouseOptions flags set.
    public uint MouseData;

    // Gets or sets the various options, or modifiers, used to simulate mouse input.
    public MouseOptions Options;

    // Gets or sets the baseline, or reference value, for timed input events such as a double click/tap.
    public uint TimeOffsetInMilliseconds;

    // Gets or sets the extra information associated with the mouse event.
    public IntPtr ExtraInfo;
}