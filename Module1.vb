Module Module1
    Public ROIName() As String
    Public ROISelected As String
    Public pathname As String, ROItype As String
    Public startScreenState As Boolean
    '定义Rect和Spoke调整ROI使用的变量
    Public ROIFlag As Boolean
    Public ROILTFlag As Boolean, ROIRDFlag As Boolean, ROIRTFlag As Boolean, ROILDFlag As Boolean

    '圆面代表上，下，右，左四个特征点,spoke ROILTFlag为内圆上的特征点，ROIRDFlag为外圆上的特征点
    Public ROIMoveFlag As Boolean
    Public ROIRotateFlag As Boolean
    Public ROICurAngle As Double
    Public MouseCurXWord As Double, MouseCurYWord As Double
    Public ROIIniLTX As Integer, ROIIniLTY As Integer, ROIIniRDX As Integer, ROIIniRDY As Integer, ROIIniRTX As Integer, ROIIniRTY As Integer, ROIIniLDX As Integer, ROIIniLDY As Integer
    Public ROIIniCenX As Integer, ROIIniCenY As Integer, ROIIniCorX As Integer, ROIIniCorY As Integer

    Public ROICurLTX As Integer, ROICurLTY As Integer, ROICurRDX As Integer, ROICurRDY As Integer, ROICurRTX As Integer, ROICurRTY As Integer, ROICurLDX As Integer, ROICurLDY As Integer
    Public ROICurCenX As Integer, ROICurCenY As Integer, ROICurCorX As Integer, ROICurCorY As Integer

    Public ROIPtsXArray() As Integer, ROIPtsYArray() As Integer
    Public ROIAngle As Double, ROILength As Double, ROIWidth As Double
    Public MouseCurX As Integer, MouseCurY As Integer, MouseIniX As Integer, MouseIniY As Integer, MouseIniXN As Integer, MouseIniYN As Integer
    Public LTtoCenDis As Double, RDtoCenDis As Double, RTtoCenDis As Double, LDtoCenDis As Double

    Public IniCorPointX As Integer, IniCorPointY As Integer, CurCorPointX As Integer, CurCorPointY As Integer
    Public RotateAngle As Double, RotateDirection As Integer
    Public tempCorDis As Double, tempCorAngle As Double, tempAngle As Double, tempIniRotateAngle As Double, tempCurRotateAngle As Double, tempROIAngle As Double
End Module
