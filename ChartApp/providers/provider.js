(function (angular) {
    'use strict';
    angular.module('ChartApp')
    .provider('serviceName', Constructor);
    Constructor.$inject = ['provider','constant','value','$injector'];
    function Constructor()
    {
        //when we will use serviceName provider then i have to call serviceNameProvider.
        var hjh = $injector.get('myservice');
        var vm = 5;
        this.doconfig = function (value) {
            //do something......
        };

        //creating service here
        this.$get = service;
        service.$inject = [];
        function service()
        {
            //do something
            function say()
            {
                //do nothing......
            }


            return {
                p: 7,
                say:say
            }

        }




    }


})(window.angular);