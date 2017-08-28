Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class SouthRockfordDr0112
    Inherits LowEndApartment

    Public Sub New()
        Try
            Apartment = New Apartment("0112 South Rockford Drive Apt. ", "13", 80000)
            Apartment.Name = ReadCfgValue("0112SouthRockfordName", langFile)
            Apartment.Description = ReadCfgValue("0112SouthRockfordDesc", langFile)
            Apartment.Entrance = New Vector3(-812.3849, -980.3691, 14.26866)
            Apartment.TeleportOutside = New Vector3(-814.8087, -984.2986, 14.03712)
            Apartment.GarageEntrance = New Vector3(-812.1517, -954.1611, 15.22835)
            Apartment.GarageOutside = New Vector3(-822.1036, -955.2672, 15.24641)
            Apartment.GarageOutHeading = 99.68565
            Apartment.CameraPosition = New Vector3(-835.3129, -1003.118, 16.48207)
            Apartment.CameraRotation = New Vector3(3.313114, 0, -32.55415)
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\0112_south_rockford_dr\"
            Apartment.SaveFile = "0112SRDowner"
            Apartment.PlayerMap = "0112SouthRockfordDr"
            SettingName = "0112SouthRockfordDr"
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
