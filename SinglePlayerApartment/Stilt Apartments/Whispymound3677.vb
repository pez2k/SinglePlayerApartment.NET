Imports GTA.Math
Imports System.Windows.Forms
Imports SinglePlayerApartment.SinglePlayerApartment
Imports SinglePlayerApartment.INMNative

Public Class Whispymound3677
    Inherits StiltApartment

    Public Sub New()
        Try
            Apartment = New Apartment("Whispymound Drive ", "3677", 478000)
            Apartment.Name = ReadCfgValue("3677Name", langFile)
            Apartment.Description = ReadCfgValue("3677Desc", langFile)
            Apartment.Entrance = New Vector3(119.3083, 564.0632, 183.9594)
            Apartment.Save = New Vector3(126.1813, 545.9031, 180.5226)
            Apartment.TeleportInside = New Vector3(117.5057, 557.3167, 184.3022)
            Apartment.TeleportOutside = New Vector3(118.8673, 567.283, 183.1295)
            Apartment.ApartmentExit = New Vector3(117.2371, 560.0856, 184.3048)
            Apartment.Wardrobe = New Vector3(122.0242, 548.9013, 180.4972)
            Apartment.GarageEntrance = New Vector3(131.7664, 568.0024, 183.1025)
            Apartment.GarageOutside = New Vector3(132.723, 568.142, 183.099)
            Apartment.GarageOutHeading = 335.12
            Apartment.CameraPosition = New Vector3(112.5791, 574.6387, 190.8119)
            Apartment.CameraRotation = New Vector3(-21.01317, 0, -144.2139)
            Apartment.WardrobeHeading = 182.3311
            Apartment.GaragePath = Application.StartupPath & "\scripts\SinglePlayerApartment\Garage\3677_whispymound\"
            Apartment.SaveFile = "3677WMDowner"
            Apartment.PlayerMap = "Whispy3677"
            Apartment.IPL = "apa_stilt_ch2_05c_ext1"
            SettingName = "3677Whispymound"
            XmasTreeLocation = New Vector3(117.5677, 551.5292, 184.097)
            HideMapObjects = {"apa_ch2_05c_b4", "ch2_05c_emissive_07", "ch2_05c_decals_05", "ch2_05c_B4_LOD"}
            Init()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub
End Class
