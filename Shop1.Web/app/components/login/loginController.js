/// <reference path="D:\C#\ItClass\AspNetApi_AngularJs\Projects\Git1\Shop1.Web\Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.controller('loginController', loginController);
    loginController.$inject = ['$scope', '$state'];
    function loginController($scope, $state) {
        $scope.loginSubmit = function () {
            $state.go('home');
        }
    }
})(angular.module('shop1'));