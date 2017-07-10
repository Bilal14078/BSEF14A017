function addFunction()
{
    var value = document.getElementById("quantity");
    document.getElementById("quantity").innerHTML = value + 1;
}

function minusFunction()
{
    var value = document.getElementById("quantity");
    if (value > 1)
    {
        document.getElementById("quantity").innerHTML = value - 1;

    }
}