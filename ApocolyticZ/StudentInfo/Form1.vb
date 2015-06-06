Imports System.IO
Public Class Form1
    Dim health As Integer
    Dim energy As Integer
    Dim thirst As Integer
    Dim hunger As Integer
    Dim smgammo, sniperammo, pistolammo, shotgunammo As Integer



    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        health = 20
        energy = 15
        thirst = 10
        hunger = 10
        smgammo = 0
        pistolammo = 0
        sniperammo = 0
        shotgunammo = 0


        Label12.Text = health
        Label13.Text = hunger
        Label14.Text = thirst
        Label16.Text = energy
        Label2.Text = pistolammo
        Label4.Text = shotgunammo
        Label6.Text = sniperammo
        Label8.Text = smgammo



    End Sub


    Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

  

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
   

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Randomize()
        Dim num As Integer

        num = Int((100 * Rnd() + 1))

        Label17.Text = num
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        health = health + 1
        Label12.Text = health
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        health = health + 2
        Label12.Text = health
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        health = health + 3
        Label12.Text = health
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        health = health + 4
        Label12.Text = health
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        health = health + 5
        Label12.Text = health
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        health = health - 1
        Label12.Text = health
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        health = health - 2
        Label12.Text = health
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        health = health - 3
        Label12.Text = health
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        health = health - 4
        Label12.Text = health
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        health = health - 5
        Label12.Text = health
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        health = health + 5
        energy = 10

        Label12.Text = health
        Label16.Text = energy
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Randomize()
        Dim num As Integer

        num = Int((100 * Rnd() + 1))

        If num < 51 Then
            If num >= 1 And num < 11 Then
                If num = 1 Then
                    MessageBox.Show("Tin Can")
                    ListBox1.Items.Add("Tin Can")
                ElseIf num = 2 Then
                    MessageBox.Show("Scissors")
                    ListBox1.Items.Add("Scissors")
                ElseIf num = 3 Then

                ElseIf num = 4 Then
                    MessageBox.Show("Bobby Pins")
                    ListBox1.Items.Add("Bobby Pins")
                ElseIf num = 5 Then

                ElseIf num = 6 Then
                    MessageBox.Show("Mug")
                    ListBox1.Items.Add("Mug")
                ElseIf num = 7 Then
                    MessageBox.Show("Noodles(uncooked)")
                    ListBox1.Items.Add("Noodles(uncooked +1 for uncooked and +3 for cooked +1 Hunger)")
                ElseIf num = 8 Then

                ElseIf num = 9 Then
                    MessageBox.Show("Water Bottle(empty)")
                    ListBox1.Items.Add("Water Bottle(empty)")
                Else

                End If

            ElseIf num >= 11 And num < 21 Then
                If num = 11 Then
                    MessageBox.Show("Rotten Food(-1 Health +1 Hunger)")
                    ListBox1.Items.Add("Rotten Food(-1 Health +1 Hunger)")
                ElseIf num = 12 Then

                ElseIf num = 13 Then
                    MessageBox.Show("Plate")
                    ListBox1.Items.Add("Plate")
                ElseIf num = 14 Then
                    MessageBox.Show("Potato Chips(+1 Health +1 Hunger)")
                    ListBox1.Items.Add("Potato Chips(+1 Health +1 Hunger)")
                ElseIf num = 15 Then

                ElseIf num = 16 Then
                    MessageBox.Show("Soup(+2 Health +2 Thirst)")
                    ListBox1.Items.Add("Soup(+2 Health +2 Thirst)")
                ElseIf num = 17 Then

                ElseIf num = 18 Then

                ElseIf num = 19 Then
                    MessageBox.Show("Binoculars")
                    ListBox1.Items.Add("Binoculars")
                Else
                    MessageBox.Show("Pocket Knife(1 Damage)")
                    ListBox1.Items.Add("Pocket Knife(1 Damage)")
                End If
            ElseIf num >= 21 And num < 31 Then
                If num = 21 Then

                ElseIf num = 22 Then
                    MessageBox.Show("Juice Box(+3 Thirst)")
                    ListBox1.Items.Add("Juice Box(+3 Thirst)")
                ElseIf num = 23 Then
                    MessageBox.Show("Rotten Milk(+1 Thirst -1 Health)")
                    ListBox1.Items.Add("Rotten Milk(+1 Thirst -1 Health)")
                ElseIf num = 24 Then
                    MessageBox.Show("Duct Tape")
                    ListBox1.Items.Add("Duct Tape")
                ElseIf num = 25 Then

                ElseIf num = 26 Then
                    MessageBox.Show("10ft Rope")
                    ListBox1.Items.Add("10ft Rope")
                ElseIf num = 27 Then
                    MessageBox.Show("Glow Stick")
                    ListBox1.Items.Add("Glow Stick")
                ElseIf num = 28 Then

                ElseIf num = 29 Then

                Else
                    MessageBox.Show("Fresh Water Tablets")
                    ListBox1.Items.Add("Fresh Water Tablets")
                End If
            ElseIf num >= 31 And num < 41 Then
                If num = 31 Then
                    MessageBox.Show("Lighter")
                    ListBox1.Items.Add("Lighter")
                ElseIf num = 32 Then
                    MessageBox.Show("Band Aids(3)")
                    ListBox1.Items.Add("Band Aids(3)")
                ElseIf num = 33 Then

                ElseIf num = 34 Then
                    MessageBox.Show("Tacs")
                    ListBox1.Items.Add("Tacs")
                ElseIf num = 35 Then
                    MessageBox.Show("Clothespins")
                    ListBox1.Items.Add("Clothespins")
                ElseIf num = 36 Then

                ElseIf num = 37 Then

                ElseIf num = 38 Then
                    MessageBox.Show("Plastic Sack")
                    ListBox1.Items.Add("Plastic Sack")
                ElseIf num = 39 Then

                Else
                    MessageBox.Show("Light Bulb")
                    ListBox1.Items.Add("Light Bulb")
                End If
            ElseIf num >= 41 And num < 51 Then
                If num = 41 Then

                ElseIf num = 42 Then
                    MessageBox.Show("Duffel Bag")
                    ListBox1.Items.Add("Duffel Bag")
                ElseIf num = 43 Then

                ElseIf num = 44 Then

                ElseIf num = 45 Then
                    MessageBox.Show("Water Bottle(unpure water)")
                    ListBox1.Items.Add("Water Bottle(unpure water)")
                ElseIf num = 46 Then
                    MessageBox.Show("Chapstick")
                    ListBox1.Items.Add("Chapstick")
                ElseIf num = 47 Then

                ElseIf num = 48 Then
                    MessageBox.Show("Microchip")
                    ListBox1.Items.Add("Microchip")
                ElseIf num = 49 Then

                Else
                    MessageBox.Show("Tin Foil")
                    ListBox1.Items.Add("Tin Foil")
                End If

            ElseIf num > 50 And num < 91 Then

                If num >= 51 And num < 61 Then
                    If num = 51 Then

                    ElseIf num = 52 Then

                    ElseIf num = 53 Then

                    ElseIf num = 54 Then

                    ElseIf num = 55 Then

                    ElseIf num = 56 Then

                    ElseIf num = 57 Then

                    ElseIf num = 58 Then

                    ElseIf num = 59 Then

                    Else

                    End If

                ElseIf num >= 61 And num < 71 Then
                    If num = 61 Then

                    ElseIf num = 62 Then

                    ElseIf num = 63 Then

                    ElseIf num = 64 Then

                    ElseIf num = 65 Then

                    ElseIf num = 66 Then

                    ElseIf num = 67 Then

                    ElseIf num = 68 Then

                    ElseIf num = 69 Then

                    Else

                    End If
                ElseIf num >= 71 And num < 81 Then
                    If num = 71 Then

                    ElseIf num = 72 Then

                    ElseIf num = 73 Then

                    ElseIf num = 74 Then

                    ElseIf num = 75 Then

                    ElseIf num = 76 Then

                    ElseIf num = 77 Then

                    ElseIf num = 78 Then

                    ElseIf num = 79 Then

                    Else

                    End If
                ElseIf num >= 81 And num < 91 Then
                    If num = 81 Then

                    ElseIf num = 82 Then

                    ElseIf num = 83 Then

                    ElseIf num = 84 Then

                    ElseIf num = 85 Then

                    ElseIf num = 86 Then

                    ElseIf num = 87 Then

                    ElseIf num = 88 Then

                    ElseIf num = 89 Then

                    Else

                    End If

                ElseIf num >= 91 And num < 100 Then

                    If num = 91 Then

                    ElseIf num = 92 Then

                    ElseIf num = 93 Then

                    ElseIf num = 94 Then

                    ElseIf num = 95 Then

                    ElseIf num = 96 Then

                    ElseIf num = 97 Then

                    ElseIf num = 98 Then

                    ElseIf num = 99 Then

                    Else

                    End If

                End If
            End If

        End If


    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        MessageBox.Show("Item Used / Dropped")
    End Sub

    Public Sub getItems(ByVal newInt As Integer, ByVal otherInt As Integer)
        MessageBox.Show("Hello")
    End Sub
End Class
