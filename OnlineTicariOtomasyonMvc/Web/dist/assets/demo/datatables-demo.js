// Call the dataTables jQuery plugin
$(document).ready(function () {
    $('#dataTable').DataTable();
});

$(document).ready(function () {
    $(".sb-sidenav-menu").on("mouseenter", function () {
        // Yan �ubu�un �zerine gelindi�inde i�eri�i g�ster
        $(this).css("overflow-y", "auto");
    });

    $(".sb-sidenav-menu").on("mouseleave", function () {
        // Yan �ubuktan ��k�ld���nda kayd�rma �ubu�unu gizle
        $(this).css("overflow-y", "hidden");
    });
});