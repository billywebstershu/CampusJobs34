function filterTable() {
    var input = document.getElementById("pharmacyInput");
    var filter = input.value.toUpperCase();
    var table = document.getElementById("Timesheets");
    var tr = table.getElementsByTagName("tr");

    for (var i = 1; i < tr.length; i++) {
        var td = tr[i].getElementsByTagName("td");
        var match = false;

        for (var j = 0; j < td.length; j++) {
            if (td[j] && td[j].innerText.toUpperCase().indexOf(filter) > -1) {
                match = true;
                break;
            }
        }

        tr[i].style.display = match ? "" : "none";
    }
}

function handleAccept(button) {
    var row = button.closest("tr");
    row.classList.remove("declined");
    row.classList.add("accepted");
}

function handleDecline(button) {
    var row = button.closest("tr");
    row.classList.remove("accepted");
    row.classList.add("declined");
}