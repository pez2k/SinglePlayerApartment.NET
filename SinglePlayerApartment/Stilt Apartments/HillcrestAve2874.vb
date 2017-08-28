Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class HillcrestAve2874
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Hillcrest Avenue ", "2874", 571000)
            Apartment.Name = ReadCfgValue("2874Name", langFile)
            Apartment.Description = ReadCfgValue("2874Desc", langFile)
            Apartment.Entrance = New Vector3(-853.075, 695.4132, 148.7877)
            Apartment.Save = New Vector3(-851.2404, 677.0281, 149.0784)
            Apartment.TeleportInside = New Vector3(-859.5645, 688.7182, 152.8571)
            Apartment.TeleportOutside = New Vector3(-853.2899, 698.7006, 148.7756)
            Apartment.ApartmentExit = New Vector3(-859.9158, 691.5079, 152.8589)
            Apartment.Wardrobe = New Vector3(-855.3519, 680.0969, 149.0531)
            Apartment.GarageEntrance = New Vector3(-864.5076, 698.6345, 148.6063)
            Apartment.GarageOutside = New Vector3(-862.7094, 700.4839, 148.595)
            Apartment.GarageOutHeading = 328.02
            Apartment.CameraPosition = New Vector3(-863.697, 713.9671, 152.9681)
            Apartment.CameraRotation = New Vector3(-8.148409, 1.0781, -167.5327)
            Apartment.WardrobeHeading = 182.5082
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\2874_hillcreast_ave\"
            Apartment.SaveFile = "2874HAowner"
            Apartment.PlayerMap = "HillcrestA2874"
            Apartment.IPL = "apa_stilt_ch2_09b_ext2"
            SettingName = "2874Hillcrest"
            XmasTreeLocation = New Vector3(-859.7589, 682.8218, 152.6529)
            HideMapObjects = {"apa_ch2_09b_hs02", "apa_ch2_09b_hs02b_details", "apa_ch2_09b_Emissive_09_LOD", "ch2_09b_botpoolHouse02_LOD", "apa_ch2_09b_Emissive_09", "apa_ch2_09b_hs02_balcony"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
