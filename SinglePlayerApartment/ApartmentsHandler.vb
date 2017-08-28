Imports GTA

Public Class ApartmentsHandler
    Inherits Script

    Public Shared _3AltaStreet As _3AltaStreet
    Public Shared _4IntegrityWay As _4IntegrityWay
    Public Shared DelPerroHeight As DelPerroHeight
    Public Shared EclipseTower As EclipseTower
    Public Shared RichardMajestic As RichardMajestic
    Public Shared TinselTower As TinselTower
    Public Shared WeazelPlaza As WeazelPlaza
    Public Shared HillcrestAve2862 As HillcrestAve2862
    Public Shared HillcrestAve2868 As HillcrestAve2868
    Public Shared HillcrestAve2874 As HillcrestAve2874
    Public Shared MadWayne2113 As MadWayne2113
    Public Shared MiltonRd2117 As MiltonRd2117
    Public Shared NorthConker2044 As NorthConker2044
    Public Shared NorthConker2045 As NorthConker2045
    Public Shared Whispymound3677 As Whispymound3677
    Public Shared WildOats3655 As WildOats3655
    Public Shared BayCityAve As BayCityAve
    Public Shared BlvdDelPerro As BlvdDelPerro
    Public Shared CougarAve As CougarAve
    Public Shared DreamTower As DreamTower
    Public Shared HangmanAve As HangmanAve
    Public Shared LasLagunasBlvd0604 As LasLagunasBlvd0604
    Public Shared LasLagunasBlvd2143 As LasLagunasBlvd2143
    Public Shared MiltonRd0184 As MiltonRd0184
    Public Shared PowerSt As PowerSt
    Public Shared ProcopioDr4401 As ProcopioDr4401
    Public Shared ProcopioDr4584 As ProcopioDr4584
    Public Shared ProsperitySt As ProsperitySt
    Public Shared SanVitasSt As SanVitasSt
    Public Shared SouthMoMiltonDr As SouthMoMiltonDr
    Public Shared SouthRockfordDrive0325 As SouthRockfordDrive0325
    Public Shared SpanishAve As SpanishAve
    Public Shared SustanciaRd As SustanciaRd
    Public Shared TheRoyale As TheRoyale
    Public Shared GrapeseedAve As GrapeseedAve
    Public Shared PaletoBlvd As PaletoBlvd
    Public Shared SouthRockfordDr0112 As SouthRockfordDr0112
    Public Shared VespucciBlvd As VespucciBlvd
    Public Shared ZancudoAve As ZancudoAve

    Public Sub New()
        _3AltaStreet = New _3AltaStreet()
        _4IntegrityWay = New _4IntegrityWay()
        DelPerroHeight = New DelPerroHeight()
        EclipseTower = New EclipseTower()
        RichardMajestic = New RichardMajestic()
        TinselTower = New TinselTower()
        WeazelPlaza = New WeazelPlaza()
        HillcrestAve2862 = New HillcrestAve2862()
        HillcrestAve2868 = New HillcrestAve2868()
        HillcrestAve2874 = New HillcrestAve2874()
        MadWayne2113 = New MadWayne2113()
        MiltonRd2117 = New MiltonRd2117()
        NorthConker2044 = New NorthConker2044()
        NorthConker2045 = New NorthConker2045()
        Whispymound3677 = New Whispymound3677()
        WildOats3655 = New WildOats3655()
        BayCityAve = New BayCityAve()
        BlvdDelPerro = New BlvdDelPerro()
        CougarAve = New CougarAve()
        DreamTower = New DreamTower()
        HangmanAve = New HangmanAve()
        LasLagunasBlvd0604 = New LasLagunasBlvd0604()
        LasLagunasBlvd2143 = New LasLagunasBlvd2143()
        MiltonRd0184 = New MiltonRd0184()
        PowerSt = New PowerSt()
        ProcopioDr4401 = New ProcopioDr4401()
        ProcopioDr4584 = New ProcopioDr4584()
        ProsperitySt = New ProsperitySt()
        SanVitasSt = New SanVitasSt()
        SouthMoMiltonDr = New SouthMoMiltonDr()
        SouthRockfordDrive0325 = New SouthRockfordDrive0325()
        SpanishAve = New SpanishAve()
        SustanciaRd = New SustanciaRd()
        TheRoyale = New TheRoyale()
        GrapeseedAve = New GrapeseedAve()
        PaletoBlvd = New PaletoBlvd()
        SouthRockfordDr0112 = New SouthRockfordDr0112()
        VespucciBlvd = New VespucciBlvd()
        ZancudoAve = New ZancudoAve()
    End Sub

    Public Sub OnTick(o As Object, e As EventArgs) Handles Me.Tick
        Try
            'High End Apartments
            _3AltaStreet.OnTick()
            _4IntegrityWay.OnTick()
            DelPerroHeight.OnTick()
            EclipseTower.OnTick()
            RichardMajestic.OnTick()
            TinselTower.OnTick()
            WeazelPlaza.OnTick()

            'Stilts Apartment
            HillcrestAve2862.OnTick()
            HillcrestAve2868.OnTick()
            HillcrestAve2874.OnTick()
            MadWayne2113.OnTick()
            MiltonRd2117.OnTick()
            NorthConker2044.OnTick()
            NorthConker2045.OnTick()
            Whispymound3677.OnTick()
            WildOats3655.OnTick()

            'Medium Range Apartment
            BayCityAve.OnTick()
            BlvdDelPerro.OnTick()
            CougarAve.OnTick()
            DreamTower.OnTick()
            HangmanAve.OnTick()
            LasLagunasBlvd0604.OnTick()
            LasLagunasBlvd2143.OnTick()
            MiltonRd0184.OnTick()
            PowerSt.OnTick()
            ProcopioDr4401.OnTick()
            ProcopioDr4584.OnTick()
            ProsperitySt.OnTick()
            SanVitasSt.OnTick()
            SouthMoMiltonDr.OnTick()
            SouthRockfordDrive0325.OnTick()
            SpanishAve.OnTick()
            SustanciaRd.OnTick()
            TheRoyale.OnTick()

            'Low Range Apartment
            GrapeseedAve.OnTick()
            PaletoBlvd.OnTick()
            SouthRockfordDr0112.OnTick()
            VespucciBlvd.OnTick()
            ZancudoAve.OnTick()
        Catch ex As Exception
            logger.Log(ex.Message & " " & ex.StackTrace)
        End Try
    End Sub

    Public Sub OnAborted() Handles MyBase.Aborted
        'High End Apartments
        _3AltaStreet.OnAborted()
        _4IntegrityWay.OnAborted()
        DelPerroHeight.OnAborted()
        EclipseTower.OnAborted()
        RichardMajestic.OnAborted()
        TinselTower.OnAborted()
        WeazelPlaza.OnAborted()

        'Stilts Apartment
        HillcrestAve2862.OnAborted()
        HillcrestAve2868.OnAborted()
        HillcrestAve2874.OnAborted()
        MadWayne2113.OnAborted()
        MiltonRd2117.OnAborted()
        NorthConker2044.OnAborted()
        NorthConker2045.OnAborted()
        Whispymound3677.OnAborted()
        WildOats3655.OnAborted()

        'Medium Range Apartment
        BayCityAve.OnAborted()
        BlvdDelPerro.OnAborted()
        CougarAve.OnAborted()
        DreamTower.OnAborted()
        HangmanAve.OnAborted()
        LasLagunasBlvd0604.OnAborted()
        LasLagunasBlvd2143.OnAborted()
        MiltonRd0184.OnAborted()
        PowerSt.OnAborted()
        ProcopioDr4401.OnAborted()
        ProcopioDr4584.OnAborted()
        ProsperitySt.OnAborted()
        SanVitasSt.OnAborted()
        SouthMoMiltonDr.OnAborted()
        SouthRockfordDrive0325.OnAborted()
        SpanishAve.OnAborted()
        SustanciaRd.OnAborted()
        TheRoyale.OnAborted()

        'Low Range Apartment
        GrapeseedAve.OnAborted()
        PaletoBlvd.OnAborted()
        SouthRockfordDr0112.OnAborted()
        VespucciBlvd.OnAborted()
        ZancudoAve.OnAborted()
    End Sub

    Public Shared Sub HideBlips()
        HillcrestAve2862.HideBlips()
        HillcrestAve2868.HideBlips()
        HillcrestAve2874.HideBlips()
        MadWayne2113.HideBlips()
        MiltonRd2117.HideBlips()
        NorthConker2044.HideBlips()
        NorthConker2045.HideBlips()
        Whispymound3677.HideBlips()
        WildOats3655.HideBlips()
    End Sub

    Public Shared Sub ShowBlips()
        HillcrestAve2862.ShowBlips()
        HillcrestAve2868.ShowBlips()
        HillcrestAve2874.ShowBlips()
        MadWayne2113.ShowBlips()
        MiltonRd2117.ShowBlips()
        NorthConker2044.ShowBlips()
        NorthConker2045.ShowBlips()
        Whispymound3677.ShowBlips()
        WildOats3655.ShowBlips()
    End Sub
End Class
