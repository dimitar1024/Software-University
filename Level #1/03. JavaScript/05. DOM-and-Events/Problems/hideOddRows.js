var isActive = true;

function event() {
    var rows = document.body.getElementsByTagName('tr');
    var btn = document.getElementById('btnHideOddRows');


    if (isActive) {
        for (var i = 0; i < rows.length; i += 2) {
            rows[i].style.display = 'none';
        }
        btn.innerHTML = "Show Odd Rows";
    }
    else {
        for (var i = 0; i < rows.length; i++) {
            rows[i].style.display = 'block';
        }
        btn.innerHTML = "Hide Odd Rows";
    }

    isActive = !isActive;
    
};

document.getElementById("btnHideOddRows").addEventListener("click", event);