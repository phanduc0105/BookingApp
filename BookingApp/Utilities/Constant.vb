Public Class Constant
    Public Const MSG_REQUIRED_TEXT = "{0} cannot be empty."
    Public Const MSG_REQUIRED_NUMBER = "{0} must be greater than 0."
    Public Const MSG_SAVE_SUCCESS = "Save data success."
    Public Const MSG_DEL_SUCCESS = "Delete data success."
    Public Const MSG_CONFIRM_SAVE_DATA = "Do you want to save the data?"
    Public Const MSG_CONFIRM_DEL_DATA = "Do you want to delete the data?"

    Public Const MAX_VIP_SEAT As Integer = 20
    Public Const MAX_COUPLE_SEAT As Integer = 20
    Public Const MAX_STANDARD_SEAT As Integer = 60

    Public Enum ScreenMode
        Normal
        Search
    End Enum

    Public Enum SeatType
        VIP
        Couple
        Standard
    End Enum
End Class
