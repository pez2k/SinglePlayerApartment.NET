Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class MadWayne2113
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Mad Wayne Thunder Drive ", "2113", 449000)
            Apartment.Name = ReadCfgValue("2113Name", langFile)
            Apartment.Description = ReadCfgValue("2113Desc", langFile)
            Apartment.Owner = ReadCfgValue("2113MWTowner", saveFile)
            Apartment.Entrance = New Vector3(-1294.3609, 454.6022, 97.5311)
            Apartment.Save = New Vector3(-1282.3803, 434.7835, 94.1202)
            Apartment.TeleportInside = New Vector3(-1289.6389, 446.7739, 97.8989)
            Apartment.TeleportOutside = New Vector3(-1294.2279, 456.4709, 97.0794)
            Apartment.ApartmentExit = New Vector3(-1289.9187, 449.8238, 97.9025)
            Apartment.Wardrobe = New Vector3(-1286.1141, 438.157, 94.0948)
            Apartment.GarageEntrance = New Vector3(-1294.9924, 456.477, 97.0332)
            Apartment.GarageOutside = New Vector3(-1297.027, 456.455, 96.9554)
            Apartment.GarageOutHeading = 322.69
            Apartment.CameraPosition = New Vector3(-1306.412, 467.0048, 102.6207)
            Apartment.CameraRotation = New Vector3(-17.02023, 0, -141.3645)
            Apartment.WardrobeHeading = 177.5665
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\2113_mad_wayne\"
            Apartment.SaveFile = "2113MWTowner"
            Apartment.PlayerMap = "MadWayne2113"
            Apartment.IPL = "apa_stilt_ch2_12b_ext1"
            SettingName = "2113MadWayne"
            XmasTreeLocation = New Vector3(-1290.406, 441.3187, 97.6946)
            HideMapObjects = {"apa_ch2_12b_house03mc", "ch2_12b_emissive_02", "ch2_12b_house03_MC_a_LOD", "ch2_12b_emissive_02_LOD", "ch2_12b_railing_06"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
