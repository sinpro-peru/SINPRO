Public Class R_Catalogo_Marca_Modelo_Corto
    Private var As String
    Private CodFab As Boolean 'Código Fábrica
    Private CodInt As Boolean 'Código Interno
    Private Descripcion As Boolean 'Descripción
    Private Marca As Boolean
    Private Modelo As Boolean
    Private Precio As Boolean
    Private CantExist As Boolean
    Private Ubicacion As Boolean
    Private MarcaProducto As Boolean
    Private exist As Integer
    Private Empaque As Boolean
    Private order As String
    Private fuente As Integer
    Private grupo As String
    Private compra As String
    Private resgrupo As String
    Private rescompra As String
    Private Lenyenda_Visible As Boolean = False
    Private Obs_Visible As Boolean = False
    Private Obs As String = ""
    Private Leyenda As String = ""

    Public Sub valores_CatalogoModelosCorto(ByVal MarcasModelos As String, ByVal cf As Boolean, ByVal ci As Boolean, ByVal d As Boolean, ByVal mar As Boolean, ByVal mode As Boolean, ByVal Pre As Boolean, ByVal ce As Boolean, ByVal ubi As Boolean, ByVal mp As Boolean, ByVal ex As Integer, ByVal em As Boolean, ByVal ord As String, ByVal gr As String, ByVal com As String, ByVal rg As String, ByVal rc As String, ByVal lv As Boolean, ByVal ov As Boolean, ByVal leyen As String, ByVal obs As String)
        var = MarcasModelos
        CodFab = cf
        CodInt = ci
        Descripcion = d
        Marca = mar
        Modelo = mode
        Precio = Pre
        CantExist = ce
        Ubicacion = ubi
        MarcaProducto = mp
        exist = ex
        Empaque = em
        order = ord
        grupo = gr
        compra = com
        resgrupo = rg
        rescompra = rc
        Lenyenda_Visible = lv
        Obs_Visible = ov
        Me.Obs = obs
        Leyenda = leyen
    End Sub

    Private Sub R_Catalogo_Marca_Modelo_Corto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ReportViewer1.LocalReport.DisplayName = "AGSA - Listado actualizado " + Format(Now, "dd-MM-yyyy")
            Me.ReportViewer1.LocalReport.EnableExternalImages = True
            Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
            MELDataSet.EnforceConstraints = False
            Me.Sp_consultaCatalogoModelosTableAdapter.Fill(Me.MELDataSet.sp_consultaCatalogoModelos, var, exist, order, grupo, compra, resgrupo, rescompra)
            Dim misParams(13) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CodFabrica", CodFab)
            misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("CodInterno", CodInt)
            misParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("Descripcion", Descripcion)
            misParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("Marca", Marca)
            misParams(4) = New Microsoft.Reporting.WinForms.ReportParameter("Modelo", Modelo)
            misParams(5) = New Microsoft.Reporting.WinForms.ReportParameter("Precio", Precio)
            misParams(6) = New Microsoft.Reporting.WinForms.ReportParameter("CantExist", CantExist)
            misParams(7) = New Microsoft.Reporting.WinForms.ReportParameter("Ubicacion", Ubicacion)
            misParams(8) = New Microsoft.Reporting.WinForms.ReportParameter("MarcaProducto", MarcaProducto)
            misParams(9) = New Microsoft.Reporting.WinForms.ReportParameter("Empaque", Empaque)
            misParams(10) = New Microsoft.Reporting.WinForms.ReportParameter("Leyenda_Visible", Lenyenda_Visible)
            misParams(11) = New Microsoft.Reporting.WinForms.ReportParameter("Obs_Visible", Obs_Visible)
            misParams(12) = New Microsoft.Reporting.WinForms.ReportParameter("Obs", Obs)
            misParams(13) = New Microsoft.Reporting.WinForms.ReportParameter("Leyenda", Leyenda)
            Me.ReportViewer1.LocalReport.SetParameters(misParams)
            Me.ReportViewer1.ZoomPercent = 100
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class