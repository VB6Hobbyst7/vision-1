Module ROIChoose
    Public Sub Rect_LButtonClick(ByVal X As Double, ByVal Y As Double)
        Dim tempLTDis As Double, tempRTDis As Double, tempRDDis As Double, tempLDDis As Double
        Dim tempA1 As Double, tempA2 As Double, tempA3 As Double, tempA4 As Double, tempAall As Double
        Dim tempROICurLTX1 As Double, tempROICurLTY1 As Double, tempROICurRTX1 As Double, tempROICurRTY1 As Double
        Dim tempROICurRDX1 As Double, tempROICurRDY1 As Double, tempROICurLDX1 As Double, tempROICurLDY1 As Double
        Dim tempROICurLTX2 As Double, tempROICurLTY2 As Double, tempROICurRTX2 As Double, tempROICurRTY2 As Double
        Dim tempROICurRDX2 As Double, tempROICurRDY2 As Double, tempROICurLDX2 As Double, tempROICurLDY2 As Double
        Dim tempIniCorPointX1 As Double, tempIniCorPointY1 As Double, tempIniCorPointX2 As Double, tempIniCorPointY2 As Double
        ROILength = ROIPtsXArray(1) - ROIPtsXArray(0)
        ROIWidth = ROIPtsYArray(1) - ROIPtsYArray(0)
        ROIIniCenX = (ROIPtsXArray(1) + ROIPtsXArray(0)) / 2
        ROIIniCenY = (ROIPtsYArray(1) + ROIPtsYArray(0)) / 2
        '获取鼠标的当前位置
        MouseIniX = X
        MouseIniY = Y

        '计算ROI初始位置4个角点坐标
        ROIIniLTX = ROIPtsXArray(0)
        ROIIniLTY = ROIPtsYArray(0)
        ROIIniRTX = ROIPtsXArray(1)
        ROIIniRTY = ROIPtsYArray(0)
        ROIIniRDX = ROIPtsXArray(1)
        ROIIniRDY = ROIPtsYArray(1)
        ROIIniLDX = ROIPtsXArray(0)
        ROIIniLDY = ROIPtsYArray(1)

        tempROICurLTX1 = ROIIniLTX - ROIIniCenX
        tempROICurLTY1 = ROIIniLTY - ROIIniCenY
        tempROICurRTX1 = ROIIniRTX - ROIIniCenX
        tempROICurRTY1 = ROIIniRTY - ROIIniCenY
        tempROICurRDX1 = ROIIniRDX - ROIIniCenX
        tempROICurRDY1 = ROIIniRDY - ROIIniCenY
        tempROICurLDX1 = ROIIniLDX - ROIIniCenX
        tempROICurLDY1 = ROIIniLDY - ROIIniCenY

        tempROICurLTX2 = tempROICurLTX1 * Math.Cos(-ROICurAngle) + tempROICurLTY1 * Math.Sin(-ROICurAngle)
        tempROICurLTY2 = tempROICurLTY1 * Math.Cos(-ROICurAngle) - tempROICurLTX1 * Math.Sin(-ROICurAngle)
        tempROICurRTX2 = tempROICurRTX1 * Math.Cos(-ROICurAngle) + tempROICurRTY1 * Math.Sin(-ROICurAngle)
        tempROICurRTY2 = tempROICurRTY1 * Math.Cos(-ROICurAngle) - tempROICurRTX1 * Math.Sin(-ROICurAngle)
        tempROICurRDX2 = tempROICurRDX1 * Math.Cos(-ROICurAngle) + tempROICurRDY1 * Math.Sin(-ROICurAngle)
        tempROICurRDY2 = tempROICurRDY1 * Math.Cos(-ROICurAngle) - tempROICurRDX1 * Math.Sin(-ROICurAngle)
        tempROICurLDX2 = tempROICurLDX1 * Math.Cos(-ROICurAngle) + tempROICurLDY1 * Math.Sin(-ROICurAngle)
        tempROICurLDY2 = tempROICurLDY1 * Math.Cos(-ROICurAngle) - tempROICurLDX1 * Math.Sin(-ROICurAngle)

        ROICurLTX = tempROICurLTX2 + ROIIniCenX
        ROICurLTY = tempROICurLTY2 + ROIIniCenY
        ROICurRTX = tempROICurRTX2 + ROIIniCenX
        ROICurRTY = tempROICurRTY2 + ROIIniCenY
        ROICurRDX = tempROICurRDX2 + ROIIniCenX
        ROICurRDY = tempROICurRDY2 + ROIIniCenY
        ROICurLDX = tempROICurLDX2 + ROIIniCenX
        ROICurLDY = tempROICurLDY2 + ROIIniCenY


        '计算鼠标位置距离4个角点的距离
        tempLTDis = Math.Sqrt(Math.Pow((X - ROICurLTX), 2) + Math.Pow((Y - ROICurLTY), 2))
        tempRTDis = Math.Sqrt(Math.Pow((X - ROICurRTX), 2) + Math.Pow((Y - ROICurRTY), 2))
        tempRDDis = Math.Sqrt(Math.Pow((X - ROICurRDX), 2) + Math.Pow((Y - ROICurRDY), 2))
        tempLDDis = Math.Sqrt(Math.Pow((X - ROICurLDX), 2) + Math.Pow((Y - ROICurLDY), 2))

        '计算鼠标位置距离4个角点的夹角
        tempA1 = Math.Acos((Math.Pow(tempLTDis, 2) + Math.Pow(tempRTDis, 2) - Math.Pow(ROILength, 2)) / (2 * tempLTDis * tempRTDis))
        tempA2 = Math.Acos((Math.Pow(tempRTDis, 2) + Math.Pow(tempRDDis, 2) - Math.Pow(ROIWidth, 2)) / (2 * tempRTDis * tempRDDis))
        tempA3 = Math.Acos((Math.Pow(tempRDDis, 2) + Math.Pow(tempLDDis, 2) - Math.Pow(ROILength, 2)) / (2 * tempRDDis * tempLDDis))
        tempA4 = Math.Acos((Math.Pow(tempLTDis, 2) + Math.Pow(tempLDDis, 2) - Math.Pow(ROIWidth, 2)) / (2 * tempLTDis * tempLDDis))
        tempAall = tempA1 + tempA2 + tempA3 + tempA4

        '计算初始矩形的旋转定位点的位置
        IniCorPointX = ROIPtsXArray(1) + 15
        IniCorPointY = ROIPtsYArray(0) - 15


        tempIniCorPointX1 = IniCorPointX - ROIIniCenX
        tempIniCorPointY1 = IniCorPointY - ROIIniCenY

        tempIniCorPointX2 = tempIniCorPointX1 * Math.Cos(-ROICurAngle) + tempIniCorPointY1 * Math.Sin(-ROICurAngle)
        tempIniCorPointY2 = tempIniCorPointY1 * Math.Cos(-ROICurAngle) - tempIniCorPointX1 * Math.Sin(-ROICurAngle)

        CurCorPointX = tempIniCorPointX2 + ROIIniCenX
        CurCorPointY = tempIniCorPointY2 + ROIIniCenY


        If (Math.Abs(X - ROICurLTX) < 4 And Math.Abs(Y - ROICurLTY) < 4) Then
            ROILTFlag = True
        Else
            ROILTFlag = False
        End If

        If (Math.Abs(X - ROICurRDX) < 4 And Math.Abs(Y - ROICurRDY) < 4) Then
            ROIRDFlag = True
        Else
            ROIRDFlag = False
        End If

        If (Math.Abs(X - ROICurRTX) < 4 And Math.Abs(Y - ROICurRTY) < 4) Then
            ROIRTFlag = True
        Else
            ROIRTFlag = False
        End If

        If (Math.Abs(X - ROICurLDX) < 4 And Math.Abs(Y - ROICurLDY) < 4) Then
            ROILDFlag = True
        Else
            ROILDFlag = False
        End If

        If (Math.Abs(tempAall - 2 * Math.PI) < 0.2 And ROILTFlag = False And ROIRDFlag = False And ROIRTFlag = False And ROILDFlag = False) Then
            ROIMoveFlag = True
        Else
            ROIMoveFlag = False
        End If

        If (Math.Abs(Int(X) - CurCorPointX) <= 5 And Math.Abs(Int(Y) - CurCorPointY) <= 5) Then
            ROIRotateFlag = True

        Else
            ROIRotateFlag = False
        End If

    End Sub
End Module
