Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class PaletoBlvd
    Inherits LowEndApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Paleto Boulevard ", "0232", 121000)
            Apartment.Name = ReadCfgValue("PaletoBlvdName", langFile)
            Apartment.Description = ReadCfgValue("PaletoBlvdDesc", langFile)
            Apartment.Entrance = New Vector3(-15.24203, 6557.372, 33.24039)
            Apartment.TeleportOutside = New Vector3(-12.83225, 6560.163, 31.97093)
            Apartment.GarageEntrance = New Vector3(-12.11096, 6563.872, 31.77629)
            Apartment.GarageOutside = New Vector3(-6.329562, 6558.033, 31.7927)
            Apartment.GarageOutHeading = 225.0206
            Apartment.CameraPosition = New Vector3(-0.02845764, 6551.444, 32.63414)
            Apartment.CameraRotation = New Vector3(7.133693, 0, 85.69931)
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\paleto_blvd\"
            Apartment.SaveFile = "PBowner"
            Apartment.PlayerMap = "PaletoBlvd"
            SettingName = "PaletoBlvd"
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
