(function (angular) {

    'use strict';
    angular.module('ChartApp')
    .factory('myfactory', factory)
    factory.$inject = [];
    function factory()
    {

        //say from factory.
        function sayhello()
        {

        }


        return {
            sayhello: sayhello,
            name:'kanon'
        }

    }


})(window.angular);