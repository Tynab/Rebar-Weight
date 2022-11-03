Imports System.Environment
Imports System.Environment.SpecialFolder

Friend Module Constant
    Friend Const M_BNDG_RATE = 1.03
    Friend Const DEN_IRON = 7.874
    Friend Const L_MAX = 5500
    Friend ReadOnly FILE_SETUP_NAME = $"{My.Resources.app_name} Setup.msi"
    Friend ReadOnly BACK_PATH = GetFolderPath(ApplicationData)
    Friend ReadOnly FRNT_PATH = $"{BACK_PATH}\{My.Resources.co_name}"
    Friend ReadOnly FILE_SETUP_ADR = $"{FRNT_PATH}\{FILE_SETUP_NAME}"
    Friend ReadOnly ARR_RAW_WOOD() = {3500, 4000, 4500, 5000, 5500}
    Friend ReadOnly ARR_D_LOCK() = {10, 13, 16, 19, 22, 25, 29, 32, 35, 38, 41, 51}
    Friend ReadOnly M_SFC_D_LOCK = New Dictionary(Of Integer, Double) From
        {{10, 0.56},
        {13, 1},
        {16, 1.56},
        {19, 2.25},
        {22, 3.04},
        {25, 3.98},
        {29, 5.04},
        {32, 6.23},
        {35, 7.51},
        {38, 8.95},
        {41, 10.5},
        {51, 15.9}}
End Module
