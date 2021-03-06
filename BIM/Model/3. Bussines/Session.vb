Namespace sessions
    Public Module Session

#Region "properties"
        Public Property person_name As String
        Public Property person_code As Integer
        Public Property person_photo As Image
        Public Property agency_name As String
        Public Property agency_code As Integer
        Public Property admin_user As Integer
        Public Property city_code As Integer
        Public Property agency_permit As String
        Public Property query_permit As String
        Public Property permits_options As String
        Public Property session_code As Integer
        Public Property user_access As String
        Public Property position_name As String
        Public Property query_level As String
#End Region

#Region "methods"
        Public Function search_permission() As DataTable
            Return fn_transform_deserialize(permits_options)
        End Function
#End Region
    End Module
End Namespace

