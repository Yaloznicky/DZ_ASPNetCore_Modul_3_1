function clickHandler(data) {

    var id = data.getAttribute("data-id");
    var title = data.getAttribute("data-title");

    $("#title").text(title);
    $('#staticBackdrop').find('button.btn-danger').val(id);
}
