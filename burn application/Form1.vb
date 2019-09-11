Public Class Form1




    Dim uhead, uneck, utrunck, uarm, uforearm, uhand, ubuttock, ugenitalia, uthigh, uleg, ufoot As Single

    Dim head As Single = 0
    Dim neck As Single = 0
    Dim trunck As Single = 0
    Dim arm As Single = 0
    Dim forearm As Single = 0
    Dim hand As Single = 0
    Dim genitalia As Single = 0
    Dim buttock As Single = 0
    Dim thigh As Single = 0
    Dim leg As Single = 0
    Dim foot As Single = 0
    '-----------------------------------

    Dim patientname As String
    Dim age As String
    Dim gender As String
    Dim adress As String
    Dim cause As String
    Dim burndate As String
    Dim tbsa As String
    Dim degree As String
    Dim area1, area2, area3, area4, area5, area6, area7, area8, area9, area10, area11 As String
    Dim fluidmagament, painkiller, hidrocortizone, tagament, catheter, dressing, facedressing, oxygen, observation As String


    Dim burning As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Burn_data_base_2003DataSet.Burn_database' table. You can move, or remove it, as needed.
        Me.Burn_databaseTableAdapter.Fill(Me.Burn_data_base_2003DataSet.Burn_database)


        Me.Burn_databaseBindingSource.AddNew()


        labeldate.Text = Now
        

        uneck = 0.5
        utrunck = 0.187
        ubuttock = 0.2
        ugenitalia = 0.5
        uarm = 0.18182
        uforearm = 0.1875
        uhand = 0.625
        ufoot = 0.5834

        If Formselectage.RadioButton1.Checked Then
            uhead = 0.826
            uthigh = 0.1375
            uleg = 0.18518


        End If
        If Formselectage.RadioButton2.Checked Then
            uhead = 0.739
            uthigh = 0.1625
            uleg = 0.18518
        End If
        If Formselectage.RadioButton3.Checked Then
            uhead = 0.5652
            uthigh = 0.2
            uleg = 0.2037
        End If
        If Formselectage.RadioButton4.Checked Then
            uhead = 0.4782
            uthigh = 0.2125
            uleg = 0.22223
        End If
        If Formselectage.RadioButton5.Checked Then

            uhead = 0.3913
            uthigh = 0.225
            uleg = 0.2407
        End If
        If Formselectage.RadioButton6.Checked Then
            uhead = 0.3043
            uthigh = 0.2375
            uleg = 0.25925
        End If
        '-------------------------------------------------------------------------

        label0degree.Text = 100

    End Sub




    Private Sub foot2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles foot9.MouseEnter, foot8.MouseEnter, foot7.MouseEnter, foot6.MouseEnter, foot5.MouseEnter, foot4.MouseEnter, foot3.MouseEnter, foot2.MouseEnter, foot12.MouseEnter, foot11.MouseEnter, foot10.MouseEnter, foot1.MouseEnter

        If burning = True Then
            Dim foot As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If foot.BackColor = Color.NavajoWhite Then
                    foot.BackColor = Color.Maroon
                    label3degree.Text += ufoot
                    footlabel.Text += ufoot

                ElseIf foot.BackColor = Color.IndianRed Then
                    foot.BackColor = Color.Maroon
                    label2degree.Text -= ufoot

                    If label2degree.Text < 0.5 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += ufoot

                End If


                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If foot.BackColor = Color.NavajoWhite Then
                    foot.BackColor = Color.IndianRed
                    label2degree.Text += ufoot
                    footlabel.Text += ufoot
                ElseIf foot.BackColor = Color.Maroon Then
                    foot.BackColor = Color.IndianRed
                    label3degree.Text -= ufoot
                    If label3degree.Text < 0.5 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += ufoot

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If foot.BackColor = Color.Maroon Then
                    foot.BackColor = Color.NavajoWhite
                    label3degree.Text -= ufoot
                    footlabel.Text -= ufoot
                    If label3degree.Text < 0.5 Then
                        label3degree.Text = 0
                    End If
                ElseIf foot.BackColor = Color.IndianRed Then
                    foot.BackColor = Color.NavajoWhite
                    label2degree.Text -= ufoot
                    footlabel.Text -= ufoot
                    If label2degree.Text < 0.5 Then
                        label2degree.Text = 0
                    End If
                End If
            End If


        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

    Private Sub face7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles face9.MouseEnter, face8.MouseEnter, face7.MouseEnter, face6.MouseEnter, face5.MouseEnter, face4.MouseEnter, face3.MouseEnter, face23.MouseEnter, face22.MouseEnter, face21.MouseEnter, face20.MouseEnter, face2.MouseEnter, face19.MouseEnter, face18.MouseEnter, face17.MouseEnter, face16.MouseEnter, face15.MouseEnter, face14.MouseEnter, face13.MouseEnter, face12.MouseEnter, face11.MouseEnter, face10.MouseEnter, face1.MouseEnter

        '----------------------------------------------------------------------------
        'this block to select the corresponding age group
        If burning = True Then
            If Formselectage.RadioButton1.Checked Then
                uhead = 0.826
                uthigh = 0.1375
                uleg = 0.1923


            End If
            If Formselectage.RadioButton2.Checked Then
                uhead = 0.739
                uthigh = 0.1625
                uleg = 0.1923
            End If
            If Formselectage.RadioButton3.Checked Then
                uhead = 0.5652
                uthigh = 0.2
                uleg = 0.21154
            End If
            If Formselectage.RadioButton4.Checked Then
                uhead = 0.4782
                uthigh = 0.2125
                uleg = 0.23077
            End If
            If Formselectage.RadioButton5.Checked Then

                uhead = 0.3913
                uthigh = 0.225
                uleg = 0.25
            End If
            If Formselectage.RadioButton6.Checked Then
                uhead = 0.3043
                uthigh = 0.2375
                uleg = 0.28846
            End If
            '-------------------------------------------------------------------------

            Dim face As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If face.BackColor = Color.NavajoWhite Then
                    face.BackColor = Color.Maroon
                    label3degree.Text += uhead
                    headlabel.Text += uhead
                ElseIf face.BackColor = Color.IndianRed Then
                    face.BackColor = Color.Maroon
                    label2degree.Text -= uhead

                    If label2degree.Text < 0.2 Then
                        label2degree.Text = 0

                    End If
                    label3degree.Text += uhead

                End If

                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If face.BackColor = Color.NavajoWhite Then
                    face.BackColor = Color.IndianRed
                    label2degree.Text += uhead
                    headlabel.Text += uhead
                ElseIf face.BackColor = Color.Maroon Then
                    face.BackColor = Color.IndianRed
                    label3degree.Text -= uhead

                    If label3degree.Text < 0.2 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += uhead

                End If

                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If face.BackColor = Color.Maroon Then
                    face.BackColor = Color.NavajoWhite
                    label3degree.Text -= uhead
                    headlabel.Text -= uhead
                    If label3degree.Text < 0.2 Then
                        label3degree.Text = 0
                    End If
                ElseIf face.BackColor = Color.IndianRed Then
                    face.BackColor = Color.NavajoWhite
                    label2degree.Text -= uhead
                    headlabel.Text -= uhead
                    If label2degree.Text < 0.2 Then
                        label2degree.Text = 0
                    End If
                End If
            End If



        End If

        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

    Private Sub leg17_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leg9.MouseEnter, leg8.MouseEnter, leg7.MouseEnter, leg6.MouseEnter, leg52.MouseEnter, leg51.MouseEnter, leg50.MouseEnter, leg5.MouseEnter, leg49.MouseEnter, leg48.MouseEnter, leg47.MouseEnter, leg46.MouseEnter, leg45.MouseEnter, leg44.MouseEnter, leg43.MouseEnter, leg42.MouseEnter, leg41.MouseEnter, leg40.MouseEnter, leg4.MouseEnter, leg39.MouseEnter, leg38.MouseEnter, leg37.MouseEnter, leg36.MouseEnter, leg35.MouseEnter, leg34.MouseEnter, leg33.MouseEnter, leg32.MouseEnter, leg31.MouseEnter, leg30.MouseEnter, leg3.MouseEnter, leg29.MouseEnter, leg28.MouseEnter, leg27.MouseEnter, leg26.MouseEnter, leg25.MouseEnter, leg24.MouseEnter, leg23.MouseEnter, leg22.MouseEnter, leg21.MouseEnter, leg20.MouseEnter, leg2.MouseEnter, leg19.MouseEnter, leg18.MouseEnter, leg17.MouseEnter, leg16.MouseEnter, leg15.MouseEnter, leg14.MouseEnter, leg13.MouseEnter, leg12.MouseEnter, leg11.MouseEnter, leg10.MouseEnter, leg1.MouseEnter


        '----------------------------------------------------------------------------
        'this block to select the corresponding age group
        If burning = True Then
            If Formselectage.RadioButton1.Checked Then
                uhead = 0.826
                uthigh = 0.1375
                uleg = 0.18518


            End If
            If Formselectage.RadioButton2.Checked Then
                uhead = 0.739
                uthigh = 0.1625
                uleg = 0.18518
            End If
            If Formselectage.RadioButton3.Checked Then
                uhead = 0.5652
                uthigh = 0.2
                uleg = 0.2037
            End If
            If Formselectage.RadioButton4.Checked Then
                uhead = 0.4782
                uthigh = 0.2125
                uleg = 0.22223
            End If
            If Formselectage.RadioButton5.Checked Then

                uhead = 0.3913
                uthigh = 0.225
                uleg = 0.2407
            End If
            If Formselectage.RadioButton6.Checked Then
                uhead = 0.3043
                uthigh = 0.2375
                uleg = 0.25926
            End If
            '-------------------------------------------------------------------------
            Dim leg As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If leg.BackColor = Color.NavajoWhite Then
                    leg.BackColor = Color.Maroon
                    label3degree.Text += uleg
                    leglabel.Text += uleg
                ElseIf leg.BackColor = Color.IndianRed Then
                    leg.BackColor = Color.Maroon
                    label2degree.Text -= uleg

                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += uleg

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If leg.BackColor = Color.NavajoWhite Then
                    leg.BackColor = Color.IndianRed
                    label2degree.Text += uleg
                    leglabel.Text += uleg
                ElseIf leg.BackColor = Color.Maroon Then
                    leg.BackColor = Color.IndianRed
                    label3degree.Text -= uleg
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += uleg

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If leg.BackColor = Color.Maroon Then
                    leg.BackColor = Color.NavajoWhite
                    label3degree.Text -= uleg
                    leglabel.Text -= uleg
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf leg.BackColor = Color.IndianRed Then
                    leg.BackColor = Color.NavajoWhite
                    label2degree.Text -= uleg
                    leglabel.Text -= uleg
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If

            End If



        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub


    Private Sub thigh37_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles thigh9.MouseEnter, thigh80.MouseEnter, thigh8.MouseEnter, thigh79.MouseEnter, thigh78.MouseEnter, thigh77.MouseEnter, thigh76.MouseEnter, thigh75.MouseEnter, thigh74.MouseEnter, thigh73.MouseEnter, thigh72.MouseEnter, thigh71.MouseEnter, thigh70.MouseEnter, thigh7.MouseEnter, thigh69.MouseEnter, thigh68.MouseEnter, thigh67.MouseEnter, thigh66.MouseEnter, thigh65.MouseEnter, thigh64.MouseEnter, thigh63.MouseEnter, thigh62.MouseEnter, thigh61.MouseEnter, thigh60.MouseEnter, thigh6.MouseEnter, thigh59.MouseEnter, thigh58.MouseEnter, thigh57.MouseEnter, thigh56.MouseEnter, thigh55.MouseEnter, thigh54.MouseEnter, thigh53.MouseEnter, thigh52.MouseEnter, thigh51.MouseEnter, thigh50.MouseEnter, thigh5.MouseEnter, thigh49.MouseEnter, thigh48.MouseEnter, thigh47.MouseEnter, thigh46.MouseEnter, thigh45.MouseEnter, thigh44.MouseEnter, thigh43.MouseEnter, thigh42.MouseEnter, thigh41.MouseEnter, thigh40.MouseEnter, thigh4.MouseEnter, thigh39.MouseEnter, thigh38.MouseEnter, thigh37.MouseEnter, thigh36.MouseEnter, thigh35.MouseEnter, thigh34.MouseEnter, thigh33.MouseEnter, thigh32.MouseEnter, thigh31.MouseEnter, thigh30.MouseEnter, thigh3.MouseEnter, thigh29.MouseEnter, thigh28.MouseEnter, thigh27.MouseEnter, thigh26.MouseEnter, thigh25.MouseEnter, thigh24.MouseEnter, thigh23.MouseEnter, thigh22.MouseEnter, thigh21.MouseEnter, thigh20.MouseEnter, thigh2.MouseEnter, thigh19.MouseEnter, thigh18.MouseEnter, thigh17.MouseEnter, thigh16.MouseEnter, thigh15.MouseEnter, thigh14.MouseEnter, thigh13.MouseEnter, thigh12.MouseEnter, thigh11.MouseEnter, thigh10.MouseEnter, thigh1.MouseEnter



        '----------------------------------------------------------------------------
        'this block to select the corresponding age group
        If burning = True Then
            If Formselectage.RadioButton1.Checked Then
                uhead = 0.826
                uthigh = 0.1375
                uleg = 0.1923


            End If
            If Formselectage.RadioButton2.Checked Then
                uhead = 0.739
                uthigh = 0.1625
                uleg = 0.1923
            End If
            If Formselectage.RadioButton3.Checked Then
                uhead = 0.5652
                uthigh = 0.2
                uleg = 0.21154
            End If
            If Formselectage.RadioButton4.Checked Then
                uhead = 0.4782
                uthigh = 0.2125
                uleg = 0.23077
            End If
            If Formselectage.RadioButton5.Checked Then

                uhead = 0.3913
                uthigh = 0.225
                uleg = 0.25
            End If
            If Formselectage.RadioButton6.Checked Then
                uhead = 0.3043
                uthigh = 0.2375
                uleg = 0.28846
            End If
            '-------------------------------------------------------------------------

            Dim thigh As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If thigh.BackColor = Color.NavajoWhite Then
                    thigh.BackColor = Color.Maroon
                    label3degree.Text += uthigh
                    thighlabel.Text += uthigh
                ElseIf thigh.BackColor = Color.IndianRed Then
                    thigh.BackColor = Color.Maroon
                    label2degree.Text -= uthigh
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += uthigh

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If thigh.BackColor = Color.NavajoWhite Then
                    thigh.BackColor = Color.IndianRed
                    label2degree.Text += uthigh
                    thighlabel.Text += uthigh
                ElseIf thigh.BackColor = Color.Maroon Then
                    thigh.BackColor = Color.IndianRed
                    label3degree.Text -= uthigh
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += uthigh

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If thigh.BackColor = Color.Maroon Then
                    thigh.BackColor = Color.NavajoWhite
                    label3degree.Text -= uthigh
                    thighlabel.Text -= uthigh
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf thigh.BackColor = Color.IndianRed Then
                    thigh.BackColor = Color.NavajoWhite
                    label2degree.Text -= uthigh
                    thighlabel.Text -= uthigh
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If


        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

   

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub genitalia2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genitalia2.MouseEnter, genitalia1.MouseEnter
        If burning = True Then
            Dim genitalia As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If genitalia.BackColor = Color.NavajoWhite Then
                    genitalia.BackColor = Color.Maroon
                    label3degree.Text += ugenitalia
                    genitalialabel.Text += ugenitalia
                ElseIf genitalia.BackColor = Color.IndianRed Then
                    genitalia.BackColor = Color.Maroon
                    label2degree.Text -= ugenitalia
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += ugenitalia

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If genitalia.BackColor = Color.NavajoWhite Then
                    genitalia.BackColor = Color.IndianRed
                    label2degree.Text += ugenitalia
                    genitalialabel.Text += ugenitalia
                ElseIf genitalia.BackColor = Color.Maroon Then
                    genitalia.BackColor = Color.IndianRed
                    label3degree.Text -= ugenitalia
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += ugenitalia

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If genitalia.BackColor = Color.Maroon Then
                    genitalia.BackColor = Color.NavajoWhite
                    label3degree.Text -= ugenitalia
                    genitalialabel.Text -= ugenitalia
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf genitalia.BackColor = Color.IndianRed Then
                    genitalia.BackColor = Color.NavajoWhite
                    label2degree.Text -= ugenitalia
                    genitalialabel.Text -= ugenitalia
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If

        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------

    End Sub


    Private Sub hand7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hand8.MouseEnter, hand7.MouseEnter, hand6.MouseEnter, hand5.MouseEnter, hand4.MouseEnter, hand3.MouseEnter, hand2.MouseEnter, hand1.MouseEnter
        If burning = True Then
            Dim hand As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If hand.BackColor = Color.NavajoWhite Then
                    hand.BackColor = Color.Maroon
                    label3degree.Text += uhand
                    handlabel.Text += uhand
                ElseIf hand.BackColor = Color.IndianRed Then
                    hand.BackColor = Color.Maroon
                    label2degree.Text -= uhand
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += uhand

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If hand.BackColor = Color.NavajoWhite Then
                    hand.BackColor = Color.IndianRed
                    label2degree.Text += uhand
                    handlabel.Text += uhand
                ElseIf hand.BackColor = Color.Maroon Then
                    hand.BackColor = Color.IndianRed
                    label3degree.Text -= uhand
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += uhand

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If hand.BackColor = Color.Maroon Then
                    hand.BackColor = Color.NavajoWhite
                    label3degree.Text -= uhand
                    handlabel.Text -= uhand
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf hand.BackColor = Color.IndianRed Then
                    hand.BackColor = Color.NavajoWhite
                    label2degree.Text -= uhand
                    handlabel.Text -= uhand
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If

        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

    Private Sub neck2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles neck4.MouseEnter, neck3.MouseEnter, neck2.MouseEnter, neck1.MouseEnter
        If burning = True Then
            Dim neck As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If neck.BackColor = Color.NavajoWhite Then
                    neck.BackColor = Color.Maroon
                    label3degree.Text += uneck
                    necklabel.Text += uneck
                ElseIf neck.BackColor = Color.IndianRed Then
                    neck.BackColor = Color.Maroon
                    label2degree.Text -= uneck
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += uneck

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If neck.BackColor = Color.NavajoWhite Then
                    neck.BackColor = Color.IndianRed
                    label2degree.Text += uneck
                    necklabel.Text += uneck
                ElseIf neck.BackColor = Color.Maroon Then
                    neck.BackColor = Color.IndianRed
                    label3degree.Text -= uneck
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += uneck

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If neck.BackColor = Color.Maroon Then
                    neck.BackColor = Color.NavajoWhite
                    label3degree.Text -= uneck
                    necklabel.Text -= uneck
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf neck.BackColor = Color.IndianRed Then
                    neck.BackColor = Color.NavajoWhite
                    label2degree.Text -= uneck
                    necklabel.Text -= uneck
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If



        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

    Private Sub buttock21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label358.MouseEnter, buttock9.MouseEnter, buttock8.MouseEnter, buttock7.MouseEnter, buttock6.MouseEnter, buttock5.MouseEnter, buttock4.MouseEnter, buttock3.MouseEnter, buttock25.MouseEnter, buttock24.MouseEnter, buttock23.MouseEnter, buttock22.MouseEnter, buttock21.MouseEnter, buttock20.MouseEnter, buttock2.MouseEnter, buttock19.MouseEnter, buttock18.MouseEnter, buttock17.MouseEnter, buttock16.MouseEnter, buttock15.MouseEnter, buttock14.MouseEnter, buttock13.MouseEnter, buttock12.MouseEnter, buttock11.MouseEnter, buttock10.MouseEnter, buttock1.MouseEnter
        If burning = True Then
            Dim buttock As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If buttock.BackColor = Color.NavajoWhite Then
                    buttock.BackColor = Color.Maroon
                    label3degree.Text += ubuttock
                    buttocklabel.Text += ubuttock
                ElseIf buttock.BackColor = Color.IndianRed Then
                    buttock.BackColor = Color.Maroon
                    label2degree.Text -= ubuttock
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += ubuttock

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If buttock.BackColor = Color.NavajoWhite Then
                    buttock.BackColor = Color.IndianRed
                    label2degree.Text += ubuttock
                    buttocklabel.Text += ubuttock
                ElseIf buttock.BackColor = Color.Maroon Then
                    buttock.BackColor = Color.IndianRed
                    label3degree.Text -= ubuttock
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += ubuttock

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If buttock.BackColor = Color.Maroon Then
                    buttock.BackColor = Color.NavajoWhite
                    label3degree.Text -= ubuttock
                    buttocklabel.Text -= ubuttock
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf buttock.BackColor = Color.IndianRed Then
                    buttock.BackColor = Color.NavajoWhite
                    label2degree.Text -= ubuttock
                    buttocklabel.Text -= ubuttock
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If


        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

    Private Sub forearm2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forearm9.MouseEnter, forearm8.MouseEnter, forearm7.MouseEnter, forearm6.MouseEnter, forearm5.MouseEnter, forearm4.MouseEnter, forearm32.MouseEnter, forearm31.MouseEnter, forearm30.MouseEnter, forearm3.MouseEnter, forearm29.MouseEnter, forearm28.MouseEnter, forearm27.MouseEnter, forearm26.MouseEnter, forearm25.MouseEnter, forearm24.MouseEnter, forearm23.MouseEnter, forearm22.MouseEnter, forearm21.MouseEnter, forearm20.MouseEnter, forearm2.MouseEnter, forearm19.MouseEnter, forearm18.MouseEnter, forearm17.MouseEnter, forearm16.MouseEnter, forearm15.MouseEnter, forearm14.MouseEnter, forearm13.MouseEnter, forearm12.MouseEnter, forearm11.MouseEnter, forearm10.MouseEnter, forearm1.MouseEnter
        If burning = True Then
            Dim forearm As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If forearm.BackColor = Color.NavajoWhite Then
                    forearm.BackColor = Color.Maroon
                    label3degree.Text += uforearm
                    forearmlabel.Text += uforearm
                ElseIf forearm.BackColor = Color.IndianRed Then
                    forearm.BackColor = Color.Maroon
                    label2degree.Text -= uforearm
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += uforearm

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If forearm.BackColor = Color.NavajoWhite Then
                    forearm.BackColor = Color.IndianRed
                    label2degree.Text += uforearm
                    forearmlabel.Text += uforearm
                ElseIf forearm.BackColor = Color.Maroon Then
                    forearm.BackColor = Color.IndianRed
                    label3degree.Text -= uforearm
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += uforearm

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If forearm.BackColor = Color.Maroon Then
                    forearm.BackColor = Color.NavajoWhite
                    label3degree.Text -= uforearm
                    forearmlabel.Text -= uforearm
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf forearm.BackColor = Color.IndianRed Then
                    forearm.BackColor = Color.NavajoWhite
                    label2degree.Text -= uforearm
                    forearmlabel.Text -= uforearm
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If

        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

    Private Sub arm8_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arm9.MouseEnter, arm8.MouseEnter, arm7.MouseEnter, arm6.MouseEnter, arm5.MouseEnter, arm44.MouseEnter, arm43.MouseEnter, arm42.MouseEnter, arm41.MouseEnter, arm40.MouseEnter, arm4.MouseEnter, arm39.MouseEnter, arm38.MouseEnter, arm37.MouseEnter, arm36.MouseEnter, arm35.MouseEnter, arm34.MouseEnter, arm33.MouseEnter, arm32.MouseEnter, arm31.MouseEnter, arm30.MouseEnter, arm3.MouseEnter, arm29.MouseEnter, arm28.MouseEnter, arm27.MouseEnter, arm26.MouseEnter, arm25.MouseEnter, arm24.MouseEnter, arm23.MouseEnter, arm22.MouseEnter, arm21.MouseEnter, arm20.MouseEnter, arm2.MouseEnter, arm19.MouseEnter, arm18.MouseEnter, arm17.MouseEnter, arm16.MouseEnter, arm15.MouseEnter, arm14.MouseEnter, arm13.MouseEnter, arm12.MouseEnter, arm11.MouseEnter, arm10.MouseEnter, arm1.MouseEnter
        If burning = True Then
            Dim arm As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If arm.BackColor = Color.NavajoWhite Then
                    arm.BackColor = Color.Maroon
                    label3degree.Text += uarm
                    armlabel.Text += uarm
                ElseIf arm.BackColor = Color.IndianRed Then
                    arm.BackColor = Color.Maroon
                    label2degree.Text -= uarm
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += uarm

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If arm.BackColor = Color.NavajoWhite Then
                    arm.BackColor = Color.IndianRed
                    label2degree.Text += uarm
                    armlabel.Text += uarm
                ElseIf arm.BackColor = Color.Maroon Then
                    arm.BackColor = Color.IndianRed
                    label3degree.Text -= uarm
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += uarm

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If arm.BackColor = Color.Maroon Then
                    arm.BackColor = Color.NavajoWhite
                    label3degree.Text -= uarm
                    armlabel.Text -= uarm
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf arm.BackColor = Color.IndianRed Then
                    arm.BackColor = Color.NavajoWhite
                    label2degree.Text -= uarm
                    armlabel.Text -= uarm
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If


        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------
    End Sub

    Private Sub trunck48_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trunck99.MouseEnter, trunck98.MouseEnter, trunck97.MouseEnter, trunck96.MouseEnter, trunck95.MouseEnter, trunck94.MouseEnter, trunck93.MouseEnter, trunck92.MouseEnter, trunck91.MouseEnter, trunck90.MouseEnter, trunck9.MouseEnter, trunck89.MouseEnter, trunck88.MouseEnter, trunck87.MouseEnter, trunck86.MouseEnter, trunck85.MouseEnter, trunck84.MouseEnter, trunck83.MouseEnter, trunck82.MouseEnter, trunck81.MouseEnter, trunck80.MouseEnter, trunck8.MouseEnter, trunck79.MouseEnter, trunck78.MouseEnter, trunck77.MouseEnter, trunck76.MouseEnter, trunck75.MouseEnter, trunck74.MouseEnter, trunck73.MouseEnter, trunck72.MouseEnter, trunck71.MouseEnter, trunck70.MouseEnter, trunck7.MouseEnter, trunck69.MouseEnter, trunck68.MouseEnter, trunck67.MouseEnter, trunck66.MouseEnter, trunck65.MouseEnter, trunck64.MouseEnter, trunck63.MouseEnter, trunck62.MouseEnter, trunck61.MouseEnter, trunck60.MouseEnter, trunck6.MouseEnter, trunck59.MouseEnter, trunck58.MouseEnter, trunck57.MouseEnter, trunck56.MouseEnter, trunck55.MouseEnter, trunck54.MouseEnter, trunck53.MouseEnter, trunck52.MouseEnter, trunck51.MouseEnter, trunck50.MouseEnter, trunck5.MouseEnter, trunck49.MouseEnter, trunck48.MouseEnter, trunck47.MouseEnter, trunck46.MouseEnter, trunck45.MouseEnter, trunck44.MouseEnter, trunck43.MouseEnter, trunck42.MouseEnter, trunck41.MouseEnter, trunck40.MouseEnter, trunck4.MouseEnter, trunck39.MouseEnter, trunck38.MouseEnter, trunck37.MouseEnter, trunck36.MouseEnter, trunck35.MouseEnter, trunck34.MouseEnter, trunck33.MouseEnter, trunck32.MouseEnter, trunck31.MouseEnter, trunck30.MouseEnter, trunck3.MouseEnter, trunck29.MouseEnter, trunck28.MouseEnter, trunck27.MouseEnter, trunck26.MouseEnter, trunck25.MouseEnter, trunck24.MouseEnter, trunck23.MouseEnter, trunck22.MouseEnter, trunck21.MouseEnter, trunck20.MouseEnter, trunck2.MouseEnter, trunck19.MouseEnter, trunck18.MouseEnter, trunck17.MouseEnter, trunck16.MouseEnter, trunck15.MouseEnter, trunck14.MouseEnter, trunck139.MouseEnter, trunck138.MouseEnter, trunck137.MouseEnter, trunck136.MouseEnter, trunck135.MouseEnter, trunck134.MouseEnter, trunck133.MouseEnter, trunck132.MouseEnter, trunck131.MouseEnter, trunck130.MouseEnter, trunck13.MouseEnter, trunck129.MouseEnter, trunck128.MouseEnter, trunck127.MouseEnter, trunck126.MouseEnter, trunck125.MouseEnter, trunck124.MouseEnter, trunck123.MouseEnter, trunck122.MouseEnter, trunck121.MouseEnter, trunck120.MouseEnter, trunck12.MouseEnter, trunck119.MouseEnter, trunck118.MouseEnter, trunck117.MouseEnter, trunck116.MouseEnter, trunck115.MouseEnter, trunck114.MouseEnter, trunck113.MouseEnter, trunck112.MouseEnter, trunck111.MouseEnter, trunck110.MouseEnter, trunck11.MouseEnter, trunck109.MouseEnter, trunck108.MouseEnter, trunck107.MouseEnter, trunck106.MouseEnter, trunck105.MouseEnter, trunck104.MouseEnter, trunck103.MouseEnter, trunck102.MouseEnter, trunck101.MouseEnter, trunck100.MouseEnter, trunck10.MouseEnter, trunck1.MouseEnter, MyBase.MouseEnter
        If burning = True Then
            Dim trunck As Control = CType(sender, Control)
            '----------------------------------------------------------------------------
            ' this code for calculating areas 3rd degree and 2nd degree and 0 degeree

            If RadioButton1.Checked Then
                If trunck.BackColor = Color.NavajoWhite Then
                    trunck.BackColor = Color.Maroon
                    label3degree.Text += utrunck
                    truncklabel.Text += utrunck
                ElseIf trunck.BackColor = Color.IndianRed Then
                    trunck.BackColor = Color.Maroon
                    label2degree.Text -= utrunck
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                    label3degree.Text += utrunck

                End If
                '----------------------------------------------------------------------


            ElseIf RadioButton2.Checked Then
                If trunck.BackColor = Color.NavajoWhite Then
                    trunck.BackColor = Color.IndianRed
                    label2degree.Text += utrunck
                    truncklabel.Text += utrunck
                ElseIf trunck.BackColor = Color.Maroon Then
                    trunck.BackColor = Color.IndianRed
                    label3degree.Text -= utrunck
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                    label2degree.Text += utrunck

                End If
                '------------------------------------------------------------------------

            ElseIf RadioButton3.Checked Then
                If trunck.BackColor = Color.Maroon Then
                    trunck.BackColor = Color.NavajoWhite
                    label3degree.Text -= utrunck
                    truncklabel.Text -= utrunck
                    If label3degree.Text < 0.1 Then
                        label3degree.Text = 0
                    End If
                ElseIf trunck.BackColor = Color.IndianRed Then
                    trunck.BackColor = Color.NavajoWhite
                    label2degree.Text -= utrunck
                    truncklabel.Text -= utrunck
                    If label2degree.Text < 0.1 Then
                        label2degree.Text = 0
                    End If
                End If
            End If


        End If
        '---------------------------------------------------------------------------------
        'to calculate safe areas and TBSA of the body

        labeltbsa.Text = CUInt(label3degree.Text + CUInt(label2degree.Text))

        label0degree.Text = 100 - CUInt(label3degree.Text + CUInt(label2degree.Text))

        '------------------------------------------

    End Sub



    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Sorry, help is still not available")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("TBSA% calculator 16/1/2010" & Chr(13) & "Programmed by:Dr.Hunar Ahmad(Kurdistan-Hawler city)" & Chr(13) & "Distribution of this program is not allowed without permission of the Author")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        If labeltbsa.Text < 10 Then
            MsgBox("this patient doesn't need fluid resusitaion")


        ElseIf NumericUpDown2.Value = 0 Then
            MsgBox("please enter the weight in kg")


        ElseIf labeltbsa.Text < 50 Then
            totalfluidtextbox.Text = CUInt(NumericUpDown2.Value * 3 * labeltbsa.Text)
            totalplasma.Text = CUInt(0.25 * NumericUpDown2.Value * labeltbsa.Text)
            labelscondday.Text = CUInt(1.5 * NumericUpDown2.Value * labeltbsa.Text)

            firsteighthours.Text = CUInt(totalfluidtextbox.Text / 2)
            secondeighthours.Text = CUInt(firsteighthours.Text / 2)
            thirdeighthours.Text = CUInt(secondeighthours.Text)

            firsteightrate.Text = CUInt(firsteighthours.Text / 8)
            secondeightrate.Text = CUInt(secondeighthours.Text / 8)
            thirdeightrate.Text = (secondeightrate.Text)


        Else : totalfluidtextbox.Text = CUInt(150 * NumericUpDown2.Value)
            totalplasma.Text = CUInt(12.5 * NumericUpDown2.Value)
            labelscondday.Text = CUInt(75 * NumericUpDown2.Value)

            firsteighthours.Text = CUInt(totalfluidtextbox.Text / 2)
            secondeighthours.Text = CUInt(firsteighthours.Text / 2)
            thirdeighthours.Text = CUInt(secondeighthours.Text)

            firsteightrate.Text = CUInt(firsteighthours.Text / 8)
            secondeightrate.Text = CUInt(secondeighthours.Text / 8)
            thirdeightrate.Text = (secondeightrate.Text)


        End If





    End Sub


    Private Sub SaveAsImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsImageToolStripMenuItem.Click
        '--------------------------------------------------------------------
        ' a very nice code to save the form as image
        ' definitions:

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Dim formSize As Size = New Size(Me.Bounds.Width, Me.Bounds.Height)
        Dim screenGrab As New Bitmap(Me.Bounds.Width, Me.Bounds.Height)
        Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(screenGrab)


        GroupBox1.Visible = False
        MenuStrip1.Visible = False
        burningbutton.Visible = False

        SaveFileDialog1.Filter = "bmp(*.bmp)|*.bmp"
        If nametextbox.Text IsNot Nothing Then
            SaveFileDialog1.FileName = nametextbox.Text
        End If
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            g.CopyFromScreen(New Point(Me.Location.X, Me.Location.Y), New Point(0, 0), formSize)
            screenGrab.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)

        End If
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        GroupBox1.Visible = True
        MenuStrip1.Visible = True
        burningbutton.Visible = True
    End Sub
    '----------------------------------------------------------------------------------

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles burningbutton.Click
        If burningbutton.Text = "Start burning" Then
            burningbutton.Text = "Stop burning"
            burning = True
        ElseIf burningbutton.Text = "Stop burning" Then
            burningbutton.Text = "Start burning"
            burning = False
        End If
    End Sub



    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If nametextbox.Text = "" Then
            patientname = "unknown person"
        Else : patientname = nametextbox.Text

        End If

        If TextBox1.Text = "" Then
            age = "of unknown age"
        Else : age = TextBox1.Text
        End If

        If ComboBox1.Text = "" Then
            gender = "with unknown gender"
        Else : gender = ComboBox1.Text
        End If

        If ComboBox2.Text = "" Then
            adress = "unknown place"
        Else : adress = ComboBox2.Text
        End If

        If ComboBox3.Text = "" Then
            cause = "unknown cause"
        Else : cause = ComboBox3.Text
        End If

        burndate = DateTimePicker1.Value

        tbsa = labeltbsa.Text & "%"

        If ComboBox4.Text = "" Then
            degree = "unknown degree of burn"
        Else : degree = ComboBox4.Text & " burn"
        End If

        If headlabel.Text = 0 Then
            area1 = ""
        Else : area1 = "face, "
        End If

        If necklabel.Text = 0 Then
            area2 = ""
        Else : area2 = "neck, "
        End If

        If truncklabel.Text = 0 Then
            area3 = ""
        Else : area3 = "trunck, "
        End If

        If genitalialabel.Text = 0 Then
            area4 = ""
        Else : area4 = "genitalia, "
        End If

        If thighlabel.Text = 0 Then
            area5 = ""
        Else : area5 = "thigh, "
        End If

        If armlabel.Text = 0 Then
            area6 = ""
        Else : area6 = "arm, "
        End If

        If forearmlabel.Text = 0 Then
            area7 = ""
        Else : area7 = "forearm, "
        End If

        If handlabel.Text = 0 Then
            area8 = ""
        Else : area8 = "hand, "
        End If

        If leglabel.Text = 0 Then
            area9 = ""
        Else : area9 = "leg, "
        End If

        If buttocklabel.Text = 0 Then
            area10 = ""
        Else : area10 = "buttock, "
        End If

        If footlabel.Text = 0 Then
            area11 = ""
        Else : area11 = "foot, "
        End If

        If labeltbsa.Text < 10 Then
            fluidmagament = ""
        Else : fluidmagament = "I.V fluid, "
        End If

        If labeltbsa.Text < 20 Then
            tagament = ""
        Else
            tagament = "Tagament ampul, "
        End If

        If labeltbsa.Text < 20 AndAlso genitalialabel.Text = 0 Then
            catheter = ""
        Else
            catheter = "Foley's catheter, "
        End If

        If ComboBox3.Text = "Fire" Then
            hidrocortizone = "Hydrocortizone vial, "
        Else : hidrocortizone = "'"
        End If
        observation = "Observation."
        dressing = "Daily dressing, "

        If headlabel.Text = 0 Then
            facedressing = ""
        Else : facedressing = "Twice dressing for face per day, "

        End If

        If necklabel.Text = 0 AndAlso headlabel.Text = 0 Then
            oxygen = ""
        Else : oxygen = "Give O2, "
        End If

        painkiller = "painkiller, "

        computernote.Text = patientname & " is " & age & " years old " & gender & " living in " & adress & " burned by " & cause & " at " & burndate & " his total body surface area of the burn is " & tbsa & " he had " & degree & " including these areas: " & area1 & area2 & area3 & area4 & area5 & area6 & area7 & area8 & area9 & area10 & area11
        managmentnote.Text = "Lines of management:-" & Chr(13) & fluidmagament & Chr(13) & painkiller & Chr(13) & hidrocortizone & Chr(13) & tagament & Chr(13) & catheter & Chr(13) & dressing & Chr(13) & facedressing & Chr(13) & oxygen & Chr(13) & observation

    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadDataToolStripMenuItem.Click
        Form2.ShowDialog()

    End Sub

    Private Sub AddToDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToDataToolStripMenuItem.Click
        Try
            Me.Validate()
            Me.Burn_databaseBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Burn_data_base_2003DataSet)
        Catch ex As Exception
            MsgBox("please enter a unique patient No.")
        End Try
        
    End Sub

    
End Class
