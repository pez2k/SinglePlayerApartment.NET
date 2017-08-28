Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class GrapeseedAve
    Inherits LowEndApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Grapeseed Avenue ", "1893", 118000)
            Apartment.Name = ReadCfgValue("GrapeseedAveName", langFile)
            Apartment.Description = ReadCfgValue("GrapeseedAveDesc", langFile)
            Apartment.Entrance = New Vector3(1662.156, 4776.137, 42.01189)
            Apartment.TeleportOutside = New Vector3(1665.579, 4776.712, 41.93869)
            Apartment.GarageEntrance = New Vector3(1662.088, 4768.009, 41.79552)
            Apartment.GarageOutside = New Vector3(1667.8, 4768.668, 41.70086)
            Apartment.GarageOutHeading = 275.8229
            Apartment.CameraPosition = New Vector3(1683.295, 4774.074, 43.80255)
            Apartment.CameraRotation = New Vector3(-2.922752, 0, 93.5119)
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\grapeseed_ave\"
            Apartment.SaveFile = "GAowner"
            Apartment.PlayerMap = "GrapeseedAve"
            SettingName = "GrapeseedAve"
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
