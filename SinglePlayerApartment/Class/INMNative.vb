Imports GTA
Imports GTA.Native
Imports GTA.Math
Imports INMNativeUI
Imports System.Drawing

Namespace INMNative

    Public Class Apartment

        Private _cost, _interiorID, _radio As Integer
        Private _radioRoomList As List(Of String) = New List(Of String)
        Private _owner, _name, _desc, _unit, _grgpath, _savefile, _playermap, _ipl, _lastipl As String
        Private _aptblip, _grgblip As Blip
        Private _entrance, _save, _telin, _telout, _exit, _wardrobe, _garageent, _grgout, _camerapos, _camerarot, _interior, _ascamerapos, _ascamerarot As Vector3
        Private _grgoutheading, _camerafov, _wardrobeheading, _ascamerafov As Single
        Private _isathome, _enabled As Boolean

        Public Sub New(Name As String, Unit As String, Cost As Integer, Optional Description As String = "")
            _name = Name
            _unit = Unit
            _cost = Cost
            _desc = Description
            _enabled = True
        End Sub

        Public Property Owner() As String
            Get
                Return _owner
            End Get
            Set(value As String)
                _owner = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public Property Unit() As String
            Get
                Return _unit
            End Get
            Set(value As String)
                _unit = value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return _desc
            End Get
            Set(value As String)
                _desc = value
            End Set
        End Property

        Public Property Cost() As Integer
            Get
                Return _cost
            End Get
            Set(value As Integer)
                _cost = value
            End Set
        End Property

        Public Property AptBlip() As Blip
            Get
                Return _aptblip
            End Get
            Set(value As Blip)
                _aptblip = value
            End Set
        End Property

        Public Property GrgBlip() As Blip
            Get
                Return _grgblip
            End Get
            Set(value As Blip)
                _grgblip = value
            End Set
        End Property

        Public Property Entrance() As Vector3
            Get
                Return _entrance
            End Get
            Set(value As Vector3)
                _entrance = value
            End Set
        End Property

        Public Property Save() As Vector3
            Get
                Return _save
            End Get
            Set(value As Vector3)
                _save = value
            End Set
        End Property

        Public Property TeleportInside() As Vector3
            Get
                Return _telin
            End Get
            Set(value As Vector3)
                _telin = value
            End Set
        End Property

        Public Property TeleportOutside() As Vector3
            Get
                Return _telout
            End Get
            Set(value As Vector3)
                _telout = value
            End Set
        End Property

        Public Property ApartmentExit() As Vector3
            Get
                Return _exit
            End Get
            Set(value As Vector3)
                _exit = value
            End Set
        End Property

        Public Property Wardrobe() As Vector3
            Get
                Return _wardrobe
            End Get
            Set(value As Vector3)
                _wardrobe = value
            End Set
        End Property

        Public Property WardrobeHeading() As Single
            Get
                Return _wardrobeheading
            End Get
            Set(value As Single)
                _wardrobeheading = value
            End Set
        End Property

        Public Property GarageEntrance() As Vector3
            Get
                Return _garageent
            End Get
            Set(value As Vector3)
                _garageent = value
            End Set
        End Property

        Public Property GarageOutside() As Vector3
            Get
                Return _grgout
            End Get
            Set(value As Vector3)
                _grgout = value
            End Set
        End Property

        Public Property GarageOutHeading() As Single
            Get
                Return _grgoutheading
            End Get
            Set(value As Single)
                _grgoutheading = value
            End Set
        End Property

        Public Property CameraPosition() As Vector3
            Get
                Return _camerapos
            End Get
            Set(value As Vector3)
                _camerapos = value
            End Set
        End Property

        Public Property CameraRotation() As Vector3
            Get
                Return _camerarot
            End Get
            Set(value As Vector3)
                _camerarot = value
            End Set
        End Property

        Public Property CameraFOV() As Single
            Get
                Return _camerafov
            End Get
            Set(value As Single)
                _camerafov = value
            End Set
        End Property

        Public ReadOnly Property GarageDistance() As Single
            Get
                Return World.GetDistance(Game.Player.Character.Position, GarageEntrance)
            End Get
        End Property

        Public ReadOnly Property WardrobeDistance() As Single
            Get
                Return World.GetDistance(Game.Player.Character.Position, Wardrobe)
            End Get
        End Property

        Public ReadOnly Property EntranceDistance() As Single
            Get
                Return World.GetDistance(Game.Player.Character.Position, Entrance)
            End Get
        End Property

        Public ReadOnly Property SaveDistance() As Single
            Get
                Return World.GetDistance(Game.Player.Character.Position, Save)
            End Get
        End Property

        Public ReadOnly Property ExitDistance() As Single
            Get
                Return World.GetDistance(Game.Player.Character.Position, ApartmentExit)
            End Get
        End Property

        Public Property IsAtHome() As Boolean
            Get
                Return _isathome
            End Get
            Set(value As Boolean)
                _isathome = value
            End Set
        End Property

        Public ReadOnly Property Position() As Vector3
            Get
                Return Entrance
            End Get
        End Property

        Public ReadOnly Property IsForSale() As Boolean
            Get
                If AptBlip.Sprite = BlipSprite.SafehouseForSale Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

        Public Property Enabled() As Boolean
            Get
                Return _enabled
            End Get
            Set(value As Boolean)
                _enabled = value
            End Set
        End Property

        Public Property GaragePath() As String
            Get
                Return _grgpath
            End Get
            Set(value As String)
                _grgpath = value
            End Set
        End Property

        Public Property Interior() As Vector3
            Get
                Return _interior
            End Get
            Set(value As Vector3)
                _interior = value
            End Set
        End Property

        Public Property SaveFile() As String
            Get
                Return _savefile
            End Get
            Set(value As String)
                _savefile = value
            End Set
        End Property

        Public Property PlayerMap() As String
            Get
                Return _playermap
            End Get
            Set(value As String)
                _playermap = value
            End Set
        End Property

        Public Property IPL() As String
            Get
                Return _ipl
            End Get
            Set(value As String)
                _ipl = value
            End Set
        End Property

        Public Property LastIPL() As String
            Get
                Return _lastipl
            End Get
            Set(value As String)
                _lastipl = value
            End Set
        End Property

        Public Property ApartmentStyleCameraPosition() As Vector3
            Get
                Return _ascamerapos
            End Get
            Set(value As Vector3)
                _ascamerapos = value
            End Set
        End Property

        Public Property ApartmentStyleCameraRotation() As Vector3
            Get
                Return _ascamerarot
            End Get
            Set(value As Vector3)
                _ascamerarot = value
            End Set
        End Property

        Public Property ApartmentStyleCameraFOV() As Single
            Get
                Return _ascamerafov
            End Get
            Set(value As Single)
                _ascamerafov = value
            End Set
        End Property

        Public Property InteriorID() As Integer
            Get
                Return _interiorID
            End Get
            Set(value As Integer)
                _interiorID = value
            End Set
        End Property

        Public Shared Function GetInteriorID(interior As Vector3) As Integer
            Return Native.Function.Call(Of Integer)(Hash.GET_INTERIOR_AT_COORDS, interior.X, interior.Y, interior.Z)
        End Function

        Public Sub SetInteriorActive()
            Try
                Dim intID As Integer = Native.Function.Call(Of Integer)(Hash.GET_INTERIOR_AT_COORDS, Interior.X, Interior.Y, Interior.Z)
                Native.Function.Call(Hash._0x2CA429C029CCF247, New InputArgument() {intID})
                Native.Function.Call(Hash.SET_INTERIOR_ACTIVE, intID, True)
                Native.Function.Call(Hash.DISABLE_INTERIOR, intID, False)
                'InteriorID = intID
                If Not intID = 0 AndAlso Not SinglePlayerApartment.InteriorIDList.Contains(intID) Then SinglePlayerApartment.InteriorIDList.Add(intID)
            Catch ex As Exception
                logger.Log(ex.Message & " " & ex.StackTrace)
            End Try
        End Sub

        Public Sub Create(Apartments() As Apartment)
            Dim blipColor As INMBlipColor = INMBlipColor.White
            Dim sameOwner As Boolean = False
            Dim vacant As Boolean = False

            For Each a In Apartments
                sameOwner = (a.Owner = Apartments(0).Owner)
                If Not sameOwner Then
                    Exit For
                End If
            Next

            If sameOwner Then
                Select Case Apartments(0).Owner
                    Case "Michael"
                        blipColor = INMBlipColor.Michael
                    Case "Franklin"
                        blipColor = INMBlipColor.Franklin
                    Case "Trevor"
                        blipColor = INMBlipColor.Trevor
                    Case "Player3"
                        blipColor = INMBlipColor.Yellow
                    Case Else
                        vacant = True
                End Select
            End If

            Apartments(0).AptBlip = World.CreateBlip(Apartments(0).Entrance)
            Apartments(0).AptBlip.Color = blipColor
            Apartments(0).AptBlip.IsShortRange = True

            If vacant Then
                Apartments(0).AptBlip.Sprite = BlipSprite.SafehouseForSale
                Apartments(0).AptBlip.Name = SinglePlayerApartment.ForSale
            Else
                Apartments(0).AptBlip.Sprite = BlipSprite.Safehouse
                Apartments(0).AptBlip.Name = Apartments(0).Name
                Apartments(0).GrgBlip = World.CreateBlip(Apartments(0).GarageEntrance)
                Apartments(0).GrgBlip.Sprite = BlipSprite.Garage
                Apartments(0).GrgBlip.Color = blipColor
                Apartments(0).GrgBlip.IsShortRange = True
                Apartments(0).GrgBlip.Name = Apartments(0).Name + If(Apartments.GetUpperBound(0) = 1, Apartments(0).Unit, "") + SinglePlayerApartment.Garage
            End If
        End Sub

    End Class

    Public Class PersonalVehicle

        Private _owner As String
        Public Property Owner() As String
            Get
                Return _owner
            End Get
            Set(value As String)
                _owner = value
            End Set
        End Property

        Private _file As String
        Public Property FilePath() As String
            Get
                Return _file
            End Get
            Set(value As String)
                _file = value
            End Set
        End Property

        Private _vehicle As Vehicle
        Public Property Vehicle() As Vehicle
            Get
                Return _vehicle
            End Get
            Set(value As Vehicle)
                _vehicle = value
            End Set
        End Property

        Private _enable As Boolean
        Public Property Enable() As Boolean
            Get
                Return _enable
            End Get
            Set(value As Boolean)
                _enable = value
            End Set
        End Property

        Public ReadOnly Property Exist() As Boolean
            Get
                Return Not _file = Nothing
            End Get
        End Property

        Public Sub New()
            _enable = False
        End Sub

        Public Sub New(Owner As String, FilePath As String, ByRef Vehicle As Vehicle)
            _owner = Owner
            _file = FilePath
            _vehicle = Vehicle
            _enable = True
        End Sub

        Public Sub Delete()
            Owner = Nothing
            FilePath = Nothing
            Vehicle = Nothing
            Enable = False
        End Sub
    End Class

    Public Enum INMBlipColor
        White = 0
        Franklin = 43
        Michael = 42
        Trevor = 44
        Yellow = 66
    End Enum

    Public Class SPAVehicle
        Public Handle As Vehicle
        Public State As SPAVehicleState
    End Class

    Public Enum SPAVehicleState
        ' Fields
        Active = 1
        InGarage = 0
        Destroyed = 2
    End Enum
End Namespace
