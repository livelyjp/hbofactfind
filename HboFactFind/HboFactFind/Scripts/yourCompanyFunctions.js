function updateTotalInputFields(sourceClass, outputClass, callback) {
    $(sourceClass).change(function () {
        var totalPoints = 0;
        $(sourceClass).each(function (i, n) {
            totalPoints += parseFloat($(n).val());
        });
        $(outputClass).val(totalPoints);
        callback();
    });
};
function calculateMonthlyTotalFromAnnual(sourceClass, outputClass) {
    var totalPoints = $(sourceClass).val();
    $(outputClass).val((totalPoints / 12).toFixed(2));
}