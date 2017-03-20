(function (angular) {
    'use strict';
    angular.module('ChartApp')
    .service('myService', Constructor);
    Constructor.$inject = [];
    function Constructor()
    {
        var sv = this;
        function say()
        {
            console.log('hello from service');
        }

        sv.say = say;
    }


})(window.angular);