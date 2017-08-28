Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class HillcrestAve2868
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Hillcrest Avenue ", "2868", 672000)
            Apartment.Name = ReadCfgValue("2868Name", langFile)
            Apartment.Description = ReadCfgValue("2868Desc", langFile)
            Apartment.Entrance = New Vector3(-753.2365, 620.3427, 142.7831)
            Apartment.Save = New Vector3(-769.5107, 606.3783, 140.3565)
            Apartment.TeleportInside = New Vector3(-761.0836, 617.9774, 144.1539)
            Apartment.TeleportOutside = New Vector3(-751.1387, 621.1008, 142.2527)
            Apartment.ApartmentExit = New Vector3(-758.2289, 619.0676, 144.1405)
            Apartment.Wardrobe = New Vector3(-767.4208, 611.0219, 140.3307)
            Apartment.GarageEntrance = New Vector3(-754.1208, 629.6571, 141.9053)
            Apartment.GarageOutside = New Vector3(-752.724, 625.291, 141.7961)
            Apartment.GarageOutHeading = 244.24
            Apartment.CameraPosition = New Vector3(-734.5688, 618.7574, 148.982)
            Apartment.CameraRotation = New Vector3(-16.70547, 0, 86.47249)
            Apartment.WardrobeHeading = 113.3104
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\2868_hillcreast_ave\"
            Apartment.SaveFile = "2868HAowner"
            Apartment.PlayerMap = "HillcrestA2868"
            Apartment.IPL = "apa_stilt_ch2_09b_ext3"
            SettingName = "2868Hillcrest"
            XmasTreeLocation = New Vector3(-765.5088, 615.976, 143.9306)
            HideMapObjects = {"apa_ch2_09b_hs01a_details", "apa_ch2_09b_hs01", "apa_ch2_09b_hs01_balcony", "apa_ch2_09b_Emissive_11_LOD", "apa_ch2_09b_Emissive_11", "apa_CH2_09b_House08_LOD"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
