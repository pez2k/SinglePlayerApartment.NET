Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class NorthConker2044
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("North Conker Avenue ", "2044", 762000)
            Apartment.Name = ReadCfgValue("2044Name", langFile)
            Apartment.Description = ReadCfgValue("2044Desc", langFile)
            Apartment.Entrance = New Vector3(346.4214, 440.7363, 147.7075)
            Apartment.Save = New Vector3(332.7306, 423.6146, 145.5968)
            Apartment.TeleportInside = New Vector3(340.6531, 436.7456, 149.394)
            Apartment.TeleportOutside = New Vector3(349.893, 442.8174, 147.3472)
            Apartment.ApartmentExit = New Vector3(342.1347, 437.8865, 149.3808)
            Apartment.Wardrobe = New Vector3(334.2987, 428.6485, 145.5708)
            Apartment.GarageEntrance = New Vector3(352.814, 437.2492, 146.3828)
            Apartment.GarageOutside = New Vector3(356.54, 439.226, 145.098)
            Apartment.GarageOutHeading = 294.08
            Apartment.CameraPosition = New Vector3(347.726, 459.0123, 150.3243)
            Apartment.CameraRotation = New Vector3(-3.703, 0, 161.5176)
            Apartment.WardrobeHeading = 103.0573
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\2044_north_conker\"
            Apartment.SaveFile = "2044NCowner"
            Apartment.PlayerMap = "NConker2044"
            Apartment.IPL = "apa_stilt_ch2_04_ext1"
            SettingName = "2044NorthConker"
            XmasTreeLocation = New Vector3(335.2501, 433.802, 149.1707)
            HideMapObjects = {"apa_ch2_04_house02", "apa_ch2_04_house02_d", "apa_ch2_04_M_a_LOD", "ch2_04_house02_railings", "ch2_04_emissive_04", "ch2_04_emissive_04_LOD", "apa_ch2_04_house02_details"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
