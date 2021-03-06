Public Module object_data_names
    Public Enum dop
        'Procedimientos para el grupo general
        settings_general_search_deptos
        settings_general_search_cities
        settings_general_search_country
        settings_general_search_genre
        settings_general_search_docs

        'Procedimientos del grupo Agencias
        entities_bussines_agency_search
        entities_bussines_agency_showed
        entities_bussines_agency_erased

        'Procedimientos para el login de usuarios
        tracing_control_sessions_login

        'Procedimientos para la administración de personal
        entities_workforce_password_create
        entities_workforce_persons_showed
        entities_workforce_persons_search
        entities_workforce_persons_sellers
        entities_workforce_persons_listed
        entities_workforce_persons_leaders
        entities_workforce_persons_erased

        'Procedimientos para la consulta de clientes
        relationship_customer_person_created
        relationship_customer_person_edited
        relationship_customer_person_showed
        relationship_customer_person_search
        relationship_customer_person_sources
        relationship_customer_person_listed
        relationship_customer_knowledge_search
    End Enum
End Module
