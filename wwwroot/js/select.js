function setSelectedIndex(s, valsearch) {

    // Loop through all the items in drop down list

    for (i = 0; i < s.options.length; i++) {

        if (s.options[i].value == valsearch) {

            // Item is found. Set its property and exit

            s.options[i].selected = true;

            break;

        }

    }

    return;

}


setSelectedIndex(document.getElementById("PreserveSelect"), document.getElementById("Preserve").value);
setSelectedIndex(document.getElementById("HeadSelect"), document.getElementById("headdirection").value);
setSelectedIndex(document.getElementById("SexGeSelect"), document.getElementById("SexGe").value);
setSelectedIndex(document.getElementById("SexOSelect"), document.getElementById("SexO").value);
