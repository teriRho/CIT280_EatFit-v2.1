Public Module Globalvariables
    'Login name
    Public loginName As String
    'Basic info
    Public basic_errorflag As Boolean = False
    Public basic_name, basic_sex, basic_Gdate As String
    Public basic_age, basic_height, basic_weight, basic_BMI, basic_Gweight As Integer
    'Advanced options
    Public adv_none, adv_vegetarian, adv_vegan, adv_glutenfree As Boolean
    Public adv_peanuts, adv_treenuts, adv_soy, adv_eggs, adv_lactose, adv_wheat, adv_fish, adv_shellfish As Boolean
End Module
