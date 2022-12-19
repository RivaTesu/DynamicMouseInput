using Dynamic_Mouse_Input.Mouse;

var input = new MouseInfo
{
    DeltaX = 500,
    DeltaY = 500,
    MouseData = default,
    Options = MouseOptions.MoveNoCoalesce,
    TimeOffsetInMilliseconds = default,
    ExtraInfo = default,
};

MouseInput.Inject(input);