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

window.userActivity = {
    lastActivity: Date.now(),

    init: function () {
        document.addEventListener('mousemove', function () {
            window.userActivity.lastActivity = Date.now();
        });

        document.addEventListener('keydown', function () {
            window.userActivity.lastActivity = Date.now();
        });
    }
};

window.userActivity.init();


window.showCountdown = (remainingMinutes) => {
    // You can use this method to update your UI with the remaining minutes
    console.log(`Remaining minutes: ${remainingMinutes}`);
    // Update your UI elements with the remaining time as needed
};

//function timeOutCall(dotnethelper)
//{
//    document.onmousemove = resetTimeDelay;
//    document.onkeypress = resetTimeDelay;

//    function resetTimeDelay() {
//        dotnethelper.invokeMethodAsync("TimerInterval");
//    }
//}

//window.setLogoutTimer = function (dotnetHelper) {
//    let logoutTimer;

//    function resetTimer() {
//        clearTimeout(logoutTimer);
//        logoutTimer = setTimeout(() => {
//            dotnetHelper.invokeMethodAsync('Logout');
//        }, 60000); // 15 minutes in milliseconds
//    }

//    document.addEventListener('mousemove', resetTimer);
//    document.addEventListener('keydown', resetTimer);

//    resetTimer(); // Initialize the timer on page load
//}
