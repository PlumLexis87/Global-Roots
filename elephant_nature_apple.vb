Public Class DiversityAdvocacyGroup

'Declare class fields
Private _name As String
Private _missionStatement As String
Private _supportedInitiatives As List(Of String)
Private _numberOfMembers As Integer

'Constructors
Public Sub New(name As String, missionStatement As String)
    _name = name
    _missionStatement = missionStatement
    _supportedInitiatives = New List(Of String)
    _numberOfMembers = 0
End Sub

Public Sub New(name As String, missionStatement As String, supportedInitiatives As List(Of String))
    _name = name
    _missionStatement = missionStatement
    _supportedInitiatives = supportedInitiatives
    _numberOfMembers = 0
End Sub

'Properties
Public Property Name As String
    Get
        Return _name
    End Get
    Set
        _name = Value
    End Set
End Property

Public ReadOnly Property MissionStatement As String
    Get
        Return _missionStatement
    End Get
End Property

Public ReadOnly Property SupportedInitiatives As List(Of String)
    Get
        Return _supportedInitiatives
    End Get
End Property

Public ReadOnly Property NumberOfMembers As Integer
    Get
        Return _numberOfMembers
    End Get
End Property

'Methods
Public Sub AddSupportedInitiative(initiative As String)
    _supportedInitiatives.Add(initiative)
End Sub

Public Sub RemoveSupportedInitiative(initiative As String)
    _supportedInitiatives.Remove(initiative)
End Sub

Public Sub AddMember()
    _numberOfMembers += 1
End Sub

Public Sub RemoveMember()
    _numberOfMembers -= 1
End Sub

End Class