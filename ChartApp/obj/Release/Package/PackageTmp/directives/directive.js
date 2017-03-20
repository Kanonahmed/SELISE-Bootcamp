(function (angular) {
    'use strict';
    angular.module('ChartApp')
    .directive('digitalClock', factory)
    .directive('mainpulateClock', proFactory);

    factory.$inject = ['$interval'];
    function factory($interval)
    {
        function link(scope,attrs,element)
        {
            scope.hour = 0;
            scope.min = 1;
            scope.seconds = 2;
            scope.arr = ['red', 'green', 'blue'];

            var count = 0;
            scope.color = scope.arr[count];
            count++;
            setInterval(function () {
                if (count > 2) count = 0;
                scope.color = scope.arr[count];
                count++;
            }, 2000);

            scope.sayHello=function()
            {
                console.log('hi');
            }
            
            populateTime();
            function populateTime()
            {
                var time = new Date();
                scope.hour = time.getHours();
                scope.min = time.getMinutes();
                scope.seconds = time.getSeconds();
            }

            scope.$on('$destroy', function () {
                $interval.cancel(timeout);
            });
            

            var timeout = $interval(function () {
                populateTime();

            }, 1000);
            


        }

        return {
            require:[],
            restrict: 'EA',
            scope: {
                AuthorName: '=name',
                //sayHello:'&say'
                sayHello:'&'
               // color:'=onColor'
            },
            transclude:true,
            templateUrl:'views/directiveview.html',
            link: link
        };
    }

    proFactory.$inject = [];
    function proFactory()
    {

        return {
            restrict: 'E',
            require: ['digitalClock'],
            controller: function()
            {
                //if i declare any function in controller then who inherit me he can be allowed to access my funtion. otherwise i declare any function in link then who inherit me he don't allow to access my function.
            },
            controllerAs: tab,
            template:'hello from next directive'
            
        }

    }



})(window.angular);