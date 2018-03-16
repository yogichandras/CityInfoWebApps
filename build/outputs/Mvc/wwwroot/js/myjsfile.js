function fileupload(filename) {
    var inputfile = document.getElementById(filename);
    var files = inputfile.files;
    var data = new FormData();
    for (var i = 0; i != files.length; i++) {
        data.append("files", files[i]);

    }
    $.ajax(
        {
            url: "Upload/Uploader",
            data: data,
            processData: false,
            contentType: false,
            type: "POST",
            success: function (data) {
                alert("success");
            }
        }
    );
}