Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class ZancudoAve
    Inherits LowEndApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Zancudo Avenue ", "140", 121000)
            Apartment.Name = ReadCfgValue("ZancudoAveName", langFile)
            Apartment.Description = ReadCfgValue("ZancudoAveDesc", langFile)
            Apartment.Entrance = New Vector3(1898.997, 3781.67, 32.87691)
            Apartment.TeleportOutside = New Vector3(1901.745, 3783.513, 32.79797)
            Apartment.GarageEntrance = New Vector3(1884.389, 3769.249, 32.68288)
            Apartment.GarageOutside = New Vector3(1887.34, 3764.256, 32.59146)
            Apartment.GarageOutHeading = 214.5068
            Apartment.CameraPosition = New Vector3(1901.893, 3758.286, 33.14275)
            Apartment.CameraRotation = New Vector3(-1.035176, 0, 30.5063)
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\zancudo_ave\"
            Apartment.SaveFile = "ZAowner"
            Apartment.PlayerMap = "ZancudoAve"
            SettingName = "ZancudoAve"
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
