var app = angular.module("app", ["ngRoute"])
    .config(function ($routeProvider, $locationProvider) {

        $routeProvider.when('/', {
            templateUrl: '/AngularJS/Templates/inicio.html',
            controller: 'bienvenidoController'
        });

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
    });