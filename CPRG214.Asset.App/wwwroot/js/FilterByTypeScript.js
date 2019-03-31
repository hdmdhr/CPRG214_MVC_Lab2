function showFiltedAssets(assetTypeId) {
    var xhttp;
    xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            // received response (ViewComponent), change #tblFilteredAssets content            
            $("#tblFilteredAssets").html(this.responseText);
        }
    }
    xhttp.open('GET', '/Assets/GetAssetsByType?id=' + assetTypeId, true);
    xhttp.send();
}

