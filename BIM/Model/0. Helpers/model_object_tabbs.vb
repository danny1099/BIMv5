Imports System.ComponentModel
Imports DevExpress.XtraTab

<ToolboxItem(True)>
Public Class model_object_tabbs
    Inherits XtraTabControl


    Public Sub New()
        Me.LookAndFeel.SkinName = fn_skin_manager()
        Me.LookAndFeel.UseDefaultLookAndFeel = False
    End Sub
End Class
