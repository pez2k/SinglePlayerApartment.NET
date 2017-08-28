Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class MiltonRd2117
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Milton Road ", "2117", 608000)
            Apartment.Name = ReadCfgValue("2117Name", langFile)
            Apartment.Description = ReadCfgValue("2117Desc", langFile)
            Apartment.Entrance = New Vector3(-559.5131, 664.0349, 145.4592)
            Apartment.Save = New Vector3(-568.4787, 645.6554, 142.0576)
            Apartment.TeleportInside = New Vector3(-572.4428, 658.958, 145.8364)
            Apartment.TeleportOutside = New Vector3(-558.0556, 666.2042, 145.1311)
            Apartment.ApartmentExit = New Vector3(-571.8295, 662.1631, 145.8388)
            Apartment.Wardrobe = New Vector3(-571.277, 649.8883, 142.0322)
            Apartment.GarageEntrance = New Vector3(-555.3114, 665.145, 144.6135)
            Apartment.GarageOutside = New Vector3(-555.117, 666.15, 144.4309)
            Apartment.GarageOutHeading = 343.26
            Apartment.CameraPosition = New Vector3(-548.5573, 669.8001, 146.1121)
            Apartment.CameraRotation = New Vector3(-6.038576, 0, 124.0644)
            Apartment.WardrobeHeading = 166.0936
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\2117_milton_road\"
            Apartment.SaveFile = "2117MRowner"
            Apartment.PlayerMap = "MiltonR2117"
            Apartment.IPL = "apa_stilt_ch2_09c_ext3"
            SettingName = "2117MiltonRd"
            XmasTreeLocation = New Vector3(-574.551, 654.0375, 145.632)
            HideMapObjects = {"apa_ch2_09c_hs07", "ch2_09c_build_11_07_LOD", "CH2_09c_Emissive_07_LOD", "apa_ch2_09c_build_11_07_LOD", "ch2_09c_hs07_details", "CH2_09c_Emissive_07"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
