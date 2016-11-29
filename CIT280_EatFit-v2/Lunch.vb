Public Class frmLunch
    Private Sub frmLunch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectfruit()
        selectvegetable()
        selectgrain()
        selectprotein()
        selectdrink()
        linkobjects()
    End Sub
    Private Sub linkobjects()
        pbLFruit.Image = Fruitbox
        txtLFruit.Text = Fruittext
        pbLVegetable.Image = Vegetablebox
        txtLVegetable.Text = Vegetabletext
        pbLProtein.Image = Proteinbox
        txtLProtein.Text = Proteintext
        pbLGrain.Image = Grainbox
        txtLGrain.Text = Graintext
        pbLDrink.Image = Drinkbox
        txtLDrink.Text = Drinktext
    End Sub
    Private Sub frmSnack_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        clearobjects()
    End Sub
End Class