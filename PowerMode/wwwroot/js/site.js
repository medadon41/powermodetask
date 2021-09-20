function toggleChecks(checkbox) {
    var checkboxes = document.getElementsByClassName('select-check');
    for (var i = 0; i < checkboxes.length; i++) {
        if (checkbox.checked) {
            checkboxes[i].checked = true;
        }
        else
        {
            checkboxes[i].checked = false;
        }
    }
}
