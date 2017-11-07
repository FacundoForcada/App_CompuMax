Public Class EstadoDAO
    Public Sub llenarComboGrupo(cmb_estado As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_estado, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Estado"), "est_denom", "est_codigo")
    End Sub
End Class
