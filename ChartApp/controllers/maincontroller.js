(function (angular) {
    'use strict';
    angular.module('ChartApp')
    .controller('ChartController', Constructor);
    Constructor.$inject = ['$mdMedia'];
    function Constructor($mdMedia)
    {
        var vm = this;
        vm.$mdMedia = $mdMedia;
        function sayhello()
        {
            console.log('hi');
        }
        vm.color = 'red';
        vm.name = 'kanon';
        vm.labels = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
        vm.series = ['Year'];
        vm.data = [[65, 59, 80, 81, 56, 55, 40]]
        vm.sayhello = sayhello;
    }
    
})(window.angular);