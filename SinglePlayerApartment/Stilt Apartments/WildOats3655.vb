Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class WildOats3655
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Wild Oats Drive ", "3655", 800000)
            Apartment.Name = ReadCfgValue("3655Name", langFile)
            Apartment.Description = ReadCfgValue("3655Desc", langFile)
            Apartment.Entrance = New Vector3(-174.606, 502.6157, 137.4205)
            Apartment.Save = New Vector3(-163.1819, 484.9918, 133.8695)
            Apartment.TeleportInside = New Vector3(-173.286, 495.0179, 137.667)
            Apartment.TeleportOutside = New Vector3(-177.3793, 503.8313, 136.8531)
            Apartment.ApartmentExit = New Vector3(-174.3115, 497.8294, 137.6536)
            Apartment.Wardrobe = New Vector3(-167.5116, 487.8223, 133.8438)
            Apartment.GarageEntrance = New Vector3(-189.307, 502.66, 133.9093)
            Apartment.GarageOutside = New Vector3(-187.563, 502.25, 134.13)
            Apartment.GarageOutHeading = 332.11
            Apartment.CameraPosition = New Vector3(-198.8929, 511.1027, 136.112)
            Apartment.CameraRotation = New Vector3(4.350469, 0, -128.423)
            Apartment.WardrobeHeading = 103.0573
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\3655_wild_oats\"
            Apartment.SaveFile = "3655WODowner"
            Apartment.PlayerMap = "WildOats3655"
            Apartment.IPL = "apa_stilt_ch2_05e_ext1"
            SettingName = "3655WildOats"
            XmasTreeLocation = New Vector3(-172.3067, 490.151, 137.4436)
            HideMapObjects = {"apa_ch2_05e_res5", "apa_ch2_05e_res5_LOD"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
