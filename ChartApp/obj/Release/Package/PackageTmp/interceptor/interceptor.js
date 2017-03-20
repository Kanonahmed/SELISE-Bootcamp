(function (angular) {
    'use strict';
    angular.module('ChartApp')
    .factory('myInterceptor', factory);
    factory.$inject = ['$injector','$q'];
    factory()
    {

        var timestampMarker = {
            request: function (config) {
                config.requestTimestamp = new Date().getTime();
                return config;
            },
            response: function (response) {
                response.config.responseTimestamp = new Date().getTime();
                return response;
            }
        };
        return timestampMarker;
    }

    angular.module('ChartApp')
    .config(Configuration);
    Configuration.$inject=['$httpProvider']
    function Configuration($httpProvider)
    {
        $httpProvider.interceptors.push('myInterceptor');

    }


    //$http.get('https://api.github.com/users/naorye/repos') call from client side......
   




})(window.angular);