﻿(function () {
    angular.module('shop1.products', ['shop1.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController",
            parent: 'base'
        }).state('product_add', {
            url: "/product_add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController",
            parent: 'base'
        }).state('product_edit', {
            url: "/product_edit/:id",
            templateUrl: "/app/components/products/productEditView.html",
            controller: "productEditController",
            parent: 'base'
        });
    }
})();