Public Class Form1
    Private dinero, vuelta, maximo, posicion, dif, dif2, conteo, conteo2, precio, propiedadesj1, propiedadesj2, turno, dinero2, vuelta2, posicion2, valor1, valor2, casa1, casa2 As Integer



    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        casa1 = Val(Propiedades1.Text) * 100
        valor1 = casa1 + Val(TextBox4.Text)
        casa2 = Val(Propiedades2.Text) * 100
        valor2 = casa2 + Val(TextBox7.Text)
        If valor1 > valor2 Then
            My.Computer.Audio.Play(My.Resources.golden_time_sad_song, AudioPlayMode.Background)
            MsgBox("El ganador es el jugador 1 con un valor total  de : " & valor1 & vbNewLine & "Patrimonio jugador 1   " & valor1 & vbNewLine & "Patrimonio jugador 2  " & valor2)
            PictureBox2.Enabled = False
            PictureBox2.Visible = False
        ElseIf valor2 > valor1 Then
            My.Computer.Audio.Play(My.Resources.golden_time_sad_song, AudioPlayMode.Background)
            MsgBox("El ganador es el jugador 2 con un valor total de : " & valor2 & vbNewLine & "Patrimonio jugador 1   " & valor1 & vbNewLine & "Patrimonio jugador 2  " & valor2)
            PictureBox2.Enabled = False
            PictureBox2.Visible = False
        ElseIf dinero = dinero2 Then
            My.Computer.Audio.Play(My.Resources.golden_time_sad_song, AudioPlayMode.Background)
            MsgBox("Este juego es un empate" & vbNewLine & "Patrimonio jugador 1  " & valor1 & vbNewLine & "Patrimonio jugador 2  " & valor2)
            PictureBox2.Enabled = False
            PictureBox2.Visible = False
        End If
        MsgBox("¡El juego ha terminado!.¡Gracias por jugar! ")
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Dim decision, imagen As String
    Dim dado, dado2, bolsa, cupones As Integer
    Private fichas() As PowerPacks.OvalShape
    Private fichas2() As PowerPacks.OvalShape

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(My.Resources.Dice_Roll_064fcfd5_b570_3f22_9b53_5b126d2b0925, AudioPlayMode.Background)
        imagen = Application.StartupPath & "/bancopoly1"
        If turno = 1 Then


            For Me.conteo = 0 To 39
                Me.fichas(conteo).Visible = False
            Next

            Randomize()
            dado = Int(Rnd() * 6) + 1
            TextBox1.Text = dado
            posicion = posicion + dado
            If posicion <= 40 Then
                Me.fichas(posicion - 1).Visible = True
                TextBox2.Text = posicion
            Else
                dif = posicion - 40
                posicion = dif
                Me.fichas(posicion - 1).Visible = True
                TextBox2.Text = posicion
                vuelta = vuelta + 1
                TextBox3.Text = vuelta
                dinero = dinero + 200
                TextBox4.Text = dinero
                TextBox2.Text = posicion
            End If
            bolsa = Int(Rnd() * 9) + 1
            If TextBox2.Text = 16 Then
                If bolsa = 1 Then
                    MsgBox("Cobre Q180 por intereses ganados por sus bonos de retalizacion fiscal")
                    dinero = dinero + 180
                    TextBox4.Text = dinero
                End If
                If bolsa = 2 Then
                    MsgBox("¡Le toco el cuchubal! cobre Q50")
                    dinero = dinero + 50
                    TextBox4.Text = dinero
                End If
                If bolsa = 3 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                If bolsa = 4 Then
                    MsgBox("Cobre Q60 por utilidades en la venta de sus productos en la feria de la localidad")
                    dinero = dinero + 60
                    TextBox4.Text = dinero
                End If
                If bolsa = 5 Then
                    MsgBox("Suspendido por enfermedad. Recive Q145 de parte del IGSS")
                    dinero = dinero + 145
                    TextBox4.Text = dinero
                End If
                If bolsa = 6 Then
                    MsgBox("Se gano la loteria. Cobre Q55 del Bancopoly")
                    dinero = dinero + 55
                    TextBox4.Text = dinero
                End If
                If bolsa = 7 Then
                    MsgBox("Cobra Q125 por intereses de su cuenta de ahorros en el Bancopoly")
                    dinero = dinero + 125
                    TextBox4.Text = dinero
                End If
                If bolsa = 8 Then
                    MsgBox("¡Vayase hasta Escuintla! No pague nada y cobre Q200 por costos del paseo")
                    For Me.conteo = 0 To 39
                        Me.fichas(conteo).Visible = False
                    Next

                    posicion = 18
                    Me.fichas(posicion - 1).Visible = True
                    TextBox2.Text = posicion
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                If bolsa = 9 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                '2do If 32
            ElseIf TextBox2.Text = 32 Then
                If bolsa = 1 Then
                    MsgBox("Cobre Q180 por intereses ganados por sus bonos de retalizacion fiscal")
                    dinero = dinero + 180
                    TextBox4.Text = dinero
                End If
                If bolsa = 2 Then
                    MsgBox("¡Le toco el cuchubal! cobre Q50")
                    dinero = dinero + 50
                    TextBox4.Text = dinero
                End If
                If bolsa = 3 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                If bolsa = 4 Then
                    MsgBox("Cobre Q60 por utilidades en la venta de sus productos en la feria de la localidad")
                    dinero = dinero + 60
                    TextBox4.Text = dinero
                End If
                If bolsa = 5 Then
                    MsgBox("Suspendido por enfermedad. Recive Q145 de parte del IGSS")
                    dinero = dinero + 145
                    TextBox4.Text = dinero
                End If
                If bolsa = 6 Then
                    MsgBox("Se gano la loteria. Cobre Q55 del Bancopoly")
                    dinero = dinero + 55
                    TextBox4.Text = dinero
                End If
                If bolsa = 7 Then
                    MsgBox("Cobra Q125 por intereses de su cuenta de ahorros en el Bancopoly")
                    dinero = dinero + 125
                    TextBox4.Text = dinero
                End If
                If bolsa = 8 Then
                    MsgBox("¡Vayase hasta Escuintla! No pague nada y cobre Q200 por costos del paseo")
                    For Me.conteo = 0 To 39
                        Me.fichas(conteo).Visible = False
                    Next

                    posicion = 18
                    Me.fichas(posicion - 1).Visible = True
                    TextBox2.Text = posicion
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                If bolsa = 9 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                '3er if 40
            ElseIf TextBox2.Text = 40 Then
                If bolsa = 1 Then
                    MsgBox("Cobre Q180 por intereses ganados por sus bonos de retalizacion fiscal")
                    dinero = dinero + 180
                    TextBox4.Text = dinero
                End If
                If bolsa = 2 Then
                    MsgBox("¡Le toco el cuchubal! cobre Q50")
                    dinero = dinero + 50
                    TextBox4.Text = dinero
                End If
                If bolsa = 3 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                If bolsa = 4 Then
                    MsgBox("Cobre Q60 por utilidades en la venta de sus productos en la feria de la localidad")
                    dinero = dinero + 60
                    TextBox4.Text = dinero
                End If
                If bolsa = 5 Then
                    MsgBox("Suspendido por enfermedad. Recive Q145 de parte del IGSS")
                    dinero = dinero + 145
                    TextBox4.Text = dinero
                End If
                If bolsa = 6 Then
                    MsgBox("Se gano la loteria. Cobre Q55 del Bancopoly")
                    dinero = dinero + 55
                    TextBox4.Text = dinero
                End If
                If bolsa = 7 Then
                    MsgBox("Cobra Q125 por intereses de su cuenta de ahorros en el Bancopoly")
                    dinero = dinero + 125
                    TextBox4.Text = dinero
                End If
                If bolsa = 8 Then
                    MsgBox("¡Vayase hasta Escuintla! No pague nada y cobre Q200 por costos del paseo")
                    For Me.conteo = 0 To 39
                        Me.fichas(conteo).Visible = False
                    Next

                    posicion = 18
                    Me.fichas(posicion - 1).Visible = True
                    TextBox2.Text = posicion
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If
                If bolsa = 9 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                End If

            End If
            'cupones.....................................................................................................................................................
            '...........................................................................................................................................................
            cupones = Int(Rnd() * 9) + 1
            If TextBox2.Text = 6 Then
                If cupones = 1 Then
                    MsgBox("Pague Q50 por ajustes en combustible y energia comprada")
                    dinero = dinero - 50
                    TextBox4.Text = dinero
                End If
                If cupones = 2 Then
                    MsgBox("Pague Q20 de impuesto para señalizacion, semaforos, bacheo y adoquinamiento")
                    dinero = dinero - 20
                    TextBox4.Text = dinero
                End If
                If cupones = 3 Then
                    MsgBox("Pague Q100 al Bancopoly. Impuesto y multa por atraso en pago de planillas del IGGS")
                    dinero = dinero - 100
                    TextBox4.Text = dinero
                End If
                If cupones = 4 Then
                    MsgBox("Introduccion de agua potable y electrificacion. Pague Q150 al bancopoly")
                    dinero = dinero - 150
                    TextBox4.Text = dinero
                End If
                If cupones = 5 Then
                    MsgBox("Exceso por consumo de agua potable. Pague Q50 al bancopoly")
                    dinero = dinero - 50
                    TextBox4.Text = dinero
                End If
                If cupones = 6 Then
                    MsgBox("Auto avaluo. Pague Q30")
                    dinero = dinero - 30
                    TextBox4.Text = dinero
                End If
                If cupones = 7 Then
                    MsgBox("Pague Q150 multa por presentacion extemporanea de declaracion impuesto sobre la renta")
                    dinero = dinero - 150
                    TextBox4.Text = dinero
                End If
                If cupones = 8 Then
                    MsgBox("Feria de la localidad, pague Q25 por contribucion para cohetillos, marimba y baile de Moros")
                    dinero = dinero - 25
                    TextBox4.Text = dinero
                End If
                If cupones = 9 Then
                    MsgBox("Se emitieron ordenes de corte para sus lineas telefonicas. Pague Q100 para evitar la suspencion del servicio")
                    dinero = dinero - 100
                    TextBox4.Text = dinero
                End If
            ElseIf TextBox2.Text = 20 Then
                If cupones = 1 Then
                    MsgBox("Pague Q50 por ajustes en combustible y energia comprada")
                    dinero = dinero - 50
                    TextBox4.Text = dinero
                End If
                If cupones = 2 Then
                    MsgBox("Pague Q20 de impuesto para señalizacion, semaforos, bacheo y adoquinamiento")
                    dinero = dinero - 20
                    TextBox4.Text = dinero
                End If
                If cupones = 3 Then
                    MsgBox("Pague Q100 al Bancopoly. Impuesto y multa por atraso en pago de planillas del IGGS")
                    dinero = dinero - 100
                    TextBox4.Text = dinero
                End If
                If cupones = 4 Then
                    MsgBox("Introduccion de agua potable y electrificacion. Pague Q150 al bancopoly")
                    dinero = dinero - 150
                    TextBox4.Text = dinero
                End If
                If cupones = 5 Then
                    MsgBox("Exceso por consumo de agua potable. Pague Q50 al bancopoly")
                    dinero = dinero - 50
                    TextBox4.Text = dinero
                End If
                If cupones = 6 Then
                    MsgBox("Auto avaluo. Pague Q30")
                    dinero = dinero - 30
                    TextBox4.Text = dinero
                End If
                If cupones = 7 Then
                    MsgBox("Pague Q150 multa por presentacion extemporanea de declaracion impuesto sobre la renta")
                    dinero = dinero - 150
                    TextBox4.Text = dinero
                End If
                If cupones = 8 Then
                    MsgBox("Feria de la localidad, pague Q25 por contribucion para cohetillos, marimba y baile de Moros")
                    dinero = dinero - 25
                    TextBox4.Text = dinero
                End If
                If cupones = 9 Then
                    MsgBox("Se emitieron ordenes de corte para sus lineas telefonicas. Pague Q100 para evitar la suspencion del servicio")
                    dinero = dinero - 100
                    TextBox4.Text = dinero
                End If
            ElseIf TextBox2.Text = 35 Then
                If cupones = 1 Then
                    MsgBox("Pague Q50 por ajustes en combustible y energia comprada")
                    dinero = dinero - 50
                    TextBox4.Text = dinero
                End If
                If cupones = 2 Then
                    MsgBox("Pague Q20 de impuesto para señalizacion, semaforos, bacheo y adoquinamiento")
                    dinero = dinero - 20
                    TextBox4.Text = dinero
                End If
                If cupones = 3 Then
                    MsgBox("Pague Q100 al Bancopoly. Impuesto y multa por atraso en pago de planillas del IGGS")
                    dinero = dinero - 100
                    TextBox4.Text = dinero
                End If
                If cupones = 4 Then
                    MsgBox("Introduccion de agua potable y electrificacion. Pague Q150 al bancopoly")
                    dinero = dinero - 150
                    TextBox4.Text = dinero
                End If
                If cupones = 5 Then
                    MsgBox("Exceso por consumo de agua potable. Pague Q50 al bancopoly")
                    dinero = dinero - 50
                    TextBox4.Text = dinero
                End If
                If cupones = 6 Then
                    MsgBox("Auto avaluo. Pague Q30")
                    dinero = dinero - 30
                    TextBox4.Text = dinero
                End If
                If cupones = 7 Then
                    MsgBox("Pague Q150 multa por presentacion extemporanea de declaracion impuesto sobre la renta")
                    dinero = dinero - 150
                    TextBox4.Text = dinero
                End If
                If cupones = 8 Then
                    MsgBox("Feria de la localidad, pague Q25 por contribucion para cohetillos, marimba y baile de Moros")
                    dinero = dinero - 25
                    TextBox4.Text = dinero
                End If
                If cupones = 9 Then
                    MsgBox("Se emitieron ordenes de corte para sus lineas telefonicas. Pague Q100 para evitar la suspencion del servicio")
                    dinero = dinero - 100
                    TextBox4.Text = dinero
                End If

            End If


            'fin cupones..................................................................................................................................................
            '.............................................................................................................................................................

            'dpts
            '..Progreso
            If TextBox2.Text = 2 Then
                TextBox6.Text = "El progreso"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/progreso.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 70
                TextBox5.Text = precio
                If CheckBox1.CheckState = False Then
                    decision = InputBox("Bienvenido a El Progreso ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 70 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 70
                            TextBox4.Text = dinero
                            CheckBox1.Checked = True
                            CheckBox1.BackColor = Color.Green
                            OvalShape1.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox1.Checked = False
                    End If
                ElseIf CheckBox1.BackColor = Color.Blue And CheckBox2.BackColor = Color.Blue Then

                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q50 ")
                        dinero = dinero - 50
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 50
                        TextBox7.Text = dinero2
                    ElseIf CheckBox1.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q25")
                        dinero = dinero - 25
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 25
                        TextBox7.Text = dinero2
                    End If
                End If



            'Fin Progreso

            'Huehuetenango
            If TextBox2.Text = 5 Then
                TextBox6.Text = "Huehuetenango"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/huehue.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 130
                TextBox5.Text = precio
                If CheckBox3.CheckState = False Then
                    decision = InputBox("Bienvenido a Huehuetenango ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 130 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 130
                            TextBox4.Text = dinero
                            CheckBox3.Checked = True
                            CheckBox3.BackColor = Color.Green
                            OvalShape2.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox3.Checked = False
                    End If
                ElseIf CheckBox3.BackColor = Color.Blue And CheckBox4.BackColor = Color.Blue And CheckBox5.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q120 ")
                        dinero = dinero - 120
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 60
                        TextBox7.Text = dinero2
                    ElseIf CheckBox3.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q60")
                        dinero = dinero - 60
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 60
                        TextBox7.Text = dinero2
                    End If


            End If
            'fin huehuetenango 

            'Quetzal
            If TextBox2.Text = 7 Then
                TextBox6.Text = "Quetzaltenango"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/xela.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 100
                TextBox5.Text = precio
                If CheckBox4.CheckState = False Then
                    decision = InputBox("Bienvenido a Quetzaltenango ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 100 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 100
                            TextBox4.Text = dinero
                            CheckBox4.Checked = True
                            CheckBox4.BackColor = Color.Green
                            OvalShape3.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox4.Checked = False
                    End If
                ElseIf CheckBox3.BackColor = Color.Blue And CheckBox4.BackColor = Color.Blue And CheckBox5.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q110 ")
                        dinero = dinero - 110
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 110
                        TextBox7.Text = dinero2
                    ElseIf CheckBox4.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q55")
                        dinero = dinero - 55
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 55
                        TextBox7.Text = dinero2
                    End If


            End If
            'Fin quetzal

            'Alta
            If TextBox2.Text = 8 Then
                TextBox6.Text = "Alta Verapaz"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/alta.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 90
                TextBox5.Text = precio
                If CheckBox5.CheckState = False Then
                    decision = InputBox("Bienvenido a Alta Verapaz ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 90 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 90
                            TextBox4.Text = dinero
                            CheckBox5.Checked = True
                            CheckBox5.BackColor = Color.Green
                            OvalShape4.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox5.Checked = False
                    End If
                ElseIf CheckBox3.BackColor = Color.Blue And CheckBox4.BackColor = Color.Blue And CheckBox5.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q130 ")
                        dinero = dinero - 130
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 130
                        TextBox7.Text = dinero2
                    ElseIf CheckBox5.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q65")
                        dinero = dinero - 65
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 65
                        TextBox7.Text = dinero2

                End If

            End If
            'Fin Alta

            'Quiche
            If TextBox2.Text = 10 Then
                TextBox6.Text = "Quiche"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/quic.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 150
                TextBox5.Text = precio
                If CheckBox6.CheckState = False Then
                    decision = InputBox("Bienvenido a Quiche ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 150 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 150
                            TextBox4.Text = dinero
                            CheckBox6.Checked = True
                            CheckBox6.BackColor = Color.Green
                            OvalShape6.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox6.Checked = False
                    End If
                ElseIf CheckBox6.BackColor = Color.Green And CheckBox7.BackColor = Color.Green And CheckBox8.BackColor = Color.Green Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q140 ")
                    dinero = dinero - 140
                    TextBox4.Text = dinero
                    dinero2 = dinero2 + 140
                    TextBox7.Text = dinero2
                ElseIf CheckBox6.BackColor = Color.Green Then
                    MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q70")
                        dinero = dinero - 70
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 70
                        TextBox7.Text = dinero2

                End If

            End If
            'Fin Quiche

            'Izabal
            If TextBox2.Text = 12 Then
                TextBox6.Text = "Izabal"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/iza.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 140
                TextBox5.Text = precio
                If CheckBox7.CheckState = False Then
                    decision = InputBox("Bienvenido a Izabal ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 140 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 140
                            TextBox4.Text = dinero
                            CheckBox7.Checked = True
                            CheckBox7.BackColor = Color.Green
                            OvalShape7.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox7.Checked = False
                    End If
                ElseIf CheckBox6.BackColor = Color.Blue And CheckBox7.BackColor = Color.Blue And CheckBox8.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q1160 ")
                        dinero = dinero - 160
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 160
                        TextBox7.Text = dinero2
                    ElseIf CheckBox7.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q80")
                        dinero = dinero - 80
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 80
                        TextBox7.Text = dinero2
                    End If


            End If
            'Fin Izabal

            'Chimaltenango
            If TextBox2.Text = 13 Then
                TextBox6.Text = "Chimaltenango"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/chi.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 150
                TextBox5.Text = precio
                If CheckBox8.CheckState = False Then
                    decision = InputBox("Bienvenido a Chimaltenango ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 150 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 150
                            TextBox4.Text = dinero
                            CheckBox8.Checked = True
                            CheckBox8.BackColor = Color.Green
                            OvalShape8.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox8.Checked = False
                    End If
                ElseIf CheckBox6.BackColor = Color.Blue And CheckBox7.BackColor = Color.Blue And CheckBox8.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q150 ")
                        dinero = dinero - 150
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 150
                        TextBox7.Text = dinero2
                    ElseIf CheckBox8.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q75")
                        dinero = dinero - 75
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 75
                        TextBox7.Text = dinero2
                    End If


            End If
            'Fin Chimaltenango

            'Retalhuleu
            If TextBox2.Text = 15 Then
                TextBox6.Text = "Retalhuleu"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Retal.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 200
                TextBox5.Text = precio
                If CheckBox9.CheckState = False Then
                    decision = InputBox("Bienvenido a Retalhuleu ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 200 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 200
                            TextBox4.Text = dinero
                            CheckBox9.Checked = True
                            CheckBox9.BackColor = Color.Green
                            OvalShape9.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox9.Checked = False
                    End If
                ElseIf CheckBox9.BackColor = Color.Blue And CheckBox10.BackColor = Color.Blue And CheckBox11.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q200 ")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                        TextBox7.Text = dinero2
                    ElseIf CheckBox9.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q100")
                        dinero = dinero - 100
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 100
                        TextBox7.Text = dinero2
                    End If


            End If
            'Fin Retalhuleu

            'Solola
            If TextBox2.Text = 17 Then
                TextBox6.Text = "Solola"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/solola.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 170
                TextBox5.Text = precio
                If CheckBox10.CheckState = False Then
                    decision = InputBox("Bienvenido a Solola ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 170 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 170
                            TextBox4.Text = dinero
                            CheckBox10.Checked = True
                            CheckBox10.BackColor = Color.Green
                            OvalShape10.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox10.Checked = False
                    End If
                ElseIf CheckBox9.BackColor = Color.Blue And CheckBox10.BackColor = Color.Blue And CheckBox11.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q180 ")
                        dinero = dinero - 180
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 180
                        TextBox7.Text = dinero2
                    ElseIf CheckBox10.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q90")
                        dinero = dinero - 90
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 90
                        TextBox7.Text = dinero2
                    End If


            End If
            'Fin Solola

            'Escuintla
            If TextBox2.Text = 18 Then
                TextBox6.Text = "Escuintla"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/escuint.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 190
                TextBox5.Text = precio
                If CheckBox11.CheckState = False Then
                    decision = InputBox("Bienvenido a Escuintla ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 190 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 190
                            TextBox4.Text = dinero
                            CheckBox11.Checked = True
                            CheckBox11.BackColor = Color.Green
                            OvalShape11.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox11.Checked = False
                    End If
                ElseIf CheckBox9.BackColor = Color.Blue And CheckBox10.BackColor = Color.Blue And CheckBox11.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q190 ")
                        dinero = dinero - 190
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 190
                        TextBox7.Text = dinero2
                    ElseIf CheckBox11.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q95")
                        dinero = dinero - 95
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 95
                        TextBox7.Text = dinero2
                    End If


            End If
            'Fin Escuintla

            'San Marcos
            If TextBox2.Text = 19 Then
                TextBox6.Text = "San Marcos"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/marcos.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 230
                TextBox5.Text = precio
                If CheckBox12.CheckState = False Then
                    decision = InputBox("Bienvenido a San Marcos ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 230 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 230
                            TextBox4.Text = dinero
                            CheckBox12.Checked = True
                            CheckBox12.BackColor = Color.Green
                            OvalShape12.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox12.Checked = False
                    End If
                ElseIf CheckBox12.BackColor = Color.Blue And CheckBox13.BackColor = Color.Blue And CheckBox14.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q200 ")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                        TextBox7.Text = dinero2
                    ElseIf CheckBox12.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q100")
                        dinero = dinero - 100
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 100
                        TextBox7.Text = dinero2
                    End If

            End If
            'Fin San Marcos

            'Chiquimula
            If TextBox2.Text = 22 Then
                TextBox6.Text = "Chiquimula"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/chiqui.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 200
                TextBox5.Text = precio
                If CheckBox13.CheckState = False Then
                    decision = InputBox("Bienvenido a Chiquimula,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 200 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 200
                            TextBox4.Text = dinero
                            CheckBox13.Checked = True
                            CheckBox13.BackColor = Color.Green
                            OvalShape13.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox13.Checked = False
                    End If
                ElseIf CheckBox12.BackColor = Color.Blue And CheckBox13.BackColor = Color.Blue And CheckBox14.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q180 ")
                        dinero = dinero - 180
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 180
                        TextBox7.Text = dinero2
                    ElseIf CheckBox13.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q90")
                        dinero = dinero - 90
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 90
                        TextBox7.Text = dinero2
                    End If

            End If
            'Fin Chiquimula
            'Baja verapaz
            If TextBox2.Text = 23 Then
                TextBox6.Text = "Baja Verapaz"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/baja.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 250
                TextBox5.Text = precio
                If CheckBox14.CheckState = False Then
                    decision = InputBox("Bienvenido a Baja Verapaz,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 250 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 250
                            TextBox4.Text = dinero
                            CheckBox14.Checked = True
                            CheckBox14.BackColor = Color.Green
                            OvalShape14.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox14.Checked = False
                    End If
                ElseIf CheckBox12.BackColor = Color.Blue And CheckBox13.BackColor = Color.Blue And CheckBox14.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q190 ")
                        dinero = dinero - 190
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 190
                        TextBox7.Text = dinero2
                    ElseIf CheckBox14.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q95")
                        dinero = dinero - 95
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 95
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Baja Verapaz

            'Zacapa
            If TextBox2.Text = 25 Then
                TextBox6.Text = "Zacapa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/zacapa.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 270
                TextBox5.Text = precio
                If CheckBox15.CheckState = False Then
                    decision = InputBox("Bienvenido a Zacapa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 270 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 270
                            TextBox4.Text = dinero
                            CheckBox15.Checked = True
                            CheckBox15.BackColor = Color.Green
                            OvalShape15.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox15.Checked = False
                    End If
                ElseIf CheckBox15.BackColor = Color.Blue And CheckBox16.BackColor = Color.Blue And CheckBox17.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q280 ")
                        dinero = dinero - 280
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 280
                        TextBox7.Text = dinero2
                    ElseIf CheckBox15.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q140")
                        dinero = dinero - 140
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 140
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Zacapa

            'Totonicapan
            If TextBox2.Text = 26 Then
                TextBox6.Text = "Totonicapan"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/toto.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 280
                TextBox5.Text = precio
                If CheckBox16.CheckState = False Then
                    decision = InputBox("Bienvenido a Totonicapan,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 280 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 280
                            TextBox4.Text = dinero
                            CheckBox16.Checked = True
                            CheckBox16.BackColor = Color.Green
                            OvalShape16.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox16.Checked = False
                    End If
                ElseIf CheckBox15.BackColor = Color.Blue And CheckBox16.BackColor = Color.Blue And CheckBox17.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q250 ")
                        dinero = dinero - 250
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 250
                        TextBox7.Text = dinero2
                    ElseIf CheckBox16.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q125")
                        dinero = dinero - 125
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 125
                        TextBox7.Text = dinero2
                    End If

            End If
            'Fin Totonicapan

            'Guatemala
            If TextBox2.Text = 28 Then
                TextBox6.Text = "Guatemala"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/guat.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 250
                TextBox5.Text = precio
                If CheckBox17.CheckState = False Then
                    decision = InputBox("Bienvenido a Guatemala,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 250 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 250
                            TextBox4.Text = dinero
                            CheckBox17.Checked = True
                            CheckBox17.BackColor = Color.Green
                            OvalShape17.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox17.Checked = False
                    End If
                ElseIf CheckBox15.BackColor = Color.Blue And CheckBox16.BackColor = Color.Blue And CheckBox17.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q270 ")
                        dinero = dinero - 270
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 270
                        TextBox7.Text = dinero2
                    ElseIf CheckBox17.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q135")
                        dinero = dinero - 135
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 135
                        TextBox7.Text = dinero2
                    End If

            End If
            'Fin Guatemala

            'Santa Rosa
            If TextBox2.Text = 30 Then
                TextBox6.Text = "Santa Rosa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/rosa.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 310
                TextBox5.Text = precio
                If CheckBox18.CheckState = False Then
                    decision = InputBox("Bienvenido a Santa Rosa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 310 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 310
                            TextBox4.Text = dinero
                            CheckBox18.Checked = True
                            CheckBox18.BackColor = Color.Green
                            OvalShape18.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox18.Checked = False
                    End If
                ElseIf CheckBox18.BackColor = Color.Blue And CheckBox19.BackColor = Color.Blue And CheckBox20.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q300 ")
                        dinero = dinero - 300
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 300
                        TextBox7.Text = dinero2
                    ElseIf CheckBox18.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q150")
                        dinero = dinero - 150
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 150
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Santa Rosa

            'Sacatepequez
            If TextBox2.Text = 31 Then
                TextBox6.Text = "Sacatepequez"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/sacat.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 310
                TextBox5.Text = precio
                If CheckBox19.CheckState = False Then
                    decision = InputBox("Bienvenido a Sacatepequez,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 310 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 310
                            TextBox4.Text = dinero
                            CheckBox19.Checked = True
                            CheckBox19.BackColor = Color.Green
                            OvalShape19.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox19.Checked = False
                    End If
                ElseIf CheckBox18.BackColor = Color.Blue And CheckBox19.BackColor = Color.Blue And CheckBox20.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q320 ")
                        dinero = dinero - 320
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 320
                        TextBox7.Text = dinero2
                    ElseIf CheckBox19.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q160")
                        dinero = dinero - 160
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 160
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Sacatepequez

            'Suchitepequez
            If TextBox2.Text = 33 Then
                TextBox6.Text = "Suchitepequez"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/suchi.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 300
                TextBox5.Text = precio
                If CheckBox20.CheckState = False Then
                    decision = InputBox("Bienvenido a Suchitepequez,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 300 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 300
                            TextBox4.Text = dinero
                            CheckBox20.Checked = True
                            CheckBox20.BackColor = Color.Green
                            OvalShape20.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox20.Checked = False
                    End If
                ElseIf CheckBox18.BackColor = Color.Blue And CheckBox19.BackColor = Color.Blue And CheckBox20.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q280 ")
                        dinero = dinero - 280
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 280
                        TextBox7.Text = dinero2
                    ElseIf CheckBox20.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q140")
                        dinero = dinero - 140
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 140
                        TextBox7.Text = dinero2
                    End If

            End If
            'Fin Suchitepequez


            'Jalapa
            If TextBox2.Text = 36 Then
                TextBox6.Text = "Jalapa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/jala.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 360
                TextBox5.Text = precio
                If CheckBox21.CheckState = False Then
                    decision = InputBox("Bienvenido a Jalapa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 360 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 360
                            TextBox4.Text = dinero
                            CheckBox21.Checked = True
                            CheckBox21.BackColor = Color.Green
                            OvalShape21.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox21.Checked = False
                    End If
                ElseIf CheckBox21.BackColor = Color.Blue And CheckBox22.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q360 ")
                        dinero = dinero - 360
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 360
                        TextBox7.Text = dinero2
                    ElseIf CheckBox21.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q180")
                        dinero = dinero - 180
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 180
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Jalapa

            'Jutiapa
            If TextBox2.Text = 38 Then
                TextBox6.Text = "Jutiapa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/juti.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 390
                TextBox5.Text = precio
                If CheckBox22.CheckState = False Then
                    decision = InputBox("Bienvenido a Jutiapa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 390 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 390
                            TextBox4.Text = dinero
                            CheckBox22.Checked = True
                            CheckBox22.BackColor = Color.Green
                            OvalShape22.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox22.Checked = False
                    End If
                ElseIf CheckBox21.BackColor = Color.Blue And CheckBox22.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q400 ")
                        dinero = dinero - 400
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 400
                        TextBox7.Text = dinero2
                    ElseIf CheckBox22.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q200")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Jutiapa

            'Peten
            If TextBox2.Text = 39 Then
                TextBox6.Text = "Peten"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/peten.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 50
                TextBox5.Text = precio
                If CheckBox2.CheckState = False Then
                    decision = InputBox("Bienvenido a Peten,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 50 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 50
                            TextBox4.Text = dinero
                            CheckBox2.Checked = True
                            CheckBox2.BackColor = Color.Green
                            OvalShape23.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox2.Checked = False
                    End If
                ElseIf CheckBox1.BackColor = Color.Blue And CheckBox22.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara el doble de alquiler ,el alquiler es de Q70 ")
                        dinero = dinero - 70
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 70
                        TextBox7.Text = dinero2
                    ElseIf CheckBox2.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q35")
                        dinero = dinero - 35
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 35
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Peten


            'empresas
            'Aviaguat
            If TextBox2.Text = 4 Then
                My.Computer.Audio.Play(My.Resources.Airbus_Autopilot_Off_da5260f2_67ba_4a3b_aaf7_7acba8c49577, AudioPlayMode.Background)
                TextBox6.Text = "Aviaguat"
                precio = 210
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Aviaguat.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox23.Checked = False Then
                    decision = InputBox("Bienvenido a Aviaguat ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 210 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar Aviaguat")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 210
                            TextBox4.Text = dinero
                            CheckBox23.Checked = True
                            CheckBox23.BackColor = Color.Green
                            OvalShape5.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox23.Checked = False
                    End If
                ElseIf CheckBox23.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara alquiler ,que son Q100")
                        dinero = dinero - 100
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 100
                        TextBox7.Text = dinero2
                    ElseIf CheckBox23.BackColor = Color.Blue And CheckBox24.BackColor = Color.Blue And CheckBox25.BackColor = Color.Blue And CheckBox26.BackColor = Color.Blue And CheckBox27.BackColor = Color.Blue And CheckBox28.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el doble ,son Q200")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                        TextBox7.Text = dinero2
                    End If

                End If
            'Fin Aviaguat

            'INDE
            If TextBox2.Text = 11 Then
                My.Computer.Audio.Play(My.Resources.Electric_Shock_257ec604_ec64_3255_981b_bf2d607a7e36, AudioPlayMode.Background)
                TextBox6.Text = "INDE"
                precio = 175
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Inde.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox24.Checked = False Then
                    decision = InputBox("Bienvenido a INDE ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 175 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar Aviaguat")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 175
                            TextBox4.Text = dinero
                            CheckBox24.Checked = True
                            CheckBox24.BackColor = Color.Green
                            OvalShape24.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox24.Checked = False
                    End If
                ElseIf CheckBox24.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara alquiler ,que son Q75")
                        dinero = dinero - 75
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 75
                        TextBox7.Text = dinero2
                    ElseIf CheckBox23.BackColor = Color.Blue And CheckBox24.BackColor = Color.Blue And CheckBox25.BackColor = Color.Blue And CheckBox26.BackColor = Color.Blue And CheckBox27.BackColor = Color.Blue And CheckBox28.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el doble ,son Q150")
                        dinero = dinero - 150
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 150
                        TextBox7.Text = dinero
                    End If

            End If
            'FIN INDE

            'Fegua
            If TextBox2.Text = 14 Then
                My.Computer.Audio.Play(My.Resources.Train_Horn_8f4e4fb0_3b0a_48b2_bdb6_50cbd71b7900, AudioPlayMode.Background)
                TextBox6.Text = "FEGUA"
                precio = 190
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/fegua.jpeg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox25.Checked = False Then
                    decision = InputBox("Bienvenido a FEGUA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 190 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar FEGUA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 190
                            TextBox4.Text = dinero
                            CheckBox25.Checked = True
                            CheckBox25.BackColor = Color.Green
                            OvalShape25.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox25.Checked = False
                    End If
                ElseIf CheckBox25.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara alquiler ,que son Q100")
                        dinero = dinero - 100
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 100
                        TextBox7.Text = dinero2
                    ElseIf CheckBox23.BackColor = Color.Blue And CheckBox24.BackColor = Color.Blue And CheckBox25.BackColor = Color.Blue And CheckBox26.BackColor = Color.Blue And CheckBox27.BackColor = Color.Blue And CheckBox28.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el doble ,son Q200")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                        TextBox7.Text = dinero
                    End If

                End If
            'Fin Fegua

            'Flomerca
            If TextBox2.Text = 24 Then
                My.Computer.Audio.Play(My.Resources.Creaking_Boat_Sms_14dc17c8_aa91_31d2_b025_bdbd82b33072, AudioPlayMode.Background)
                TextBox6.Text = "Flomerca"
                precio = 210
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Flomerca.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox26.Checked = False Then
                    decision = InputBox("Bienvenido a FLOMERCA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 210 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar FLOMERCA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 210
                            TextBox4.Text = dinero
                            CheckBox26.Checked = True
                            CheckBox26.BackColor = Color.Green
                            OvalShape26.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox26.Checked = False
                    End If
                ElseIf CheckBox26.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara alquiler ,que son Q100")
                        dinero = dinero - 100
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 100
                        TextBox7.Text = dinero2
                    ElseIf CheckBox26.BackColor = Color.Blue And CheckBox24.BackColor = Color.Blue And CheckBox25.BackColor = Color.Blue And CheckBox26.BackColor = Color.Blue And CheckBox27.BackColor = Color.Blue And CheckBox28.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el doble ,son Q200")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                        TextBox7.Text = dinero
                    End If

                End If
            'Fin Flomerca

            'EMPAGUA
            If TextBox2.Text = 27 Then
                My.Computer.Audio.Play(My.Resources.Water_c461fc80_d814_316a_82dc_7f2fbd1d2406, AudioPlayMode.Background)
                TextBox6.Text = "EMPAGUA"
                precio = 175
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Empagua.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox28.Checked = False Then
                    decision = InputBox("Bienvenido a EMPAGUA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 175 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar EMPAGUA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 175
                            TextBox4.Text = dinero
                            CheckBox28.Checked = True
                            CheckBox28.BackColor = Color.Green
                            OvalShape28.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox28.Checked = False
                    End If
                ElseIf CheckBox28.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara alquiler ,que son Q75")
                        dinero = dinero - 75
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 75
                        TextBox7.Text = dinero2
                    ElseIf CheckBox26.BackColor = Color.Blue And CheckBox24.BackColor = Color.Blue And CheckBox25.BackColor = Color.Blue And CheckBox26.BackColor = Color.Blue And CheckBox27.BackColor = Color.Blue And CheckBox28.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el doble ,son Q150")
                        dinero = dinero - 150
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 150
                        TextBox7.Text = dinero
                    End If

                End If
            'FIN EMPAGUA

            'EXTRA
            If TextBox2.Text = 34 Then
                My.Computer.Audio.Play(My.Resources.Bus_8_Start_ffca03f4_0f1c_3689_80df_486d84a48aa8, AudioPlayMode.Background)
                TextBox6.Text = "EXTRA"
                precio = 190
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Extra.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox27.Checked = False Then
                    decision = InputBox("Bienvenido a EXTRA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero < 190 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar EXTRA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero = dinero - 190
                            TextBox4.Text = dinero
                            CheckBox27.Checked = True
                            CheckBox27.BackColor = Color.Green
                            OvalShape27.BackColor = Color.Lime
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox27.Checked = False
                    End If
                ElseIf CheckBox27.BackColor = Color.Blue Then
                    MsgBox("El jugador 2 cobrara alquiler ,que son Q100")
                        dinero = dinero - 100
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 100
                        TextBox7.Text = dinero2
                    ElseIf CheckBox26.BackColor = Color.Blue And CheckBox24.BackColor = Color.Blue And CheckBox25.BackColor = Color.Blue And CheckBox26.BackColor = Color.Blue And CheckBox27.BackColor = Color.Blue And CheckBox28.BackColor = Color.Blue Then
                        MsgBox("El jugador 2 cobrara el doble ,son Q200")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                        TextBox7.Text = dinero
                    End If

                End If
            'Fin EXTRA



            'impuestos
            If TextBox2.Text = 3 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Impuestos SAT:Pague 100")

                dinero = dinero - 100
                TextBox4.Text = dinero

            End If
            If TextBox2.Text = 37 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Impuestos SAT:Pague 80")
                dinero = dinero - 80
                TextBox4.Text = dinero

            End If
            'esquinas
            If TextBox2.Text = 9 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Usted cayo en la carcel,Pague Q50")
                dinero = dinero - 50
                TextBox4.Text = dinero
            End If
            If TextBox2.Text = 21 Then
                MsgBox("Descanso gratis")

            End If
            If TextBox2.Text = 29 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Vayase a la carcel")
                For Me.conteo = 0 To 39
                    Me.fichas(conteo).Visible = False
                Next
                dinero = dinero - 50
                TextBox4.Text = dinero
                posicion = 9
                Me.fichas(posicion - 1).Visible = True
                TextBox2.Text = posicion

            End If
            turno = 2
            'Fin Turno 1...................................................................................................................................................................................................
        ElseIf turno = 2 Then
        For Me.conteo2 = 0 To 39
                Me.fichas2(conteo2).Visible = False
            Next

            Randomize()
            dado2 = Int(Rnd() * 6) + 1
            TextBox1.Text = dado2
            posicion2 = posicion2 + dado2
            If posicion2 <= 40 Then
                Me.fichas2(posicion2 - 1).Visible = True
                TextBox9.Text = posicion2
            Else
                dif2 = posicion2 - 40
                posicion2 = dif2
                Me.fichas2(posicion2 - 1).Visible = True
                TextBox9.Text = posicion2
                vuelta2 = vuelta2 + 1
                TextBox8.Text = vuelta2
                dinero2 = dinero2 + 200
                TextBox7.Text = dinero2
                TextBox9.Text = posicion2
            End If
            bolsa = Int(Rnd() * 9) + 1
            If TextBox9.Text = 16 Then
                If bolsa = 1 Then
                    MsgBox("Cobre Q180 por intereses ganados por sus bonos de retalizacion fiscal")
                    dinero2 = dinero2 + 180
                    TextBox7.Text = dinero2
                End If
                If bolsa = 2 Then
                    MsgBox("¡Le toco el cuchubal! cobre Q50")
                    dinero2 = dinero2 + 50
                    TextBox7.Text = dinero2
                End If
                If bolsa = 3 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                If bolsa = 4 Then
                    MsgBox("Cobre Q60 por utilidades en la venta de sus productos en la feria de la localidad")
                    dinero2 = dinero2 + 60
                    TextBox7.Text = dinero2
                End If
                If bolsa = 5 Then
                    MsgBox("Suspendido por enfermedad. Recive Q145 de parte del IGSS")
                    dinero2 = dinero2 + 145
                    TextBox7.Text = dinero2
                End If
                If bolsa = 6 Then
                    MsgBox("Se gano la loteria. Cobre Q55 del Bancopoly")
                    dinero2 = dinero2 + 55
                    TextBox7.Text = dinero2
                End If
                If bolsa = 7 Then
                    MsgBox("Cobra Q125 por intereses de su cuenta de ahorros en el Bancopoly")
                    dinero2 = dinero2 + 125
                    TextBox7.Text = dinero2
                End If
                If bolsa = 8 Then
                    MsgBox("¡Vayase hasta Escuintla! No pague nada y cobre Q200 por costos del paseo")
                    For Me.conteo2 = 0 To 39
                        Me.fichas(conteo2).Visible = False
                    Next

                    posicion2 = 18
                    Me.fichas2(posicion2 - 1).Visible = True
                    TextBox9.Text = posicion2
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                If bolsa = 9 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                '2do If 32
            ElseIf TextBox9.Text = 32 Then
                If bolsa = 1 Then
                    MsgBox("Cobre Q180 por intereses ganados por sus bonos de retalizacion fiscal")
                    dinero2 = dinero2 + 180
                    TextBox7.Text = dinero2
                End If
                If bolsa = 2 Then
                    MsgBox("¡Le toco el cuchubal! cobre Q50")
                    dinero2 = dinero2 + 50
                    TextBox7.Text = dinero2
                End If
                If bolsa = 3 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                If bolsa = 4 Then
                    MsgBox("Cobre Q60 por utilidades en la venta de sus productos en la feria de la localidad")
                    dinero2 = dinero2 + 60
                    TextBox7.Text = dinero2
                End If
                If bolsa = 5 Then
                    MsgBox("Suspendido por enfermedad. Recive Q145 de parte del IGSS")
                    dinero2 = dinero2 + 145
                    TextBox7.Text = dinero2
                End If
                If bolsa = 6 Then
                    MsgBox("Se gano la loteria. Cobre Q55 del Bancopoly")
                    dinero2 = dinero2 + 55
                    TextBox7.Text = dinero2
                End If
                If bolsa = 7 Then
                    MsgBox("Cobra Q125 por intereses de su cuenta de ahorros en el Bancopoly")
                    dinero2 = dinero2 + 125
                    TextBox7.Text = dinero2
                End If
                If bolsa = 8 Then
                    MsgBox("¡Vayase hasta Escuintla! No pague nada y cobre Q200 por costos del paseo")
                    For Me.conteo2 = 0 To 39
                        Me.fichas2(conteo2).Visible = False
                    Next

                    posicion2 = 18
                    Me.fichas2(posicion2 - 1).Visible = True
                    TextBox9.Text = posicion2
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                If bolsa = 9 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                '3er if 40
            ElseIf TextBox9.Text = 40 Then
                If bolsa = 1 Then
                    MsgBox("Cobre Q180 por intereses ganados por sus bonos de retalizacion fiscal")
                    dinero2 = dinero2 + 180
                    TextBox7.Text = dinero2
                End If
                If bolsa = 2 Then
                    MsgBox("¡Le toco el cuchubal! cobre Q50")
                    dinero2 = dinero2 + 50
                    TextBox7.Text = dinero2
                End If
                If bolsa = 3 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                If bolsa = 4 Then
                    MsgBox("Cobre Q60 por utilidades en la venta de sus productos en la feria de la localidad")
                    dinero2 = dinero2 + 60
                    TextBox7.Text = dinero2
                End If
                If bolsa = 5 Then
                    MsgBox("Suspendido por enfermedad. Recive Q145 de parte del IGSS")
                    dinero2 = dinero2 + 145
                    TextBox7.Text = dinero2
                End If
                If bolsa = 6 Then
                    MsgBox("Se gano la loteria. Cobre Q55 del Bancopoly")
                    dinero2 = dinero2 + 55
                    TextBox7.Text = dinero2
                End If
                If bolsa = 7 Then
                    MsgBox("Cobra Q125 por intereses de su cuenta de ahorros en el Bancopoly")
                    dinero2 = dinero2 + 125
                    TextBox7.Text = dinero2
                End If
                If bolsa = 8 Then
                    MsgBox("¡Vayase hasta Escuintla! No pague nada y cobre Q200 por costos del paseo")
                    For Me.conteo2 = 0 To 39
                        Me.fichas2(conteo2).Visible = False
                    Next

                    posicion2 = 18
                    Me.fichas2(posicion2 - 1).Visible = True
                    TextBox9.Text = posicion2
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If
                If bolsa = 9 Then
                    MsgBox("Cobre Q200. Incentivo fiscal a sus departamentos para el fomento de exportaciones no tradicionales")
                    dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If

            End If
            'cupones.....................................................................................................................................................
            '...........................................................................................................................................................
            cupones = Int(Rnd() * 9) + 1
            If TextBox9.Text = 6 Then
                If cupones = 1 Then
                    MsgBox("Pague Q50 por ajustes en combustible y energia comprada")
                    dinero2 = dinero2 - 50
                    TextBox7.Text = dinero2
                End If
                If cupones = 2 Then
                    MsgBox("Pague Q20 de impuesto para señalizacion, semaforos, bacheo y adoquinamiento")
                    dinero2 = dinero2 - 20
                    TextBox7.Text = dinero2
                End If
                If cupones = 3 Then
                    MsgBox("Pague Q100 al Bancopoly. Impuesto y multa por atraso en pago de planillas del IGGS")
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                End If
                If cupones = 4 Then
                    MsgBox("Introduccion de agua potable y electrificacion. Pague Q150 al bancopoly")
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If
                If cupones = 5 Then
                    MsgBox("Exceso por consumo de agua potable. Pague Q50 al bancopoly")
                    dinero2 = dinero2 - 50
                    TextBox7.Text = dinero2
                End If
                If cupones = 6 Then
                    MsgBox("Auto avaluo. Pague Q30")
                    dinero2 = dinero2 - 30
                    TextBox7.Text = dinero2
                End If
                If cupones = 7 Then
                    MsgBox("Pague Q150 multa por presentacion extemporanea de declaracion impuesto sobre la renta")
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If
                If cupones = 8 Then
                    MsgBox("Feria de la localidad, pague Q25 por contribucion para cohetillos, marimba y baile de Moros")
                    dinero2 = dinero2 - 25
                    TextBox7.Text = dinero2
                End If
                If cupones = 9 Then
                    MsgBox("Se emitieron ordenes de corte para sus lineas telefonicas. Pague Q100 para evitar la suspencion del servicio")
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                End If
            ElseIf TextBox9.Text = 20 Then
                If cupones = 1 Then
                    MsgBox("Pague Q50 por ajustes en combustible y energia comprada")
                    dinero2 = dinero2 - 50
                    TextBox7.Text = dinero2
                End If
                If cupones = 2 Then
                    MsgBox("Pague Q20 de impuesto para señalizacion, semaforos, bacheo y adoquinamiento")
                    dinero2 = dinero2 - 20
                    TextBox7.Text = dinero2
                End If
                If cupones = 3 Then
                    MsgBox("Pague Q100 al Bancopoly. Impuesto y multa por atraso en pago de planillas del IGGS")
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                End If
                If cupones = 4 Then
                    MsgBox("Introduccion de agua potable y electrificacion. Pague Q150 al bancopoly")
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If
                If cupones = 5 Then
                    MsgBox("Exceso por consumo de agua potable. Pague Q50 al bancopoly")
                    dinero2 = dinero2 - 50
                    TextBox7.Text = dinero2
                End If
                If cupones = 6 Then
                    MsgBox("Auto avaluo. Pague Q30")
                    dinero2 = dinero2 - 30
                    TextBox7.Text = dinero2
                End If
                If cupones = 7 Then
                    MsgBox("Pague Q150 multa por presentacion extemporanea de declaracion impuesto sobre la renta")
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If
                If cupones = 8 Then
                    MsgBox("Feria de la localidad, pague Q25 por contribucion para cohetillos, marimba y baile de Moros")
                    dinero2 = dinero2 - 25
                    TextBox7.Text = dinero2
                End If
                If cupones = 9 Then
                    MsgBox("Se emitieron ordenes de corte para sus lineas telefonicas. Pague Q100 para evitar la suspencion del servicio")
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                End If
            ElseIf TextBox9.Text = 35 Then
                If cupones = 1 Then
                    MsgBox("Pague Q50 por ajustes en combustible y energia comprada")
                    dinero2 = dinero2 - 50
                    TextBox7.Text = dinero2
                End If
                If cupones = 2 Then
                    MsgBox("Pague Q20 de impuesto para señalizacion, semaforos, bacheo y adoquinamiento")
                    dinero2 = dinero2 - 20
                    TextBox7.Text = dinero2
                End If
                If cupones = 3 Then
                    MsgBox("Pague Q100 al Bancopoly. Impuesto y multa por atraso en pago de planillas del IGGS")
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                End If
                If cupones = 4 Then
                    MsgBox("Introduccion de agua potable y electrificacion. Pague Q150 al bancopoly")
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If
                If cupones = 5 Then
                    MsgBox("Exceso por consumo de agua potable. Pague Q50 al bancopoly")
                    dinero2 = dinero2 - 50
                    TextBox7.Text = dinero2
                End If
                If cupones = 6 Then
                    MsgBox("Auto avaluo. Pague Q30")
                    dinero2 = dinero2 - 30
                    TextBox7.Text = dinero2
                End If
                If cupones = 7 Then
                    MsgBox("Pague Q150 multa por presentacion extemporanea de declaracion impuesto sobre la renta")
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If
                If cupones = 8 Then
                    MsgBox("Feria de la localidad, pague Q25 por contribucion para cohetillos, marimba y baile de Moros")
                    dinero2 = dinero2 - 25
                    TextBox7.Text = dinero2
                End If
                If cupones = 9 Then
                    MsgBox("Se emitieron ordenes de corte para sus lineas telefonicas. Pague Q100 para evitar la suspencion del servicio")
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                End If

            End If


            'fin cupones..................................................................................................................................................
            '.............................................................................................................................................................

            'dpts
            '..Progreso
            If TextBox9.Text = 2 Then
                TextBox6.Text = "El progreso"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/progreso.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 70
                TextBox5.Text = precio
                If CheckBox1.CheckState = False Then
                    decision = InputBox("Bienvenido a El Progreso ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 70 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 70
                            TextBox7.Text = dinero2
                            CheckBox1.Checked = True
                            CheckBox1.BackColor = Color.Blue
                            OvalShape1.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox1.Checked = False
                    End If
                ElseIf CheckBox1.BackColor = Color.Green And CheckBox2.BackColor = Color.Green Then

                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q50 ")
                    dinero2 = dinero2 - 50
                    TextBox7.Text = dinero2
                    dinero = dinero + 50
                    TextBox4.Text = dinero
                ElseIf CheckBox1.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q25")
                    dinero2 = dinero2 - 25
                    TextBox7.Text = dinero2
                    dinero = dinero + 25
                    TextBox4.Text = dinero
                End If
            End If



            'Fin Progreso

            'Huehuetenango
            If TextBox9.Text = 5 Then
                TextBox6.Text = "Huehuetenango"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/huehue.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 130
                TextBox5.Text = precio
                If CheckBox3.CheckState = False Then
                    decision = InputBox("Bienvenido a Huehuetenango ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 130 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 130
                            TextBox7.Text = dinero2
                            CheckBox3.Checked = True
                            CheckBox3.BackColor = Color.Blue
                            OvalShape2.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox3.Checked = False
                    End If
                ElseIf CheckBox3.BackColor = Color.Green And CheckBox4.BackColor = Color.Green And CheckBox5.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q120 ")
                    dinero2 = dinero2 - 120
                    TextBox7.Text = dinero2
                    dinero = dinero + 60
                    TextBox4.Text = dinero
                ElseIf CheckBox3.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q60")
                    dinero = dinero + 60
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 60
                    TextBox7.Text = dinero2

                End If

            End If
            'fin huehuetenango 

            'Quetzal
            If TextBox9.Text = 7 Then
                TextBox6.Text = "Quetzaltenango"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/xela.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 100
                TextBox5.Text = precio
                If CheckBox4.CheckState = False Then
                    decision = InputBox("Bienvenido a Quetzaltenango ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 100 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 100
                            TextBox7.Text = dinero2
                            CheckBox4.Checked = True
                            CheckBox4.BackColor = Color.Blue
                            OvalShape3.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox4.Checked = False
                    End If
                ElseIf CheckBox3.BackColor = Color.Green And CheckBox4.BackColor = Color.Green And CheckBox5.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q110 ")
                    dinero = dinero + 110
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 110
                    TextBox7.Text = dinero2
                ElseIf CheckBox4.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q55")
                    dinero = dinero + 55
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 55
                    TextBox7.Text = dinero2

                End If
            End If
            'Fin quetzal

            'Alta
            If TextBox9.Text = 8 Then
                TextBox6.Text = "Alta Verapaz"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/alta.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 90
                TextBox5.Text = precio
                If CheckBox5.CheckState = False Then
                    decision = InputBox("Bienvenido a Alta Verapaz ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 90 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 90
                            TextBox7.Text = dinero2
                            CheckBox5.Checked = True
                            CheckBox5.BackColor = Color.Blue
                            OvalShape4.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox5.Checked = False
                    End If
                ElseIf CheckBox3.BackColor = Color.Green And CheckBox4.BackColor = Color.Green And CheckBox5.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q130 ")
                    dinero = dinero + 130
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 130
                    TextBox7.Text = dinero2
                ElseIf CheckBox5.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q65")
                    dinero = dinero + 65
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 65
                    TextBox7.Text = dinero2
                End If

            End If
            'Fin Alta

            'Quiche
            If TextBox9.Text = 10 Then
                TextBox6.Text = "Quiche"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/quic.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 150
                TextBox5.Text = precio
                If CheckBox6.CheckState = False Then
                    decision = InputBox("Bienvenido a Quiche ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 150 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 150
                            TextBox7.Text = dinero2
                            CheckBox6.Checked = True
                            CheckBox6.BackColor = Color.Blue
                            OvalShape6.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox6.Checked = False
                    End If
                ElseIf CheckBox6.BackColor = Color.Green And CheckBox7.BackColor = Color.Green And CheckBox8.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q140 ")
                    dinero = dinero + 140
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 140
                    TextBox7.Text = dinero2
                ElseIf CheckBox6.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q70")
                    dinero = dinero + 70
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 70
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Quiche

            'Izabal
            If TextBox9.Text = 12 Then
                TextBox6.Text = "Izabal"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/iza.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 140
                TextBox5.Text = precio
                If CheckBox7.CheckState = False Then
                    decision = InputBox("Bienvenido a Izabal ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 140 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 140
                            TextBox7.Text = dinero2
                            CheckBox7.Checked = True
                            CheckBox7.BackColor = Color.Blue
                            OvalShape7.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox7.Checked = False
                    End If
                ElseIf CheckBox6.BackColor = Color.Green And CheckBox7.BackColor = Color.Green And CheckBox8.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q160 ")
                    dinero = dinero + 160
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 160
                    TextBox7.Text = dinero2
                ElseIf CheckBox7.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q80")
                    dinero = dinero - 80
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 80
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Izabal

            'Chimaltenango
            If TextBox9.Text = 13 Then
                TextBox6.Text = "Chimaltenango"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/chi.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 150
                TextBox5.Text = precio
                If CheckBox8.CheckState = False Then
                    decision = InputBox("Bienvenido a Chimaltenango ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 150 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 150
                            TextBox7.Text = dinero2
                            CheckBox8.Checked = True
                            CheckBox8.BackColor = Color.Blue
                            OvalShape8.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox8.Checked = False
                    End If
                ElseIf CheckBox6.BackColor = Color.Green And CheckBox7.BackColor = Color.Green And CheckBox8.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q150 ")
                    dinero = dinero + 150
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                ElseIf CheckBox8.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q75")
                    dinero = dinero + 75
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 75
                    TextBox7.Text = dinero2
                End If

            End If
            'Fin Chimaltenango

            'Retalhuleu
            If TextBox9.Text = 15 Then
                TextBox6.Text = "Retalhuleu"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Retal.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 200
                TextBox5.Text = precio
                If CheckBox9.CheckState = False Then
                    decision = InputBox("Bienvenido a Retalhuleu ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 200 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 200
                            TextBox7.Text = dinero
                            CheckBox9.Checked = True
                            CheckBox9.BackColor = Color.Blue
                            OvalShape9.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox9.Checked = False
                    End If
                ElseIf CheckBox9.BackColor = Color.Green And CheckBox10.BackColor = Color.Green And CheckBox11.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q200 ")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 200
                    TextBox7.Text = dinero2
                ElseIf CheckBox9.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q100")
                    dinero = dinero + 100
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                End If

            End If
            'Fin Retalhuleu

            'Solola
            If TextBox9.Text = 17 Then
                TextBox6.Text = "Solola"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/solola.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 170
                TextBox5.Text = precio
                If CheckBox10.CheckState = False Then
                    decision = InputBox("Bienvenido a Solola ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 170 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 170
                            TextBox7.Text = dinero2
                            CheckBox10.Checked = True
                            CheckBox10.BackColor = Color.Blue
                            OvalShape10.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox10.Checked = False
                    End If
                ElseIf CheckBox9.BackColor = Color.Green And CheckBox10.BackColor = Color.Green And CheckBox11.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q180 ")
                    dinero = dinero + 180
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 180
                    TextBox7.Text = dinero2
                ElseIf CheckBox10.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q90")
                    dinero = dinero + 90
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 90
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Solola

            'Escuintla
            If TextBox9.Text = 18 Then
                TextBox6.Text = "Escuintla"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/escuint.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 190
                TextBox5.Text = precio
                If CheckBox11.CheckState = False Then
                    decision = InputBox("Bienvenido a Escuintla ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 190 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 190
                            TextBox7.Text = dinero2
                            CheckBox11.Checked = True
                            CheckBox11.BackColor = Color.Blue
                            OvalShape11.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox11.Checked = False
                    End If
                ElseIf CheckBox9.BackColor = Color.Green And CheckBox10.BackColor = Color.Green And CheckBox11.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q190 ")
                    dinero = dinero + 190
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 190
                    TextBox7.Text = dinero2
                ElseIf CheckBox11.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q95")
                    dinero = dinero + 95
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 95
                    TextBox7.Text = dinero2
                    End If


            End If
            'Fin Escuintla

            'San Marcos
            If TextBox9.Text = 19 Then
                TextBox6.Text = "San Marcos"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/marcos.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 230
                TextBox5.Text = precio
                If CheckBox12.CheckState = False Then
                    decision = InputBox("Bienvenido a San Marcos ,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 230 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 230
                            TextBox7.Text = dinero2
                            CheckBox12.Checked = True
                            CheckBox12.BackColor = Color.Blue
                            OvalShape12.BackColor = Color.Blue
                            propiedadesj1 = propiedadesj1 + 1
                            Propiedades1.Text = propiedadesj1
                        End If
                    Else
                        CheckBox12.Checked = False
                    End If
                ElseIf CheckBox12.BackColor = Color.Green And CheckBox13.BackColor = Color.Green And CheckBox14.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q200 ")
                        dinero = dinero + 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 - 200
                        TextBox7.Text = dinero2
                    ElseIf CheckBox12.BackColor = Color.Green Then
                        MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q100")
                        dinero = dinero + 100
                        TextBox4.Text = dinero
                        dinero2 = dinero2 - 100
                        TextBox7.Text = dinero2
                    End If

            End If
            'Fin San Marcos

            'Chiquimula
            If TextBox9.Text = 22 Then
                TextBox6.Text = "Chiquimula"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/chiqui.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 200
                TextBox5.Text = precio
                If CheckBox13.CheckState = False Then
                    decision = InputBox("Bienvenido a Chiquimula,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 200 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 200
                            TextBox7.Text = dinero2
                            CheckBox13.Checked = True
                            CheckBox13.BackColor = Color.Blue
                            OvalShape13.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox13.Checked = False
                    End If
                ElseIf CheckBox12.BackColor = Color.Green And CheckBox13.BackColor = Color.Green And CheckBox14.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q180 ")
                    dinero = dinero + 180
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 180
                    TextBox7.Text = dinero2
                ElseIf CheckBox13.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q90")
                    dinero = dinero + 90
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 90
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Chiquimula
            'Baja verapaz
            If TextBox9.Text = 23 Then
                TextBox6.Text = "Baja Verapaz"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/baja.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 250
                TextBox5.Text = precio
                If CheckBox14.CheckState = False Then
                    decision = InputBox("Bienvenido a Baja Verapaz,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 250 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 250
                            TextBox7.Text = dinero2
                            CheckBox14.Checked = True
                            CheckBox14.BackColor = Color.Blue
                            OvalShape14.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox14.Checked = False
                    End If
                ElseIf CheckBox12.BackColor = Color.Green And CheckBox13.BackColor = Color.Green And CheckBox14.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q190 ")
                    dinero = dinero + 190
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 190
                    TextBox7.Text = dinero2
                ElseIf CheckBox14.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q95")
                    dinero = dinero + 95
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 95
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Baja Verapaz

            'Zacapa
            If TextBox9.Text = 25 Then
                TextBox6.Text = "Zacapa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/zacapa.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 270
                TextBox5.Text = precio
                If CheckBox15.CheckState = False Then
                    decision = InputBox("Bienvenido a Zacapa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 270 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 270
                            TextBox7.Text = dinero2
                            CheckBox15.Checked = True
                            CheckBox15.BackColor = Color.Blue
                            OvalShape15.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox15.Checked = False
                    End If
                ElseIf CheckBox15.BackColor = Color.Green And CheckBox16.BackColor = Color.Green And CheckBox17.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q280 ")
                    dinero = dinero + 280
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 280
                    TextBox7.Text = dinero2
                ElseIf CheckBox15.BackColor = Color.Green Then
                    MsgBox("El jugador 2 cobrara el alquiler ,el alquiler es de Q140")
                    dinero = dinero + 140
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 140
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Zacapa

            'Totonicapan
            If TextBox9.Text = 26 Then
                TextBox6.Text = "Totonicapan"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/toto.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 280
                TextBox5.Text = precio
                If CheckBox16.CheckState = False Then
                    decision = InputBox("Bienvenido a Totonicapan,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 280 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 280
                            TextBox7.Text = dinero2
                            CheckBox16.Checked = True
                            CheckBox16.BackColor = Color.Blue
                            OvalShape16.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox16.Checked = False
                    End If
                ElseIf CheckBox15.BackColor = Color.Green And CheckBox16.BackColor = Color.Green And CheckBox17.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q250 ")
                    dinero = dinero + 250
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 250
                    TextBox7.Text = dinero2
                ElseIf CheckBox16.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q125")
                    dinero = dinero + 125
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 125
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Totonicapan

            'Guatemala
            If TextBox9.Text = 28 Then
                TextBox6.Text = "Guatemala"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/guat.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 250
                TextBox5.Text = precio
                If CheckBox17.CheckState = False Then
                    decision = InputBox("Bienvenido a Guatemala,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 250 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 250
                            TextBox7.Text = dinero2
                            CheckBox17.Checked = True
                            CheckBox17.BackColor = Color.Blue
                            OvalShape17.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox17.Checked = False
                    End If
                ElseIf CheckBox15.BackColor = Color.Green And CheckBox16.BackColor = Color.Green And CheckBox17.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q270 ")
                    dinero = dinero + 270
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 270
                    TextBox7.Text = dinero2
                ElseIf CheckBox17.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q135")
                    dinero = dinero + 135
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 135
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Guatemala

            'Santa Rosa
            If TextBox9.Text = 30 Then
                TextBox6.Text = "Santa Rosa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/rosa.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 310
                TextBox5.Text = precio
                If CheckBox18.CheckState = False Then
                    decision = InputBox("Bienvenido a Santa Rosa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 310 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 310
                            TextBox7.Text = dinero2
                            CheckBox18.Checked = True
                            CheckBox18.BackColor = Color.Blue
                            OvalShape18.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox18.Checked = False
                    End If
                ElseIf CheckBox18.BackColor = Color.Green And CheckBox19.BackColor = Color.Green And CheckBox20.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q300 ")
                    dinero = dinero + 300
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 300
                    TextBox7.Text = dinero2
                ElseIf CheckBox18.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q150")
                    dinero = dinero + 150
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Santa Rosa

            'Sacatepequez
            If TextBox9.Text = 31 Then
                TextBox6.Text = "Sacatepequez"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/sacat.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 310
                TextBox5.Text = precio
                If CheckBox19.CheckState = False Then
                    decision = InputBox("Bienvenido a Sacatepequez,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 310 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 310
                            TextBox7.Text = dinero2
                            CheckBox19.Checked = True
                            CheckBox19.BackColor = Color.Blue
                            OvalShape19.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox19.Checked = False
                    End If
                ElseIf CheckBox18.BackColor = Color.Green And CheckBox19.BackColor = Color.Green And CheckBox20.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q320 ")
                    dinero = dinero + 320
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 320
                    TextBox7.Text = dinero2
                ElseIf CheckBox19.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q160")
                    dinero = dinero + 160
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 160
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Sacatepequez

            'Suchitepequez
            If TextBox9.Text = 33 Then
                TextBox6.Text = "Suchitepequez"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/suchi.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 300
                TextBox5.Text = precio
                If CheckBox20.CheckState = False Then
                    decision = InputBox("Bienvenido a Suchitepequez,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 300 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 300
                            TextBox7.Text = dinero2
                            CheckBox20.Checked = True
                            CheckBox20.BackColor = Color.Blue
                            OvalShape20.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox20.Checked = False
                    End If
                ElseIf CheckBox18.BackColor = Color.Green And CheckBox19.BackColor = Color.Green And CheckBox20.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q280 ")
                    dinero = dinero + 280
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 280
                    TextBox7.Text = dinero2
                ElseIf CheckBox20.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q140")
                    dinero = dinero + 140
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 140
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Suchitepequez


            'Jalapa
            If TextBox9.Text = 36 Then
                TextBox6.Text = "Jalapa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/jala.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 360
                TextBox5.Text = precio
                If CheckBox21.CheckState = False Then
                    decision = InputBox("Bienvenido a Jalapa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 360 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 360
                            TextBox7.Text = dinero2
                            CheckBox21.Checked = True
                            CheckBox21.BackColor = Color.Blue
                            OvalShape21.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox21.Checked = False
                    End If
                ElseIf CheckBox21.BackColor = Color.Green And CheckBox22.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q360 ")
                    dinero = dinero + 360
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 360
                    TextBox7.Text = dinero2
                ElseIf CheckBox21.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q180")
                    dinero = dinero + 180
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 180
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Jalapa

            'Jutiapa
            If TextBox9.Text = 38 Then
                TextBox6.Text = "Jutiapa"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/juti.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 390
                TextBox5.Text = precio
                If CheckBox22.CheckState = False Then
                    decision = InputBox("Bienvenido a Jutiapa,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 390 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 390
                            TextBox7.Text = dinero2
                            CheckBox22.Checked = True
                            CheckBox22.BackColor = Color.Blue
                            OvalShape22.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox22.Checked = False
                    End If
                ElseIf CheckBox21.BackColor = Color.Green And CheckBox22.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q400 ")
                    dinero = dinero + 400
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 400
                    TextBox7.Text = dinero2
                ElseIf CheckBox22.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q200")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 200
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Jutiapa

            'Peten
            If TextBox9.Text = 39 Then
                TextBox6.Text = "Peten"
                Me.PictureBox3.Image = Image.FromFile(imagen & "/peten.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                precio = 50
                TextBox5.Text = precio
                If CheckBox2.CheckState = False Then
                    decision = InputBox("Bienvenido a Peten,Le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 50 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("A usted no le alcanza el dinero")

                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 50
                            TextBox7.Text = dinero2
                            CheckBox2.Checked = True
                            CheckBox2.BackColor = Color.Blue
                            OvalShape23.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox2.Checked = False
                    End If
                ElseIf CheckBox1.BackColor = Color.Green And CheckBox22.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble de alquiler ,el alquiler es de Q70 ")
                    dinero = dinero + 70
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 70
                    TextBox7.Text = dinero2
                ElseIf CheckBox2.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el alquiler ,el alquiler es de Q35")
                    dinero = dinero + 35
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 35
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Peten


            'empresas
            'Aviaguat
            If TextBox9.Text = 4 Then
                My.Computer.Audio.Play(My.Resources.Airbus_Autopilot_Off_da5260f2_67ba_4a3b_aaf7_7acba8c49577, AudioPlayMode.Background)
                TextBox6.Text = "Aviaguat"
                precio = 210
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Aviaguat.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox23.Checked = False Then
                    decision = InputBox("Bienvenido a Aviaguat ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 210 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar Aviaguat")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 210
                            TextBox7.Text = dinero2
                            CheckBox23.Checked = True
                            CheckBox23.BackColor = Color.Blue
                            OvalShape5.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox23.Checked = False
                    End If
                ElseIf CheckBox23.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara alquiler ,que son Q100")
                    dinero = dinero + 100
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                ElseIf CheckBox23.BackColor = Color.Green And CheckBox24.BackColor = Color.Green And CheckBox25.BackColor = Color.Green And CheckBox26.BackColor = Color.Green And CheckBox27.BackColor = Color.Green And CheckBox28.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble ,son Q200")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 200
                    TextBox7.Text = dinero2
                    End If

            End If
            'Fin Aviaguat

            'INDE
            If TextBox9.Text = 11 Then
                My.Computer.Audio.Play(My.Resources.Electric_Shock_257ec604_ec64_3255_981b_bf2d607a7e36, AudioPlayMode.Background)
                TextBox6.Text = "INDE"
                precio = 175
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Inde.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox24.Checked = False Then
                    decision = InputBox("Bienvenido a INDE ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 175 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar Aviaguat")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 175
                            TextBox7.Text = dinero2
                            CheckBox24.Checked = True
                            CheckBox24.BackColor = Color.Blue
                            OvalShape24.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox24.Checked = False
                    End If
                ElseIf CheckBox24.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara alquiler ,que son Q75")
                    dinero = dinero + 75
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 75
                    TextBox7.Text = dinero2
                ElseIf CheckBox23.BackColor = Color.Green And CheckBox24.BackColor = Color.Green And CheckBox25.BackColor = Color.Green And CheckBox26.BackColor = Color.Green And CheckBox27.BackColor = Color.Green And CheckBox28.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble ,son Q150")
                    dinero = dinero + 150
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If

            End If
            'FIN INDE

            'Fegua
            If TextBox9.Text = 14 Then
                My.Computer.Audio.Play(My.Resources.Train_Horn_8f4e4fb0_3b0a_48b2_bdb6_50cbd71b7900, AudioPlayMode.Background)
                TextBox6.Text = "FEGUA"
                precio = 190
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/fegua.jpeg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox25.Checked = False Then
                    decision = InputBox("Bienvenido a FEGUA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 190 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar FEGUA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 190
                            TextBox7.Text = dinero2
                            CheckBox25.Checked = True
                            CheckBox25.BackColor = Color.Blue
                            OvalShape25.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox25.Checked = False
                    End If
                ElseIf CheckBox25.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara alquiler ,que son Q100")
                    dinero = dinero + 100
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                ElseIf CheckBox23.BackColor = Color.Green And CheckBox24.BackColor = Color.Green And CheckBox25.BackColor = Color.Green And CheckBox26.BackColor = Color.Green And CheckBox27.BackColor = Color.Green And CheckBox28.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble ,son Q200")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 200
                    TextBox7.Text = dinero2
                End If

            End If
            'Fin Fegua

            'Flomerca
            If TextBox9.Text = 24 Then
                My.Computer.Audio.Play(My.Resources.Creaking_Boat_Sms_14dc17c8_aa91_31d2_b025_bdbd82b33072, AudioPlayMode.Background)
                TextBox6.Text = "Flomerca"
                precio = 210
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Flomerca.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox26.Checked = False Then
                    decision = InputBox("Bienvenido a FLOMERCA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 210 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar FLOMERCA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 210
                            TextBox7.Text = dinero2
                            CheckBox26.Checked = True
                            CheckBox26.BackColor = Color.Blue
                            OvalShape26.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox26.Checked = False
                    End If
                ElseIf CheckBox26.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara alquiler ,que son Q100")
                    dinero = dinero + 100
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                ElseIf CheckBox26.BackColor = Color.Green And CheckBox24.BackColor = Color.Green And CheckBox25.BackColor = Color.Green And CheckBox26.BackColor = Color.Green And CheckBox27.BackColor = Color.Green And CheckBox28.BackColor = Color.Green Then
                    MsgBox("El jugador 2 cobrara el doble ,son Q200")
                        dinero = dinero - 200
                        TextBox4.Text = dinero
                        dinero2 = dinero2 + 200
                    TextBox7.Text = dinero2
                End If

            End If
            'Fin Flomerca

            'EMPAGUA
            If TextBox9.Text = 27 Then
                My.Computer.Audio.Play(My.Resources.Water_c461fc80_d814_316a_82dc_7f2fbd1d2406, AudioPlayMode.Background)
                TextBox6.Text = "EMPAGUA"
                precio = 175
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Empagua.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox28.Checked = False Then
                    decision = InputBox("Bienvenido a EMPAGUA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 175 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar EMPAGUA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 175
                            TextBox7.Text = dinero2
                            CheckBox28.Checked = True
                            CheckBox28.BackColor = Color.Blue
                            OvalShape28.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox28.Checked = False
                    End If
                ElseIf CheckBox28.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara alquiler ,que son Q75")
                    dinero = dinero + 75
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 75
                    TextBox7.Text = dinero2
                ElseIf CheckBox26.BackColor = Color.Green And CheckBox24.BackColor = Color.Green And CheckBox25.BackColor = Color.Green And CheckBox26.BackColor = Color.Green And CheckBox27.BackColor = Color.Green And CheckBox28.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble ,son Q150")
                    dinero = dinero + 150
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 150
                    TextBox7.Text = dinero2
                End If

            End If
            'FIN EMPAGUA

            'EXTRA
            If TextBox9.Text = 34 Then
                My.Computer.Audio.Play(My.Resources.Bus_8_Start_ffca03f4_0f1c_3689_80df_486d84a48aa8, AudioPlayMode.Background)
                TextBox6.Text = "EXTRA"
                precio = 190
                TextBox5.Text = precio
                Me.PictureBox3.Image = Image.FromFile(imagen & "/Extra.jpg")
                Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                If CheckBox27.Checked = False Then
                    decision = InputBox("Bienvenido a EXTRA ,le gustaria comprarla? Si/No", "Compra", "")
                    If decision = "Si" Then
                        If dinero2 < 190 Then
                            My.Computer.Audio.Play(My.Resources.error_text_message, AudioPlayMode.Background)
                            MsgBox("No tienes el suficiente dinero para comprar EXTRA")
                        Else
                            My.Computer.Audio.Play(My.Resources.Money_e79c530c_1f53_4c93_bf78_c27b0ce181f5, AudioPlayMode.Background)
                            dinero2 = dinero2 - 190
                            TextBox4.Text = dinero2
                            CheckBox27.Checked = True
                            CheckBox27.BackColor = Color.Blue
                            OvalShape27.BackColor = Color.Blue
                            propiedadesj2 = propiedadesj2 + 1
                            Propiedades2.Text = propiedadesj2
                        End If
                    Else
                        CheckBox27.Checked = False
                    End If
                ElseIf CheckBox27.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara alquiler ,que son Q100")
                    dinero = dinero + 100
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 100
                    TextBox7.Text = dinero2
                ElseIf CheckBox26.BackColor = Color.Green And CheckBox24.BackColor = Color.Green And CheckBox25.BackColor = Color.Green And CheckBox26.BackColor = Color.Green And CheckBox27.BackColor = Color.Green And CheckBox28.BackColor = Color.Green Then
                    MsgBox("El jugador 1 cobrara el doble ,son Q200")
                    dinero = dinero + 200
                    TextBox4.Text = dinero
                    dinero2 = dinero2 - 200
                    TextBox7.Text = dinero2
                End If

            End If
            'Fin EXTRA



            'impuestos
            If TextBox9.Text = 3 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Impuestos SAT:Pague 100")

                dinero2 = dinero2 - 100
                TextBox7.Text = dinero2

            End If
            If TextBox9.Text = 37 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Impuestos SAT:Pague 80")
                dinero2 = dinero2 - 80
                TextBox7.Text = dinero2

            End If
            'esquinas
            If TextBox9.Text = 9 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Usted cayo en la carcel,Pague Q50")
                dinero2 = dinero2 - 50
                TextBox7.Text = dinero2
            End If
            If TextBox9.Text = 21 Then
                MsgBox("Descanso gratis")

            End If
            If TextBox9.Text = 29 Then
                My.Computer.Audio.Play(My.Resources.OOF, AudioPlayMode.Background)
                MsgBox("Vayase a la carcel")
                For Me.conteo2 = 0 To 39
                    Me.fichas2(conteo2).Visible = False
                Next
                dinero2 = dinero2 - 50
                TextBox7.Text = dinero2
                posicion2 = 9
                Me.fichas2(posicion2 - 1).Visible = True
                TextBox9.Text = posicion2

            End If

            turno = 1
        End If
        'Fin turno 2
        If dinero <= 0 Then
            My.Computer.Audio.Play(My.Resources.golden_time_sad_song, AudioPlayMode.Background)
            MsgBox("El jugador 2 es el ganador" & vbNewLine & "El jugador 1 ha quedado en numeros negativos: " & dinero)
            PictureBox2.Visible = False
            PictureBox2.Enabled = False
            MsgBox("Gracias por jugar")
        ElseIf dinero2 <= 0 Then
            My.Computer.Audio.Play(My.Resources.golden_time_sad_song, AudioPlayMode.Background)
            MsgBox("El jugador 1 es el ganador" & vbNewLine & "El jugador 2 ha quedado en numeros negativos: " & dinero2)
            PictureBox2.Visible = False
            PictureBox2.Enabled = False
            MsgBox("Gracias por jugar")
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.OBI_WAN_HELLO_THERE, AudioPlayMode.Background)
        fichas = New PowerPacks.OvalShape() {A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20, A21, A22, A23, A24, A25, A26, A27, A28, A29, A30, A31, A32, A33, A34, A35, A36, A37, A38, A39, A40}
        fichas2 = New PowerPacks.OvalShape() {L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40}

        maximo = 40
        posicion = 1
        posicion2 = 1
        vuelta2 = 0
        For Me.conteo2 = 0 To 39
            Me.fichas2(conteo2).Visible = False
        Next

        For Me.conteo = 0 To 39
            Me.fichas(conteo).Visible = False
        Next
        turno = 1
        TextBox9.Text = posicion2

        Me.fichas2(posicion - 1).Visible = True
        TextBox8.Text = vuelta2

        TextBox2.Text = posicion
        Me.fichas(posicion - 1).Visible = True

        dinero2 = 1500
        TextBox7.Text = dinero2
        dinero = 1500
        TextBox4.Text = dinero
        vuelta = 0
        TextBox3.Text = vuelta
    End Sub
End Class
