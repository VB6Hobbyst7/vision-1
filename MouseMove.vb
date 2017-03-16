Module MouseMove
    Public Sub Rect_MouseMove(ByVal X As Double, ByVal Y As Double)

        'Dim MouseCurXWord As Double, MouseCurYWord As Double
        Dim ROICurLTXWord As Double, ROICurLTYWord As Double
        Dim ROICurRDXWord As Double, ROICurRDYWord As Double
        Dim tempROICurLTX As Double, tempROICurLTY As Double, tempROICurRDX As Double, tempROICurRDY As Double
        Dim tempROICurLTX1 As Double, tempROICurLTY1 As Double, tempROICurRDX1 As Double, tempROICurRDY1 As Double
        MouseCurX = X
        MouseCurY = Y
        ROIIniCenX = (ROIPtsXArray(1) + ROIPtsXArray(0)) / 2
        ROIIniCenY = (ROIPtsYArray(1) + ROIPtsYArray(0)) / 2

        MouseCurXWord = (MouseCurX - ROIIniCenX) * Math.Cos(-ROICurAngle) - (MouseCurY - ROIIniCenY) * Math.Sin(-ROICurAngle)
        MouseCurYWord = (MouseCurX - ROIIniCenX) * Math.Sin(-ROICurAngle) + (MouseCurY - ROIIniCenY) * Math.Cos(-ROICurAngle)

        If (ROILTFlag = True Or ROIRTFlag = True Or ROIRDFlag = True Or ROILDFlag = True) Then
            If (MouseCurXWord < 0 And MouseCurYWord < 0) Then
                ROICurLTXWord = MouseCurXWord
                ROICurLTYWord = MouseCurYWord
                ROICurRDXWord = -MouseCurXWord
                ROICurRDYWord = -MouseCurYWord

                ROICurLTX = ROICurLTXWord * Math.Cos(-ROICurAngle) + ROICurLTYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurLTY = ROICurLTYWord * Math.Cos(-ROICurAngle) - ROICurLTXWord * Math.Sin(-ROICurAngle) + ROIIniCenY
                ROICurRDX = ROICurRDXWord * Math.Cos(-ROICurAngle) + ROICurRDYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurRDY = ROICurRDYWord * Math.Cos(-ROICurAngle) - ROICurRDXWord * Math.Sin(-ROICurAngle) + ROIIniCenY

                tempROICurLTX = ROICurLTX - ROIIniCenX
                tempROICurLTY = ROICurLTY - ROIIniCenY
                tempROICurRDX = ROICurRDX - ROIIniCenX
                tempROICurRDY = ROICurRDY - ROIIniCenY


                tempROICurLTX1 = tempROICurLTX * Math.Cos(ROICurAngle) + tempROICurLTY * Math.Sin(ROICurAngle)
                tempROICurLTY1 = tempROICurLTY * Math.Cos(ROICurAngle) - tempROICurLTX * Math.Sin(ROICurAngle)
                tempROICurRDX1 = tempROICurRDX * Math.Cos(ROICurAngle) + tempROICurRDY * Math.Sin(ROICurAngle)
                tempROICurRDY1 = tempROICurRDY * Math.Cos(ROICurAngle) - tempROICurRDX * Math.Sin(ROICurAngle)

                ROIIniLTX = tempROICurLTX1 + ROIIniCenX
                ROIIniLTY = tempROICurLTY1 + ROIIniCenY
                ROIIniRDX = tempROICurRDX1 + ROIIniCenX
                ROIIniRDY = tempROICurRDY1 + ROIIniCenY

                If (ROIIniLTX < ROIIniRDX) Then
                    ROIPtsXArray.SetValue(ROIIniLTX, 0)
                    ROIPtsXArray.SetValue(ROIIniRDX, 1)
                Else
                    ROIPtsXArray.SetValue(ROIIniLTX, 1)
                    ROIPtsXArray.SetValue(ROIIniRDX, 0)
                End If


                If (ROIIniLTY < ROIIniRDY) Then
                    ROIPtsYArray.SetValue(ROIIniLTY, 0)
                    ROIPtsYArray.SetValue(ROIIniRDY, 1)
                Else
                    ROIPtsYArray.SetValue(ROIIniLTY, 1)
                    ROIPtsYArray.SetValue(ROIIniRDY, 0)
                End If
                'ROIPtsXArray.SetValue(ROIIniLTX, 0)
                'ROIPtsYArray.SetValue(ROIIniLTY, 0)
                'ROIPtsXArray.SetValue(ROIIniRDX, 1)
                'ROIPtsYArray.SetValue(ROIIniRDY, 1)
            End If

            If (MouseCurXWord > 0 And MouseCurYWord <= 0) Then
                ROICurLTXWord = -MouseCurXWord
                ROICurLTYWord = MouseCurYWord
                ROICurRDXWord = MouseCurXWord
                ROICurRDYWord = -MouseCurYWord

                ROICurLTX = ROICurLTXWord * Math.Cos(-ROICurAngle) + ROICurLTYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurLTY = ROICurLTYWord * Math.Cos(-ROICurAngle) - ROICurLTXWord * Math.Sin(-ROICurAngle) + ROIIniCenY
                ROICurRDX = ROICurRDXWord * Math.Cos(-ROICurAngle) + ROICurRDYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurRDY = ROICurRDYWord * Math.Cos(-ROICurAngle) - ROICurRDXWord * Math.Sin(-ROICurAngle) + ROIIniCenY

                tempROICurLTX = ROICurLTX - ROIIniCenX
                tempROICurLTY = ROICurLTY - ROIIniCenY
                tempROICurRDX = ROICurRDX - ROIIniCenX
                tempROICurRDY = ROICurRDY - ROIIniCenY


                tempROICurLTX1 = tempROICurLTX * Math.Cos(ROICurAngle) + tempROICurLTY * Math.Sin(ROICurAngle)
                tempROICurLTY1 = tempROICurLTY * Math.Cos(ROICurAngle) - tempROICurLTX * Math.Sin(ROICurAngle)
                tempROICurRDX1 = tempROICurRDX * Math.Cos(ROICurAngle) + tempROICurRDY * Math.Sin(ROICurAngle)
                tempROICurRDY1 = tempROICurRDY * Math.Cos(ROICurAngle) - tempROICurRDX * Math.Sin(ROICurAngle)

                ROIIniLTX = tempROICurLTX1 + ROIIniCenX
                ROIIniLTY = tempROICurLTY1 + ROIIniCenY
                ROIIniRDX = tempROICurRDX1 + ROIIniCenX
                ROIIniRDY = tempROICurRDY1 + ROIIniCenY

                If (ROIIniLTX < ROIIniRDX) Then
                    ROIPtsXArray.SetValue(ROIIniLTX, 0)
                    ROIPtsXArray.SetValue(ROIIniRDX, 1)
                Else
                    ROIPtsXArray.SetValue(ROIIniLTX, 1)
                    ROIPtsXArray.SetValue(ROIIniRDX, 0)
                End If


                If (ROIIniLTY < ROIIniRDY) Then
                    ROIPtsYArray.SetValue(ROIIniLTY, 0)
                    ROIPtsYArray.SetValue(ROIIniRDY, 1)
                Else
                    ROIPtsYArray.SetValue(ROIIniLTY, 1)
                    ROIPtsYArray.SetValue(ROIIniRDY, 0)
                End If

                'ROIPtsXArray.SetValue(ROIIniLTX, 0)
                'ROIPtsYArray.SetValue(ROIIniLTY, 0)
                'ROIPtsXArray.SetValue(ROIIniRDX, 1)
                'ROIPtsYArray.SetValue(ROIIniRDY, 1)

            End If

            If (MouseCurXWord > 0 And MouseCurYWord > 0) Then
                ROICurLTXWord = -MouseCurXWord
                ROICurLTYWord = -MouseCurYWord
                ROICurRDXWord = MouseCurXWord
                ROICurRDYWord = MouseCurYWord

                ROICurLTX = ROICurLTXWord * Math.Cos(-ROICurAngle) + ROICurLTYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurLTY = ROICurLTYWord * Math.Cos(-ROICurAngle) - ROICurLTXWord * Math.Sin(-ROICurAngle) + ROIIniCenY
                ROICurRDX = ROICurRDXWord * Math.Cos(-ROICurAngle) + ROICurRDYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurRDY = ROICurRDYWord * Math.Cos(-ROICurAngle) - ROICurRDXWord * Math.Sin(-ROICurAngle) + ROIIniCenY

                tempROICurLTX = ROICurLTX - ROIIniCenX
                tempROICurLTY = ROICurLTY - ROIIniCenY
                tempROICurRDX = ROICurRDX - ROIIniCenX
                tempROICurRDY = ROICurRDY - ROIIniCenY


                tempROICurLTX1 = tempROICurLTX * Math.Cos(ROICurAngle) + tempROICurLTY * Math.Sin(ROICurAngle)
                tempROICurLTY1 = tempROICurLTY * Math.Cos(ROICurAngle) - tempROICurLTX * Math.Sin(ROICurAngle)
                tempROICurRDX1 = tempROICurRDX * Math.Cos(ROICurAngle) + tempROICurRDY * Math.Sin(ROICurAngle)
                tempROICurRDY1 = tempROICurRDY * Math.Cos(ROICurAngle) - tempROICurRDX * Math.Sin(ROICurAngle)

                ROIIniLTX = tempROICurLTX1 + ROIIniCenX
                ROIIniLTY = tempROICurLTY1 + ROIIniCenY
                ROIIniRDX = tempROICurRDX1 + ROIIniCenX
                ROIIniRDY = tempROICurRDY1 + ROIIniCenY


                If (ROIIniLTX < ROIIniRDX) Then
                    ROIPtsXArray.SetValue(ROIIniLTX, 0)
                    ROIPtsXArray.SetValue(ROIIniRDX, 1)
                Else
                    ROIPtsXArray.SetValue(ROIIniLTX, 1)
                    ROIPtsXArray.SetValue(ROIIniRDX, 0)
                End If


                If (ROIIniLTY < ROIIniRDY) Then
                    ROIPtsYArray.SetValue(ROIIniLTY, 0)
                    ROIPtsYArray.SetValue(ROIIniRDY, 1)
                Else
                    ROIPtsYArray.SetValue(ROIIniLTY, 1)
                    ROIPtsYArray.SetValue(ROIIniRDY, 0)
                End If
                'ROIPtsXArray.SetValue(ROIIniLTX, 0)
                'ROIPtsYArray.SetValue(ROIIniLTY, 0)
                'ROIPtsXArray.SetValue(ROIIniRDX, 1)
                'ROIPtsYArray.SetValue(ROIIniRDY, 1)

            End If

            If (MouseCurXWord < 0 And MouseCurYWord > 0) Then
                ROICurLTXWord = MouseCurXWord
                ROICurLTYWord = -MouseCurYWord
                ROICurRDXWord = -MouseCurXWord
                ROICurRDYWord = MouseCurYWord

                ROICurLTX = ROICurLTXWord * Math.Cos(-ROICurAngle) + ROICurLTYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurLTY = ROICurLTYWord * Math.Cos(-ROICurAngle) - ROICurLTXWord * Math.Sin(-ROICurAngle) + ROIIniCenY
                ROICurRDX = ROICurRDXWord * Math.Cos(-ROICurAngle) + ROICurRDYWord * Math.Sin(-ROICurAngle) + ROIIniCenX
                ROICurRDY = ROICurRDYWord * Math.Cos(-ROICurAngle) - ROICurRDXWord * Math.Sin(-ROICurAngle) + ROIIniCenY

                tempROICurLTX = ROICurLTX - ROIIniCenX
                tempROICurLTY = ROICurLTY - ROIIniCenY
                tempROICurRDX = ROICurRDX - ROIIniCenX
                tempROICurRDY = ROICurRDY - ROIIniCenY


                tempROICurLTX1 = tempROICurLTX * Math.Cos(ROICurAngle) + tempROICurLTY * Math.Sin(ROICurAngle)
                tempROICurLTY1 = tempROICurLTY * Math.Cos(ROICurAngle) - tempROICurLTX * Math.Sin(ROICurAngle)
                tempROICurRDX1 = tempROICurRDX * Math.Cos(ROICurAngle) + tempROICurRDY * Math.Sin(ROICurAngle)
                tempROICurRDY1 = tempROICurRDY * Math.Cos(ROICurAngle) - tempROICurRDX * Math.Sin(ROICurAngle)

                ROIIniLTX = tempROICurLTX1 + ROIIniCenX
                ROIIniLTY = tempROICurLTY1 + ROIIniCenY
                ROIIniRDX = tempROICurRDX1 + ROIIniCenX
                ROIIniRDY = tempROICurRDY1 + ROIIniCenY

                If (ROIIniLTX < ROIIniRDX) Then
                    ROIPtsXArray.SetValue(ROIIniLTX, 0)
                    ROIPtsXArray.SetValue(ROIIniRDX, 1)
                Else
                    ROIPtsXArray.SetValue(ROIIniLTX, 1)
                    ROIPtsXArray.SetValue(ROIIniRDX, 0)
                End If


                If (ROIIniLTY < ROIIniRDY) Then
                    ROIPtsYArray.SetValue(ROIIniLTY, 0)
                    ROIPtsYArray.SetValue(ROIIniRDY, 1)
                Else
                    ROIPtsYArray.SetValue(ROIIniLTY, 1)
                    ROIPtsYArray.SetValue(ROIIniRDY, 0)
                End If
                'ROIPtsXArray.SetValue(ROIIniLTX, 0)
                'ROIPtsYArray.SetValue(ROIIniLTY, 0)
                'ROIPtsXArray.SetValue(ROIIniRDX, 1)
                'ROIPtsYArray.SetValue(ROIIniRDY, 1)
            End If

        End If



        If (ROIRotateFlag = True) Then



            Dim tempA1 As Double, tempA2 As Double
            If (MouseCurX <> ROIIniCenX And MouseCurX > ROIIniCenX And MouseIniX > ROIIniCenX) Then
                tempA1 = (Math.Atan((MouseCurY - ROIIniCenY) / (MouseCurX - ROIIniCenX)))
                tempA2 = (Math.Atan((MouseIniY - ROIIniCenY) / (MouseIniX - ROIIniCenX)))
                tempIniRotateAngle = tempA1 - tempA2
            End If

            If (MouseCurX <> ROIIniCenX And MouseCurX < ROIIniCenX And MouseIniX > ROIIniCenX) Then
                tempA1 = (Math.Atan((MouseCurY - ROIIniCenY) / (MouseCurX - ROIIniCenX)))
                tempA2 = (Math.Atan((MouseIniY - ROIIniCenY) / (MouseIniX - ROIIniCenX)))
                tempIniRotateAngle = tempA1 - tempA2 - Math.PI
            End If

            If (MouseCurX <> ROIIniCenX And MouseCurX < ROIIniCenX And MouseIniX < ROIIniCenX) Then
                tempA1 = (Math.Atan((MouseCurY - ROIIniCenY) / (MouseCurX - ROIIniCenX)))
                tempA2 = (Math.Atan((MouseIniY - ROIIniCenY) / (MouseIniX - ROIIniCenX)))
                tempIniRotateAngle = (tempA1 - tempA2)
            End If

            If (MouseCurX <> ROIIniCenX And MouseCurX > ROIIniCenX And MouseIniX < ROIIniCenX) Then
                tempA1 = (Math.Atan((MouseCurY - ROIIniCenY) / (MouseCurX - ROIIniCenX)))
                tempA2 = (Math.Atan((MouseIniY - ROIIniCenY) / (MouseIniX - ROIIniCenX)))
                tempIniRotateAngle = Math.PI + (tempA1 - tempA2)
            End If

            If (MouseCurX = ROIIniCenX And MouseCurY < ROIIniCenY And MouseIniX > ROIIniCenX) Then
                tempA1 = (Math.PI) / 2
                tempA2 = (Math.Atan((MouseIniY - ROIIniCenY) / (MouseIniX - ROIIniCenX)))
                tempIniRotateAngle = -(tempA1 + tempA2)
            End If

            If (MouseCurX = ROIIniCenX And MouseCurY > ROIIniCenY And MouseIniX > ROIIniCenX) Then
                tempA1 = (Math.PI) / 2
                tempA2 = (Math.Atan((MouseIniY - ROIIniCenY) / (MouseIniX - ROIIniCenX)))
                tempIniRotateAngle = (tempA1 + tempA2)
            End If

            If (MouseCurX = ROIIniCenX And MouseCurY < ROIIniCenY And MouseIniX < ROIIniCenX) Then
                tempA1 = (Math.PI) / 2
                tempA2 = (Math.Atan((MouseIniY - ROIIniCenY) / (MouseIniX - ROIIniCenX)))
                tempIniRotateAngle = (tempA1 - tempA2)
            End If


        End If

    End Sub
End Module
