Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class VespucciBlvd
    Inherits LowEndApartment

    Public Sub New()
        Try
            Apartment = New Apartment("2057 Vespucci Boulevard Apt. ", "1", 87000)
            Apartment.Name = ReadCfgValue("VespucciName", langFile)
            Apartment.Description = ReadCfgValue("VespucciDesc", langFile)
            Apartment.Entrance = New Vector3(-662.4664, -854.2357, 24.4628)
            Apartment.TeleportOutside = New Vector3(-662.6467, -851.4024, 24.4296)
            Apartment.GarageEntrance = New Vector3(-667.7385, -853.5117, 23.84)
            Apartment.GarageOutside = New Vector3(-667.6065, -849.4223, 23.8855)
            Apartment.GarageOutHeading = 358.19
            Apartment.CameraPosition = New Vector3(-644.9753, -820.6812, 33.11289)
            Apartment.CameraRotation = New Vector3(5.2089, -2.1432, 152.9055)
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\vespucci_blvd\"
            Apartment.SaveFile = "VPBowner"
            Apartment.PlayerMap = "VespucciBlvd"
            SettingName = "VespucciBlvd"
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
