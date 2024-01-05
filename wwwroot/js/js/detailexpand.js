highlightHeader = function (colIndex, rowindex)
{
    /*var a = document.getElementsByClassName("e-row")[rowindex];*/
    /*var b = a.getElementsByClassName('e-rowcell')[colIndex].style.backgroundColor = 'pink';*/
    //var b = a.getElementsByClassName('e-rowcell')[0].style.backgroundColor = 'red';

    var a = document.getElementsByClassName("e-row")[rowindex];
    var b = a.getElementsByClassName("e-rowcell")[colIndex].style.backgroundColor = "red";

    //var b = document.getElementsByClassName("e-rowcell")[colIndex];
    //document.getElementsByClassName('header')[0].style.backgroundColor = 'red'

    //var b = a.querySelector('.e-rowcell')[12]
    //b.style.backgroundColor = '#f00'
    //var b = a.getElementsByClassName('e-rowcell')[12].setAttribute("style", "width:100px;height:100px;background-color:#f00;");
//        a.getElementsByClassName('e-rowcell')[0].style.background = "#f00";

    //var b = a.getElementsByClassName('e-rowcell')[colIndex];
    //for (var i = 0; i < b.length; i++) {
    //    b[i].style.background = "pink";
    //}
};

function changeBackground(color)
{
    var elements = document.getElementsByClassName("pls-work")
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.background = color;
    }
}

function RequiredFieldFunction()
{
    var x = document.getElementsByClassName("requiredfield");
    var i;
    for (i = 0; i < x.length; i++) {
        x[i].style.backgroundColor = "red";
    }
}

function RequiredFieldClearFunction(_id)
{
    document.getElementById(_id).style.color = "black";
    document.getElementById(_id).style.backgroundColor = "white";
}
