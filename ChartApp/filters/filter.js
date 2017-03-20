(function (angular) {
    'use strict';

    var module = angular.module('ChartApp');

    module.filter('reverse', factory);
    function factory() {
        return function (input, upercase) {
            var result = '';
            for (var i = input.length - 1; i >= 0; i--)
                result += input.charAt(i);
            if (upercase === 'true')
                result = result.toUpperCase();
            return result;
        };
    }

})(window.angular)