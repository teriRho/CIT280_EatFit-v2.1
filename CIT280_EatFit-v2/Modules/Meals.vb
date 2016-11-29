Public Module Meals
    'Public meal drawing objects
    Public Fruitbox, Fruittext
    Public Proteinbox, Proteintext
    Public Grainbox, Graintext
    Public Vegetablebox, Vegetabletext
    Public Drinkbox, Drinktext
    'selection methods
    Public Sub selectfruit()
        Randomize()
        Dim fruitchoice As Integer = Math.Ceiling(Rnd() * 12)
        Select Case True
            Case fruitchoice = 1
                loadapple()
            Case fruitchoice = 2
                loadbanana()
            Case fruitchoice = 3
                loadorange()
            Case fruitchoice = 4
                loadstrawberry()
            Case fruitchoice = 5
                loadgrapes()
            Case fruitchoice = 6
                loadpapaya()
            Case fruitchoice = 7
                loadpear()
            Case fruitchoice = 8
                loadraspberry()
            Case fruitchoice = 9
                loadcherries()
            Case fruitchoice = 10
                loadblueberries()
            Case fruitchoice = 11
                loadpineapple()
            Case fruitchoice = 12
                loadavocado()
            Case Else
                MsgBox("Fruit error: " & fruitchoice)
                frmSnack.Close()
        End Select
    End Sub
    'reset objects
    Public Sub clearobjects()
        Fruitbox = Nothing
        Fruittext = Nothing
        Proteinbox = Nothing
        Proteintext = Nothing
        Grainbox = Nothing
        Grainbox = Nothing
        Vegetabletext = Nothing
        Vegetabletext = Nothing
        Drinkbox = Nothing
        Drinktext = Nothing
    End Sub
    'Fruit load methods
    Public Sub loadapple()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\apple.jpg")
        Fruittext = "Apple"
    End Sub
    Public Sub loadbanana()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\banana.jpg")
        Fruittext = "Banana"
    End Sub
    Public Sub loadorange()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\orange.jpg")
        Fruittext = "Orange"
    End Sub
    Public Sub loadstrawberry()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\strawberry.jpg")
        Fruittext = "Strawberry"
    End Sub
    Public Sub loadgrapes()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\grapes.jpg")
        Fruittext = "Grapes"
    End Sub
    Public Sub loadpapaya()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\papaya.jpg")
        Fruittext = "Papaya"
    End Sub
    Public Sub loadpear()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\pear.jpg")
        Fruittext = "Pear"
    End Sub
    Public Sub loadraspberry()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\raspberry.jpg")
        Fruittext = "Raspberry"
    End Sub
    Public Sub loadcherries()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\cherries.jpg")
        Fruittext = "Cherries"
    End Sub
    Public Sub loadblueberries()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\blueberries.jpg")
        Fruittext = "Blueberries"
    End Sub
    Public Sub loadpineapple()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\pineapple.png")
        Fruittext = "Pineapple"
    End Sub
    Public Sub loadavocado()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\avocado.jpg")
        Fruittext = "Avocado"
    End Sub
    Public Sub selectvegetable()
        Randomize()
        Dim vegetablechoice As Integer = Math.Ceiling(Rnd() * 12)
        Select Case True
            Case vegetablechoice = 1
                loadgreenbeans()
            Case vegetablechoice = 2
                loadkidneybeans()
            Case vegetablechoice = 3
                loadcarrot()
            Case vegetablechoice = 4
                loadcelery()
            Case vegetablechoice = 5
                loadcorn()
            Case vegetablechoice = 6
                loadpeas()
            Case vegetablechoice = 7
                loadspinach()
            Case vegetablechoice = 8
                loadkale()
            Case vegetablechoice = 9
                loadbroccoli()
            Case vegetablechoice = 10
                loadcauliflower()
            Case vegetablechoice = 11
                loadpeppers()
            Case vegetablechoice = 12
                loadasparagus()
            Case Else
                MsgBox("Vegetable error: " & vegetablechoice)
                frmSnack.Close()
        End Select
    End Sub
    'reset objects
    Public Sub clearobjects()
        Fruitbox = Nothing
        Fruittext = Nothing
        Proteinbox = Nothing
        Proteintext = Nothing
        Grainbox = Nothing
        Grainbox = Nothing
        Vegetabletext = Nothing
        Vegetabletext = Nothing
        Drinkbox = Nothing
        Drinktext = Nothing
    End Sub
    'Fruit load methods
    Public Sub loadgreenbeans()
        Vegetablebox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\greenbeans.jpg")
        Vegetabletext = "Green Beans"
    End Sub
    Public Sub loadkidneybeans()
        Vegetablebox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\kidneybeans.jpg")
        Vegetabletext = "Kidney Beans"
    End Sub
    Public Sub loadcarrot()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\carrot.jpg")
        Fruittext = "Carrot"
    End Sub
    Public Sub loadcelery()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\celery.jpg")
        Fruittext = "Celery"
    End Sub
    Public Sub loadcorn()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\corn.jpg")
        Fruittext = "Corn"
    End Sub
    Public Sub loadpeas()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\peas.jpg")
        Fruittext = "Peas"
    End Sub
    Public Sub loadspinach()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\spinach.jpg")
        Fruittext = "Spinach"
    End Sub
    Public Sub loadkale()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\kale.jpg")
        Fruittext = "Kale"
    End Sub
    Public Sub loadbroccoli()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\broccoli.jpg")
        Fruittext = "Broccoli"
    End Sub
    Public Sub loadcauliflower()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\Cauliflower.jpg")
        Fruittext = "Cauliflower"
    End Sub
    Public Sub loadpeppers()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\peppers.png")
        Fruittext = "Peppers"
    End Sub
    Public Sub loadasparagus()
        Fruitbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\asparagus.jpg")
        Fruittext = "Asparagus"
    End Sub
End Module
'selection methods
Public Sub selectprotein()
    Randomize()
    Dim proteinchoice As Integer = Math.Ceiling(Rnd() * 8)
    Select Case True
        Case proteinchoice = 1
            loadbeef()
        Case proteinchoice = 2
            loadchicken()
        Case proteinchoice = 3
            loadpork()
        Case proteinchoice = 4
            loadfish()
        Case proteinchoice = 5
            loadtofu()
        Case proteinchoice = 6
            loadnuts()
        Case proteinchoice = 7
            loadeggs()
        Case proteinchoice = 8
            loadsoy()
        Case Else
            MsgBox("protein error: " & proteinchoice)
            frmSnack.Close()
    End Select
End Sub
'reset objects
Public Sub clearobjects()
    Fruitbox = Nothing
    Fruittext = Nothing
    Proteinbox = Nothing
    Proteintext = Nothing
    Grainbox = Nothing
    Grainbox = Nothing
    Vegetabletext = Nothing
    Vegetabletext = Nothing
    Drinkbox = Nothing
    Drinktext = Nothing
End Sub
'protein load methods
Public Sub loadbeef()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\beef.jpg")
    Proteintext = "beef"
End Sub
Public Sub loadchicken()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\chicken.jpg")
    Proteintext = "chicken"
End Sub
Public Sub loadpork()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\pork.jpg")
    Proteintext = "pork"
End Sub
Public Sub loadfish()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\fish.jpg")
    Proteintext = "fish"
End Sub
Public Sub loadtofu()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\tofu.jpg")
    Proteintext = "tofu"
End Sub
Public Sub loadnuts()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\nuts.jpg")
    Proteintext = "nuts"
End Sub
Public Sub loadeggs()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\eggs.jpg")
    Proteintext = "eggs"
End Sub
Public Sub loadsoy()
    Proteinbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\soy.jpg")
    Proteintext = "soy"
End Sub
'selection methods
Public Sub selectgrain()
    Randomize()
    Dim grainchoice As Integer = Math.Ceiling(Rnd() * 8)
    Select Case True
        Case grainchoice = 1
            loadrice()
        Case grainchoice = 2
            loadnoodles()
        Case grainchoice = 3
            loadgranola()
        Case grainchoice = 4
            loadoats()
        Case grainchoice = 5
            loadbread()
        Case grainchoice = 6
            loadtortillas()
        Case grainchoice = 7
            loadgrits()
        Case Else
            MsgBox("grain error: " & grainchoice)
            frmSnack.Close()
    End Select
End Sub
'reset objects
Public Sub clearobjects()
    Fruitbox = Nothing
    Fruittext = Nothing
    Proteinbox = Nothing
    Proteintext = Nothing
    Grainbox = Nothing
    Grainbox = Nothing
    Vegetabletext = Nothing
    Vegetabletext = Nothing
    Drinkbox = Nothing
    Drinktext = Nothing
End Sub
'grain load methods
Public Sub loadrice()
    Grainbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\rice.jpg")
    Graintext = "rice"
End Sub
Public Sub loadnoodles()
    Grainbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\noodles.jpg")
    Graintext = "noodles"
End Sub
Public Sub loadgranola()
    Grainbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\granola.jpg")
    Graintext = "granola"
End Sub
Public Sub loadoats()
    Grainbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\oats.jpg")
    Graintext = "oats"
End Sub
Public Sub loadbread()
    Grainbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\bread.jpg")
    Graintext = "bread"
End Sub
Public Sub loadtortillas()
    Grainbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\tortillas.jpg")
    Graintext = "tortillas"
End Sub
Public Sub loadgrits()
    Grainbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\grits.jpg")
    Graintext = "grits"
End Sub
'selection methods
Public Sub selectdrink()
    Randomize()
    Dim drinkchoice As Integer = Math.Ceiling(Rnd() * 8)
    Select Case True
        Case drinkchoice = 1
            loadmilk()
        Case drinkchoice = 2
            loadwater()
        Case drinkchoice = 3
            loadcoffee()
        Case drinkchoice = 4
            loadjuice()
        Case drinkchoice = 5
            loadsportsdrink()
        Case Else
            MsgBox("Drink error: " & drinkchoice)
            frmSnack.Close()
    End Select
End Sub
'reset objects
Public Sub clearobjects()
    Fruitbox = Nothing
    Fruittext = Nothing
    Proteinbox = Nothing
    Proteintext = Nothing
    Grainbox = Nothing
    Grainbox = Nothing
    Vegetabletext = Nothing
    Vegetabletext = Nothing
    Drinkbox = Nothing
    Drinktext = Nothing
End Sub
'drink load methods
Public Sub loadmilk()
    Drinkbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\milk.jpg")
    Drinktext = "Milk"
End Sub
Public Sub loadwater()
    Drinkbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\water.jpg")
    Drinktext = "Water"
End Sub
Public Sub loadcoffee()
    Drinkbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\coffee.jpg")
    Drinktext = "Coffee"
End Sub
Public Sub loadjuice()
    Drinkbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\juice.jpg")
    Drinktext = "Juice"
End Sub
Public Sub loadsportsdrink()
    Drinkbox = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Meals" & "\sportsdrink.jpg")
    Drinktext = "Sports Drink"
End Sub





