Public Class frmDinner
    Private Sub frmDinner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectfruit()
        selectvegetable()
        selectprotein()
        selectgrain()
        selectdrink()
        linkobjects()
    End Sub
    Private Sub linkobjects()
        pbDFruit.Image = Fruitbox
        txtDFruit.Text = Fruittext
        pbDVegetable.Image = Vegetablebox
        txtDVegetable.Text = Vegetabletext
        pbDProtein.Image = Proteinbox
        txtDProtein.Text = Proteintext
        pbDGrain.Image = Grainbox
        txtDGrain.Text = Graintext
        pbDDrink.Image = Drinkbox
        txtDDrink.Text = Drinktext
    End Sub
    Private Sub frmDinner_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        clearobjects()
    End Sub
End Class