/// <reference path="D:\CSharp\ItClass\AspNetApi_AngularJs\Projects\Git1\Shop1.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('shop1.statistics', ['shop1.common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('statistic_revenue', {
            url: '/statistic_revenue',
            parent:'base',
            templateUrl: '/app/components/statistic/revenueStatisticView.html',
            controller: 'revenueStatisticController'
        })
    }

})();
