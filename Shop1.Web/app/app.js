/// <reference path="D:\C#\ItClass\AspNetApi_AngularJs\Projects\Git1\Shop1.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module("shop1", ["shop1.products", "shop1.common"]).config(config);
    config.$inject = ["$stateProvider", "$urlRouterProvider"];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state("home", {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');

    }
})();