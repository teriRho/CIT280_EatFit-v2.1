Public Class frmSnack
    Private Sub frmSnack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectfruit()
        linkobjects()
    End Sub
    Private Sub linkobjects()
        pbSFruit.Image = Fruitbox
        txtSFruit.Text = Fruittext
        pbSProtein.Image = Proteinbox
        txtSProtein.Text = Proteintext
        pbSGrain.Image = Grainbox
        txtSGrain.Text = Graintext
        pbSDrink.Image = Drinkbox
        txtSDrink.Text = Drinktext
    End Sub
    Private Sub frmSnack_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        clearobjects()
    End Sub
End Class