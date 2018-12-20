"use strict";

function createAlert(style, innerContent) {
    return "<div class=\"alert " + style + "\" role=\"alert\">" + innerContent + "</div>";
}

function applyAlert(callerElement, alertsElementId, alertContent) {
    $(alertsElementId).removeClass("hidden");
    $(alertsElementId).append(alertContent);
    callerElement.disabled = false;
}

function onMissionStart(element, jobId) {
    var formElementId = "#" + jobId;
    var alertsElementId = formElementId + "-alerts";
    var data = $(formElementId).serializeArray();
    var launch = !requireConfirmation || confirm("Launch mission?");
    if (!launch) return;

    element.disabled = true;
    $.ajax({
        async: true,
        cache: false,
        timeout: 10000,
        url: baseUrl + "?" + idFieldName + "=" + jobId,
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        data: data,
        type: "post",
        success: function (r) {
            var jobLink = jobLinkBaseUrl + r;
            var alert = createAlert("alert-success", "Mission launched with id: <a href=\"" + jobLink + "\"><strong>" + r + "</strong></a>");
            applyAlert(element, alertsElementId, alert);
        },
        error: function (r) {
            var alert = createAlert("alert-danger", "An error occured during launching: <br/><strong>" + r.responseText + "</strong>");
            applyAlert(element, alertsElementId, alert);
        }
    });
}

$(".datetimepicker").each(function () {
    $(this).datetimepicker({
        format: "YYYY-MM-DD HH:mm"
    });
});

//https://jquery-howto.blogspot.com/2009/06/jquery-custom-selectors-with-parameters.html
jQuery.expr[':'].icontains = function (a, i, m) {
    return jQuery(a).text().toLowerCase()
        .indexOf(m[3].toLowerCase()) >= 0;
};

$(".template-search").each(function () {
    var searchInput = this;
    var jqSearchInput = $(this);
    var parentDiv = jqSearchInput.parent();
    var templateLis = parentDiv.find('li');
    jqSearchInput.keyup(function () {
        if (searchInput.value === '') {
            templateLis.removeClass('hidden');
        } else {
            templateLis.each(function () {
                var li = $(this);
                var h1 = li.find('h1:icontains(' + searchInput.value + ')');
                if (!h1.length) {
                    li.addClass('hidden');
                } else if (li.hasClass('hidden')) {
                    li.removeClass('hidden');
                }
            });
        }
    });
});