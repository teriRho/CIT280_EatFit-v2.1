Public Class frmBreakfast
    Private Sub frmBreakfast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectfruit()
        selectprotein()
        selectgrain()
        selectdrink()
        linkobjects()
    End Sub
    Private Sub linkobjects()
        pbBFruit.Image = Fruitbox
        txtBFruit.Text = Fruittext
        pbBProtein.Image = Proteinbox
        txtBProtein.Text = Proteintext
        pbBGrain.Image = Grainbox
        txtBGrain.Text = Graintext
        pbBDrink.Image = Drinkbox
        txtBDrink.Text = Drinktext
    End Sub
    Private Sub frmBreakfast_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        clearobjects()
    End Sub
    End ClassPublic Class frmBreakfast
End Class