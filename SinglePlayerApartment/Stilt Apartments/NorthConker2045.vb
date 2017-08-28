Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class NorthConker2045
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("North Conker Avenue ", "2045", 727000)
            Apartment.Name = ReadCfgValue("2045Name", langFile)
            Apartment.Description = ReadCfgValue("2045Desc", langFile)
            Apartment.Entrance = New Vector3(373.8461, 427.7975, 145.6839)
            Apartment.Save = New Vector3(377.2632, 407.4584, 142.1256)
            Apartment.TeleportInside = New Vector3(373.2864, 420.6612, 145.9045)
            Apartment.TeleportOutside = New Vector3(371.9392, 430.4312, 145.1107)
            Apartment.ApartmentExit = New Vector3(373.7533, 423.8348, 145.9078)
            Apartment.Wardrobe = New Vector3(374.4273, 411.5888, 142.1002)
            Apartment.GarageEntrance = New Vector3(391.3488, 430.2205, 143.1705)
            Apartment.GarageOutside = New Vector3(392.482, 430.467, 143.0165)
            Apartment.GarageOutHeading = 298.54
            Apartment.CameraPosition = New Vector3(366.7971, 447.0355, 148.0793)
            Apartment.CameraRotation = New Vector3(-8.704479, -2.1593, -156.5936)
            Apartment.WardrobeHeading = 166.7329
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\2045_north_conker\"
            Apartment.SaveFile = "2045NCowner"
            Apartment.PlayerMap = "NConker2045"
            Apartment.IPL = "apa_stilt_ch2_04_ext2"
            SettingName = "2045NorthConker"
            XmasTreeLocation = New Vector3(371.0827, 415.4963, 145.7)
            HideMapObjects = {"apa_ch2_04_house01", "apa_ch2_04_house01_d", "ch2_04_emissive_05_LOD", "apa_ch2_04_M_b_LOD", "ch2_04_emissive_05", "ch2_04_house01_details"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
