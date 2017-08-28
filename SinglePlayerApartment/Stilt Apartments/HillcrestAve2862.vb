Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class HillcrestAve2862
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Hillcrest Avenue ", "2862", 705000)
            Apartment.Name = ReadCfgValue("2862Name", langFile)
            Apartment.Description = ReadCfgValue("2862Desc", langFile)
            Apartment.Entrance = New Vector3(-686.0914, 596.1551, 143.6421)
            Apartment.Save = New Vector3(-666.4602, 586.9831, 141.5956)
            Apartment.TeleportInside = New Vector3(-680.1067, 590.6495, 145.393)
            Apartment.TeleportOutside = New Vector3(-688.8965, 598.6945, 143.5084)
            Apartment.ApartmentExit = New Vector3(-682.4827, 592.6603, 145.3797)
            Apartment.Wardrobe = New Vector3(-671.645, 587.338, 141.5698)
            Apartment.GarageEntrance = New Vector3(-684.222, 602.92, 142.926)
            Apartment.GarageOutside = New Vector3(-682.2719, 605.082, 143.0796)
            Apartment.GarageOutHeading = 8.87
            Apartment.CameraPosition = New Vector3(-712.7956, 597.7189, 146.6349)
            Apartment.CameraRotation = New Vector3(-5.849331, 0, -87.56305)
            Apartment.WardrobeHeading = 213.4807
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\2862_hillcreast_ave\"
            Apartment.SaveFile = "2862HAowner"
            Apartment.PlayerMap = "HillcrestA2862"
            Apartment.IPL = "apa_stilt_ch2_09c_ext2"
            SettingName = "2862Hillcrest"
            XmasTreeLocation = New Vector3(-676.817, 587.2742, 145.1695)
            HideMapObjects = {"apa_ch2_09c_hs11", "CH2_09c_Emissive_11_LOD", "CH2_09c_Emissive_11", "apa_ch2_09c_hs11_details"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
