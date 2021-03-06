Public Module object_data_names
    Public Enum dop
        'Consultas de las tablas catalogo del grupo general
        spSettingsGeneralSearch_Document
        spSettingsGeneralSearch_Deparment
        spSettingsGeneralSearch_Cities
        spSettingsGeneralSearch_Country
        spSettingsGeneralSearch_Dispatch
        spSettingsGeneralSearch_Genre
        spSettingsGeneralSearch_Payment
        spSettingsGeneralSearch_Quotas
        spSettingsGeneralSearch_Operator
        spSettingsGeneralSearch_Stratum
        spSettingsGeneralSearch_Version

        'Procesos para la gestión de cargos
        spEntitiesBussinesPositions_Create
        spEntitiesBussinesPositions_Edited
        spEntitiesBussinesPositions_Erased
        spEntitiesBussinesPositions_Search
        spEntitiesBussinesPositions_Viewer

        'Procesos para la gestión de canales
        spEntitiesBussinesChannel_Create
        spEntitiesBussinesChannel_Edited
        spEntitiesBussinesChannel_Erased
        spEntitiesBussinesChannel_Search
        spEntitiesBussinesChannel_Viewer

        'Procesos para la gestión de agencias
        spEntitiesBussinesAgency_Create
        spEntitiesBussinesAgency_Edited
        spEntitiesBussinesAgency_Erased
        spEntitiesBussinesAgency_Search
        spEntitiesBussinesAgency_Viewer

        'Procesos para la gestión de distribuidores 
        spEntitiesBussinesDealer_Create
        spEntitiesBussinesDealer_Edited
        spEntitiesBussinesDealer_Erased
        spEntitiesBussinesDealer_Search
        spEntitiesBussinesDealer_Viewer

        'Procedimientos para la gestión de personal
        spEntitiesBussinesPersonal_Leader

        'Procedimientos para el login de usuarios
        tracing_control_sessions_login
    End Enum
End Module
