(function () {
    angular
    .module('app')
    .controller('Main', main);

    function main()
    {
        var vm = this;
        vm.food = 'pizza';
    }

})();