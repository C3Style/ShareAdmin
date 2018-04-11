var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ShareAdmin');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);