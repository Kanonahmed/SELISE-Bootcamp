(function (angular) {
    'use strict';
    document.addEventListener('DOMContentLoaded', initApp, false);
    function initApp()
    {
        var app=angular.module('ChartApp');
        app.constant('appInfo', 'version: 1.0.0');

        app.value('localization', {
            lang: 'eng',
            region: 'uk'
        });

        app.config(setProductionSettings);

        setProductionSettings.$inject = ['$compileProvider'];
        function setProductionSettings($compileProvider) {
            $compileProvider.debugInfoEnabled(false);
        }
        angular.bootstrap(document,['ChartApp']);
    }

})(window.angular);